namespace ReservaAereas
{
    partial class frmPlane
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.runwayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flujoaereoDataSet = new ReservaAereas.flujoaereoDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_StatusId = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Capacity = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusTableAdapter = new ReservaAereas.flujoaereoDataSetTableAdapters.StatusTableAdapter();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runwayTableAdapter = new ReservaAereas.flujoaereoDataSetTableAdapters.RunwayTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Airline = new System.Windows.Forms.Label();
            this.cmb_AirlineId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.runwayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flujoaereoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Id";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(287, 108);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(196, 108);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 21;
            this.buttonInsert.Text = "Agregar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.runwayBindingSource, "Id", true));
            this.txt_Id.Location = new System.Drawing.Point(347, 14);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(59, 20);
            this.txt_Id.TabIndex = 20;
            // 
            // runwayBindingSource
            // 
            this.runwayBindingSource.DataMember = "Runway";
            this.runwayBindingSource.DataSource = this.flujoaereoDataSet;
            // 
            // flujoaereoDataSet
            // 
            this.flujoaereoDataSet.DataSetName = "flujoaereoDataSet";
            this.flujoaereoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Estado";
            // 
            // cmb_StatusId
            // 
            this.cmb_StatusId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Name", true));
            this.cmb_StatusId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.statusBindingSource, "Name", true));
            this.cmb_StatusId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.runwayBindingSource, "Status_id", true));
            this.cmb_StatusId.DataSource = this.statusBindingSource;
            this.cmb_StatusId.DisplayMember = "Name";
            this.cmb_StatusId.FormattingEnabled = true;
            this.cmb_StatusId.Location = new System.Drawing.Point(445, 76);
            this.cmb_StatusId.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_StatusId.Name = "cmb_StatusId";
            this.cmb_StatusId.Size = new System.Drawing.Size(111, 21);
            this.cmb_StatusId.TabIndex = 18;
            this.cmb_StatusId.ValueMember = "Id";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.flujoaereoDataSet;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(15, 44);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 17;
            this.lbl_Description.Text = "Descripcion";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(15, 14);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 13);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "Nombre";
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.runwayBindingSource, "Description", true));
            this.txt_Capacity.Location = new System.Drawing.Point(87, 44);
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.Size = new System.Drawing.Size(319, 20);
            this.txt_Capacity.TabIndex = 15;
            // 
            // txt_Name
            // 
            this.txt_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.runwayBindingSource, "Name", true));
            this.txt_Name.Location = new System.Drawing.Point(87, 14);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(147, 20);
            this.txt_Name.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Airline);
            this.panel1.Controls.Add(this.cmb_AirlineId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_StatusId);
            this.panel1.Controls.Add(this.lbl_Description);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.txt_Capacity);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 142);
            this.panel1.TabIndex = 16;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 350;
            // 
            // Status_id
            // 
            this.Status_id.DataPropertyName = "Status_id";
            this.Status_id.HeaderText = "Status_id";
            this.Status_id.Name = "Status_id";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // runwayTableAdapter
            // 
            this.runwayTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Status_id,
            this.Description});
            this.dataGridView1.DataSource = this.runwayBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 257);
            this.dataGridView1.TabIndex = 15;
            // 
            // lbl_Airline
            // 
            this.lbl_Airline.AutoSize = true;
            this.lbl_Airline.Location = new System.Drawing.Point(15, 82);
            this.lbl_Airline.Name = "lbl_Airline";
            this.lbl_Airline.Size = new System.Drawing.Size(51, 13);
            this.lbl_Airline.TabIndex = 25;
            this.lbl_Airline.Text = "Aerolinea";
            // 
            // cmb_AirlineId
            // 
            this.cmb_AirlineId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Name", true));
            this.cmb_AirlineId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.statusBindingSource, "Name", true));
            this.cmb_AirlineId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.runwayBindingSource, "Status_id", true));
            this.cmb_AirlineId.DataSource = this.statusBindingSource;
            this.cmb_AirlineId.DisplayMember = "Name";
            this.cmb_AirlineId.FormattingEnabled = true;
            this.cmb_AirlineId.Location = new System.Drawing.Point(87, 76);
            this.cmb_AirlineId.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_AirlineId.Name = "cmb_AirlineId";
            this.cmb_AirlineId.Size = new System.Drawing.Size(184, 21);
            this.cmb_AirlineId.TabIndex = 24;
            this.cmb_AirlineId.ValueMember = "Id";
            // 
            // frmPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPlane";
            this.Text = "frmPlane";
            ((System.ComponentModel.ISupportInitialize)(this.runwayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flujoaereoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.BindingSource runwayBindingSource;
        private flujoaereoDataSet flujoaereoDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_StatusId;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Capacity;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Panel panel1;
        private flujoaereoDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private flujoaereoDataSetTableAdapters.RunwayTableAdapter runwayTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Airline;
        private System.Windows.Forms.ComboBox cmb_AirlineId;
    }
}