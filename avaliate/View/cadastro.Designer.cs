namespace avaliate
{
    partial class cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.voltarMenu = new System.Windows.Forms.Button();
            this.nivelEnsino = new System.Windows.Forms.ListBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmarSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new avaliate.gradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materia = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.materia);
            this.groupBox1.Controls.Add(this.voltarMenu);
            this.groupBox1.Controls.Add(this.nivelEnsino);
            this.groupBox1.Controls.Add(this.cadastrar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.confirmarSenha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.senha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(69, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 436);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // voltarMenu
            // 
            this.voltarMenu.AutoSize = true;
            this.voltarMenu.BackColor = System.Drawing.Color.Transparent;
            this.voltarMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.voltarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.voltarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.voltarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarMenu.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarMenu.ForeColor = System.Drawing.Color.White;
            this.voltarMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.voltarMenu.Location = new System.Drawing.Point(462, 369);
            this.voltarMenu.Name = "voltarMenu";
            this.voltarMenu.Size = new System.Drawing.Size(195, 45);
            this.voltarMenu.TabIndex = 23;
            this.voltarMenu.Text = "Cancelar";
            this.voltarMenu.UseVisualStyleBackColor = false;
            this.voltarMenu.Click += new System.EventHandler(this.voltarMenu_Click);
            // 
            // nivelEnsino
            // 
            this.nivelEnsino.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelEnsino.FormattingEnabled = true;
            this.nivelEnsino.ItemHeight = 33;
            this.nivelEnsino.Location = new System.Drawing.Point(481, 191);
            this.nivelEnsino.Name = "nivelEnsino";
            this.nivelEnsino.ScrollAlwaysVisible = true;
            this.nivelEnsino.Size = new System.Drawing.Size(388, 37);
            this.nivelEnsino.TabIndex = 22;
            this.nivelEnsino.UseWaitCursor = true;
            // 
            // cadastrar
            // 
            this.cadastrar.AutoSize = true;
            this.cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.ForeColor = System.Drawing.Color.White;
            this.cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastrar.Location = new System.Drawing.Point(674, 369);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(195, 45);
            this.cadastrar.TabIndex = 21;
            this.cadastrar.Text = "Cadastrar-se";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(475, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nível de Ensino";
            // 
            // confirmarSenha
            // 
            this.confirmarSenha.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.confirmarSenha.Location = new System.Drawing.Point(481, 289);
            this.confirmarSenha.Name = "confirmarSenha";
            this.confirmarSenha.Size = new System.Drawing.Size(388, 40);
            this.confirmarSenha.TabIndex = 19;
            this.confirmarSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(475, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = "Confirme a senha";
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.ForeColor = System.Drawing.Color.Gray;
            this.senha.Location = new System.Drawing.Point(30, 289);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(388, 40);
            this.senha.TabIndex = 17;
            this.senha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Senha";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Gray;
            this.email.Location = new System.Drawing.Point(481, 93);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(388, 40);
            this.email.TabIndex = 15;
            this.email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(475, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "E-Mail";
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.Color.Gray;
            this.nome.Location = new System.Drawing.Point(31, 93);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(388, 40);
            this.nome.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Matéria";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(59)))), ((int)(((byte)(209)))));
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.gradientPanel2.Controls.Add(this.pictureBox2);
            this.gradientPanel2.Controls.Add(this.groupBox1);
            this.gradientPanel2.Controls.Add(this.pictureBox1);
            this.gradientPanel2.Location = new System.Drawing.Point(-4, -125);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1341, 889);
            this.gradientPanel2.TabIndex = 10;
            this.gradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel2_Paint_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(231, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(556, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // materia
            // 
            this.materia.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia.FormattingEnabled = true;
            this.materia.ItemHeight = 33;
            this.materia.Location = new System.Drawing.Point(31, 191);
            this.materia.Name = "materia";
            this.materia.ScrollAlwaysVisible = true;
            this.materia.Size = new System.Drawing.Size(388, 37);
            this.materia.TabIndex = 24;
            this.materia.UseWaitCursor = true;
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 577);
            this.Controls.Add(this.gradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox confirmarSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private gradientPanel gradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.ListBox nivelEnsino;
        private System.Windows.Forms.Button voltarMenu;
        private System.Windows.Forms.ListBox materia;
    }
}