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
            EstadoGuias = new ListView();
            NdeGuía = new ColumnHeader();
            TiempoSinAsignar = new ColumnHeader();
            Dirección = new ColumnHeader();
            Tipopaquete = new ColumnHeader();
            detalleHDR = new Label();
            tipodeservicio = new Label();
            Retiro = new CheckBox();
            Distribucion = new CheckBox();
            GenerarHDR = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            button7 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tutsasa
            // 
            tutsasa.AutoSize = true;
            tutsasa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tutsasa.Location = new Point(31, 15);
            tutsasa.Margin = new Padding(4, 0, 4, 0);
            tutsasa.Name = "tutsasa";
            tutsasa.Size = new Size(155, 32);
            tutsasa.TabIndex = 0;
            tutsasa.Text = "TUTASA S.A.";
            // 
            // HDRUltimaMillaTitulo
            // 
            HDRUltimaMillaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            HDRUltimaMillaTitulo.Location = new Point(433, 15);
            HDRUltimaMillaTitulo.Margin = new Padding(4, 0, 4, 0);
            HDRUltimaMillaTitulo.MaximumSize = new Size(714, 833);
            HDRUltimaMillaTitulo.Name = "HDRUltimaMillaTitulo";
            HDRUltimaMillaTitulo.Size = new Size(569, 58);
            HDRUltimaMillaTitulo.TabIndex = 1;
            HDRUltimaMillaTitulo.Text = "HDR Última Milla";
            // 
            // FleterosDisponibles
            // 
            FleterosDisponibles.FormattingEnabled = true;
            FleterosDisponibles.Location = new Point(31, 110);
            FleterosDisponibles.Margin = new Padding(4, 5, 4, 5);
            FleterosDisponibles.Name = "FleterosDisponibles";
            FleterosDisponibles.Size = new Size(447, 33);
            FleterosDisponibles.TabIndex = 2;
            // 
            // Fletero
            // 
            Fletero.AutoSize = true;
            Fletero.Location = new Point(31, 80);
            Fletero.Margin = new Padding(4, 0, 4, 0);
            Fletero.Name = "Fletero";
            Fletero.Size = new Size(74, 25);
            Fletero.TabIndex = 3;
            Fletero.Text = "Fleteros";
            // 
            // EstadoGuias
            // 
            EstadoGuias.Columns.AddRange(new ColumnHeader[] { NdeGuía, TiempoSinAsignar, Dirección, Tipopaquete });
            EstadoGuias.Location = new Point(51, 497);
            EstadoGuias.Margin = new Padding(4, 5, 4, 5);
            EstadoGuias.Name = "EstadoGuias";
            EstadoGuias.Size = new Size(603, 376);
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
            // TiempoSinAsignar
            // 
            TiempoSinAsignar.Text = "Tiempo Sin Asignación";
            TiempoSinAsignar.Width = 200;
            // 
            // Dirección
            // 
            Dirección.Text = "Dirección";
            Dirección.Width = 100;
            // 
            // Tipopaquete
            // 
            Tipopaquete.Text = "Tipo de Paquete";
            Tipopaquete.Width = 150;
            // 
            // detalleHDR
            // 
            detalleHDR.AutoSize = true;
            detalleHDR.Location = new Point(51, 467);
            detalleHDR.Margin = new Padding(4, 0, 4, 0);
            detalleHDR.Name = "detalleHDR";
            detalleHDR.Size = new Size(108, 25);
            detalleHDR.TabIndex = 7;
            detalleHDR.Text = "Detalle HDR";
            // 
            // tipodeservicio
            // 
            tipodeservicio.AutoSize = true;
            tipodeservicio.Enabled = false;
            tipodeservicio.ImageAlign = ContentAlignment.TopCenter;
            tipodeservicio.Location = new Point(16, 32);
            tipodeservicio.Margin = new Padding(4, 0, 4, 0);
            tipodeservicio.Name = "tipodeservicio";
            tipodeservicio.Size = new Size(138, 25);
            tipodeservicio.TabIndex = 11;
            tipodeservicio.Text = "Tipo de Servicio";
            // 
            // Retiro
            // 
            Retiro.AutoSize = true;
            Retiro.Location = new Point(16, 62);
            Retiro.Margin = new Padding(4, 5, 4, 5);
            Retiro.Name = "Retiro";
            Retiro.Size = new Size(84, 29);
            Retiro.TabIndex = 12;
            Retiro.Text = "Retiro";
            Retiro.UseVisualStyleBackColor = true;
            // 
            // Distribucion
            // 
            Distribucion.AutoSize = true;
            Distribucion.Location = new Point(106, 62);
            Distribucion.Margin = new Padding(4, 5, 4, 5);
            Distribucion.Name = "Distribucion";
            Distribucion.Size = new Size(133, 29);
            Distribucion.TabIndex = 13;
            Distribucion.Text = "Distribución";
            Distribucion.UseVisualStyleBackColor = true;
            // 
            // GenerarHDR
            // 
            GenerarHDR.Location = new Point(1327, 901);
            GenerarHDR.Margin = new Padding(4, 5, 4, 5);
            GenerarHDR.Name = "GenerarHDR";
            GenerarHDR.Size = new Size(180, 38);
            GenerarHDR.TabIndex = 14;
            GenerarHDR.Text = "Generar HDR";
            GenerarHDR.UseVisualStyleBackColor = true;
            GenerarHDR.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(943, 497);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(564, 376);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N °de Guía";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tiempo Sin Asignación";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dirección";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tipo de Paquete";
            columnHeader4.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(664, 595);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(270, 38);
            button1.TabIndex = 16;
            button1.Text = "Agregar >>>";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(664, 707);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(270, 38);
            button4.TabIndex = 17;
            button4.Text = "<<< Quitar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(664, 658);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(270, 38);
            button5.TabIndex = 18;
            button5.Text = "Agregar todos >>>";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(664, 755);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(270, 38);
            button6.TabIndex = 19;
            button6.Text = "<<< Quitar todos";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Distribucion);
            groupBox1.Controls.Add(tipodeservicio);
            groupBox1.Controls.Add(Retiro);
            groupBox1.Location = new Point(51, 277);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(821, 167);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar";
            // 
            // button7
            // 
            button7.Location = new Point(613, 110);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(180, 38);
            button7.TabIndex = 21;
            button7.Text = "Buscar";
            button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(613, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 17;
            label2.Text = "Cliente (CUIT)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(613, 69);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 31);
            textBox2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(277, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 15;
            label1.Text = "Fecha (desde/hasta)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(277, 67);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(277, 104);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 23;
            // 
            // HDRUltimaMilla
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 1050);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(GenerarHDR);
            Controls.Add(detalleHDR);
            Controls.Add(EstadoGuias);
            Controls.Add(Fletero);
            Controls.Add(FleterosDisponibles);
            Controls.Add(HDRUltimaMillaTitulo);
            Controls.Add(tutsasa);
            Margin = new Padding(4, 5, 4, 5);
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
        private ComboBox FleterosDisponibles;
        private Label Fletero;
        private ListView EstadoGuias;
        private ColumnHeader NdeGuía;
        private Label detalleHDR;
        private Label tipodeservicio;
        private CheckBox Retiro;
        private CheckBox Distribucion;
        private ColumnHeader TiempoSinAsignar;
        private ColumnHeader Dirección;
        private ColumnHeader Tipopaquete;
        private Button GenerarHDR;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private Button button7;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}