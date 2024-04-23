namespace WinFormsApp1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            richTextBox1 = new RichTextBox();
            nextButton = new Button();
            timerText = new TextBox();
            titleBox = new TextBox();
            richTextBox2 = new RichTextBox();
            comments = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 66);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1022, 236);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(915, 617);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(112, 34);
            nextButton.TabIndex = 1;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            // 
            // timerText
            // 
            timerText.Location = new Point(646, 617);
            timerText.Name = "timerText";
            timerText.ReadOnly = true;
            timerText.Size = new Size(104, 31);
            timerText.TabIndex = 2;
            // 
            // titleBox
            // 
            titleBox.Location = new Point(85, 16);
            titleBox.Name = "titleBox";
            titleBox.ReadOnly = true;
            titleBox.Size = new Size(949, 31);
            titleBox.TabIndex = 3;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 333);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1022, 278);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // comments
            // 
            comments.AutoSize = true;
            comments.Location = new Point(12, 305);
            comments.Name = "comments";
            comments.Size = new Size(99, 25);
            comments.TabIndex = 5;
            comments.Text = "Comments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 6;
            label1.Text = "Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 620);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 7;
            label2.Text = "Remianing";
            // 
            // button1
            // 
            button1.Location = new Point(785, 617);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "+3 mins";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 617);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 7;
            label3.Text = "Time";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 614);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(154, 31);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 667);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comments);
            Controls.Add(richTextBox2);
            Controls.Add(titleBox);
            Controls.Add(textBox1);
            Controls.Add(timerText);
            Controls.Add(nextButton);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Meeting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button nextButton;
        private TextBox timerText;
        private TextBox titleBox;
        private RichTextBox richTextBox2;
        private Label comments;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
    }
}
