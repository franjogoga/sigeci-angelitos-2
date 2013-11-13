namespace sigeci_angelitos_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitasForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnBuscarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxX2);
            this.groupBox1.Controls.Add(this.textBoxX1);
            this.groupBox1.Controls.Add(this.comboBoxEx1);
            this.groupBox1.Controls.Add(this.dateTimeInput1);
            this.groupBox1.Controls.Add(this.btnBuscarUsuario);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuario";
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(417, 31);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(147, 20);
            this.textBoxX2.TabIndex = 11;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(129, 31);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(147, 20);
            this.textBoxX1.TabIndex = 11;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(417, 74);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(147, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 10;
            // 
            // dateTimeInput1
            // 
            // 
            // 
            // 
            this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput1.ButtonDropDown.Visible = true;
            this.dateTimeInput1.Location = new System.Drawing.Point(129, 69);
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.Class = "";
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2013, 11, 1, 0, 0, 0, 0);
            this.dateTimeInput1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateTimeInput1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(147, 20);
            this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput1.TabIndex = 9;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarUsuario.Image = global::sigeci_angelitos_2.Properties.Resources.buscar;
            this.btnBuscarUsuario.ImageFixedSize = new System.Drawing.Size(23, 23);
            this.btnBuscarUsuario.Location = new System.Drawing.Point(129, 108);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(100, 32);
            this.btnBuscarUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarUsuario.TabIndex = 4;
            this.btnBuscarUsuario.Text = "Buscar";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(304, 71);
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
            this.labelX3.Location = new System.Drawing.Point(16, 69);
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
            this.labelX2.Location = new System.Drawing.Point(304, 28);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(107, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Paciente :";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(107, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "N° Cita :";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCita,
            this.fechaCita,
            this.horaCita,
            this.servicio});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 182);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(593, 160);
            this.dgvUsuarios.TabIndex = 2;
            // 
            // idCita
            // 
            this.idCita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCita.HeaderText = "N° Cita";
            this.idCita.Name = "idCita";
            this.idCita.ReadOnly = true;
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
            // CitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 406);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CitasForm";
            this.Text = "CitasForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CitasForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscarUsuario;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
    }
}