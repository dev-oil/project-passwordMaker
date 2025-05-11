namespace project_passwordMaker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_length = new System.Windows.Forms.Label();
            this.numeric_length = new System.Windows.Forms.NumericUpDown();
            this.check_upper = new System.Windows.Forms.CheckBox();
            this.check_number = new System.Windows.Forms.CheckBox();
            this.check_special = new System.Windows.Forms.CheckBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.text_password = new System.Windows.Forms.TextBox();
            this.button_copy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_length)).BeginInit();
            this.SuspendLayout();
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Location = new System.Drawing.Point(12, 31);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(81, 12);
            this.label_length.TabIndex = 0;
            this.label_length.Text = "비밀번호 길이";
            // 
            // numeric_length
            // 
            this.numeric_length.Location = new System.Drawing.Point(12, 55);
            this.numeric_length.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numeric_length.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numeric_length.Name = "numeric_length";
            this.numeric_length.Size = new System.Drawing.Size(120, 21);
            this.numeric_length.TabIndex = 1;
            this.numeric_length.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // check_upper
            // 
            this.check_upper.AutoSize = true;
            this.check_upper.Location = new System.Drawing.Point(14, 98);
            this.check_upper.Name = "check_upper";
            this.check_upper.Size = new System.Drawing.Size(124, 16);
            this.check_upper.TabIndex = 2;
            this.check_upper.Text = "대문자 포함 (A-Z)";
            this.check_upper.UseVisualStyleBackColor = true;
            // 
            // check_number
            // 
            this.check_number.AutoSize = true;
            this.check_number.Location = new System.Drawing.Point(14, 120);
            this.check_number.Name = "check_number";
            this.check_number.Size = new System.Drawing.Size(108, 16);
            this.check_number.TabIndex = 3;
            this.check_number.Text = "숫자 포함 (0-9)";
            this.check_number.UseVisualStyleBackColor = true;
            // 
            // check_special
            // 
            this.check_special.AutoSize = true;
            this.check_special.Location = new System.Drawing.Point(14, 142);
            this.check_special.Name = "check_special";
            this.check_special.Size = new System.Drawing.Size(142, 16);
            this.check_special.TabIndex = 4;
            this.check_special.Text = "특수문자 포함 (!@#$)";
            this.check_special.UseVisualStyleBackColor = true;
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(12, 181);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(325, 58);
            this.button_generate.TabIndex = 5;
            this.button_generate.Text = "비밀번호 생성";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(14, 283);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(325, 21);
            this.text_password.TabIndex = 6;
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(14, 310);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(325, 33);
            this.button_copy.TabIndex = 7;
            this.button_copy.Text = "복사";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 417);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.check_special);
            this.Controls.Add(this.check_number);
            this.Controls.Add(this.check_upper);
            this.Controls.Add(this.numeric_length);
            this.Controls.Add(this.label_length);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "비밀번호 생성기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.NumericUpDown numeric_length;
        private System.Windows.Forms.CheckBox check_upper;
        private System.Windows.Forms.CheckBox check_number;
        private System.Windows.Forms.CheckBox check_special;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Button button_copy;
    }
}
