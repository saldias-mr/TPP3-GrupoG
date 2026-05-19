namespace TPP3_GrupoG.HojadeRutaUM
{
    partial class HDRUltimaMilla
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
            tutsasa = new Label();
            HDRUltimaMillaTitulo = new Label();
            FleteroCMB = new ComboBox();
            Fletero = new Label();
            HdrLIST1 = new ListView();
            NdeGuía = new ColumnHeader();
            TiempoSinAsignar = new ColumnHeader();
            Direccion = new ColumnHeader();
            Tipopaquete = new ColumnHeader();
            detalleHDR = new Label();
            tipodeservicio = new Label();
            retiroCheck = new CheckBox();
            distribucionCheck = new CheckBox();
            generarHdrBTN = new Button();
            HdrLIST2 = new ListView();
            NdGuia1 = new ColumnHeader();
            TiempoSinAsignar1 = new ColumnHeader();
            Direccion1 = new ColumnHeader();
            Tipopaquete1 = new ColumnHeader();
            agregarHdrBTN = new Button();
            quitarHdrBTN = new Button();
            agregarAllBTN = new Button();
            quitarAllBTN = new Button();
            groupBox1 = new GroupBox();
            fechaHasta = new DateTimePicker();
            fechaDesde = new DateTimePicker();
            buscarCuitBTN = new Button();
            label2 = new Label();
            CuitTXT = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tutsasa
            // 
            tutsasa.AutoSize = true;
            tutsasa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tutsasa.Location = new Point(41, 9);
            tutsasa.Name = "tutsasa";
            tutsasa.Size = new Size(129, 28);
            tutsasa.TabIndex = 0;
            tutsasa.Text = "TUTASA S.A.";
            // 
            // HDRUltimaMillaTitulo
            // 
            HDRUltimaMillaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            HDRUltimaMillaTitulo.Location = new Point(531, 12);
            HDRUltimaMillaTitulo.MaximumSize = new Size(571, 667);
            HDRUltimaMillaTitulo.Name = "HDRUltimaMillaTitulo";
            HDRUltimaMillaTitulo.Size = new Size(455, 47);
            HDRUltimaMillaTitulo.TabIndex = 1;
            HDRUltimaMillaTitulo.Text = "HDR Última Milla";
            // 
            // FleteroCMB
            // 
            FleteroCMB.FormattingEnabled = true;
            FleteroCMB.Location = new Point(41, 88);
            FleteroCMB.Margin = new Padding(3, 4, 3, 4);
            FleteroCMB.Name = "FleteroCMB";
            FleteroCMB.Size = new Size(358, 28);
            FleteroCMB.TabIndex = 2;
            // 
            // Fletero
            // 
            Fletero.AutoSize = true;
            Fletero.Location = new Point(41, 64);
            Fletero.Name = "Fletero";
            Fletero.Size = new Size(61, 20);
            Fletero.TabIndex = 3;
            Fletero.Text = "Fleteros";
            // 
            // HdrLIST1
            // 
            HdrLIST1.Columns.AddRange(new ColumnHeader[] { NdeGuía, TiempoSinAsignar, Direccion, Tipopaquete });
            HdrLIST1.Location = new Point(41, 397);
            HdrLIST1.Margin = new Padding(3, 4, 3, 4);
            HdrLIST1.Name = "HdrLIST1";
            HdrLIST1.Size = new Size(483, 301);
            HdrLIST1.TabIndex = 6;
            HdrLIST1.UseCompatibleStateImageBehavior = false;
            HdrLIST1.View = View.Details;
            // 
            // NdeGuía
            // 
            NdeGuía.Text = "N °de Guía";
            NdeGuía.Width = 100;
            // 
            // TiempoSinAsignar
            // 
            TiempoSinAsignar.Text = "Tiempo Sin Asignación";
            TiempoSinAsignar.Width = 165;
            // 
            // Direccion
            // 
            Direccion.Text = "Dirección";
            Direccion.Width = 100;
            // 
            // Tipopaquete
            // 
            Tipopaquete.Text = "Tipo de Paquete";
            Tipopaquete.Width = 150;
            // 
            // detalleHDR
            // 
            detalleHDR.AutoSize = true;
            detalleHDR.Location = new Point(41, 373);
            detalleHDR.Name = "detalleHDR";
            detalleHDR.Size = new Size(92, 20);
            detalleHDR.TabIndex = 7;
            detalleHDR.Text = "Detalle HDR";
            // 
            // tipodeservicio
            // 
            tipodeservicio.AutoSize = true;
            tipodeservicio.Enabled = false;
            tipodeservicio.ImageAlign = ContentAlignment.TopCenter;
            tipodeservicio.Location = new Point(13, 25);
            tipodeservicio.Name = "tipodeservicio";
            tipodeservicio.Size = new Size(116, 20);
            tipodeservicio.TabIndex = 11;
            tipodeservicio.Text = "Tipo de Servicio";
            // 
            // retiroCheck
            // 
            retiroCheck.AutoSize = true;
            retiroCheck.Location = new Point(13, 49);
            retiroCheck.Margin = new Padding(3, 4, 3, 4);
            retiroCheck.Name = "retiroCheck";
            retiroCheck.Size = new Size(71, 24);
            retiroCheck.TabIndex = 12;
            retiroCheck.Text = "Retiro";
            retiroCheck.UseVisualStyleBackColor = true;
            // 
            // distribucionCheck
            // 
            distribucionCheck.AutoSize = true;
            distribucionCheck.Location = new Point(85, 49);
            distribucionCheck.Margin = new Padding(3, 4, 3, 4);
            distribucionCheck.Name = "distribucionCheck";
            distribucionCheck.Size = new Size(111, 24);
            distribucionCheck.TabIndex = 13;
            distribucionCheck.Text = "Distribución";
            distribucionCheck.UseVisualStyleBackColor = true;
            // 
            // generarHdrBTN
            // 
            generarHdrBTN.Location = new Point(1092, 723);
            generarHdrBTN.Margin = new Padding(3, 4, 3, 4);
            generarHdrBTN.Name = "generarHdrBTN";
            generarHdrBTN.Size = new Size(144, 31);
            generarHdrBTN.TabIndex = 14;
            generarHdrBTN.Text = "Generar HDR";
            generarHdrBTN.UseVisualStyleBackColor = true;
            generarHdrBTN.Click += generarHdrBTN_Click;
            // 
            // HdrLIST2
            // 
            HdrLIST2.Columns.AddRange(new ColumnHeader[] { NdGuia1, TiempoSinAsignar1, Direccion1, Tipopaquete1 });
            HdrLIST2.Location = new Point(754, 397);
            HdrLIST2.Margin = new Padding(3, 4, 3, 4);
            HdrLIST2.Name = "HdrLIST2";
            HdrLIST2.Size = new Size(483, 301);
            HdrLIST2.TabIndex = 15;
            HdrLIST2.UseCompatibleStateImageBehavior = false;
            HdrLIST2.View = View.Details;
            // 
            // NdGuia1
            // 
            NdGuia1.Text = "N °de Guía";
            NdGuia1.Width = 100;
            // 
            // TiempoSinAsignar1
            // 
            TiempoSinAsignar1.Text = "Tiempo Sin Asignación";
            TiempoSinAsignar1.Width = 165;
            // 
            // Direccion1
            // 
            Direccion1.Text = "Dirección";
            Direccion1.Width = 100;
            // 
            // Tipopaquete1
            // 
            Tipopaquete1.Text = "Tipo de Paquete";
            Tipopaquete1.Width = 150;
            // 
            // agregarHdrBTN
            // 
            agregarHdrBTN.Location = new Point(531, 476);
            agregarHdrBTN.Margin = new Padding(3, 4, 3, 4);
            agregarHdrBTN.Name = "agregarHdrBTN";
            agregarHdrBTN.Size = new Size(216, 31);
            agregarHdrBTN.TabIndex = 16;
            agregarHdrBTN.Text = "Agregar >>>";
            agregarHdrBTN.UseVisualStyleBackColor = true;
            agregarHdrBTN.Click += agregarHdrBTN_Click;
            // 
            // quitarHdrBTN
            // 
            quitarHdrBTN.Location = new Point(531, 565);
            quitarHdrBTN.Margin = new Padding(3, 4, 3, 4);
            quitarHdrBTN.Name = "quitarHdrBTN";
            quitarHdrBTN.Size = new Size(216, 31);
            quitarHdrBTN.TabIndex = 17;
            quitarHdrBTN.Text = "<<< Quitar";
            quitarHdrBTN.UseVisualStyleBackColor = true;
            quitarHdrBTN.Click += quitarHdrBTN_Click;
            // 
            // agregarAllBTN
            // 
            agregarAllBTN.Location = new Point(532, 515);
            agregarAllBTN.Margin = new Padding(3, 4, 3, 4);
            agregarAllBTN.Name = "agregarAllBTN";
            agregarAllBTN.Size = new Size(216, 31);
            agregarAllBTN.TabIndex = 18;
            agregarAllBTN.Text = "Agregar todos >>>";
            agregarAllBTN.UseVisualStyleBackColor = true;
            agregarAllBTN.Click += agregarAllBTN_Click;
            // 
            // quitarAllBTN
            // 
            quitarAllBTN.Location = new Point(531, 604);
            quitarAllBTN.Margin = new Padding(3, 4, 3, 4);
            quitarAllBTN.Name = "quitarAllBTN";
            quitarAllBTN.Size = new Size(216, 31);
            quitarAllBTN.TabIndex = 19;
            quitarAllBTN.Text = "<<< Quitar todos";
            quitarAllBTN.UseVisualStyleBackColor = true;
            quitarAllBTN.Click += quitarAllBTN_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fechaHasta);
            groupBox1.Controls.Add(fechaDesde);
            groupBox1.Controls.Add(buscarCuitBTN);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(CuitTXT);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(distribucionCheck);
            groupBox1.Controls.Add(tipodeservicio);
            groupBox1.Controls.Add(retiroCheck);
            groupBox1.Location = new Point(41, 221);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(683, 133);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar";
            // 
            // fechaHasta
            // 
            fechaHasta.Location = new Point(222, 83);
            fechaHasta.Margin = new Padding(2, 3, 2, 3);
            fechaHasta.Name = "fechaHasta";
            fechaHasta.Size = new Size(268, 27);
            fechaHasta.TabIndex = 23;
            // 
            // fechaDesde
            // 
            fechaDesde.Location = new Point(222, 53);
            fechaDesde.Margin = new Padding(2, 3, 2, 3);
            fechaDesde.Name = "fechaDesde";
            fechaDesde.Size = new Size(268, 27);
            fechaDesde.TabIndex = 22;
            // 
            // buscarCuitBTN
            // 
            buscarCuitBTN.Location = new Point(522, 94);
            buscarCuitBTN.Margin = new Padding(3, 4, 3, 4);
            buscarCuitBTN.Name = "buscarCuitBTN";
            buscarCuitBTN.Size = new Size(144, 31);
            buscarCuitBTN.TabIndex = 21;
            buscarCuitBTN.Text = "Buscar";
            buscarCuitBTN.UseVisualStyleBackColor = true;
            buscarCuitBTN.Click += buscarCuitBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(522, 25);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 17;
            label2.Text = "Cliente (CUIT)";
            // 
            // CuitTXT
            // 
            CuitTXT.Location = new Point(522, 59);
            CuitTXT.Margin = new Padding(3, 4, 3, 4);
            CuitTXT.Name = "CuitTXT";
            CuitTXT.Size = new Size(114, 27);
            CuitTXT.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(222, 24);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 15;
            label1.Text = "Fecha (desde/hasta)";
            // 
            // HDRUltimaMilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 840);
            Controls.Add(groupBox1);
            Controls.Add(quitarAllBTN);
            Controls.Add(agregarAllBTN);
            Controls.Add(quitarHdrBTN);
            Controls.Add(agregarHdrBTN);
            Controls.Add(HdrLIST2);
            Controls.Add(generarHdrBTN);
            Controls.Add(detalleHDR);
            Controls.Add(HdrLIST1);
            Controls.Add(Fletero);
            Controls.Add(FleteroCMB);
            Controls.Add(HDRUltimaMillaTitulo);
            Controls.Add(tutsasa);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HDRUltimaMilla";
            Text = "HDR Ultima Milla";
            Load += HDRUltimaMilla_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tutsasa;
        private Label HDRUltimaMillaTitulo;
        private ComboBox FleteroCMB;
        private Label Fletero;
        private ListView HdrLIST1;
        private ColumnHeader NdeGuía;
        private Label detalleHDR;
        private Label tipodeservicio;
        private CheckBox retiroCheck;
        private CheckBox distribucionCheck;
        private ColumnHeader TiempoSinAsignar;
        private ColumnHeader Direccion;
        private ColumnHeader Tipopaquete;
        private Button generarHdrBTN;
        private ListView HdrLIST2;
        private ColumnHeader NdGuia1;
        private ColumnHeader TiempoSinAsignar1;
        private ColumnHeader Direccion1;
        private ColumnHeader Tipopaquete1;
        private Button agregarHdrBTN;
        private Button quitarHdrBTN;
        private Button agregarAllBTN;
        private Button quitarAllBTN;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox CuitTXT;
        private Label label1;
        private DateTimePicker fechaHasta;
        private DateTimePicker fechaDesde;
        private Button buscarCuitBTN;
    }
}