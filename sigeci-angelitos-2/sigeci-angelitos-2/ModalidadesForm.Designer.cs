namespace sigeci_angelitos_2
{
    partial class ModalidadesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalidadesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvModalidades = new System.Windows.Forms.DataGridView();
            this.idModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.btnBorrar = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.txtModalidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidades";
            // 
            // txtModalidad
            // 
            this.txtModalidad.Location = new System.Drawing.Point(124, 34);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.Size = new System.Drawing.Size(150, 20);
            this.txtModalidad.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(25, 31);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(84, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Modalidad :";
            // 
            // dgvModalidades
            // 
            this.dgvModalidades.AllowUserToAddRows = false;
            this.dgvModalidades.AllowUserToDeleteRows = false;
            this.dgvModalidades.AllowUserToOrderColumns = true;
            this.dgvModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModalidad,
            this.nombreModalidad});
            this.dgvModalidades.Location = new System.Drawing.Point(12, 104);
            this.dgvModalidades.Name = "dgvModalidades";
            this.dgvModalidades.ReadOnly = true;
            this.dgvModalidades.Size = new System.Drawing.Size(408, 165);
            this.dgvModalidades.TabIndex = 1;
            // 
            // idModalidad
            // 
            this.idModalidad.HeaderText = "ID";
            this.idModalidad.Name = "idModalidad";
            this.idModalidad.ReadOnly = true;
            // 
            // nombreModalidad
            // 
            this.nombreModalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreModalidad.HeaderText = "Modalidad";
            this.nombreModalidad.Name = "nombreModalidad";
            this.nombreModalidad.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Image = global::sigeci_angelitos_2.Properties.Resources.agregar;
            this.btnAgregar.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnAgregar.Location = new System.Drawing.Point(300, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(32, 32);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 9;
            // 
            // btnBorrar
            // 
            this.btnBorrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBorrar.Image = global::sigeci_angelitos_2.Properties.Resources.borrar;
            this.btnBorrar.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnBorrar.Location = new System.Drawing.Point(351, 27);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(32, 32);
            this.btnBorrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBorrar.TabIndex = 10;
            // 
            // ModalidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 285);
            this.Controls.Add(this.dgvModalidades);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModalidadesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modalidades";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModalidad;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridView dgvModalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreModalidad;
        private DevComponents.DotNetBar.ButtonX btnBorrar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
    }
}