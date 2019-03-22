namespace ReservaAereas
{
    partial class frmRunway
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
            this.runwayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flujoaereoDataSet = new ReservaAereas.flujoaereoDataSet();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new ReservaAereas.flujoaereoDataSetTableAdapters.StatusTableAdapter();
            this.runwayTableAdapter = new ReservaAereas.flujoaereoDataSetTableAdapters.RunwayTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_StatusId = new System.Windows.Forms.ComboBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.runwayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flujoaereoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Status_id,
            this.Description});
            this.dataGridView.DataSource = this.runwayBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 227);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(668, 395);
            this.dataGridView.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Status_id
            // 
            this.Status_id.DataPropertyName = "Status_id";
            this.Status_id.HeaderText = "Status_id";
            this.Status_id.Name = "Status_id";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 350;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.flujoaereoDataSet;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // runwayTableAdapter
            // 
            this.runwayTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_StatusId);
            this.panel1.Controls.Add(this.lbl_Description);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.txt_Description);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 219);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Id";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(430, 166);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 35);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(294, 166);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(112, 35);
            this.buttonInsert.TabIndex = 21;
            this.buttonInsert.Text = "Agregar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // txt_Id
            // 
            this.txt_Id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.runwayBindingSource, "Id", true));
            this.txt_Id.Location = new System.Drawing.Point(521, 21);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(86, 26);
            this.txt_Id.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
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
            this.cmb_StatusId.Location = new System.Drawing.Point(131, 119);
            this.cmb_StatusId.Name = "cmb_StatusId";
            this.cmb_StatusId.Size = new System.Drawing.Size(164, 28);
            this.cmb_StatusId.TabIndex = 18;
            this.cmb_StatusId.ValueMember = "Id";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(23, 68);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(92, 20);
            this.lbl_Description.TabIndex = 17;
            this.lbl_Description.Text = "Descripcion";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(23, 21);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(65, 20);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "Nombre";
            // 
            // txt_Description
            // 
            this.txt_Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.runwayBindingSource, "Description", true));
            this.txt_Description.Location = new System.Drawing.Point(131, 68);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(476, 26);
            this.txt_Description.TabIndex = 15;
            // 
            // txt_Name
            // 
            this.txt_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.runwayBindingSource, "Name", true));
            this.txt_Name.Location = new System.Drawing.Point(131, 21);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(218, 26);
            this.txt_Name.TabIndex = 14;
            // 
            // frmRunway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRunway";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pistas de Aterrizaje";
            this.Load += new System.EventHandler(this.frmRunway_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runwayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flujoaereoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private flujoaereoDataSet flujoaereoDataSet;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private flujoaereoDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource runwayBindingSource;
        private flujoaereoDataSetTableAdapters.RunwayTableAdapter runwayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_StatusId;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
    }
}