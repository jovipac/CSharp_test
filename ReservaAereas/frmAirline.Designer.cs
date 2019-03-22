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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNew = new System.Windows.Forms.Button();
            this.cmb_StatusId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Controls.Add(this.cmb_StatusId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 173);
            this.panel1.TabIndex = 32;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(172, 114);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(112, 35);
            this.buttonNew.TabIndex = 42;
            this.buttonNew.Text = "Nuevo";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // cmb_StatusId
            // 
            this.cmb_StatusId.FormattingEnabled = true;
            this.cmb_StatusId.Location = new System.Drawing.Point(142, 74);
            this.cmb_StatusId.Name = "cmb_StatusId";
            this.cmb_StatusId.Size = new System.Drawing.Size(121, 28);
            this.cmb_StatusId.TabIndex = 41;
            this.cmb_StatusId.DropDown += new System.EventHandler(this.FillDropDownList);
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
            this.buttonUpdate.Location = new System.Drawing.Point(428, 114);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 35);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(292, 114);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(112, 35);
            this.buttonInsert.TabIndex = 37;
            this.buttonInsert.Text = "Agregar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
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
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 409);
            this.panel2.TabIndex = 33;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(695, 409);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(570, 114);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 35);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            this.Text = "Aerolineas";
            this.Load += new System.EventHandler(this.frmAirline_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cmb_StatusId;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
    }
}