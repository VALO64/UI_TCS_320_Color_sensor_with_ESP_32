namespace UI_TCS_320_with_ESP_32
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.COM = new System.Windows.Forms.ComboBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picturepistonactivado = new System.Windows.Forms.PictureBox();
            this.picturepistondesactivado = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureverde = new System.Windows.Forms.PictureBox();
            this.picturerojo = new System.Windows.Forms.PictureBox();
            this.pictureazul = new System.Windows.Forms.PictureBox();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturepistonactivado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepistondesactivado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureverde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturerojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureazul)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(132, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oscar Albero Valles Limas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(132, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "André Raymundo Arévalo Acevedo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(132, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dylan Ulises Mota Torres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(132, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mauricio Pérez Valdez";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Controls.Add(this.COM);
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Location = new System.Drawing.Point(14, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Baud Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puerto:";
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Location = new System.Drawing.Point(20, 111);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(168, 23);
            this.BaudRate.TabIndex = 3;
            // 
            // COM
            // 
            this.COM.FormattingEnabled = true;
            this.COM.Location = new System.Drawing.Point(20, 48);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(168, 23);
            this.COM.TabIndex = 2;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDesconectar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDesconectar.Location = new System.Drawing.Point(20, 199);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(168, 24);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnConectar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConectar.Location = new System.Drawing.Point(20, 157);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(168, 24);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picturepistonactivado);
            this.groupBox2.Controls.Add(this.picturepistondesactivado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureverde);
            this.groupBox2.Controls.Add(this.picturerojo);
            this.groupBox2.Controls.Add(this.pictureazul);
            this.groupBox2.Controls.Add(this.btnVerde);
            this.groupBox2.Controls.Add(this.btnRojo);
            this.groupBox2.Controls.Add(this.btnAzul);
            this.groupBox2.Location = new System.Drawing.Point(250, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 195);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // picturepistonactivado
            // 
            this.picturepistonactivado.Image = ((System.Drawing.Image)(resources.GetObject("picturepistonactivado.Image")));
            this.picturepistonactivado.Location = new System.Drawing.Point(343, 46);
            this.picturepistonactivado.Name = "picturepistonactivado";
            this.picturepistonactivado.Size = new System.Drawing.Size(101, 131);
            this.picturepistonactivado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepistonactivado.TabIndex = 9;
            this.picturepistonactivado.TabStop = false;
            this.picturepistonactivado.Visible = false;
            // 
            // picturepistondesactivado
            // 
            this.picturepistondesactivado.Image = ((System.Drawing.Image)(resources.GetObject("picturepistondesactivado.Image")));
            this.picturepistondesactivado.Location = new System.Drawing.Point(342, 46);
            this.picturepistondesactivado.Name = "picturepistondesactivado";
            this.picturepistondesactivado.Size = new System.Drawing.Size(101, 131);
            this.picturepistondesactivado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepistondesactivado.TabIndex = 8;
            this.picturepistondesactivado.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(17, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Clasificación de colores:";
            // 
            // pictureverde
            // 
            this.pictureverde.Image = ((System.Drawing.Image)(resources.GetObject("pictureverde.Image")));
            this.pictureverde.Location = new System.Drawing.Point(220, 46);
            this.pictureverde.Name = "pictureverde";
            this.pictureverde.Size = new System.Drawing.Size(100, 100);
            this.pictureverde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureverde.TabIndex = 6;
            this.pictureverde.TabStop = false;
            this.pictureverde.Visible = false;
            // 
            // picturerojo
            // 
            this.picturerojo.Image = ((System.Drawing.Image)(resources.GetObject("picturerojo.Image")));
            this.picturerojo.Location = new System.Drawing.Point(220, 45);
            this.picturerojo.Name = "picturerojo";
            this.picturerojo.Size = new System.Drawing.Size(100, 100);
            this.picturerojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturerojo.TabIndex = 5;
            this.picturerojo.TabStop = false;
            this.picturerojo.Visible = false;
            // 
            // pictureazul
            // 
            this.pictureazul.Image = ((System.Drawing.Image)(resources.GetObject("pictureazul.Image")));
            this.pictureazul.Location = new System.Drawing.Point(218, 46);
            this.pictureazul.Name = "pictureazul";
            this.pictureazul.Size = new System.Drawing.Size(100, 100);
            this.pictureazul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureazul.TabIndex = 4;
            this.pictureazul.TabStop = false;
            this.pictureazul.Visible = false;
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.btnVerde.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerde.Location = new System.Drawing.Point(21, 81);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(168, 24);
            this.btnVerde.TabIndex = 3;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRojo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRojo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRojo.Location = new System.Drawing.Point(21, 42);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(168, 24);
            this.btnRojo.TabIndex = 2;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(95)))), ((int)(((byte)(120)))));
            this.btnAzul.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAzul.Location = new System.Drawing.Point(21, 121);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(168, 24);
            this.btnAzul.TabIndex = 1;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(773, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Proyecto Final Hidraulica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturepistonactivado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepistondesactivado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureverde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturerojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureazul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.ComboBox COM;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.PictureBox pictureverde;
        private System.Windows.Forms.PictureBox picturerojo;
        private System.Windows.Forms.PictureBox pictureazul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picturepistonactivado;
        private System.Windows.Forms.PictureBox picturepistondesactivado;
    }
}

