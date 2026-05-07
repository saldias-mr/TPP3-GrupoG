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
            guiaAsociadaLIST = new ListView();
            resultado = new Label();
            resultadoCMB = new ComboBox();
            motivoIncidencia = new Label();
            motivoIncidenciaTXT = new TextBox();
            confirmarRendicion = new Button();
            emitirResumen = new Button();
            SuspendLayout();
            // 
            // dniFletero
            // 
            dniFletero.AutoSize = true;
            dniFletero.Location = new Point(22, 15);
            dniFletero.Margin = new Padding(2, 0, 2, 0);
            dniFletero.Name = "dniFletero";
            dniFletero.Size = new Size(66, 15);
            dniFletero.TabIndex = 0;
            dniFletero.Text = "DNI Fletero";
            // 
            // buscarFletero
            // 
            buscarFletero.Location = new Point(218, 14);
            buscarFletero.Margin = new Padding(2);
            buscarFletero.Name = "buscarFletero";
            buscarFletero.Size = new Size(78, 24);
            buscarFletero.TabIndex = 1;
            buscarFletero.Text = "Buscar";
            buscarFletero.UseVisualStyleBackColor = true;
            // 
            // dniFleteroTXT
            // 
            dniFleteroTXT.Location = new Point(97, 15);
            dniFleteroTXT.Margin = new Padding(2);
            dniFleteroTXT.Name = "dniFleteroTXT";
            dniFleteroTXT.Size = new Size(106, 23);
            dniFleteroTXT.TabIndex = 2;
            // 
            // hdrPendiente
            // 
            hdrPendiente.AutoSize = true;
            hdrPendiente.Location = new Point(22, 57);
            hdrPendiente.Margin = new Padding(2, 0, 2, 0);
            hdrPendiente.Name = "hdrPendiente";
            hdrPendiente.Size = new Size(77, 15);
            hdrPendiente.TabIndex = 3;
            hdrPendiente.Text = "Hojas de ruta";
            // 
            // guiaAsociada
            // 
            guiaAsociada.AutoSize = true;
            guiaAsociada.Location = new Point(453, 57);
            guiaAsociada.Margin = new Padding(2, 0, 2, 0);
            guiaAsociada.Name = "guiaAsociada";
            guiaAsociada.Size = new Size(36, 15);
            guiaAsociada.TabIndex = 4;
            guiaAsociada.Text = "Guías";
            guiaAsociada.Click += guiaAsociada_Click;
            // 
            // hdrPendienteLIST
            // 
            hdrPendienteLIST.Columns.AddRange(new ColumnHeader[] { numHDR, tipoHDR, domicilioVisitar });
            hdrPendienteLIST.FullRowSelect = true;
            hdrPendienteLIST.Location = new Point(22, 76);
            hdrPendienteLIST.Margin = new Padding(2);
            hdrPendienteLIST.MultiSelect = false;
            hdrPendienteLIST.Name = "hdrPendienteLIST";
            hdrPendienteLIST.Size = new Size(303, 155);
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
            // guiaAsociadaLIST
            // 
            guiaAsociadaLIST.FullRowSelect = true;
            guiaAsociadaLIST.Location = new Point(453, 76);
            guiaAsociadaLIST.Margin = new Padding(2);
            guiaAsociadaLIST.MultiSelect = false;
            guiaAsociadaLIST.Name = "guiaAsociadaLIST";
            guiaAsociadaLIST.Size = new Size(122, 155);
            guiaAsociadaLIST.TabIndex = 6;
            guiaAsociadaLIST.UseCompatibleStateImageBehavior = false;
            guiaAsociadaLIST.View = View.Details;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(22, 240);
            resultado.Margin = new Padding(2, 0, 2, 0);
            resultado.Name = "resultado";
            resultado.Size = new Size(62, 15);
            resultado.TabIndex = 7;
            resultado.Text = "Resultado:";
            // 
            // resultadoCMB
            // 
            resultadoCMB.FormattingEnabled = true;
            resultadoCMB.Items.AddRange(new object[] { "Entregada", "Retirada", "No entregada", "No retirada", "Incidencia" });
            resultadoCMB.Location = new Point(86, 235);
            resultadoCMB.Margin = new Padding(2);
            resultadoCMB.Name = "resultadoCMB";
            resultadoCMB.Size = new Size(129, 23);
            resultadoCMB.TabIndex = 8;
            // 
            // motivoIncidencia
            // 
            motivoIncidencia.AutoSize = true;
            motivoIncidencia.Location = new Point(22, 271);
            motivoIncidencia.Margin = new Padding(2, 0, 2, 0);
            motivoIncidencia.Name = "motivoIncidencia";
            motivoIncidencia.Size = new Size(48, 15);
            motivoIncidencia.TabIndex = 9;
            motivoIncidencia.Text = "Motivo:";
            // 
            // motivoIncidenciaTXT
            // 
            motivoIncidenciaTXT.Location = new Point(86, 263);
            motivoIncidenciaTXT.Margin = new Padding(2);
            motivoIncidenciaTXT.Name = "motivoIncidenciaTXT";
            motivoIncidenciaTXT.Size = new Size(129, 23);
            motivoIncidenciaTXT.TabIndex = 10;
            // 
            // confirmarRendicion
            // 
            confirmarRendicion.Location = new Point(432, 278);
            confirmarRendicion.Margin = new Padding(2);
            confirmarRendicion.Name = "confirmarRendicion";
            confirmarRendicion.Size = new Size(78, 31);
            confirmarRendicion.TabIndex = 11;
            confirmarRendicion.Text = "Confirmar";
            confirmarRendicion.UseVisualStyleBackColor = true;
            // 
            // emitirResumen
            // 
            emitirResumen.Location = new Point(514, 278);
            emitirResumen.Margin = new Padding(2);
            emitirResumen.Name = "emitirResumen";
            emitirResumen.Size = new Size(98, 31);
            emitirResumen.TabIndex = 12;
            emitirResumen.Text = "Emitir resumen";
            emitirResumen.UseVisualStyleBackColor = true;
            // 
            // Rendicion_de_HDR_Ultima_Milla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 317);
            Controls.Add(emitirResumen);
            Controls.Add(confirmarRendicion);
            Controls.Add(motivoIncidenciaTXT);
            Controls.Add(motivoIncidencia);
            Controls.Add(resultadoCMB);
            Controls.Add(resultado);
            Controls.Add(guiaAsociadaLIST);
            Controls.Add(hdrPendienteLIST);
            Controls.Add(guiaAsociada);
            Controls.Add(hdrPendiente);
            Controls.Add(dniFleteroTXT);
            Controls.Add(buscarFletero);
            Controls.Add(dniFletero);
            Margin = new Padding(2);
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
        private ListView guiaAsociadaLIST;
        private ColumnHeader numHDR;
        private ColumnHeader tipoHDR;
        private ColumnHeader domicilioVisitar;
        private Label resultado;
        private ComboBox resultadoCMB;
        private Label motivoIncidencia;
        private TextBox motivoIncidenciaTXT;
        private Button confirmarRendicion;
        private Button emitirResumen;
    }
}