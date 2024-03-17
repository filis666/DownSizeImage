namespace imagedownsizer
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
            pictureBox1 = new PictureBox();
            SelectImageButton_Click = new Button();
            DownsizeButton_Click = new Button();
            DownscaleFactorTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(56, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(664, 342);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SelectImageButton_Click
            // 
            SelectImageButton_Click.Location = new Point(56, 390);
            SelectImageButton_Click.Name = "SelectImageButton_Click";
            SelectImageButton_Click.Size = new Size(212, 44);
            SelectImageButton_Click.TabIndex = 1;
            SelectImageButton_Click.Text = "select picture";
            SelectImageButton_Click.UseVisualStyleBackColor = true;
            SelectImageButton_Click.Click += SelectImageButton_Click_Click;
            // 
            // DownsizeButton_Click
            // 
            DownsizeButton_Click.Location = new Point(621, 403);
            DownsizeButton_Click.Name = "DownsizeButton_Click";
            DownsizeButton_Click.Size = new Size(112, 34);
            DownsizeButton_Click.TabIndex = 2;
            DownsizeButton_Click.Text = "downsize";
            DownsizeButton_Click.UseVisualStyleBackColor = true;
            DownsizeButton_Click.Click += DownsizeButton_Click_Click;
            // 
            // DownscaleFactorTextBox
            // 
            DownscaleFactorTextBox.Location = new Point(435, 403);
            DownscaleFactorTextBox.Name = "DownscaleFactorTextBox";
            DownscaleFactorTextBox.Size = new Size(150, 31);
            DownscaleFactorTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 362);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "0-100";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(DownscaleFactorTextBox);
            Controls.Add(DownsizeButton_Click);
            Controls.Add(SelectImageButton_Click);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button SelectImageButton_Click;
        private Button DownsizeButton_Click;
        private TextBox DownscaleFactorTextBox;
        private Label label1;
    }
}