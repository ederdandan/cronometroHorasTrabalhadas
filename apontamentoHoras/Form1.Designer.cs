namespace apontamentoHoras
{
    partial class formApontamento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formApontamento));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.tmrCronometro = new System.Windows.Forms.Timer(this.components);
            this.btnParar = new System.Windows.Forms.Button();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblMilisegundos = new System.Windows.Forms.Label();
            this.lblDoisPontos1 = new System.Windows.Forms.Label();
            this.lblDoisPontos2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnZerar = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmrApontamento = new System.Windows.Forms.Timer(this.components);
            this.tmrSoneca = new System.Windows.Forms.Timer(this.components);
            this.pbSoneca = new System.Windows.Forms.PictureBox();
            this.txtDataHoje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoneca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIniciar.Location = new System.Drawing.Point(86, 229);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(150, 40);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnApontar_Click);
            // 
            // tmrCronometro
            // 
            this.tmrCronometro.Enabled = true;
            this.tmrCronometro.Interval = 1;
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnParar.Location = new System.Drawing.Point(269, 229);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(150, 40);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "PARAR";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHoras.Location = new System.Drawing.Point(7, 51);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(172, 120);
            this.lblHoras.TabIndex = 4;
            this.lblHoras.Text = "00";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMinutos.Location = new System.Drawing.Point(259, 51);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(172, 120);
            this.lblMinutos.TabIndex = 5;
            this.lblMinutos.Text = "00";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSegundos.Location = new System.Drawing.Point(511, 51);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(172, 120);
            this.lblSegundos.TabIndex = 6;
            this.lblSegundos.Text = "00";
            // 
            // lblMilisegundos
            // 
            this.lblMilisegundos.AutoSize = true;
            this.lblMilisegundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMilisegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilisegundos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMilisegundos.Location = new System.Drawing.Point(595, 162);
            this.lblMilisegundos.Name = "lblMilisegundos";
            this.lblMilisegundos.Size = new System.Drawing.Size(46, 31);
            this.lblMilisegundos.TabIndex = 7;
            this.lblMilisegundos.Text = "00";
            this.lblMilisegundos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDoisPontos1
            // 
            this.lblDoisPontos1.AutoSize = true;
            this.lblDoisPontos1.BackColor = System.Drawing.Color.Transparent;
            this.lblDoisPontos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDoisPontos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoisPontos1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDoisPontos1.Location = new System.Drawing.Point(178, 51);
            this.lblDoisPontos1.Name = "lblDoisPontos1";
            this.lblDoisPontos1.Size = new System.Drawing.Size(81, 120);
            this.lblDoisPontos1.TabIndex = 8;
            this.lblDoisPontos1.Text = ":";
            // 
            // lblDoisPontos2
            // 
            this.lblDoisPontos2.AutoSize = true;
            this.lblDoisPontos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDoisPontos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoisPontos2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDoisPontos2.Location = new System.Drawing.Point(430, 51);
            this.lblDoisPontos2.Name = "lblDoisPontos2";
            this.lblDoisPontos2.Size = new System.Drawing.Size(81, 120);
            this.lblDoisPontos2.TabIndex = 9;
            this.lblDoisPontos2.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(37, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "HORAS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(277, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 31);
            this.label9.TabIndex = 12;
            this.label9.Text = "MINUTOS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(511, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 31);
            this.label10.TabIndex = 13;
            this.label10.Text = "SEGUNDOS";
            // 
            // btnZerar
            // 
            this.btnZerar.Enabled = false;
            this.btnZerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZerar.Location = new System.Drawing.Point(452, 229);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(150, 40);
            this.btnZerar.TabIndex = 3;
            this.btnZerar.Text = "ZERAR";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Abrir opções Menu";
            this.notifyIcon1.BalloonTipTitle = "Apontamento";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tmrApontamento
            // 
            this.tmrApontamento.Enabled = true;
            // 
            // pbSoneca
            // 
            this.pbSoneca.Image = global::apontamentoHoras.Properties.Resources.soneca2;
            this.pbSoneca.Location = new System.Drawing.Point(619, 210);
            this.pbSoneca.Name = "pbSoneca";
            this.pbSoneca.Size = new System.Drawing.Size(59, 59);
            this.pbSoneca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSoneca.TabIndex = 14;
            this.pbSoneca.TabStop = false;
            this.pbSoneca.Visible = false;
            this.pbSoneca.Click += new System.EventHandler(this.pbSoneca_Click);
            // 
            // txtDataHoje
            // 
            this.txtDataHoje.AutoSize = true;
            this.txtDataHoje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDataHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataHoje.ForeColor = System.Drawing.Color.SandyBrown;
            this.txtDataHoje.Location = new System.Drawing.Point(37, 171);
            this.txtDataHoje.Name = "txtDataHoje";
            this.txtDataHoje.Size = new System.Drawing.Size(184, 31);
            this.txtDataHoje.TabIndex = 15;
            this.txtDataHoje.Text = "XX/XX/XXXX";
            this.txtDataHoje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // formApontamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(690, 281);
            this.Controls.Add(this.txtDataHoje);
            this.Controls.Add(this.pbSoneca);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDoisPontos2);
            this.Controls.Add(this.lblDoisPontos1);
            this.Controls.Add(this.lblMilisegundos);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formApontamento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apontamento";
            this.Resize += new System.EventHandler(this.formApontamento_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbSoneca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Timer tmrCronometro;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblMilisegundos;
        private System.Windows.Forms.Label lblDoisPontos1;
        private System.Windows.Forms.Label lblDoisPontos2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer tmrApontamento;
        private System.Windows.Forms.Timer tmrSoneca;
        private System.Windows.Forms.PictureBox pbSoneca;
        private System.Windows.Forms.Label txtDataHoje;
    }
}

