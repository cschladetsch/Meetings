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
            titleBox = new TextBox();
            richTextBox2 = new RichTextBox();
            comments = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1006, 171);
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
            // titleBox
            // 
            titleBox.Location = new Point(73, 3);
            titleBox.Name = "titleBox";
            titleBox.ReadOnly = true;
            titleBox.Size = new Size(949, 31);
            titleBox.TabIndex = 3;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(16, 289);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1006, 294);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox1_TextChanged;
            // 
            // comments
            // 
            comments.AutoSize = true;
            comments.Location = new Point(16, 248);
            comments.Name = "comments";
            comments.Size = new Size(99, 25);
            comments.TabIndex = 5;
            comments.Text = "Comments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 6;
            label1.Text = "Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 622);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 7;
            label2.Text = "Remaining";
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
            label3.Location = new Point(12, 622);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 7;
            label3.Text = "Time";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(85, 620);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(339, 34);
            progressBar1.TabIndex = 9;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(531, 618);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(231, 34);
            progressBar2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 667);
            ControlBox = false;
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comments);
            Controls.Add(richTextBox2);
            Controls.Add(titleBox);
            Controls.Add(nextButton);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Meeting";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button nextButton;
        private TextBox titleBox;
        private RichTextBox richTextBox2;
        private Label comments;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
    }
}
