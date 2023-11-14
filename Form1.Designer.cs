namespace ElectronicDigitalSignature
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.entryMassenge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.choiseMethod = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(284, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сообщение для ЭЦП";
            // 
            // entryMassenge
            // 
            this.entryMassenge.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryMassenge.Location = new System.Drawing.Point(12, 62);
            this.entryMassenge.Name = "entryMassenge";
            this.entryMassenge.Size = new System.Drawing.Size(776, 32);
            this.entryMassenge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(252, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Способ составления ЭЦП";
            // 
            // choiseMethod
            // 
            this.choiseMethod.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseMethod.FormattingEnabled = true;
            this.choiseMethod.Items.AddRange(new object[] {
            "алгоритм Эль-Гамаля",
            "алгоритм RSA"});
            this.choiseMethod.Location = new System.Drawing.Point(177, 167);
            this.choiseMethod.Name = "choiseMethod";
            this.choiseMethod.Size = new System.Drawing.Size(430, 35);
            this.choiseMethod.TabIndex = 3;
            this.choiseMethod.SelectedIndexChanged += new System.EventHandler(this.choiseMethod_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(322, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(12, 228);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(776, 117);
            this.result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choiseMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entryMassenge);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entryMassenge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox choiseMethod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
    }
}

