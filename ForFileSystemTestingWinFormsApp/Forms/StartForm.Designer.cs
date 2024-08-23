namespace ForFileSystemTestingWinFormsApp.Forms
{
    partial class StartForm
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
            ReadyButton = new Button();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // ReadyButton
            // 
            ReadyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ReadyButton.BackColor = Color.White;
            ReadyButton.BackgroundImageLayout = ImageLayout.None;
            ReadyButton.FlatAppearance.BorderSize = 2;
            ReadyButton.FlatStyle = FlatStyle.Flat;
            ReadyButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ReadyButton.ForeColor = Color.Black;
            ReadyButton.Location = new Point(232, 227);
            ReadyButton.Name = "ReadyButton";
            ReadyButton.Size = new Size(141, 52);
            ReadyButton.TabIndex = 34;
            ReadyButton.Text = "Choose file";
            ReadyButton.UseVisualStyleBackColor = false;
            ReadyButton.Click += ReadyButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(121, 55);
            label1.Name = "label1";
            label1.Size = new Size(352, 23);
            label1.TabIndex = 35;
            label1.Text = "Choose file in which project was downloaded\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(157, 114);
            label2.Name = "label2";
            label2.Size = new Size(302, 46);
            label2.TabIndex = 36;
            label2.Text = "NOTE: path should end on \r\n/ForFileSystemTestingWinFormsApp";
            // 
            // folderBrowserDialog1
            // 
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 312);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReadyButton);
            Name = "StartForm";
            Text = "StartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button ReadyButton;
        private Label label1;
        private Label label2;
        public static FolderBrowserDialog folderBrowserDialog1;
    }
}