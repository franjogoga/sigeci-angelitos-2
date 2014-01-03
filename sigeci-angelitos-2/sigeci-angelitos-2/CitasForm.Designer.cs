﻿namespace sigeci_angelitos_2
{
    partial class CitasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitasForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateFechaCita = new System.Windows.Forms.DateTimePicker();
            this.txtNombres = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNumeroCita = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboServicios = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnConfirmar = new DevComponents.DotNetBar.ButtonX();
            this.btnReservar = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtApellidoPaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.idCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dateFechaCita);
            this.groupBox1.Controls.Add(this.txtApellidoPaterno);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtNumeroCita);
            this.groupBox1.Controls.Add(this.comboServicios);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuario";
            // 
            // dateFechaCita
            // 
            this.dateFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaCita.Location = new System.Drawing.Point(141, 117);
            this.dateFechaCita.Name = "dateFechaCita";
            this.dateFechaCita.Size = new System.Drawing.Size(162, 20);
            this.dateFechaCita.TabIndex = 4;
            // 
            // txtNombres
            // 
            // 
            // 
            // 
            this.txtNombres.Border.Class = "TextBoxBorder";
            this.txtNombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombres.Location = new System.Drawing.Point(428, 32);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(174, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // txtNumeroCita
            // 
            // 
            // 
            // 
            this.txtNumeroCita.Border.Class = "TextBoxBorder";
            this.txtNumeroCita.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNumeroCita.Location = new System.Drawing.Point(141, 32);
            this.txtNumeroCita.Name = "txtNumeroCita";
            this.txtNumeroCita.Size = new System.Drawing.Size(162, 20);
            this.txtNumeroCita.TabIndex = 0;
            // 
            // comboServicios
            // 
            this.comboServicios.DisplayMember = "Text";
            this.comboServicios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServicios.FormattingEnabled = true;
            this.comboServicios.ItemHeight = 14;
            this.comboServicios.Location = new System.Drawing.Point(428, 75);
            this.comboServicios.Name = "comboServicios";
            this.comboServicios.Size = new System.Drawing.Size(174, 20);
            this.comboServicios.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboServicios.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = global::sigeci_angelitos_2.Properties.Resources.buscar;
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(23, 23);
            this.btnBuscar.Location = new System.Drawing.Point(342, 110);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 32);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(342, 72);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(107, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Servicio :";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(43, 114);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(107, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Fecha Cita :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(342, 29);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(107, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Nombres :";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(43, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(107, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "N° Cita :";
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCita,
            this.fechaCita,
            this.horaCita,
            this.servicio,
            this.paciente,
            this.estado});
            this.dgvCitas.Location = new System.Drawing.Point(12, 182);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.Size = new System.Drawing.Size(647, 160);
            this.dgvCitas.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Image = global::sigeci_angelitos_2.Properties.Resources.cancelarcita;
            this.btnCancelar.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnCancelar.Location = new System.Drawing.Point(440, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 32);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConfirmar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConfirmar.Image = global::sigeci_angelitos_2.Properties.Resources.aceptar;
            this.btnConfirmar.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnConfirmar.Location = new System.Drawing.Point(248, 360);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(123, 32);
            this.btnConfirmar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            // 
            // btnReservar
            // 
            this.btnReservar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReservar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReservar.Image = global::sigeci_angelitos_2.Properties.Resources.reloj;
            this.btnReservar.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnReservar.Location = new System.Drawing.Point(57, 360);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(123, 32);
            this.btnReservar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReservar.TabIndex = 11;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(43, 75);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(107, 23);
            this.labelX5.TabIndex = 6;
            this.labelX5.Text = "Apellido Paterno :";
            // 
            // txtApellidoPaterno
            // 
            // 
            // 
            // 
            this.txtApellidoPaterno.Border.Class = "TextBoxBorder";
            this.txtApellidoPaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(141, 75);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(162, 20);
            this.txtApellidoPaterno.TabIndex = 2;
            // 
            // idCita
            // 
            this.idCita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idCita.HeaderText = "N° Cita";
            this.idCita.Name = "idCita";
            this.idCita.ReadOnly = true;
            this.idCita.Width = 65;
            // 
            // fechaCita
            // 
            this.fechaCita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaCita.HeaderText = "Fecha";
            this.fechaCita.Name = "fechaCita";
            this.fechaCita.ReadOnly = true;
            // 
            // horaCita
            // 
            this.horaCita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horaCita.HeaderText = "Hora";
            this.horaCita.Name = "horaCita";
            this.horaCita.ReadOnly = true;
            // 
            // servicio
            // 
            this.servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servicio.HeaderText = "Servicio";
            this.servicio.Name = "servicio";
            this.servicio.ReadOnly = true;
            this.servicio.ToolTipText = "Ser";
            // 
            // paciente
            // 
            this.paciente.HeaderText = "Paciente";
            this.paciente.Name = "paciente";
            this.paciente.ReadOnly = true;
            this.paciente.Width = 170;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // CitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 406);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CitasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CitasForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombres;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNumeroCita;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboServicios;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DateTimePicker dateFechaCita;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ButtonX btnConfirmar;
        private DevComponents.DotNetBar.ButtonX btnReservar;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtApellidoPaterno;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}