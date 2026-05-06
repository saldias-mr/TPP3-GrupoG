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
            Zona = new Label();
            ZonasDisponibles = new ComboBox();
            EstadoGuias = new ListView();
            NdeGuía = new ColumnHeader();
            Estado = new ColumnHeader();
            Observaciones = new ColumnHeader();
            detalleHDR = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            FleterosDisponibles.Location = new Point(22, 105);
            FleterosDisponibles.Name = "FleterosDisponibles";
            FleterosDisponibles.Size = new Size(314, 23);
            FleterosDisponibles.TabIndex = 2;
            // 
            // Fletero
            // 
            Fletero.AutoSize = true;
            Fletero.Location = new Point(22, 87);
            Fletero.Name = "Fletero";
            Fletero.Size = new Size(48, 15);
            Fletero.TabIndex = 3;
            Fletero.Text = "Fleteros";
            // 
            // Zona
            // 
            Zona.AutoSize = true;
            Zona.Location = new Point(374, 87);
            Zona.Name = "Zona";
            Zona.Size = new Size(34, 15);
            Zona.TabIndex = 4;
            Zona.Text = "Zona";
            // 
            // ZonasDisponibles
            // 
            ZonasDisponibles.FormattingEnabled = true;
            ZonasDisponibles.Location = new Point(374, 105);
            ZonasDisponibles.Name = "ZonasDisponibles";
            ZonasDisponibles.Size = new Size(290, 23);
            ZonasDisponibles.TabIndex = 5;
            // 
            // EstadoGuias
            // 
            EstadoGuias.Columns.AddRange(new ColumnHeader[] { NdeGuía, Estado, Observaciones });
            EstadoGuias.Location = new Point(22, 221);
            EstadoGuias.Name = "EstadoGuias";
            EstadoGuias.Size = new Size(642, 227);
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
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.TextAlign = HorizontalAlignment.Center;
            Estado.Width = 120;
            // 
            // Observaciones
            // 
            Observaciones.Text = "Observaciones";
            Observaciones.TextAlign = HorizontalAlignment.Center;
            Observaciones.Width = 300;
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
            // button1
            // 
            button1.Location = new Point(22, 454);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 8;
            button1.Text = "Ingresar nueva Guía";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(442, 454);
            button2.Name = "button2";
            button2.Size = new Size(140, 23);
            button2.TabIndex = 9;
            button2.Text = "Generar Resumen HDR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(589, 454);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Imprimir";
            button3.UseVisualStyleBackColor = true;
            // 
            // HDRUltimaMilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 507);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(detalleHDR);
            Controls.Add(EstadoGuias);
            Controls.Add(ZonasDisponibles);
            Controls.Add(Zona);
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
        private Label Zona;
        private ComboBox ZonasDisponibles;
        private ListView EstadoGuias;
        private ColumnHeader NdeGuía;
        private ColumnHeader Estado;
        private ColumnHeader Observaciones;
        private Label detalleHDR;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}