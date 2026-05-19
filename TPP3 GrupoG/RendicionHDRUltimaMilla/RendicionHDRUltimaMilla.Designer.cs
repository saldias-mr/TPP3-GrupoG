namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    partial class Rendicion_de_HDR_Ultima_Milla
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
            dniFletero = new Label();
            buscarFletero = new Button();
            dniFleteroTXT = new TextBox();
            hdrPendiente = new Label();
            guiaAsociada = new Label();
            hdrPendienteLIST = new ListView();
            numHDR = new ColumnHeader();
            tipoHDR = new ColumnHeader();
            domicilioVisitar = new ColumnHeader();
            guiaAsociadaLISTARendir = new ListView();
            resultado = new Label();
            resultadoCMB = new ComboBox();
            confirmarRendicion = new Button();
            emitirResumen = new Button();
            listViewGUIASaEntregar = new ListView();
            listViewHDR = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // dniFletero
            // 
            dniFletero.AutoSize = true;
            dniFletero.Location = new Point(25, 20);
            dniFletero.Margin = new Padding(2, 0, 2, 0);
            dniFletero.Name = "dniFletero";
            dniFletero.Size = new Size(85, 20);
            dniFletero.TabIndex = 0;
            dniFletero.Text = "DNI Fletero";
            // 
            // buscarFletero
            // 
            buscarFletero.Location = new Point(249, 19);
            buscarFletero.Margin = new Padding(2, 3, 2, 3);
            buscarFletero.Name = "buscarFletero";
            buscarFletero.Size = new Size(89, 32);
            buscarFletero.TabIndex = 1;
            buscarFletero.Text = "Buscar";
            buscarFletero.UseVisualStyleBackColor = true;
            buscarFletero.Click += buscarFletero_Click;
            // 
            // dniFleteroTXT
            // 
            dniFleteroTXT.Location = new Point(111, 20);
            dniFleteroTXT.Margin = new Padding(2, 3, 2, 3);
            dniFleteroTXT.Name = "dniFleteroTXT";
            dniFleteroTXT.Size = new Size(121, 27);
            dniFleteroTXT.TabIndex = 2;
            // 
            // hdrPendiente
            // 
            hdrPendiente.AutoSize = true;
            hdrPendiente.Location = new Point(25, 357);
            hdrPendiente.Margin = new Padding(2, 0, 2, 0);
            hdrPendiente.Name = "hdrPendiente";
            hdrPendiente.Size = new Size(153, 20);
            hdrPendiente.TabIndex = 3;
            hdrPendiente.Text = "Hojas de ruta a rendir";
            // 
            // guiaAsociada
            // 
            guiaAsociada.AutoSize = true;
            guiaAsociada.Location = new Point(518, 357);
            guiaAsociada.Margin = new Padding(2, 0, 2, 0);
            guiaAsociada.Name = "guiaAsociada";
            guiaAsociada.Size = new Size(45, 20);
            guiaAsociada.TabIndex = 4;
            guiaAsociada.Text = "Guías";
            guiaAsociada.Click += guiaAsociada_Click;
            // 
            // hdrPendienteLIST
            // 
            hdrPendienteLIST.Columns.AddRange(new ColumnHeader[] { numHDR, tipoHDR, domicilioVisitar });
            hdrPendienteLIST.FullRowSelect = true;
            hdrPendienteLIST.Location = new Point(25, 380);
            hdrPendienteLIST.Margin = new Padding(2, 3, 2, 3);
            hdrPendienteLIST.MultiSelect = false;
            hdrPendienteLIST.Name = "hdrPendienteLIST";
            hdrPendienteLIST.Size = new Size(487, 205);
            hdrPendienteLIST.TabIndex = 5;
            hdrPendienteLIST.UseCompatibleStateImageBehavior = false;
            hdrPendienteLIST.View = View.Details;
            // 
            // numHDR
            // 
            numHDR.Text = "Nº HDR";
            numHDR.Width = 90;
            // 
            // tipoHDR
            // 
            tipoHDR.Text = "Tipo";
            tipoHDR.Width = 90;
            // 
            // domicilioVisitar
            // 
            domicilioVisitar.Text = "Dirección";
            domicilioVisitar.Width = 90;
            // 
            // guiaAsociadaLISTARendir
            // 
            guiaAsociadaLISTARendir.FullRowSelect = true;
            guiaAsociadaLISTARendir.Location = new Point(518, 380);
            guiaAsociadaLISTARendir.Margin = new Padding(2, 3, 2, 3);
            guiaAsociadaLISTARendir.MultiSelect = false;
            guiaAsociadaLISTARendir.Name = "guiaAsociadaLISTARendir";
            guiaAsociadaLISTARendir.Size = new Size(388, 205);
            guiaAsociadaLISTARendir.TabIndex = 6;
            guiaAsociadaLISTARendir.UseCompatibleStateImageBehavior = false;
            guiaAsociadaLISTARendir.View = View.Details;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(35, 608);
            resultado.Margin = new Padding(2, 0, 2, 0);
            resultado.Name = "resultado";
            resultado.Size = new Size(78, 20);
            resultado.TabIndex = 7;
            resultado.Text = "Resultado:";
            // 
            // resultadoCMB
            // 
            resultadoCMB.FormattingEnabled = true;
            resultadoCMB.Items.AddRange(new object[] { "Entregada", "Retirada", "No entregada", "No retirada", "Incidencia" });
            resultadoCMB.Location = new Point(121, 597);
            resultadoCMB.Margin = new Padding(2, 3, 2, 3);
            resultadoCMB.Name = "resultadoCMB";
            resultadoCMB.Size = new Size(147, 28);
            resultadoCMB.TabIndex = 8;
            resultadoCMB.SelectedIndexChanged += resultadoCMB_SelectedIndexChanged;
            // 
            // confirmarRendicion
            // 
            confirmarRendicion.Location = new Point(273, 595);
            confirmarRendicion.Margin = new Padding(2, 3, 2, 3);
            confirmarRendicion.Name = "confirmarRendicion";
            confirmarRendicion.Size = new Size(89, 41);
            confirmarRendicion.TabIndex = 11;
            confirmarRendicion.Text = "Confirmar";
            confirmarRendicion.UseVisualStyleBackColor = true;
            // 
            // emitirResumen
            // 
            emitirResumen.Location = new Point(805, 677);
            emitirResumen.Margin = new Padding(2, 3, 2, 3);
            emitirResumen.Name = "emitirResumen";
            emitirResumen.Size = new Size(112, 41);
            emitirResumen.TabIndex = 12;
            emitirResumen.Text = "Emitir resumen";
            emitirResumen.UseVisualStyleBackColor = true;
            // 
            // listViewGUIASaEntregar
            // 
            listViewGUIASaEntregar.FullRowSelect = true;
            listViewGUIASaEntregar.Location = new Point(518, 92);
            listViewGUIASaEntregar.Margin = new Padding(2, 3, 2, 3);
            listViewGUIASaEntregar.MultiSelect = false;
            listViewGUIASaEntregar.Name = "listViewGUIASaEntregar";
            listViewGUIASaEntregar.Size = new Size(388, 205);
            listViewGUIASaEntregar.TabIndex = 15;
            listViewGUIASaEntregar.UseCompatibleStateImageBehavior = false;
            listViewGUIASaEntregar.View = View.Details;
            listViewGUIASaEntregar.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // listViewHDR
            // 
            listViewHDR.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewHDR.FullRowSelect = true;
            listViewHDR.Location = new Point(25, 92);
            listViewHDR.Margin = new Padding(2, 3, 2, 3);
            listViewHDR.MultiSelect = false;
            listViewHDR.Name = "listViewHDR";
            listViewHDR.Size = new Size(487, 205);
            listViewHDR.TabIndex = 14;
            listViewHDR.UseCompatibleStateImageBehavior = false;
            listViewHDR.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nº HDR";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dirección";
            columnHeader3.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 20);
            label1.TabIndex = 13;
            label1.Text = "Hojas de ruta a entregar al fletero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 16;
            label2.Text = "Guías";
            // 
            // Rendicion_de_HDR_Ultima_Milla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 744);
            Controls.Add(label2);
            Controls.Add(listViewGUIASaEntregar);
            Controls.Add(listViewHDR);
            Controls.Add(label1);
            Controls.Add(emitirResumen);
            Controls.Add(confirmarRendicion);
            Controls.Add(resultadoCMB);
            Controls.Add(resultado);
            Controls.Add(guiaAsociadaLISTARendir);
            Controls.Add(hdrPendienteLIST);
            Controls.Add(guiaAsociada);
            Controls.Add(hdrPendiente);
            Controls.Add(dniFleteroTXT);
            Controls.Add(buscarFletero);
            Controls.Add(dniFletero);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Rendicion_de_HDR_Ultima_Milla";
            Text = "Rendición de HDR Última Milla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dniFletero;
        private Button buscarFletero;
        private TextBox dniFleteroTXT;
        private Label hdrPendiente;
        private Label guiaAsociada;
        private ListView hdrPendienteLIST;
        private ListView guiaAsociadaLISTARendir;
        private ColumnHeader numHDR;
        private ColumnHeader tipoHDR;
        private ColumnHeader domicilioVisitar;
        private Label resultado;
        private ComboBox resultadoCMB;
        private Button confirmarRendicion;
        private Button emitirResumen;
        private ListView listViewGUIASaEntregar;
        private ListView listViewHDR;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label2;
    }
}