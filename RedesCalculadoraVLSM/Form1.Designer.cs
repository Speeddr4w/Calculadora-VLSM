namespace RedesCalculadoraVLSM
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxIPBase = new System.Windows.Forms.TextBox();
            this.btnProseguirCalculo = new System.Windows.Forms.Button();
            this.btnRecomecarCalculo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAdicionarHost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHosts = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mais2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudHosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o IP Base para cálculo";
            // 
            // txtboxIPBase
            // 
            this.txtboxIPBase.Location = new System.Drawing.Point(281, 12);
            this.txtboxIPBase.Name = "txtboxIPBase";
            this.txtboxIPBase.Size = new System.Drawing.Size(181, 20);
            this.txtboxIPBase.TabIndex = 1;
            // 
            // btnProseguirCalculo
            // 
            this.btnProseguirCalculo.Location = new System.Drawing.Point(468, 10);
            this.btnProseguirCalculo.Name = "btnProseguirCalculo";
            this.btnProseguirCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnProseguirCalculo.TabIndex = 2;
            this.btnProseguirCalculo.Text = "Proseguir";
            this.btnProseguirCalculo.UseVisualStyleBackColor = true;
            this.btnProseguirCalculo.Click += new System.EventHandler(this.btnProseguirCalculo_Click);
            // 
            // btnRecomecarCalculo
            // 
            this.btnRecomecarCalculo.Location = new System.Drawing.Point(549, 10);
            this.btnRecomecarCalculo.Name = "btnRecomecarCalculo";
            this.btnRecomecarCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnRecomecarCalculo.TabIndex = 3;
            this.btnRecomecarCalculo.Text = "Recomeçar";
            this.btnRecomecarCalculo.UseVisualStyleBackColor = true;
            this.btnRecomecarCalculo.Click += new System.EventHandler(this.BtnRecomecarCalculo_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(468, 35);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnAdicionarHost
            // 
            this.btnAdicionarHost.Enabled = false;
            this.btnAdicionarHost.Location = new System.Drawing.Point(387, 35);
            this.btnAdicionarHost.Name = "btnAdicionarHost";
            this.btnAdicionarHost.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarHost.TabIndex = 6;
            this.btnAdicionarHost.Text = "Adicionar";
            this.btnAdicionarHost.UseVisualStyleBackColor = true;
            this.btnAdicionarHost.Click += new System.EventHandler(this.BtnAdicionarHost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade de Hosts";
            // 
            // nudHosts
            // 
            this.nudHosts.Enabled = false;
            this.nudHosts.Location = new System.Drawing.Point(281, 35);
            this.nudHosts.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.nudHosts.Name = "nudHosts";
            this.nudHosts.Size = new System.Drawing.Size(100, 20);
            this.nudHosts.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(776, 260);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hosts,
            this.mais2,
            this.Total});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(126, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(336, 101);
            this.dataGridView1.TabIndex = 10;
            // 
            // hosts
            // 
            this.hosts.HeaderText = "Hosts";
            this.hosts.Name = "hosts";
            this.hosts.ReadOnly = true;
            // 
            // mais2
            // 
            this.mais2.HeaderText = "Mais2";
            this.mais2.Name = "mais2";
            this.mais2.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.nudHosts);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAdicionarHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRecomecarCalculo);
            this.Controls.Add(this.btnProseguirCalculo);
            this.Controls.Add(this.txtboxIPBase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.nudHosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtboxIPBase;
        public System.Windows.Forms.Button btnProseguirCalculo;
        public System.Windows.Forms.Button btnRecomecarCalculo;
        public System.Windows.Forms.Button btnCalcular;
        public System.Windows.Forms.Button btnAdicionarHost;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nudHosts;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn hosts;
        public System.Windows.Forms.DataGridViewTextBoxColumn mais2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

