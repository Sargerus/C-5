namespace WindowsFormsApplication2
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
            this.asd = new System.Windows.Forms.Label();
            this.col = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.colsize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.TextBox();
            this.minbut = new System.Windows.Forms.Button();
            this.maxbut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(157, 9);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(65, 13);
            this.asd.TabIndex = 0;
            this.asd.Text = "Коллекция:";
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(12, 43);
            this.col.Multiline = true;
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(324, 206);
            this.col.TabIndex = 1;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(59, 282);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(92, 30);
            this.b1.TabIndex = 2;
            this.b1.Text = "Сгенерировать";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // colsize
            // 
            this.colsize.Location = new System.Drawing.Point(119, 256);
            this.colsize.Name = "colsize";
            this.colsize.Size = new System.Drawing.Size(32, 20);
            this.colsize.TabIndex = 3;
            this.colsize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colsize_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер коллекции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат запроса:";
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(374, 43);
            this.query.Multiline = true;
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(282, 196);
            this.query.TabIndex = 6;
            // 
            // minbut
            // 
            this.minbut.Location = new System.Drawing.Point(457, 252);
            this.minbut.Name = "minbut";
            this.minbut.Size = new System.Drawing.Size(75, 23);
            this.minbut.TabIndex = 7;
            this.minbut.Text = "Min";
            this.minbut.UseVisualStyleBackColor = true;
            this.minbut.Click += new System.EventHandler(this.minbut_Click);
            // 
            // maxbut
            // 
            this.maxbut.Location = new System.Drawing.Point(581, 251);
            this.maxbut.Name = "maxbut";
            this.maxbut.Size = new System.Drawing.Size(75, 23);
            this.maxbut.TabIndex = 8;
            this.maxbut.Text = "Max";
            this.maxbut.UseVisualStyleBackColor = true;
            this.maxbut.Click += new System.EventHandler(this.maxbut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "По возрастанию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "По убыванию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(680, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.col);
            this.Controls.Add(this.maxbut);
            this.Controls.Add(this.minbut);
            this.Controls.Add(this.query);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colsize);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.asd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox col;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox colsize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox query;
        private System.Windows.Forms.Button minbut;
        private System.Windows.Forms.Button maxbut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

