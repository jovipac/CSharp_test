namespace ReservaAereas
{
    partial class frmAirline
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_StatusId = new System.Windows.Forms.ComboBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flujoaereoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flujoaereoDataSet = new ReservaAereas.flujoaereoDataSet();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flujoaereoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flujoaereoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_StatusId);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 173);
            this.panel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Id";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(441, 113);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 35);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(305, 113);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(112, 35);
            this.buttonInsert.TabIndex = 37;
            this.buttonInsert.Text = "Agregar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(532, 28);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(86, 26);
            this.txt_Id.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Estado";
            // 
            // cmb_StatusId
            // 
            this.cmb_StatusId.DisplayMember = "Name";
            this.cmb_StatusId.FormattingEnabled = true;
            this.cmb_StatusId.Location = new System.Drawing.Point(142, 66);
            this.cmb_StatusId.Name = "cmb_StatusId";
            this.cmb_StatusId.Size = new System.Drawing.Size(164, 28);
            this.cmb_StatusId.TabIndex = 34;
            this.cmb_StatusId.ValueMember = "Id";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(34, 28);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(65, 20);
            this.lbl_Name.TabIndex = 33;
            this.lbl_Name.Text = "Nombre";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(142, 28);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(218, 26);
            this.txt_Name.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 409);
            this.panel2.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.flujoaereoDataSetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(695, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // flujoaereoDataSetBindingSource
            // 
            this.flujoaereoDataSetBindingSource.DataSource = this.flujoaereoDataSet;
            this.flujoaereoDataSetBindingSource.Position = 0;
            // 
            // flujoaereoDataSet
            // 
            this.flujoaereoDataSet.DataSetName = "flujoaereoDataSet";
            this.flujoaereoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmAirline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAirline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAirline";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flujoaereoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flujoaereoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_StatusId;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource flujoaereoDataSetBindingSource;
        private flujoaereoDataSet flujoaereoDataSet;
    }
}