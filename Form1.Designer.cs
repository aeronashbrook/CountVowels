namespace CountVowels
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a paragraph of text. All vowels, uppercase and lowercase will be counted. Y" +
    " is not considered a vowel.";
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(30, 82);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextInput.Size = new System.Drawing.Size(392, 175);
            this.TextInput.TabIndex = 1;
            this.TextInput.TextChanged += new System.EventHandler(this.textChange);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextCount
            // 
            this.TextCount.Location = new System.Drawing.Point(160, 289);
            this.TextCount.Name = "TextCount";
            this.TextCount.ReadOnly = true;
            this.TextCount.Size = new System.Drawing.Size(67, 20);
            this.TextCount.TabIndex = 4;
            this.TextCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "vowels";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextCount;
        private System.Windows.Forms.Label label2;
    }
}

