using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Stadium
{
  public partial class Form1 : Form
  {
    private const int Capacity = 2400; //Вместимость стадиона
    const int FansTicketless = 200; //Количество болельщиков без билета
    private const int Sectors = 6; //Количество секторов
    private const int Places = Capacity / Sectors; //Количество мест в секторе

    private readonly Object _lockEnterQueue = new Object(); //Объект блокировки для очереди перед входом
    private readonly Object _lockSectorQueue = new Object(); //Объект блокировки для очереди перед секторами

    SortedSet<string> tickets = new SortedSet<string>(); //Проданные билеты (пока - фактически билеты у вошедших в стадион). Для генерации случайных болельщиков, чтобы сектор и место не повторялись

    private Thread _threadEnterQueue; //Поток, создающий очередь перед входом
    private List<Thread> _stuardThreads = new List<Thread>(); //Потоки-стюарды
    private List<Thread> _securityThreads = new List<Thread>(); //Потоки-охранники на входах

    private event SectorItemsChange SectorItemsChanged; //Событие посадки болельщика на место в сектор
    private delegate void SectorItemsChange(Object sender, SectorChangedEventArgs e); //Делегат для этого события

    public Form1()
    {
      InitializeComponent();
      SectorItemsChanged += sector_SectorItemsChanged;
    }

    void CreateQueue()
    {
      int countTicketless = 0;

      for (int i = 1; i <= Sectors * Places; i++)
      {
        if (countTicketless <= FansTicketless
          && (new Random((int)DateTime.Now.Ticks).Next(0, 5000)) > 2500)
        {
          Fan fanWithoutTicket = new Fan(false);

          Monitor.Enter(_lockEnterQueue);
          BeginInvoke(new Action<Fan>(n =>
          {
            lbEnterQueue.Items.Add(n);
          }), fanWithoutTicket);
          Monitor.Exit(_lockEnterQueue);

          countTicketless++;
        }

        int sector, place;
        do
        {
          sector = new Random((int)DateTime.Now.Ticks).Next(1, Sectors + 1);
          place = new Random((int)DateTime.Now.Ticks).Next(1, Places + 1);
        } while (tickets.Contains(sector + "-" + place));

        tickets.Add(sector + "-" + place);

        Fan fanWithTicket = new Fan(true, sector, place);

        Monitor.Enter(_lockEnterQueue);
        BeginInvoke(new Action<Fan>(n =>
        {
          lbEnterQueue.Items.Add(n);
        }), fanWithTicket);
        Monitor.Exit(_lockEnterQueue);

        Thread.Sleep(new Random((int)DateTime.Now.Ticks).Next(0, 1000));
      }
    }

    private void Security(object NEnter)
    {
      while (true)
      {
        Monitor.Enter(_lockEnterQueue);

        IAsyncResult IARfan = BeginInvoke(new Func<Fan>(() =>
        {
          Fan nextFan = null;
          if (lbEnterQueue.Items.Count > 0)
          {
            nextFan = lbEnterQueue.Items[0] as Fan;
            lbEnterQueue.Items.RemoveAt(0);
          }
          return nextFan;
        }));

        Fan fan = (Fan)EndInvoke(IARfan);

        Monitor.Exit(_lockEnterQueue);

        if (fan != null)
        {
          BeginInvoke(new Action<string, int>((name, NEnt) =>
            Controls["tbEnter" + NEnt].Text = name),
            fan.ToString(), (int)NEnter);

          Thread.Sleep(new Random((int)DateTime.Now.Ticks).Next(1000, 3000));

          if (fan._ticket)
          {
            Monitor.Enter(_lockSectorQueue);
            BeginInvoke(new Action<Fan, int>((n, NEnt) =>
            {
              Controls["tbEnter" + NEnt].Text = String.Empty;
              lbSectorsQueue.Items.Add(n);
              lblFansComeIn.Text = (Convert.ToInt32(lblFansComeIn.Text) + 1).ToString();
            }), fan, (int)NEnter);
            Monitor.Exit(_lockSectorQueue);
          }
          else
          {
            BeginInvoke(new Action<int>(NEnt => Controls["tbEnter" + NEnt].Text = String.Empty), (int)NEnter);
          }
        }
      }
    }

    void Stuard(object NSector)
    {
      IAsyncResult IARfan;

      while (true)
      {
        Monitor.Enter(_lockSectorQueue);
        IARfan = BeginInvoke(new Func<int, Fan>(NSec =>
        {
          int i;
          Fan nextFan = null;

          if (lbSectorsQueue.Items.Count > 0)
          {
            if ((lbSectorsQueue.Items[0] is string) && (string)lbSectorsQueue.Items[0] == "Проход в сектора завершён!")
            {
              return new Fan(true, -1, -1);
            }

            for (i = 0; i < lbSectorsQueue.Items.Count; i++)
            {
              if ((lbSectorsQueue.Items[i] is Fan) && (lbSectorsQueue.Items[i] as Fan)._sector == NSec)
              {
                nextFan = (lbSectorsQueue.Items[i] as Fan);
                break;
              }
            }
            if (nextFan != null)
            {
              lbSectorsQueue.Items.RemoveAt(i);
            }
          }
          return nextFan;
        }), (int)NSector);

        Fan fan = (Fan)EndInvoke(IARfan);

        Monitor.Exit(_lockSectorQueue);


        if (fan != null)
        {
          if (fan._ticket && fan._sector == -1) return;

          BeginInvoke(new Action<Fan, int>((n, NSec) =>
          Controls["tbSector" + NSec].Text = n.ToString()
          ), fan, (int)NSector);

          Thread.Sleep(new Random((int)DateTime.Now.Ticks).Next(3000, 5000));

          IAsyncResult IARFullSector = BeginInvoke(new Func<Fan, int, int>((n, NSec) =>
          {
            Controls["tbSector" + NSec].Text = String.Empty;

            string S_n_P = n.ToString().Substring(4);

            int i = 0;
            for (; i < (Controls["lbSector" + NSec] as ListBox).Items.Count; i++)
            {
              if (Convert.ToInt32(((Controls["lbSector" + NSec] as ListBox).Items[i] as string).Substring(2)) > n._place)
              {
                (Controls["lbSector" + NSec] as ListBox).Items.Insert(i, S_n_P);
                break;
              }
            }

            if (i == (Controls["lbSector" + NSec] as ListBox).Items.Count)
            {
              (Controls["lbSector" + NSec] as ListBox).Items.Add(S_n_P);
            }

            SectorItemsChanged((Controls["lbSector" + NSec] as ListBox),
              new SectorChangedEventArgs((Controls["lbSector" + NSec] as ListBox).Items.Count, NSec));
            return (Controls["lbSector" + NSec] as ListBox).Items.Count;
          }), fan, (int)NSector);

          if ((int)EndInvoke(IARFullSector) == Places)
          {
            return;
          }
        }
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      lblVacantPlaces.Text = Capacity.ToString();
      for (int s = 1; s <= Sectors; s++)
      {
        Controls["lblSector" + s + "VacantPlaces"].Text = Places.ToString();
      }
    }

    private void btnBegin_Click(object sender, EventArgs e)
    {
      _threadEnterQueue = new Thread(CreateQueue);
      _threadEnterQueue.Start();

      for (int i = 1; i <= 4; i++)
      {
        _securityThreads.Add(new Thread(Security));
        _securityThreads[_securityThreads.Count - 1].Start(i);
      }

      for (int i = 1; i <= Sectors; i++)
      {
        _stuardThreads.Add(new Thread(Stuard));
        _stuardThreads[_stuardThreads.Count - 1].Start(i);
      }

      btnEnd.Enabled = true;
      btnBegin.Enabled = false;
    }

    private void btnEnd_Click(object sender, EventArgs e)
    {
      if (_threadEnterQueue != null && _threadEnterQueue.IsAlive)
      {
        _threadEnterQueue.Abort();
      }

      for (int i = 0; i < _securityThreads.Count; i++)
      {
        if (_securityThreads[i] != null && _securityThreads[i].IsAlive)
        {
          _securityThreads[i].Abort();

          string enter = Controls["tbEnter" + (i + 1)].Text;

          Controls["tbEnter" + (i + 1)].Text = String.Empty;

          if (enter != String.Empty && Convert.ToInt32(enter.Substring(4, 1)) != 0)
          {
            lbSectorsQueue.Items.Add(new Fan(true, Convert.ToInt32(enter.Substring(4, 1)), Convert.ToInt32(enter.Substring(6))));
            lblFansComeIn.Text = (Convert.ToInt32(lblFansComeIn.Text) + 1).ToString();
          }
        }
      }

      lbSectorsQueue.Items.Add("Проход в сектора завершён!");

      btnEnd.Enabled = false;
    }

    private void lblVacantPlaces_TextChanged(object sender, EventArgs e)
    {
      if (Convert.ToInt32((sender as Label).Text) == 0)
      {
        btnEnd_Click(btnEnd, new EventArgs());
        MessageBox.Show("Стадион заполнен", "Посадка закончена");
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (_threadEnterQueue != null && _threadEnterQueue.IsAlive)
      {
        _threadEnterQueue.Abort();
      }

      for (int i = 0; i < _securityThreads.Count; i++)
      {
        if (_securityThreads[i] != null && _securityThreads[i].IsAlive)
          _securityThreads[i].Abort();
      }

      for (int i = 0; i < _stuardThreads.Count; i++)
      {
        if (_stuardThreads[i] != null && _stuardThreads[i].IsAlive)
          _stuardThreads[i].Abort();
      }
    }

    public class SectorChangedEventArgs : EventArgs
    {
      private int _nSector;
      private int _busyPlaces;

      public SectorChangedEventArgs(int m, int Nsec)
      {
        _nSector = Nsec;
        _busyPlaces = m;
      }

      public int BusyPlaces
      {
        get { return _busyPlaces; }
      }

      public int NSector
      {
        get { return _nSector; }
      }
    }

    void sector_SectorItemsChanged(object sender, SectorChangedEventArgs e)
    {
      lblBusyPlaces.Text = (Convert.ToInt32(lblBusyPlaces.Text) + 1).ToString();

      lblVacantPlaces.Text = (Capacity - Convert.ToInt32(lblBusyPlaces.Text)).ToString();

      Controls["lblSector" + e.NSector + "BusyPlaces"].Text = e.BusyPlaces.ToString();
      Controls["lblSector" + e.NSector + "VacantPlaces"].Text = (Places - e.BusyPlaces).ToString();
    }
  }

  internal class Fan
  {
    public bool _ticket;
    public int _sector;
    public int _place;

    public Fan(bool ticket = true, int sector = 0, int place = 0)
    {
      _ticket = ticket;
      _sector = sector;
      _place = place;
    }

    public override string ToString()
    {
      return "Fan-" + _sector + "-" + _place;
    }

    //b. соответствующие методы
    //c. конструкторы
    //d. деструктор
  }
}
