namespace Stadium
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnBegin = new System.Windows.Forms.Button();
      this.btnEnd = new System.Windows.Forms.Button();
      this.lbSector1 = new System.Windows.Forms.ListBox();
      this.lbSector2 = new System.Windows.Forms.ListBox();
      this.lbSector3 = new System.Windows.Forms.ListBox();
      this.lbSector4 = new System.Windows.Forms.ListBox();
      this.lbSector5 = new System.Windows.Forms.ListBox();
      this.lbSector6 = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.lbSectorsQueue = new System.Windows.Forms.ListBox();
      this.lbEnterQueue = new System.Windows.Forms.ListBox();
      this.tbSector1 = new System.Windows.Forms.TextBox();
      this.tbSector2 = new System.Windows.Forms.TextBox();
      this.tbSector3 = new System.Windows.Forms.TextBox();
      this.tbSector4 = new System.Windows.Forms.TextBox();
      this.tbSector5 = new System.Windows.Forms.TextBox();
      this.tbSector6 = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.lblSector1BusyPlaces = new System.Windows.Forms.Label();
      this.lblSector1VacantPlaces = new System.Windows.Forms.Label();
      this.lblSector2VacantPlaces = new System.Windows.Forms.Label();
      this.lblSector2BusyPlaces = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.lblSector3VacantPlaces = new System.Windows.Forms.Label();
      this.lblSector3BusyPlaces = new System.Windows.Forms.Label();
      this.label23 = new System.Windows.Forms.Label();
      this.label24 = new System.Windows.Forms.Label();
      this.label25 = new System.Windows.Forms.Label();
      this.lblSector4VacantPlaces = new System.Windows.Forms.Label();
      this.lblSector4BusyPlaces = new System.Windows.Forms.Label();
      this.label28 = new System.Windows.Forms.Label();
      this.label29 = new System.Windows.Forms.Label();
      this.label30 = new System.Windows.Forms.Label();
      this.lblSector5VacantPlaces = new System.Windows.Forms.Label();
      this.lblSector5BusyPlaces = new System.Windows.Forms.Label();
      this.label33 = new System.Windows.Forms.Label();
      this.label34 = new System.Windows.Forms.Label();
      this.label35 = new System.Windows.Forms.Label();
      this.lblSector6VacantPlaces = new System.Windows.Forms.Label();
      this.lblSector6BusyPlaces = new System.Windows.Forms.Label();
      this.label38 = new System.Windows.Forms.Label();
      this.label39 = new System.Windows.Forms.Label();
      this.label40 = new System.Windows.Forms.Label();
      this.lblBusyPlaces = new System.Windows.Forms.Label();
      this.lblVacantPlaces = new System.Windows.Forms.Label();
      this.lblFansComeIn = new System.Windows.Forms.Label();
      this.lblFansComeOut = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.label22 = new System.Windows.Forms.Label();
      this.label26 = new System.Windows.Forms.Label();
      this.tbEnter1 = new System.Windows.Forms.TextBox();
      this.tbEnter2 = new System.Windows.Forms.TextBox();
      this.tbEnter3 = new System.Windows.Forms.TextBox();
      this.tbEnter4 = new System.Windows.Forms.TextBox();
      this.label27 = new System.Windows.Forms.Label();
      this.label31 = new System.Windows.Forms.Label();
      this.label32 = new System.Windows.Forms.Label();
      this.label36 = new System.Windows.Forms.Label();
      this.label37 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnBegin
      // 
      this.btnBegin.Location = new System.Drawing.Point(19, 16);
      this.btnBegin.Name = "btnBegin";
      this.btnBegin.Size = new System.Drawing.Size(75, 23);
      this.btnBegin.TabIndex = 0;
      this.btnBegin.Text = "Начало";
      this.btnBegin.UseVisualStyleBackColor = true;
      this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
      // 
      // btnEnd
      // 
      this.btnEnd.Enabled = false;
      this.btnEnd.Location = new System.Drawing.Point(117, 16);
      this.btnEnd.Name = "btnEnd";
      this.btnEnd.Size = new System.Drawing.Size(82, 23);
      this.btnEnd.TabIndex = 1;
      this.btnEnd.Text = "Завершение";
      this.btnEnd.UseVisualStyleBackColor = true;
      this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
      // 
      // lbSector1
      // 
      this.lbSector1.BackColor = System.Drawing.Color.Aquamarine;
      this.lbSector1.ColumnWidth = 40;
      this.lbSector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbSector1.ForeColor = System.Drawing.Color.Red;
      this.lbSector1.FormattingEnabled = true;
      this.lbSector1.Location = new System.Drawing.Point(19, 66);
      this.lbSector1.MultiColumn = true;
      this.lbSector1.Name = "lbSector1";
      this.lbSector1.Size = new System.Drawing.Size(191, 277);
      this.lbSector1.TabIndex = 2;
      // 
      // lbSector2
      // 
      this.lbSector2.BackColor = System.Drawing.Color.DodgerBlue;
      this.lbSector2.ColumnWidth = 40;
      this.lbSector2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbSector2.ForeColor = System.Drawing.Color.White;
      this.lbSector2.FormattingEnabled = true;
      this.lbSector2.Location = new System.Drawing.Point(216, 66);
      this.lbSector2.MultiColumn = true;
      this.lbSector2.Name = "lbSector2";
      this.lbSector2.Size = new System.Drawing.Size(189, 277);
      this.lbSector2.TabIndex = 3;
      // 
      // lbSector3
      // 
      this.lbSector3.BackColor = System.Drawing.Color.Orchid;
      this.lbSector3.ColumnWidth = 40;
      this.lbSector3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbSector3.ForeColor = System.Drawing.Color.White;
      this.lbSector3.FormattingEnabled = true;
      this.lbSector3.Location = new System.Drawing.Point(411, 66);
      this.lbSector3.MultiColumn = true;
      this.lbSector3.Name = "lbSector3";
      this.lbSector3.Size = new System.Drawing.Size(200, 277);
      this.lbSector3.TabIndex = 4;
      // 
      // lbSector4
      // 
      this.lbSector4.BackColor = System.Drawing.Color.IndianRed;
      this.lbSector4.ColumnWidth = 40;
      this.lbSector4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbSector4.ForeColor = System.Drawing.Color.White;
      this.lbSector4.FormattingEnabled = true;
      this.lbSector4.Location = new System.Drawing.Point(617, 66);
      this.lbSector4.MultiColumn = true;
      this.lbSector4.Name = "lbSector4";
      this.lbSector4.Size = new System.Drawing.Size(196, 277);
      this.lbSector4.TabIndex = 5;
      // 
      // lbSector5
      // 
      this.lbSector5.BackColor = System.Drawing.Color.PaleGreen;
      this.lbSector5.ColumnWidth = 40;
      this.lbSector5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbSector5.ForeColor = System.Drawing.Color.Red;
      this.lbSector5.FormattingEnabled = true;
      this.lbSector5.Location = new System.Drawing.Point(819, 66);
      this.lbSector5.MultiColumn = true;
      this.lbSector5.Name = "lbSector5";
      this.lbSector5.Size = new System.Drawing.Size(201, 277);
      this.lbSector5.TabIndex = 6;
      // 
      // lbSector6
      // 
      this.lbSector6.BackColor = System.Drawing.Color.MediumPurple;
      this.lbSector6.ColumnWidth = 40;
      this.lbSector6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbSector6.ForeColor = System.Drawing.Color.White;
      this.lbSector6.FormattingEnabled = true;
      this.lbSector6.Location = new System.Drawing.Point(1026, 66);
      this.lbSector6.MultiColumn = true;
      this.lbSector6.Name = "lbSector6";
      this.lbSector6.Size = new System.Drawing.Size(205, 277);
      this.lbSector6.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(91, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Сектор 1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(281, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Сектор 2";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(484, 48);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Сектор 3";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(688, 48);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "Сектор 4";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(894, 48);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(52, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Сектор 5";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(1098, 50);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(52, 13);
      this.label6.TabIndex = 13;
      this.label6.Text = "Сектор 6";
      // 
      // lbSectorsQueue
      // 
      this.lbSectorsQueue.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.lbSectorsQueue.ColumnWidth = 60;
      this.lbSectorsQueue.FormattingEnabled = true;
      this.lbSectorsQueue.Location = new System.Drawing.Point(12, 412);
      this.lbSectorsQueue.MultiColumn = true;
      this.lbSectorsQueue.Name = "lbSectorsQueue";
      this.lbSectorsQueue.Size = new System.Drawing.Size(1212, 121);
      this.lbSectorsQueue.TabIndex = 14;
      // 
      // lbEnterQueue
      // 
      this.lbEnterQueue.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.lbEnterQueue.ColumnWidth = 60;
      this.lbEnterQueue.FormattingEnabled = true;
      this.lbEnterQueue.Location = new System.Drawing.Point(12, 625);
      this.lbEnterQueue.MultiColumn = true;
      this.lbEnterQueue.Name = "lbEnterQueue";
      this.lbEnterQueue.Size = new System.Drawing.Size(1219, 173);
      this.lbEnterQueue.TabIndex = 19;
      // 
      // tbSector1
      // 
      this.tbSector1.Location = new System.Drawing.Point(82, 361);
      this.tbSector1.Name = "tbSector1";
      this.tbSector1.Size = new System.Drawing.Size(72, 20);
      this.tbSector1.TabIndex = 20;
      // 
      // tbSector2
      // 
      this.tbSector2.Location = new System.Drawing.Point(273, 362);
      this.tbSector2.Name = "tbSector2";
      this.tbSector2.Size = new System.Drawing.Size(72, 20);
      this.tbSector2.TabIndex = 21;
      // 
      // tbSector3
      // 
      this.tbSector3.Location = new System.Drawing.Point(475, 361);
      this.tbSector3.Name = "tbSector3";
      this.tbSector3.Size = new System.Drawing.Size(72, 20);
      this.tbSector3.TabIndex = 22;
      // 
      // tbSector4
      // 
      this.tbSector4.Location = new System.Drawing.Point(679, 362);
      this.tbSector4.Name = "tbSector4";
      this.tbSector4.Size = new System.Drawing.Size(72, 20);
      this.tbSector4.TabIndex = 23;
      // 
      // tbSector5
      // 
      this.tbSector5.Location = new System.Drawing.Point(887, 361);
      this.tbSector5.Name = "tbSector5";
      this.tbSector5.Size = new System.Drawing.Size(67, 20);
      this.tbSector5.TabIndex = 24;
      // 
      // tbSector6
      // 
      this.tbSector6.Location = new System.Drawing.Point(1094, 362);
      this.tbSector6.Name = "tbSector6";
      this.tbSector6.Size = new System.Drawing.Size(76, 20);
      this.tbSector6.TabIndex = 25;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(1260, 36);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(78, 13);
      this.label7.TabIndex = 31;
      this.label7.Text = "Занятых мест";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(1260, 63);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(91, 13);
      this.label8.TabIndex = 32;
      this.label8.Text = "Свободных мест";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(1260, 92);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(40, 13);
      this.label9.TabIndex = 33;
      this.label9.Text = "Зашло";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(1260, 122);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(42, 13);
      this.label10.TabIndex = 34;
      this.label10.Text = "Вышло";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(1260, 158);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(55, 13);
      this.label11.TabIndex = 35;
      this.label11.Text = "Сектор 1:";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(1320, 158);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(43, 13);
      this.label13.TabIndex = 37;
      this.label13.Text = "Занято";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(1320, 183);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(56, 13);
      this.label14.TabIndex = 38;
      this.label14.Text = "Свободно";
      // 
      // lblSector1BusyPlaces
      // 
      this.lblSector1BusyPlaces.AutoSize = true;
      this.lblSector1BusyPlaces.Location = new System.Drawing.Point(1381, 158);
      this.lblSector1BusyPlaces.Name = "lblSector1BusyPlaces";
      this.lblSector1BusyPlaces.Size = new System.Drawing.Size(13, 13);
      this.lblSector1BusyPlaces.TabIndex = 39;
      this.lblSector1BusyPlaces.Text = "0";
      // 
      // lblSector1VacantPlaces
      // 
      this.lblSector1VacantPlaces.AutoSize = true;
      this.lblSector1VacantPlaces.Location = new System.Drawing.Point(1381, 183);
      this.lblSector1VacantPlaces.Name = "lblSector1VacantPlaces";
      this.lblSector1VacantPlaces.Size = new System.Drawing.Size(25, 13);
      this.lblSector1VacantPlaces.TabIndex = 40;
      this.lblSector1VacantPlaces.Text = "400";
      // 
      // lblSector2VacantPlaces
      // 
      this.lblSector2VacantPlaces.AutoSize = true;
      this.lblSector2VacantPlaces.Location = new System.Drawing.Point(1381, 235);
      this.lblSector2VacantPlaces.Name = "lblSector2VacantPlaces";
      this.lblSector2VacantPlaces.Size = new System.Drawing.Size(25, 13);
      this.lblSector2VacantPlaces.TabIndex = 45;
      this.lblSector2VacantPlaces.Text = "400";
      // 
      // lblSector2BusyPlaces
      // 
      this.lblSector2BusyPlaces.AutoSize = true;
      this.lblSector2BusyPlaces.Location = new System.Drawing.Point(1381, 210);
      this.lblSector2BusyPlaces.Name = "lblSector2BusyPlaces";
      this.lblSector2BusyPlaces.Size = new System.Drawing.Size(13, 13);
      this.lblSector2BusyPlaces.TabIndex = 44;
      this.lblSector2BusyPlaces.Text = "0";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Location = new System.Drawing.Point(1320, 235);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(56, 13);
      this.label19.TabIndex = 43;
      this.label19.Text = "Свободно";
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Location = new System.Drawing.Point(1320, 210);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(43, 13);
      this.label20.TabIndex = 42;
      this.label20.Text = "Занято";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Location = new System.Drawing.Point(1260, 210);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(55, 13);
      this.label21.TabIndex = 41;
      this.label21.Text = "Сектор 2:";
      // 
      // lblSector3VacantPlaces
      // 
      this.lblSector3VacantPlaces.AutoSize = true;
      this.lblSector3VacantPlaces.Location = new System.Drawing.Point(1381, 290);
      this.lblSector3VacantPlaces.Name = "lblSector3VacantPlaces";
      this.lblSector3VacantPlaces.Size = new System.Drawing.Size(25, 13);
      this.lblSector3VacantPlaces.TabIndex = 50;
      this.lblSector3VacantPlaces.Text = "400";
      // 
      // lblSector3BusyPlaces
      // 
      this.lblSector3BusyPlaces.AutoSize = true;
      this.lblSector3BusyPlaces.Location = new System.Drawing.Point(1381, 265);
      this.lblSector3BusyPlaces.Name = "lblSector3BusyPlaces";
      this.lblSector3BusyPlaces.Size = new System.Drawing.Size(13, 13);
      this.lblSector3BusyPlaces.TabIndex = 49;
      this.lblSector3BusyPlaces.Text = "0";
      // 
      // label23
      // 
      this.label23.AutoSize = true;
      this.label23.Location = new System.Drawing.Point(1320, 290);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(56, 13);
      this.label23.TabIndex = 48;
      this.label23.Text = "Свободно";
      // 
      // label24
      // 
      this.label24.AutoSize = true;
      this.label24.Location = new System.Drawing.Point(1320, 265);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(43, 13);
      this.label24.TabIndex = 47;
      this.label24.Text = "Занято";
      // 
      // label25
      // 
      this.label25.AutoSize = true;
      this.label25.Location = new System.Drawing.Point(1260, 265);
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size(55, 13);
      this.label25.TabIndex = 46;
      this.label25.Text = "Сектор 3:";
      // 
      // lblSector4VacantPlaces
      // 
      this.lblSector4VacantPlaces.AutoSize = true;
      this.lblSector4VacantPlaces.Location = new System.Drawing.Point(1381, 345);
      this.lblSector4VacantPlaces.Name = "lblSector4VacantPlaces";
      this.lblSector4VacantPlaces.Size = new System.Drawing.Size(25, 13);
      this.lblSector4VacantPlaces.TabIndex = 55;
      this.lblSector4VacantPlaces.Text = "400";
      // 
      // lblSector4BusyPlaces
      // 
      this.lblSector4BusyPlaces.AutoSize = true;
      this.lblSector4BusyPlaces.Location = new System.Drawing.Point(1381, 320);
      this.lblSector4BusyPlaces.Name = "lblSector4BusyPlaces";
      this.lblSector4BusyPlaces.Size = new System.Drawing.Size(13, 13);
      this.lblSector4BusyPlaces.TabIndex = 54;
      this.lblSector4BusyPlaces.Text = "0";
      // 
      // label28
      // 
      this.label28.AutoSize = true;
      this.label28.Location = new System.Drawing.Point(1320, 345);
      this.label28.Name = "label28";
      this.label28.Size = new System.Drawing.Size(56, 13);
      this.label28.TabIndex = 53;
      this.label28.Text = "Свободно";
      // 
      // label29
      // 
      this.label29.AutoSize = true;
      this.label29.Location = new System.Drawing.Point(1320, 320);
      this.label29.Name = "label29";
      this.label29.Size = new System.Drawing.Size(43, 13);
      this.label29.TabIndex = 52;
      this.label29.Text = "Занято";
      // 
      // label30
      // 
      this.label30.AutoSize = true;
      this.label30.Location = new System.Drawing.Point(1260, 320);
      this.label30.Name = "label30";
      this.label30.Size = new System.Drawing.Size(55, 13);
      this.label30.TabIndex = 51;
      this.label30.Text = "Сектор 4:";
      // 
      // lblSector5VacantPlaces
      // 
      this.lblSector5VacantPlaces.AutoSize = true;
      this.lblSector5VacantPlaces.Location = new System.Drawing.Point(1381, 399);
      this.lblSector5VacantPlaces.Name = "lblSector5VacantPlaces";
      this.lblSector5VacantPlaces.Size = new System.Drawing.Size(25, 13);
      this.lblSector5VacantPlaces.TabIndex = 60;
      this.lblSector5VacantPlaces.Text = "400";
      // 
      // lblSector5BusyPlaces
      // 
      this.lblSector5BusyPlaces.AutoSize = true;
      this.lblSector5BusyPlaces.Location = new System.Drawing.Point(1381, 374);
      this.lblSector5BusyPlaces.Name = "lblSector5BusyPlaces";
      this.lblSector5BusyPlaces.Size = new System.Drawing.Size(13, 13);
      this.lblSector5BusyPlaces.TabIndex = 59;
      this.lblSector5BusyPlaces.Text = "0";
      // 
      // label33
      // 
      this.label33.AutoSize = true;
      this.label33.Location = new System.Drawing.Point(1320, 399);
      this.label33.Name = "label33";
      this.label33.Size = new System.Drawing.Size(56, 13);
      this.label33.TabIndex = 58;
      this.label33.Text = "Свободно";
      // 
      // label34
      // 
      this.label34.AutoSize = true;
      this.label34.Location = new System.Drawing.Point(1320, 374);
      this.label34.Name = "label34";
      this.label34.Size = new System.Drawing.Size(43, 13);
      this.label34.TabIndex = 57;
      this.label34.Text = "Занято";
      // 
      // label35
      // 
      this.label35.AutoSize = true;
      this.label35.Location = new System.Drawing.Point(1260, 374);
      this.label35.Name = "label35";
      this.label35.Size = new System.Drawing.Size(55, 13);
      this.label35.TabIndex = 56;
      this.label35.Text = "Сектор 5:";
      // 
      // lblSector6VacantPlaces
      // 
      this.lblSector6VacantPlaces.AutoSize = true;
      this.lblSector6VacantPlaces.Location = new System.Drawing.Point(1381, 451);
      this.lblSector6VacantPlaces.Name = "lblSector6VacantPlaces";
      this.lblSector6VacantPlaces.Size = new System.Drawing.Size(25, 13);
      this.lblSector6VacantPlaces.TabIndex = 65;
      this.lblSector6VacantPlaces.Text = "400";
      // 
      // lblSector6BusyPlaces
      // 
      this.lblSector6BusyPlaces.AutoSize = true;
      this.lblSector6BusyPlaces.Location = new System.Drawing.Point(1381, 426);
      this.lblSector6BusyPlaces.Name = "lblSector6BusyPlaces";
      this.lblSector6BusyPlaces.Size = new System.Drawing.Size(13, 13);
      this.lblSector6BusyPlaces.TabIndex = 64;
      this.lblSector6BusyPlaces.Text = "0";
      // 
      // label38
      // 
      this.label38.AutoSize = true;
      this.label38.Location = new System.Drawing.Point(1320, 451);
      this.label38.Name = "label38";
      this.label38.Size = new System.Drawing.Size(56, 13);
      this.label38.TabIndex = 63;
      this.label38.Text = "Свободно";
      // 
      // label39
      // 
      this.label39.AutoSize = true;
      this.label39.Location = new System.Drawing.Point(1320, 426);
      this.label39.Name = "label39";
      this.label39.Size = new System.Drawing.Size(43, 13);
      this.label39.TabIndex = 62;
      this.label39.Text = "Занято";
      // 
      // label40
      // 
      this.label40.AutoSize = true;
      this.label40.Location = new System.Drawing.Point(1260, 426);
      this.label40.Name = "label40";
      this.label40.Size = new System.Drawing.Size(55, 13);
      this.label40.TabIndex = 61;
      this.label40.Text = "Сектор 6:";
      // 
      // lblBusyPlaces
      // 
      this.lblBusyPlaces.AutoSize = true;
      this.lblBusyPlaces.Location = new System.Drawing.Point(1381, 36);
      this.lblBusyPlaces.Name = "lblBusyPlaces";
      this.lblBusyPlaces.Size = new System.Drawing.Size(13, 13);
      this.lblBusyPlaces.TabIndex = 66;
      this.lblBusyPlaces.Text = "0";
      // 
      // lblVacantPlaces
      // 
      this.lblVacantPlaces.AutoSize = true;
      this.lblVacantPlaces.Location = new System.Drawing.Point(1381, 63);
      this.lblVacantPlaces.Name = "lblVacantPlaces";
      this.lblVacantPlaces.Size = new System.Drawing.Size(31, 13);
      this.lblVacantPlaces.TabIndex = 67;
      this.lblVacantPlaces.Text = "2400";
      this.lblVacantPlaces.TextChanged += new System.EventHandler(this.lblVacantPlaces_TextChanged);
      // 
      // lblFansComeIn
      // 
      this.lblFansComeIn.AutoSize = true;
      this.lblFansComeIn.Location = new System.Drawing.Point(1381, 92);
      this.lblFansComeIn.Name = "lblFansComeIn";
      this.lblFansComeIn.Size = new System.Drawing.Size(13, 13);
      this.lblFansComeIn.TabIndex = 68;
      this.lblFansComeIn.Text = "0";
      // 
      // lblFansComeOut
      // 
      this.lblFansComeOut.AutoSize = true;
      this.lblFansComeOut.Location = new System.Drawing.Point(1381, 122);
      this.lblFansComeOut.Name = "lblFansComeOut";
      this.lblFansComeOut.Size = new System.Drawing.Size(13, 13);
      this.lblFansComeOut.TabIndex = 69;
      this.lblFansComeOut.Text = "0";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(89, 345);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(54, 13);
      this.label12.TabIndex = 70;
      this.label12.Text = "Стюард 1";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(281, 346);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(54, 13);
      this.label15.TabIndex = 71;
      this.label15.Text = "Стюард 2";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(484, 345);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(54, 13);
      this.label16.TabIndex = 72;
      this.label16.Text = "Стюард 3";
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(688, 346);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(54, 13);
      this.label17.TabIndex = 73;
      this.label17.Text = "Стюард 4";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(892, 345);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(54, 13);
      this.label18.TabIndex = 74;
      this.label18.Text = "Стюард 5";
      // 
      // label22
      // 
      this.label22.AutoSize = true;
      this.label22.Location = new System.Drawing.Point(1104, 346);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(54, 13);
      this.label22.TabIndex = 75;
      this.label22.Text = "Стюард 6";
      // 
      // label26
      // 
      this.label26.AutoSize = true;
      this.label26.Location = new System.Drawing.Point(543, 596);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(123, 13);
      this.label26.TabIndex = 76;
      this.label26.Text = "Очередь перед входом";
      // 
      // tbEnter1
      // 
      this.tbEnter1.Location = new System.Drawing.Point(108, 565);
      this.tbEnter1.Name = "tbEnter1";
      this.tbEnter1.Size = new System.Drawing.Size(124, 20);
      this.tbEnter1.TabIndex = 26;
      // 
      // tbEnter2
      // 
      this.tbEnter2.Location = new System.Drawing.Point(405, 564);
      this.tbEnter2.Name = "tbEnter2";
      this.tbEnter2.Size = new System.Drawing.Size(124, 20);
      this.tbEnter2.TabIndex = 27;
      // 
      // tbEnter3
      // 
      this.tbEnter3.Location = new System.Drawing.Point(687, 565);
      this.tbEnter3.Name = "tbEnter3";
      this.tbEnter3.Size = new System.Drawing.Size(124, 20);
      this.tbEnter3.TabIndex = 28;
      // 
      // tbEnter4
      // 
      this.tbEnter4.Location = new System.Drawing.Point(981, 566);
      this.tbEnter4.Name = "tbEnter4";
      this.tbEnter4.Size = new System.Drawing.Size(124, 20);
      this.tbEnter4.TabIndex = 29;
      // 
      // label27
      // 
      this.label27.AutoSize = true;
      this.label27.Location = new System.Drawing.Point(543, 387);
      this.label27.Name = "label27";
      this.label27.Size = new System.Drawing.Size(141, 13);
      this.label27.TabIndex = 77;
      this.label27.Text = "Очередь перед секторами";
      // 
      // label31
      // 
      this.label31.AutoSize = true;
      this.label31.Location = new System.Drawing.Point(152, 549);
      this.label31.Name = "label31";
      this.label31.Size = new System.Drawing.Size(40, 13);
      this.label31.TabIndex = 78;
      this.label31.Text = "Вход 1";
      // 
      // label32
      // 
      this.label32.AutoSize = true;
      this.label32.Location = new System.Drawing.Point(452, 548);
      this.label32.Name = "label32";
      this.label32.Size = new System.Drawing.Size(40, 13);
      this.label32.TabIndex = 79;
      this.label32.Text = "Вход 2";
      // 
      // label36
      // 
      this.label36.AutoSize = true;
      this.label36.Location = new System.Drawing.Point(732, 549);
      this.label36.Name = "label36";
      this.label36.Size = new System.Drawing.Size(40, 13);
      this.label36.TabIndex = 80;
      this.label36.Text = "Вход 3";
      // 
      // label37
      // 
      this.label37.AutoSize = true;
      this.label37.Location = new System.Drawing.Point(1016, 549);
      this.label37.Name = "label37";
      this.label37.Size = new System.Drawing.Size(40, 13);
      this.label37.TabIndex = 81;
      this.label37.Text = "Вход 4";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1424, 811);
      this.Controls.Add(this.label37);
      this.Controls.Add(this.label36);
      this.Controls.Add(this.label32);
      this.Controls.Add(this.label31);
      this.Controls.Add(this.label27);
      this.Controls.Add(this.label26);
      this.Controls.Add(this.label22);
      this.Controls.Add(this.label18);
      this.Controls.Add(this.label17);
      this.Controls.Add(this.label16);
      this.Controls.Add(this.label15);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.lblFansComeOut);
      this.Controls.Add(this.lblFansComeIn);
      this.Controls.Add(this.lblVacantPlaces);
      this.Controls.Add(this.lblBusyPlaces);
      this.Controls.Add(this.lblSector6VacantPlaces);
      this.Controls.Add(this.lblSector6BusyPlaces);
      this.Controls.Add(this.label38);
      this.Controls.Add(this.label39);
      this.Controls.Add(this.label40);
      this.Controls.Add(this.lblSector5VacantPlaces);
      this.Controls.Add(this.lblSector5BusyPlaces);
      this.Controls.Add(this.label33);
      this.Controls.Add(this.label34);
      this.Controls.Add(this.label35);
      this.Controls.Add(this.lblSector4VacantPlaces);
      this.Controls.Add(this.lblSector4BusyPlaces);
      this.Controls.Add(this.label28);
      this.Controls.Add(this.label29);
      this.Controls.Add(this.label30);
      this.Controls.Add(this.lblSector3VacantPlaces);
      this.Controls.Add(this.lblSector3BusyPlaces);
      this.Controls.Add(this.label23);
      this.Controls.Add(this.label24);
      this.Controls.Add(this.label25);
      this.Controls.Add(this.lblSector2VacantPlaces);
      this.Controls.Add(this.lblSector2BusyPlaces);
      this.Controls.Add(this.label19);
      this.Controls.Add(this.label20);
      this.Controls.Add(this.label21);
      this.Controls.Add(this.lblSector1VacantPlaces);
      this.Controls.Add(this.lblSector1BusyPlaces);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.tbEnter4);
      this.Controls.Add(this.tbEnter3);
      this.Controls.Add(this.tbEnter2);
      this.Controls.Add(this.tbEnter1);
      this.Controls.Add(this.tbSector6);
      this.Controls.Add(this.tbSector5);
      this.Controls.Add(this.tbSector4);
      this.Controls.Add(this.tbSector3);
      this.Controls.Add(this.tbSector2);
      this.Controls.Add(this.tbSector1);
      this.Controls.Add(this.lbEnterQueue);
      this.Controls.Add(this.lbSectorsQueue);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lbSector6);
      this.Controls.Add(this.lbSector5);
      this.Controls.Add(this.lbSector4);
      this.Controls.Add(this.lbSector3);
      this.Controls.Add(this.lbSector2);
      this.Controls.Add(this.lbSector1);
      this.Controls.Add(this.btnEnd);
      this.Controls.Add(this.btnBegin);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Стадион";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnBegin;
    private System.Windows.Forms.Button btnEnd;
    private System.Windows.Forms.ListBox lbSector1;
    private System.Windows.Forms.ListBox lbSector2;
    private System.Windows.Forms.ListBox lbSector3;
    private System.Windows.Forms.ListBox lbSector4;
    private System.Windows.Forms.ListBox lbSector5;
    private System.Windows.Forms.ListBox lbSector6;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ListBox lbSectorsQueue;
    private System.Windows.Forms.ListBox lbEnterQueue;
    private System.Windows.Forms.TextBox tbSector1;
    private System.Windows.Forms.TextBox tbSector2;
    private System.Windows.Forms.TextBox tbSector3;
    private System.Windows.Forms.TextBox tbSector4;
    private System.Windows.Forms.TextBox tbSector5;
    private System.Windows.Forms.TextBox tbSector6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label lblSector1BusyPlaces;
    private System.Windows.Forms.Label lblSector1VacantPlaces;
    private System.Windows.Forms.Label lblSector2VacantPlaces;
    private System.Windows.Forms.Label lblSector2BusyPlaces;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label lblSector3VacantPlaces;
    private System.Windows.Forms.Label lblSector3BusyPlaces;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.Label label25;
    private System.Windows.Forms.Label lblSector4VacantPlaces;
    private System.Windows.Forms.Label lblSector4BusyPlaces;
    private System.Windows.Forms.Label label28;
    private System.Windows.Forms.Label label29;
    private System.Windows.Forms.Label label30;
    private System.Windows.Forms.Label lblSector5VacantPlaces;
    private System.Windows.Forms.Label lblSector5BusyPlaces;
    private System.Windows.Forms.Label label33;
    private System.Windows.Forms.Label label34;
    private System.Windows.Forms.Label label35;
    private System.Windows.Forms.Label lblSector6VacantPlaces;
    private System.Windows.Forms.Label lblSector6BusyPlaces;
    private System.Windows.Forms.Label label38;
    private System.Windows.Forms.Label label39;
    private System.Windows.Forms.Label label40;
    private System.Windows.Forms.Label lblBusyPlaces;
    private System.Windows.Forms.Label lblVacantPlaces;
    private System.Windows.Forms.Label lblFansComeIn;
    private System.Windows.Forms.Label lblFansComeOut;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Label label26;
    private System.Windows.Forms.TextBox tbEnter1;
    private System.Windows.Forms.TextBox tbEnter2;
    private System.Windows.Forms.TextBox tbEnter3;
    private System.Windows.Forms.TextBox tbEnter4;
    private System.Windows.Forms.Label label27;
    private System.Windows.Forms.Label label31;
    private System.Windows.Forms.Label label32;
    private System.Windows.Forms.Label label36;
    private System.Windows.Forms.Label label37;
  }
}

