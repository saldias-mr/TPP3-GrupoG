namespace TPP3_GrupoG.HDRUltimaMilla
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
            FleterosDisponibles = new ComboBox();
            Fletero = new Label();
            CentroDistribucion = new Label();
            ZonasDisponibles = new ComboBox();
            EstadoGuias = new ListView();
            NdeGuía = new ColumnHeader();
            Observaciones = new ColumnHeader();
            detalleHDR = new Label();
            button2 = new Button();
            button3 = new Button();
            tipodeservicio = new Label();
            Retiro = new CheckBox();
            Distribucion = new CheckBox();
            TiempoSinAsignar = new ColumnHeader();
            Dirección = new ColumnHeader();
            Tipopaquete = new ColumnHeader();
            GenerarHDR = new Button();
            SuspendLayout();
            // 
            // tutsasa
            // 
            tutsasa.AutoSize = true;
            tutsasa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tutsasa.Location = new Point(22, 9);
            tutsasa.Name = "tutsasa";
            tutsasa.Size = new Size(102, 21);
            tutsasa.TabIndex = 0;
            tutsasa.Text = "TUTASA S.A.";
            // 
            // HDRUltimaMillaTitulo
            // 
            HDRUltimaMillaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            HDRUltimaMillaTitulo.Location = new Point(303, 9);
            HDRUltimaMillaTitulo.MaximumSize = new Size(500, 500);
            HDRUltimaMillaTitulo.Name = "HDRUltimaMillaTitulo";
            HDRUltimaMillaTitulo.Size = new Size(398, 35);
            HDRUltimaMillaTitulo.TabIndex = 1;
            HDRUltimaMillaTitulo.Text = "HDR Última Milla";
            // 
            // FleterosDisponibles
            // 
            FleterosDisponibles.FormattingEnabled = true;
            FleterosDisponibles.Location = new Point(22, 123);
            FleterosDisponibles.Name = "FleterosDisponibles";
            FleterosDisponibles.Size = new Size(314, 23);
            FleterosDisponibles.TabIndex = 2;
            // 
            // Fletero
            // 
            Fletero.AutoSize = true;
            Fletero.Location = new Point(22, 105);
            Fletero.Name = "Fletero";
            Fletero.Size = new Size(48, 15);
            Fletero.TabIndex = 3;
            Fletero.Text = "Fleteros";
            // 
            // CentroDistribucion
            // 
            CentroDistribucion.AutoSize = true;
            CentroDistribucion.Location = new Point(22, 61);
            CentroDistribucion.Name = "CentroDistribucion";
            CentroDistribucion.Size = new Size(126, 15);
            CentroDistribucion.TabIndex = 4;
            CentroDistribucion.Text = "Centro de Distribución";
            // 
            // ZonasDisponibles
            // 
            ZonasDisponibles.FormattingEnabled = true;
            ZonasDisponibles.Location = new Point(22, 79);
            ZonasDisponibles.Name = "ZonasDisponibles";
            ZonasDisponibles.Size = new Size(314, 23);
            ZonasDisponibles.TabIndex = 5;
            // 
            // EstadoGuias
            // 
            EstadoGuias.Columns.AddRange(new ColumnHeader[] { NdeGuía, TiempoSinAsignar, Observaciones, Dirección, Tipopaquete });
            EstadoGuias.Location = new Point(22, 221);
            EstadoGuias.Name = "EstadoGuias";
            EstadoGuias.Size = new Size(784, 227);
            EstadoGuias.TabIndex = 6;
            EstadoGuias.UseCompatibleStateImageBehavior = false;
            EstadoGuias.View = View.Details;
            EstadoGuias.SelectedIndexChanged += EstadoGuias_SelectedIndexChanged;
            // 
            // NdeGuía
            // 
            NdeGuía.Text = "N °de Guía";
            NdeGuía.Width = 120;
            // 
            // Observaciones
            // 
            Observaciones.DisplayIndex = 1;
            Observaciones.Text = "Observaciones";
            Observaciones.TextAlign = HorizontalAlignment.Center;
            Observaciones.Width = 200;
            // 
            // detalleHDR
            // 
            detalleHDR.AutoSize = true;
            detalleHDR.Location = new Point(22, 203);
            detalleHDR.Name = "detalleHDR";
            detalleHDR.Size = new Size(70, 15);
            detalleHDR.TabIndex = 7;
            detalleHDR.Text = "Detalle HDR";
            // 
            // button2
            // 
            button2.Location = new Point(556, 454);
            button2.Name = "button2";
            button2.Size = new Size(140, 23);
            button2.TabIndex = 9;
            button2.Text = "Generar Resumen HDR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(702, 454);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
            button3.TabIndex = 10;
            button3.Text = "Imprimir HDR";
            button3.UseVisualStyleBackColor = true;
            // 
            // tipodeservicio
            // 
            tipodeservicio.AutoSize = true;
            tipodeservicio.Enabled = false;
            tipodeservicio.ImageAlign = ContentAlignment.TopCenter;
            tipodeservicio.Location = new Point(22, 149);
            tipodeservicio.Name = "tipodeservicio";
            tipodeservicio.Size = new Size(91, 15);
            tipodeservicio.TabIndex = 11;
            tipodeservicio.Text = "Tipo de Servicio";
            // 
            // Retiro
            // 
            Retiro.AutoSize = true;
            Retiro.Location = new Point(22, 167);
            Retiro.Name = "Retiro";
            Retiro.Size = new Size(57, 19);
            Retiro.TabIndex = 12;
            Retiro.Text = "Retiro";
            Retiro.UseVisualStyleBackColor = true;
            // 
            // Distribucion
            // 
            Distribucion.AutoSize = true;
            Distribucion.Location = new Point(85, 167);
            Distribucion.Name = "Distribucion";
            Distribucion.Size = new Size(90, 19);
            Distribucion.TabIndex = 13;
            Distribucion.Text = "Distribución";
            Distribucion.UseVisualStyleBackColor = true;
            // 
            // TiempoSinAsignar
            // 
            TiempoSinAsignar.DisplayIndex = 2;
            TiempoSinAsignar.Text = "Tiempo Sin Asignación";
            TiempoSinAsignar.Width = 150;
            // 
            // Dirección
            // 
            Dirección.Text = "Dirección";
            Dirección.Width = 100;
            // 
            // Tipopaquete
            // 
            Tipopaquete.Text = "Tipo de Paquete";
            Tipopaquete.Width = 100;
            // 
            // GenerarHDR
            // 
            GenerarHDR.Location = new Point(22, 454);
            GenerarHDR.Name = "GenerarHDR";
            GenerarHDR.Size = new Size(126, 23);
            GenerarHDR.TabIndex = 14;
            GenerarHDR.Text = "Generar HDR";
            GenerarHDR.UseVisualStyleBackColor = true;
            GenerarHDR.Click += button1_Click;
            // 
            // HDRUltimaMilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 507);
            Controls.Add(GenerarHDR);
            Controls.Add(Distribucion);
            Controls.Add(Retiro);
            Controls.Add(tipodeservicio);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(detalleHDR);
            Controls.Add(EstadoGuias);
            Controls.Add(ZonasDisponibles);
            Controls.Add(CentroDistribucion);
            Controls.Add(Fletero);
            Controls.Add(FleterosDisponibles);
            Controls.Add(HDRUltimaMillaTitulo);
            Controls.Add(tutsasa);
            Name = "HDRUltimaMilla";
            Text = "HDR Ultima Milla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tutsasa;
        private Label HDRUltimaMillaTitulo;
        private ComboBox FleterosDisponibles;
        private Label Fletero;
        private Label CentroDistribucion;
        private ComboBox ZonasDisponibles;
        private ListView EstadoGuias;
        private ColumnHeader NdeGuía;
        private ColumnHeader Observaciones;
        private Label detalleHDR;
        private Button button2;
        private Button button3;
        private Label tipodeservicio;
        private CheckBox Retiro;
        private CheckBox Distribucion;
        private ColumnHeader TiempoSinAsignar;
        private ColumnHeader Dirección;
        private ColumnHeader Tipopaquete;
        private Button GenerarHDR;
    }
}