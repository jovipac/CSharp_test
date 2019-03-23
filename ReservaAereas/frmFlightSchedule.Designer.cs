namespace ReservaAereas
{
    partial class frmFlightSchedule
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.lbl_Airline = new System.Windows.Forms.Label();
            this.cmb_AirlineId = new System.Windows.Forms.ComboBox();
            this.date_calendar = new System.Windows.Forms.MonthCalendar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_Plane = new System.Windows.Forms.Label();
            this.cmb_PlaneId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Destination = new System.Windows.Forms.Label();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.date_DepartureTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_AdmissionTime = new System.Windows.Forms.Label();
            this.lbl_Origin = new System.Windows.Forms.Label();
            this.txt_Origin = new System.Windows.Forms.TextBox();
            this.date_AdmissionTime = new System.Windows.Forms.DateTimePicker();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(744, 507);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonNext1);
            this.tabPage1.Controls.Add(this.lbl_Airline);
            this.tabPage1.Controls.Add(this.cmb_AirlineId);
            this.tabPage1.Controls.Add(this.date_calendar);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonNext1
            // 
            this.buttonNext1.Location = new System.Drawing.Point(530, 402);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(113, 36);
            this.buttonNext1.TabIndex = 28;
            this.buttonNext1.Text = "Siguiente";
            this.buttonNext1.UseVisualStyleBackColor = true;
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // lbl_Airline
            // 
            this.lbl_Airline.AutoSize = true;
            this.lbl_Airline.Location = new System.Drawing.Point(177, 330);
            this.lbl_Airline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Airline.Name = "lbl_Airline";
            this.lbl_Airline.Size = new System.Drawing.Size(76, 20);
            this.lbl_Airline.TabIndex = 27;
            this.lbl_Airline.Text = "Aerolinea";
            // 
            // cmb_AirlineId
            // 
            this.cmb_AirlineId.DisplayMember = "Id";
            this.cmb_AirlineId.FormattingEnabled = true;
            this.cmb_AirlineId.Location = new System.Drawing.Point(285, 321);
            this.cmb_AirlineId.Name = "cmb_AirlineId";
            this.cmb_AirlineId.Size = new System.Drawing.Size(274, 28);
            this.cmb_AirlineId.TabIndex = 26;
            this.cmb_AirlineId.ValueMember = "Id";
            this.cmb_AirlineId.DropDown += new System.EventHandler(this.cmb_AirlineId_DropDown);
            // 
            // date_calendar
            // 
            this.date_calendar.Location = new System.Drawing.Point(188, 41);
            this.date_calendar.Name = "date_calendar";
            this.date_calendar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_Plane);
            this.tabPage2.Controls.Add(this.cmb_PlaneId);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbl_Destination);
            this.tabPage2.Controls.Add(this.txt_Destination);
            this.tabPage2.Controls.Add(this.date_DepartureTime);
            this.tabPage2.Controls.Add(this.lbl_AdmissionTime);
            this.tabPage2.Controls.Add(this.lbl_Origin);
            this.tabPage2.Controls.Add(this.txt_Origin);
            this.tabPage2.Controls.Add(this.date_AdmissionTime);
            this.tabPage2.Controls.Add(this.buttonInsert);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_Plane
            // 
            this.lbl_Plane.AutoSize = true;
            this.lbl_Plane.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Plane.Location = new System.Drawing.Point(75, 63);
            this.lbl_Plane.Name = "lbl_Plane";
            this.lbl_Plane.Size = new System.Drawing.Size(48, 20);
            this.lbl_Plane.TabIndex = 39;
            this.lbl_Plane.Text = "Avion";
            // 
            // cmb_PlaneId
            // 
            this.cmb_PlaneId.FormattingEnabled = true;
            this.cmb_PlaneId.Location = new System.Drawing.Point(242, 61);
            this.cmb_PlaneId.Name = "cmb_PlaneId";
            this.cmb_PlaneId.Size = new System.Drawing.Size(418, 28);
            this.cmb_PlaneId.TabIndex = 38;
            this.cmb_PlaneId.DropDown += new System.EventHandler(this.cmb_PlaneId_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Hora de Salida";
            // 
            // lbl_Destination
            // 
            this.lbl_Destination.AutoSize = true;
            this.lbl_Destination.Location = new System.Drawing.Point(69, 222);
            this.lbl_Destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Destination.Name = "lbl_Destination";
            this.lbl_Destination.Size = new System.Drawing.Size(64, 20);
            this.lbl_Destination.TabIndex = 36;
            this.lbl_Destination.Text = "Destino";
            // 
            // txt_Destination
            // 
            this.txt_Destination.Location = new System.Drawing.Point(242, 222);
            this.txt_Destination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(411, 26);
            this.txt_Destination.TabIndex = 35;
            // 
            // date_DepartureTime
            // 
            this.date_DepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date_DepartureTime.Location = new System.Drawing.Point(242, 273);
            this.date_DepartureTime.Name = "date_DepartureTime";
            this.date_DepartureTime.Size = new System.Drawing.Size(411, 26);
            this.date_DepartureTime.TabIndex = 34;
            // 
            // lbl_AdmissionTime
            // 
            this.lbl_AdmissionTime.AutoSize = true;
            this.lbl_AdmissionTime.Location = new System.Drawing.Point(71, 164);
            this.lbl_AdmissionTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AdmissionTime.Name = "lbl_AdmissionTime";
            this.lbl_AdmissionTime.Size = new System.Drawing.Size(127, 20);
            this.lbl_AdmissionTime.TabIndex = 33;
            this.lbl_AdmissionTime.Text = "Hora de Entrada";
            // 
            // lbl_Origin
            // 
            this.lbl_Origin.AutoSize = true;
            this.lbl_Origin.Location = new System.Drawing.Point(71, 110);
            this.lbl_Origin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Origin.Name = "lbl_Origin";
            this.lbl_Origin.Size = new System.Drawing.Size(56, 20);
            this.lbl_Origin.TabIndex = 32;
            this.lbl_Origin.Text = "Origen";
            // 
            // txt_Origin
            // 
            this.txt_Origin.Location = new System.Drawing.Point(244, 110);
            this.txt_Origin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Origin.Name = "txt_Origin";
            this.txt_Origin.Size = new System.Drawing.Size(411, 26);
            this.txt_Origin.TabIndex = 31;
            // 
            // date_AdmissionTime
            // 
            this.date_AdmissionTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date_AdmissionTime.Location = new System.Drawing.Point(244, 161);
            this.date_AdmissionTime.Name = "date_AdmissionTime";
            this.date_AdmissionTime.Size = new System.Drawing.Size(411, 26);
            this.date_AdmissionTime.TabIndex = 30;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(530, 402);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(113, 36);
            this.buttonInsert.TabIndex = 29;
            this.buttonInsert.Text = "Reservar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(736, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmFlightSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 512);
            this.Controls.Add(this.tabControl);
            this.Name = "frmFlightSchedule";
            this.Text = "Flight Schedule";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MonthCalendar date_calendar;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.Label lbl_Airline;
        private System.Windows.Forms.ComboBox cmb_AirlineId;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DateTimePicker date_AdmissionTime;
        private System.Windows.Forms.Label lbl_AdmissionTime;
        private System.Windows.Forms.Label lbl_Origin;
        private System.Windows.Forms.TextBox txt_Origin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_Plane;
        private System.Windows.Forms.ComboBox cmb_PlaneId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Destination;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.DateTimePicker date_DepartureTime;
    }
}