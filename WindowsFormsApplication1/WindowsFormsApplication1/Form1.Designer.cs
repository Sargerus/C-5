namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.not = new System.Windows.Forms.CheckBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.dec = new System.Windows.Forms.RadioButton();
            this.hex = new System.Windows.Forms.RadioButton();
            this.bin = new System.Windows.Forms.RadioButton();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(63, 98);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 2;
            this.a.TextChanged += new System.EventHandler(this.a_TextChanged);
            this.a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a_KeyPress);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(63, 200);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 3;
            this.b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.b_KeyPress);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(38, 148);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(48, 17);
            this.rb1.TabIndex = 4;
            this.rb1.TabStop = true;
            this.rb1.Text = "AND";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(93, 148);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(41, 17);
            this.rb2.TabIndex = 5;
            this.rb2.Text = "OR";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(140, 148);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(48, 17);
            this.rb3.TabIndex = 6;
            this.rb3.Text = "XOR";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "=";
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(283, 145);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(140, 20);
            this.c.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // not
            // 
            this.not.AutoSize = true;
            this.not.Location = new System.Drawing.Point(93, 177);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(49, 17);
            this.not.TabIndex = 11;
            this.not.Text = "NOT";
            this.not.UseVisualStyleBackColor = true;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.dec);
            this.gb1.Controls.Add(this.hex);
            this.gb1.Controls.Add(this.bin);
            this.gb1.Location = new System.Drawing.Point(283, 98);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(140, 41);
            this.gb1.TabIndex = 12;
            this.gb1.TabStop = false;
            this.gb1.Enter += new System.EventHandler(this.gb1_Enter);
            // 
            // dec
            // 
            this.dec.AutoSize = true;
            this.dec.Location = new System.Drawing.Point(98, 24);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(45, 17);
            this.dec.TabIndex = 2;
            this.dec.TabStop = true;
            this.dec.Text = "Dec";
            this.dec.UseVisualStyleBackColor = true;
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.Location = new System.Drawing.Point(47, 23);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(44, 17);
            this.hex.TabIndex = 1;
            this.hex.TabStop = true;
            this.hex.Text = "Hex";
            this.hex.UseVisualStyleBackColor = true;
            // 
            // bin
            // 
            this.bin.AutoSize = true;
            this.bin.Checked = true;
            this.bin.Location = new System.Drawing.Point(0, 23);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(40, 17);
            this.bin.TabIndex = 0;
            this.bin.TabStop = true;
            this.bin.Text = "Bin";
            this.bin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 351);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.not);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox not;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton dec;
        private System.Windows.Forms.RadioButton hex;
        private System.Windows.Forms.RadioButton bin;
    }
}

