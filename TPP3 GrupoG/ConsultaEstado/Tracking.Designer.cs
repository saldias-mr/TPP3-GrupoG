namespace TPP3_GrupoG.ConsultaEstado
{
    partial class Tracking
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
            label1 = new Label();
            numGuiaTXT = new TextBox();
            BuscarGuiaBTN = new Button();
            moviEncomiendaLIST = new ListView();
            UltimaUbicacion = new ColumnHeader();
            Estado = new ColumnHeader();
            Cliente = new ColumnHeader();
            Destinatario = new ColumnHeader();
            FechaCreacion = new ColumnHeader();
            lbl_NameTutasa = new Label();
            label3 = new Label();
            label4 = new Label();
            VolverBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 92);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese N° de Guía";
            // 
            // numGuiaTXT
            // 
            numGuiaTXT.Location = new Point(261, 92);
            numGuiaTXT.Margin = new Padding(3, 4, 3, 4);
            numGuiaTXT.Name = "numGuiaTXT";
            numGuiaTXT.Size = new Size(418, 27);
            numGuiaTXT.TabIndex = 1;
            // 
            // BuscarGuiaBTN
            // 
            BuscarGuiaBTN.Location = new Point(694, 92);
            BuscarGuiaBTN.Margin = new Padding(3, 4, 3, 4);
            BuscarGuiaBTN.Name = "BuscarGuiaBTN";
            BuscarGuiaBTN.Size = new Size(90, 30);
            BuscarGuiaBTN.TabIndex = 2;
            BuscarGuiaBTN.Text = "Buscar";
            BuscarGuiaBTN.UseVisualStyleBackColor = true;
            BuscarGuiaBTN.Click += buscarGuiaBTN_Click;
            // 
            // moviEncomiendaLIST
            // 
            moviEncomiendaLIST.Columns.AddRange(new ColumnHeader[] { UltimaUbicacion, Estado, Cliente, Destinatario, FechaCreacion });
            moviEncomiendaLIST.Location = new Point(35, 206);
            moviEncomiendaLIST.Margin = new Padding(3, 4, 3, 4);
            moviEncomiendaLIST.Name = "moviEncomiendaLIST";
            moviEncomiendaLIST.Size = new Size(1012, 206);
            moviEncomiendaLIST.TabIndex = 4;
            moviEncomiendaLIST.UseCompatibleStateImageBehavior = false;
            moviEncomiendaLIST.View = View.Details;
            // 
            // UltimaUbicacion
            // 
            UltimaUbicacion.Text = "Última Ubicación";
            UltimaUbicacion.Width = 200;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 90;
            // 
            // Destinatario
            // 
            Destinatario.Text = "Destinatario";
            Destinatario.Width = 200;
            // 
            // FechaCreacion
            // 
            FechaCreacion.Text = "Fecha Creación";
            FechaCreacion.Width = 200;
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(24, 10);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(171, 46);
            lbl_NameTutasa.TabIndex = 11;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(192, 10);
            label3.Name = "label3";
            label3.Size = new Size(608, 46);
            label3.TabIndex = 12;
            label3.Text = "Consultar estado e historial de una guía (tracking)";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(35, 162);
            label4.Name = "label4";
            label4.Size = new Size(429, 40);
            label4.TabIndex = 14;
            label4.Text = "Informacion de Movimientos de la Encomienda";
            // 
            // VolverBTN
            // 
            VolverBTN.BackColor = Color.DarkRed;
            VolverBTN.ForeColor = SystemColors.ButtonHighlight;
            VolverBTN.Location = new Point(925, 536);
            VolverBTN.Margin = new Padding(3, 4, 3, 4);
            VolverBTN.Name = "VolverBTN";
            VolverBTN.Size = new Size(123, 50);
            VolverBTN.TabIndex = 62;
            VolverBTN.Text = "Cancelar/Volver";
            VolverBTN.UseVisualStyleBackColor = false;
            VolverBTN.Click += VolverBTN_Click;
            // 
            // Tracking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 600);
            Controls.Add(VolverBTN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Controls.Add(moviEncomiendaLIST);
            Controls.Add(BuscarGuiaBTN);
            Controls.Add(numGuiaTXT);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Tracking";
            Text = "Tracking";
            Load += Tracking_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox numGuiaTXT;
        private Button BuscarGuiaBTN;
        private ListView moviEncomiendaLIST;
        private ColumnHeader UltimaUbicacion;
        private ColumnHeader Estado;
        public Label lbl_NameTutasa;
        private Label label3;
        public Label label4;
        private Button VolverBTN;
        private ColumnHeader Cliente;
        private ColumnHeader Destinatario;
        private ColumnHeader FechaCreacion;
    }
}