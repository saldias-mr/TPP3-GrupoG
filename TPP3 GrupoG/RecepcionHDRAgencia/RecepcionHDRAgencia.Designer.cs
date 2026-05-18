namespace TPP3_GrupoG.RecepcionHDRAgencia
{
    partial class RecepcionHDRAgencia
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
            listView_HDR = new ListView();
            numGuia = new ColumnHeader();
            direccion = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            guiasAsociadas = new Label();
            btn_Confirma = new Button();
            btn_Salir = new Button();
            dniFleteroTXT = new TextBox();
            buscarFletero = new Button();
            dniFletero = new Label();
            SuspendLayout();
            // 
            // listView_HDR
            // 
            listView_HDR.Columns.AddRange(new ColumnHeader[] { numGuia, direccion, columnHeader1 });
            listView_HDR.Location = new Point(13, 64);
            listView_HDR.Margin = new Padding(2, 3, 2, 3);
            listView_HDR.Name = "listView_HDR";
            listView_HDR.Size = new Size(638, 236);
            listView_HDR.TabIndex = 7;
            listView_HDR.UseCompatibleStateImageBehavior = false;
            listView_HDR.View = View.Details;
            // 
            // numGuia
            // 
            numGuia.Text = "Nº Guía";
            numGuia.Width = 90;
            // 
            // direccion
            // 
            direccion.Text = "Dirección";
            direccion.Width = 90;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Entregar o recibir";
            columnHeader1.Width = 180;
            // 
            // guiasAsociadas
            // 
            guiasAsociadas.AutoSize = true;
            guiasAsociadas.Location = new Point(13, 41);
            guiasAsociadas.Margin = new Padding(2, 0, 2, 0);
            guiasAsociadas.Name = "guiasAsociadas";
            guiasAsociadas.Size = new Size(45, 20);
            guiasAsociadas.TabIndex = 8;
            guiasAsociadas.Text = "Guías";
            // 
            // btn_Confirma
            // 
            btn_Confirma.Location = new Point(472, 307);
            btn_Confirma.Margin = new Padding(2, 3, 2, 3);
            btn_Confirma.Name = "btn_Confirma";
            btn_Confirma.Size = new Size(87, 33);
            btn_Confirma.TabIndex = 9;
            btn_Confirma.Text = "Confirmar recepción";
            btn_Confirma.UseVisualStyleBackColor = true;
            btn_Confirma.Click += button1_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(563, 307);
            btn_Salir.Margin = new Padding(2, 3, 2, 3);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(87, 33);
            btn_Salir.TabIndex = 10;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // dniFleteroTXT
            // 
            dniFleteroTXT.Location = new Point(98, 12);
            dniFleteroTXT.Margin = new Padding(2, 3, 2, 3);
            dniFleteroTXT.Name = "dniFleteroTXT";
            dniFleteroTXT.Size = new Size(121, 27);
            dniFleteroTXT.TabIndex = 13;
            dniFleteroTXT.TextChanged += dniFleteroTXT_TextChanged;
            // 
            // buscarFletero
            // 
            buscarFletero.Location = new Point(237, 11);
            buscarFletero.Margin = new Padding(2, 3, 2, 3);
            buscarFletero.Name = "buscarFletero";
            buscarFletero.Size = new Size(89, 32);
            buscarFletero.TabIndex = 12;
            buscarFletero.Text = "Buscar";
            buscarFletero.UseVisualStyleBackColor = true;
            buscarFletero.Click += buscarFletero_Click;
            // 
            // dniFletero
            // 
            dniFletero.AutoSize = true;
            dniFletero.Location = new Point(13, 12);
            dniFletero.Margin = new Padding(2, 0, 2, 0);
            dniFletero.Name = "dniFletero";
            dniFletero.Size = new Size(85, 20);
            dniFletero.TabIndex = 11;
            dniFletero.Text = "DNI Fletero";
            // 
            // RecepcionHDRAgencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 368);
            Controls.Add(dniFleteroTXT);
            Controls.Add(buscarFletero);
            Controls.Add(dniFletero);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Confirma);
            Controls.Add(guiasAsociadas);
            Controls.Add(listView_HDR);
            Margin = new Padding(2, 3, 2, 3);
            Name = "RecepcionHDRAgencia";
            Text = "Recepción de Hojas de Ruta (Agencia)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView_HDR;
        private ColumnHeader numGuia;
        private ColumnHeader direccion;
        private Label guiasAsociadas;
        private Button btn_Confirma;
        private Button btn_Salir;
        private TextBox dniFleteroTXT;
        private Button buscarFletero;
        private Label dniFletero;
        private ColumnHeader columnHeader1;
    }
}