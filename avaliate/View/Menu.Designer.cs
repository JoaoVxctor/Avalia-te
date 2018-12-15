namespace avaliate
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.gradientPanel1 = new avaliate.gradientPanel();
            this.greetingMessage = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.about = new System.Windows.Forms.Button();
            this.salvarProva = new System.Windows.Forms.Button();
            this.montarProva = new System.Windows.Forms.Button();
            this.cadastrarQuestoes = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(59)))), ((int)(((byte)(209)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.gradientPanel1.Controls.Add(this.greetingMessage);
            this.gradientPanel1.Controls.Add(this.sair);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.groupBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(-2, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(712, 618);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // greetingMessage
            // 
            this.greetingMessage.AutoSize = true;
            this.greetingMessage.BackColor = System.Drawing.Color.Transparent;
            this.greetingMessage.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingMessage.ForeColor = System.Drawing.Color.Gainsboro;
            this.greetingMessage.Location = new System.Drawing.Point(131, 151);
            this.greetingMessage.Name = "greetingMessage";
            this.greetingMessage.Size = new System.Drawing.Size(0, 29);
            this.greetingMessage.TabIndex = 9;
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.Transparent;
            this.sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.ForeColor = System.Drawing.Color.Transparent;
            this.sair.Location = new System.Drawing.Point(553, 567);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(112, 39);
            this.sair.TabIndex = 4;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.about);
            this.groupBox1.Controls.Add(this.salvarProva);
            this.groupBox1.Controls.Add(this.montarProva);
            this.groupBox1.Controls.Add(this.cadastrarQuestoes);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(45, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // about
            // 
            this.about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Location = new System.Drawing.Point(372, 224);
            this.about.Margin = new System.Windows.Forms.Padding(4);
            this.about.Name = "about";
            this.about.Padding = new System.Windows.Forms.Padding(1);
            this.about.Size = new System.Drawing.Size(189, 109);
            this.about.TabIndex = 3;
            this.about.Text = "Sobre o Sistema";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // salvarProva
            // 
            this.salvarProva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.salvarProva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.salvarProva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarProva.Location = new System.Drawing.Point(45, 224);
            this.salvarProva.Name = "salvarProva";
            this.salvarProva.Size = new System.Drawing.Size(189, 109);
            this.salvarProva.TabIndex = 2;
            this.salvarProva.Text = "Gerenciar Questões";
            this.salvarProva.UseVisualStyleBackColor = true;
            this.salvarProva.Click += new System.EventHandler(this.salvarProva_Click);
            // 
            // montarProva
            // 
            this.montarProva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.montarProva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.montarProva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.montarProva.Location = new System.Drawing.Point(372, 66);
            this.montarProva.Margin = new System.Windows.Forms.Padding(4);
            this.montarProva.Name = "montarProva";
            this.montarProva.Padding = new System.Windows.Forms.Padding(3);
            this.montarProva.Size = new System.Drawing.Size(189, 109);
            this.montarProva.TabIndex = 1;
            this.montarProva.Text = "Montar \r\nProva";
            this.montarProva.UseVisualStyleBackColor = true;
            this.montarProva.Click += new System.EventHandler(this.montarProva_Click);
            // 
            // cadastrarQuestoes
            // 
            this.cadastrarQuestoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.cadastrarQuestoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.cadastrarQuestoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarQuestoes.Location = new System.Drawing.Point(45, 66);
            this.cadastrarQuestoes.Name = "cadastrarQuestoes";
            this.cadastrarQuestoes.Size = new System.Drawing.Size(189, 109);
            this.cadastrarQuestoes.TabIndex = 0;
            this.cadastrarQuestoes.Text = "Cadastrar Questões";
            this.cadastrarQuestoes.UseVisualStyleBackColor = true;
            this.cadastrarQuestoes.Click += new System.EventHandler(this.cadastrarQuestoes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 612);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private gradientPanel gradientPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cadastrarQuestoes;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button salvarProva;
        private System.Windows.Forms.Button montarProva;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Label greetingMessage;
    }
}