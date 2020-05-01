namespace LAN_APP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabadd = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.txtsoft = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txthost = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnremove = new System.Windows.Forms.Button();
            this.lstpc = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstno = new System.Windows.Forms.ListBox();
            this.lstyes = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.chkall = new System.Windows.Forms.CheckBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chklist = new System.Windows.Forms.CheckedListBox();
            this.cmbsoft = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tab.SuspendLayout();
            this.tabadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabadd);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(-1, -1);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Drawing.Point(8, 3);
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(959, 580);
            this.tab.TabIndex = 0;
            // 
            // tabadd
            // 
            this.tabadd.Controls.Add(this.splitContainer1);
            this.tabadd.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabadd.Location = new System.Drawing.Point(4, 37);
            this.tabadd.Name = "tabadd";
            this.tabadd.Padding = new System.Windows.Forms.Padding(3);
            this.tabadd.Size = new System.Drawing.Size(951, 539);
            this.tabadd.TabIndex = 0;
            this.tabadd.Text = "Add/Remove Workstations";
            this.tabadd.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.txtsoft);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.btnadd);
            this.splitContainer1.Panel1.Controls.Add(this.txthost);
            this.splitContainer1.Panel1.Controls.Add(this.txtip);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.shapeContainer1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnremove);
            this.splitContainer1.Panel2.Controls.Add(this.lstpc);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(945, 533);
            this.splitContainer1.SplitterDistance = 469;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(187, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add this Software";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsoft
            // 
            this.txtsoft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoft.Location = new System.Drawing.Point(187, 388);
            this.txtsoft.Name = "txtsoft";
            this.txtsoft.Size = new System.Drawing.Size(255, 34);
            this.txtsoft.TabIndex = 9;
            this.txtsoft.TextChanged += new System.EventHandler(this.txtsoft_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 32);
            this.label11.TabIndex = 8;
            this.label11.Text = "Software Name";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(6, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 38);
            this.label10.TabIndex = 7;
            this.label10.Text = "Add new software...";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Green;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(187, 205);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(255, 45);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add this PC";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txthost
            // 
            this.txthost.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthost.Location = new System.Drawing.Point(187, 143);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(255, 38);
            this.txthost.TabIndex = 4;
            this.txthost.TextChanged += new System.EventHandler(this.txthost_TextChanged);
            // 
            // txtip
            // 
            this.txtip.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtip.Location = new System.Drawing.Point(187, 87);
            this.txtip.Mask = "###.###.###.###";
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(255, 38);
            this.txtip.TabIndex = 3;
            this.txtip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtip.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtip_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "PC Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new PC...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(469, 533);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DarkGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 11;
            this.lineShape3.X2 = 458;
            this.lineShape3.Y1 = 297;
            this.lineShape3.Y2 = 297;
            this.lineShape3.Click += new System.EventHandler(this.lineShape3_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 467;
            this.lineShape1.X2 = 467;
            this.lineShape1.Y1 = -3;
            this.lineShape1.Y2 = 530;
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnremove.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnremove.FlatAppearance.BorderSize = 0;
            this.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnremove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Location = new System.Drawing.Point(199, 461);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(255, 45);
            this.btnremove.TabIndex = 6;
            this.btnremove.Text = "Remove this PC";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // lstpc
            // 
            this.lstpc.BackColor = System.Drawing.Color.White;
            this.lstpc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstpc.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstpc.FormattingEnabled = true;
            this.lstpc.ItemHeight = 28;
            this.lstpc.Location = new System.Drawing.Point(19, 87);
            this.lstpc.Name = "lstpc";
            this.lstpc.Size = new System.Drawing.Size(435, 366);
            this.lstpc.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "List of PCs currently added...";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lstno);
            this.tabPage2.Controls.Add(this.lstyes);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.chkall);
            this.tabPage2.Controls.Add(this.btncheck);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.chklist);
            this.tabPage2.Controls.Add(this.cmbsoft);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.shapeContainer2);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(951, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check Software Availability";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(490, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Available In...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(717, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Not Available In...";
            // 
            // lstno
            // 
            this.lstno.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstno.FormattingEnabled = true;
            this.lstno.ItemHeight = 25;
            this.lstno.Location = new System.Drawing.Point(723, 342);
            this.lstno.Name = "lstno";
            this.lstno.Size = new System.Drawing.Size(209, 179);
            this.lstno.TabIndex = 11;
            // 
            // lstyes
            // 
            this.lstyes.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstyes.FormattingEnabled = true;
            this.lstyes.ItemHeight = 25;
            this.lstyes.Location = new System.Drawing.Point(496, 343);
            this.lstyes.Name = "lstyes";
            this.lstyes.Size = new System.Drawing.Size(209, 179);
            this.lstyes.TabIndex = 10;
            this.lstyes.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(496, 77);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "value";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(422, 233);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(490, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Result...";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chkall
            // 
            this.chkall.AutoSize = true;
            this.chkall.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkall.Location = new System.Drawing.Point(32, 183);
            this.chkall.Name = "chkall";
            this.chkall.Size = new System.Drawing.Size(106, 29);
            this.chkall.TabIndex = 7;
            this.chkall.Text = "Select All";
            this.chkall.UseVisualStyleBackColor = true;
            this.chkall.CheckedChanged += new System.EventHandler(this.chkall_CheckedChanged);
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.Green;
            this.btncheck.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btncheck.FlatAppearance.BorderSize = 0;
            this.btncheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheck.ForeColor = System.Drawing.Color.White;
            this.btncheck.Location = new System.Drawing.Point(173, 477);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(255, 45);
            this.btncheck.TabIndex = 6;
            this.btncheck.Text = "Check";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(9, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Look In";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chklist
            // 
            this.chklist.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklist.FormattingEnabled = true;
            this.chklist.Location = new System.Drawing.Point(29, 220);
            this.chklist.Name = "chklist";
            this.chklist.Size = new System.Drawing.Size(400, 238);
            this.chklist.TabIndex = 3;
            // 
            // cmbsoft
            // 
            this.cmbsoft.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsoft.FormattingEnabled = true;
            this.cmbsoft.Location = new System.Drawing.Point(29, 77);
            this.cmbsoft.Name = "cmbsoft";
            this.cmbsoft.Size = new System.Drawing.Size(400, 36);
            this.cmbsoft.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose Software";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(945, 533);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 468;
            this.lineShape2.X2 = 472;
            this.lineShape2.Y1 = 3;
            this.lineShape2.Y2 = 528;
            this.lineShape2.Click += new System.EventHandler(this.lineShape2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 580);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "LAN_APP";
            this.tab.ResumeLayout(false);
            this.tabadd.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabadd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListBox lstpc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnremove;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbsoft;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox chklist;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.CheckBox chkall;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstyes;
        private System.Windows.Forms.ListBox lstno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsoft;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
    }
}

