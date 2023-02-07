namespace ComponentesCombox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt01 = new System.Windows.Forms.TextBox();
            this.NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.Mask01 = new System.Windows.Forms.MaskedTextBox();
            this.Combox01 = new System.Windows.Forms.ComboBox();
            this.Bt01 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(85, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fruta Favorita";
            // 
            // Txt01
            // 
            this.Txt01.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt01.Location = new System.Drawing.Point(187, 90);
            this.Txt01.Name = "Txt01";
            this.Txt01.Size = new System.Drawing.Size(237, 48);
            this.Txt01.TabIndex = 4;
            // 
            // NumUpDown
            // 
            this.NumUpDown.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUpDown.Location = new System.Drawing.Point(187, 171);
            this.NumUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumUpDown.Name = "NumUpDown";
            this.NumUpDown.Size = new System.Drawing.Size(237, 48);
            this.NumUpDown.TabIndex = 5;
            this.NumUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // Mask01
            // 
            this.Mask01.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mask01.Location = new System.Drawing.Point(376, 286);
            this.Mask01.Mask = "00/00/0000";
            this.Mask01.Name = "Mask01";
            this.Mask01.Size = new System.Drawing.Size(187, 48);
            this.Mask01.TabIndex = 6;
            this.Mask01.ValidatingType = typeof(System.DateTime);
            // 
            // Combox01
            // 
            this.Combox01.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combox01.FormattingEnabled = true;
            this.Combox01.Items.AddRange(new object[] {
            "Abacaxi",
            "Abacate",
            "Amora",
            "Carambola",
            "Caqui",
            "Pera",
            "Morango",
            "Mexerica",
            "Jaca"});
            this.Combox01.Location = new System.Drawing.Point(296, 372);
            this.Combox01.Name = "Combox01";
            this.Combox01.Size = new System.Drawing.Size(267, 48);
            this.Combox01.TabIndex = 7;
            // 
            // Bt01
            // 
            this.Bt01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Bt01.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt01.FlatAppearance.BorderSize = 4;
            this.Bt01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt01.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt01.ForeColor = System.Drawing.Color.White;
            this.Bt01.Location = new System.Drawing.Point(615, 171);
            this.Bt01.Name = "Bt01";
            this.Bt01.Size = new System.Drawing.Size(151, 64);
            this.Bt01.TabIndex = 8;
            this.Bt01.Text = "Cadastrar";
            this.Bt01.UseVisualStyleBackColor = false;
            this.Bt01.Click += new System.EventHandler(this.Bt01_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt01);
            this.Controls.Add(this.Combox01);
            this.Controls.Add(this.Mask01);
            this.Controls.Add(this.NumUpDown);
            this.Controls.Add(this.Txt01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro - Componentes em Combox";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Txt01;
        private NumericUpDown NumUpDown;
        private MaskedTextBox Mask01;
        private ComboBox Combox01;
        private Button Bt01;
    }
}