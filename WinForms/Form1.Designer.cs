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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            Next = new Button();
            ItemComments = new RichTextBox();
            comments = new Label();
            label1 = new Label();
            label2 = new Label();
            AddTime = new Button();
            label3 = new Label();
            TotalTimeProgress = new ProgressBar();
            CurrentItemProgress = new ProgressBar();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            ItemTitle = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 90);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1006, 171);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Next
            // 
            Next.Location = new Point(901, 553);
            Next.Name = "Next";
            Next.Size = new Size(112, 34);
            Next.TabIndex = 1;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = true;
            // 
            // ItemComments
            // 
            ItemComments.Location = new Point(12, 304);
            ItemComments.Name = "ItemComments";
            ItemComments.Size = new Size(1006, 222);
            ItemComments.TabIndex = 4;
            ItemComments.Text = "";
            ItemComments.TextChanged += richTextBox1_TextChanged;
            // 
            // comments
            // 
            comments.AutoSize = true;
            comments.Location = new Point(11, 269);
            comments.Name = "comments";
            comments.Size = new Size(99, 25);
            comments.TabIndex = 5;
            comments.Text = "Comments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 6;
            label1.Text = "Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 558);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 7;
            label2.Text = "Item Remaining";
            // 
            // AddTime
            // 
            AddTime.Location = new Point(783, 553);
            AddTime.Name = "AddTime";
            AddTime.Size = new Size(112, 34);
            AddTime.TabIndex = 8;
            AddTime.Text = "+3 mins";
            AddTime.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 558);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 7;
            label3.Text = "Time Left";
            // 
            // TotalTimeProgress
            // 
            TotalTimeProgress.Location = new Point(97, 553);
            TotalTimeProgress.Name = "TotalTimeProgress";
            TotalTimeProgress.Size = new Size(286, 34);
            TotalTimeProgress.TabIndex = 9;
            // 
            // CurrentItemProgress
            // 
            CurrentItemProgress.Location = new Point(546, 553);
            CurrentItemProgress.Name = "CurrentItemProgress";
            CurrentItemProgress.Size = new Size(231, 34);
            CurrentItemProgress.TabIndex = 10;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1038, 33);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // ItemTitle
            // 
            ItemTitle.AutoSize = true;
            ItemTitle.Location = new Point(66, 37);
            ItemTitle.Name = "ItemTitle";
            ItemTitle.Size = new Size(83, 25);
            ItemTitle.TabIndex = 12;
            ItemTitle.Text = "Item Text";
            ItemTitle.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 602);
            Controls.Add(ItemTitle);
            Controls.Add(toolStrip1);
            Controls.Add(CurrentItemProgress);
            Controls.Add(TotalTimeProgress);
            Controls.Add(AddTime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comments);
            Controls.Add(ItemComments);
            Controls.Add(Next);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Meeting";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button Next;
        private RichTextBox ItemComments;
        private Label comments;
        private Label label1;
        private Label label2;
        private Button AddTime;
        private Label label3;
        private ProgressBar TotalTimeProgress;
        private ProgressBar CurrentItemProgress;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private Label ItemTitle;
    }
}
