﻿namespace Tps_SIM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDistribucion = new System.Windows.Forms.Label();
            this.CmbDistribuciones = new System.Windows.Forms.ComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDesv = new System.Windows.Forms.TextBox();
            this.TxtMedia = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.TxtLambda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbIntervalos = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TablaDatos = new System.Windows.Forms.DataGridView();
            this.Inferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Superior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListaAleatorios = new System.Windows.Forms.ListBox();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "               DISTRIBUCIÓN:               ";
            // 
            // LblDistribucion
            // 
            this.LblDistribucion.AutoSize = true;
            this.LblDistribucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistribucion.Location = new System.Drawing.Point(41, 113);
            this.LblDistribucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDistribucion.Name = "LblDistribucion";
            this.LblDistribucion.Size = new System.Drawing.Size(153, 25);
            this.LblDistribucion.TabIndex = 77;
            this.LblDistribucion.Text = "DISTRIBUCION";
            // 
            // CmbDistribuciones
            // 
            this.CmbDistribuciones.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.CmbDistribuciones.FormattingEnabled = true;
            this.CmbDistribuciones.Items.AddRange(new object[] {
            "UNIFORME",
            "EXPONENCIAL",
            "NORMAL"});
            this.CmbDistribuciones.Location = new System.Drawing.Point(215, 114);
            this.CmbDistribuciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbDistribuciones.Name = "CmbDistribuciones";
            this.CmbDistribuciones.Size = new System.Drawing.Size(121, 24);
            this.CmbDistribuciones.TabIndex = 76;
            this.CmbDistribuciones.SelectedIndexChanged += new System.EventHandler(this.CmbDistribuciones_SelectedIndexChanged);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(17, 71);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(348, 125);
            this.Label17.TabIndex = 79;
            this.Label17.Text = " \r\n\r\n                                                        \r\n\r\n\r\n";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(49, 394);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(156, 25);
            this.Label16.TabIndex = 91;
            this.Label16.Text = "DESV. ESTAN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(349, 25);
            this.label9.TabIndex = 89;
            this.label9.Text = "               PARAMETROS:               ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(200, 341);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 88;
            this.label8.Text = "MEDIA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 87;
            this.label5.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 86;
            this.label4.Text = "λ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "A:";
            // 
            // TxtDesv
            // 
            this.TxtDesv.Enabled = false;
            this.TxtDesv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesv.Location = new System.Drawing.Point(239, 390);
            this.TxtDesv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDesv.MaxLength = 5;
            this.TxtDesv.Name = "TxtDesv";
            this.TxtDesv.Size = new System.Drawing.Size(53, 30);
            this.TxtDesv.TabIndex = 84;
            // 
            // TxtMedia
            // 
            this.TxtMedia.Enabled = false;
            this.TxtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMedia.Location = new System.Drawing.Point(303, 337);
            this.TxtMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtMedia.MaxLength = 5;
            this.TxtMedia.Name = "TxtMedia";
            this.TxtMedia.Size = new System.Drawing.Size(52, 30);
            this.TxtMedia.TabIndex = 83;
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(252, 282);
            this.txtB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtB.MaxLength = 6;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(52, 30);
            this.txtB.TabIndex = 81;
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(105, 287);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtA.MaxLength = 6;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(52, 30);
            this.txtA.TabIndex = 80;
            // 
            // TxtLambda
            // 
            this.TxtLambda.Enabled = false;
            this.TxtLambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLambda.Location = new System.Drawing.Point(105, 341);
            this.TxtLambda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLambda.MaxLength = 6;
            this.TxtLambda.Name = "TxtLambda";
            this.TxtLambda.Size = new System.Drawing.Size(52, 30);
            this.TxtLambda.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 265);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(348, 175);
            this.label10.TabIndex = 90;
            this.label10.Text = " \r\n\r\n\r\n\r\n                                                        \r\n\r\n\r\n";
            // 
            // CmbIntervalos
            // 
            this.CmbIntervalos.Enabled = false;
            this.CmbIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbIntervalos.FormattingEnabled = true;
            this.CmbIntervalos.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.CmbIntervalos.Location = new System.Drawing.Point(253, 560);
            this.CmbIntervalos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbIntervalos.Name = "CmbIntervalos";
            this.CmbIntervalos.Size = new System.Drawing.Size(59, 32);
            this.CmbIntervalos.TabIndex = 93;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(92, 562);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 25);
            this.label15.TabIndex = 98;
            this.label15.Text = "INTERVALOS:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 450);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(350, 25);
            this.label11.TabIndex = 96;
            this.label11.Text = "                 ALEATORIOS:               ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 510);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 95;
            this.label7.Text = "CANTIDAD:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(209, 506);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(119, 30);
            this.txtCantidad.TabIndex = 92;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.Blue;
            this.BtnGenerar.Enabled = false;
            this.BtnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.ForeColor = System.Drawing.Color.White;
            this.BtnGenerar.Location = new System.Drawing.Point(109, 660);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(148, 57);
            this.BtnGenerar.TabIndex = 94;
            this.BtnGenerar.Text = "GENERAR";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 487);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 125);
            this.label6.TabIndex = 97;
            this.label6.Text = " \r\n\r\n                                                        \r\n\r\n\r\n";
            // 
            // TablaDatos
            // 
            this.TablaDatos.AllowUserToAddRows = false;
            this.TablaDatos.AllowUserToDeleteRows = false;
            this.TablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inferior,
            this.Superior,
            this.FO,
            this.fd,
            this.FE});
            this.TablaDatos.Location = new System.Drawing.Point(701, 26);
            this.TablaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TablaDatos.Name = "TablaDatos";
            this.TablaDatos.ReadOnly = true;
            this.TablaDatos.RowHeadersWidth = 51;
            this.TablaDatos.Size = new System.Drawing.Size(725, 229);
            this.TablaDatos.TabIndex = 100;
            // 
            // Inferior
            // 
            this.Inferior.HeaderText = "Inferior";
            this.Inferior.MinimumWidth = 6;
            this.Inferior.Name = "Inferior";
            this.Inferior.ReadOnly = true;
            this.Inferior.Width = 125;
            // 
            // Superior
            // 
            this.Superior.HeaderText = "Superior";
            this.Superior.MinimumWidth = 6;
            this.Superior.Name = "Superior";
            this.Superior.ReadOnly = true;
            this.Superior.Width = 125;
            // 
            // FO
            // 
            this.FO.HeaderText = "FO";
            this.FO.MinimumWidth = 6;
            this.FO.Name = "FO";
            this.FO.ReadOnly = true;
            this.FO.Width = 125;
            // 
            // fd
            // 
            this.fd.HeaderText = "P( )";
            this.fd.MinimumWidth = 6;
            this.fd.Name = "fd";
            this.fd.ReadOnly = true;
            this.fd.Width = 125;
            // 
            // FE
            // 
            this.FE.HeaderText = "FE";
            this.FE.MinimumWidth = 6;
            this.FE.Name = "FE";
            this.FE.ReadOnly = true;
            this.FE.Width = 125;
            // 
            // ListaAleatorios
            // 
            this.ListaAleatorios.FormattingEnabled = true;
            this.ListaAleatorios.ItemHeight = 16;
            this.ListaAleatorios.Location = new System.Drawing.Point(453, 27);
            this.ListaAleatorios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaAleatorios.Name = "ListaAleatorios";
            this.ListaAleatorios.Size = new System.Drawing.Size(197, 228);
            this.ListaAleatorios.TabIndex = 99;
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(476, 287);
            this.grafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grafico.Name = "grafico";
            this.grafico.Size = new System.Drawing.Size(917, 430);
            this.grafico.TabIndex = 101;
            this.grafico.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 806);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.TablaDatos);
            this.Controls.Add(this.ListaAleatorios);
            this.Controls.Add(this.CmbIntervalos);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDesv);
            this.Controls.Add(this.TxtMedia);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.TxtLambda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblDistribucion);
            this.Controls.Add(this.CmbDistribuciones);
            this.Controls.Add(this.Label17);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label LblDistribucion;
        internal System.Windows.Forms.ComboBox CmbDistribuciones;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox TxtDesv;
        internal System.Windows.Forms.TextBox TxtMedia;
        internal System.Windows.Forms.TextBox txtB;
        internal System.Windows.Forms.TextBox txtA;
        internal System.Windows.Forms.TextBox TxtLambda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbIntervalos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtCantidad;
        internal System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TablaDatos;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Inferior;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Superior;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FO;
        internal System.Windows.Forms.DataGridViewTextBoxColumn fd;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FE;
        internal System.Windows.Forms.ListBox ListaAleatorios;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
    }
}

