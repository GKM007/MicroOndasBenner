namespace MicroOndasBenner
{
    partial class MicroOndas
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
            this.button_ligar = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.button_pausar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.tmpTempo = new System.Windows.Forms.Timer(this.components);
            this.lblPrograma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPrograma = new System.Windows.Forms.ComboBox();
            this.lblPonto = new System.Windows.Forms.Label();
            this.btnAdicionarPrograma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ligar
            // 
            this.button_ligar.Location = new System.Drawing.Point(158, 19);
            this.button_ligar.Name = "button_ligar";
            this.button_ligar.Size = new System.Drawing.Size(75, 23);
            this.button_ligar.TabIndex = 0;
            this.button_ligar.Text = "Iniciar";
            this.button_ligar.UseVisualStyleBackColor = true;
            this.button_ligar.Click += new System.EventHandler(this.LigarMicroondas);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(117, 12);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(40, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo";
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(108, 43);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(49, 13);
            this.lblPotencia.TabIndex = 3;
            this.lblPotencia.Text = "Potência";
            // 
            // button_pausar
            // 
            this.button_pausar.Location = new System.Drawing.Point(239, 19);
            this.button_pausar.Name = "button_pausar";
            this.button_pausar.Size = new System.Drawing.Size(75, 23);
            this.button_pausar.TabIndex = 5;
            this.button_pausar.Text = "Pausar";
            this.button_pausar.UseVisualStyleBackColor = true;
            this.button_pausar.Click += new System.EventHandler(this.PausarAquecimento);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(320, 19);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 6;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.CancelarAquecimento);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(164, 9);
            this.txtTempo.MaxLength = 3;
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(121, 20);
            this.txtTempo.TabIndex = 7;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDadosTempo);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(164, 40);
            this.txtPotencia.MaxLength = 2;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(121, 20);
            this.txtPotencia.TabIndex = 8;
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPotencia_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Início Rápido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InicioRapido);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(108, 31);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(96, 20);
            this.lblMensagem.TabIndex = 10;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // tmpTempo
            // 
            this.tmpTempo.Interval = 1000;
            this.tmpTempo.Tick += new System.EventHandler(this.TempoPrograma);
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Location = new System.Drawing.Point(56, 80);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(101, 13);
            this.lblPrograma.TabIndex = 12;
            this.lblPrograma.Text = "Tipos de Programas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Segundos";
            // 
            // cmbPrograma
            // 
            this.cmbPrograma.FormattingEnabled = true;
            this.cmbPrograma.Location = new System.Drawing.Point(164, 75);
            this.cmbPrograma.Name = "cmbPrograma";
            this.cmbPrograma.Size = new System.Drawing.Size(121, 21);
            this.cmbPrograma.TabIndex = 16;
            this.cmbPrograma.SelectedIndexChanged += new System.EventHandler(this.RecuperarPrograma);
            this.cmbPrograma.Leave += new System.EventHandler(this.Cmb_Programa);
            // 
            // lblPonto
            // 
            this.lblPonto.AutoSize = true;
            this.lblPonto.ForeColor = System.Drawing.Color.Red;
            this.lblPonto.Location = new System.Drawing.Point(108, 70);
            this.lblPonto.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblPonto.Name = "lblPonto";
            this.lblPonto.Size = new System.Drawing.Size(34, 13);
            this.lblPonto.TabIndex = 17;
            this.lblPonto.Text = "ponto";
            this.lblPonto.Click += new System.EventHandler(this.lblPonto_Click);
            // 
            // btnAdicionarPrograma
            // 
            this.btnAdicionarPrograma.Location = new System.Drawing.Point(466, 23);
            this.btnAdicionarPrograma.Name = "btnAdicionarPrograma";
            this.btnAdicionarPrograma.Size = new System.Drawing.Size(136, 23);
            this.btnAdicionarPrograma.TabIndex = 18;
            this.btnAdicionarPrograma.Text = "Inserir Programa";
            this.btnAdicionarPrograma.UseVisualStyleBackColor = true;
            this.btnAdicionarPrograma.Click += new System.EventHandler(this.AdicionarPrograma);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Progresso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Monitor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionarPrograma);
            this.groupBox1.Controls.Add(this.lblTempo);
            this.groupBox1.Controls.Add(this.lblPotencia);
            this.groupBox1.Controls.Add(this.txtTempo);
            this.groupBox1.Controls.Add(this.txtPotencia);
            this.groupBox1.Controls.Add(this.cmbPrograma);
            this.groupBox1.Controls.Add(this.lblPrograma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 107);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_ligar);
            this.groupBox2.Controls.Add(this.button_pausar);
            this.groupBox2.Controls.Add(this.button_cancelar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(10, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 62);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funções";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMensagem);
            this.groupBox3.Controls.Add(this.lblPonto);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 141);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitor";
            // 
            // MicroOndas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 343);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MicroOndas";
            this.Text = "Micro Ondas";
            this.Load += new System.EventHandler(this.IniciarPrograma);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ligar;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Button button_pausar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Timer tmpTempo;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPrograma;
        private System.Windows.Forms.Label lblPonto;
        private System.Windows.Forms.Button btnAdicionarPrograma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

