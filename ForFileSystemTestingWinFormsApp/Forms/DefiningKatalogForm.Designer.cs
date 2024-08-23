namespace ForFileSystemTestingWinFormsApp.Forms
{
    partial class DefiningKatalogForm
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
            katalogMainTextBox = new TextBox();
            ReadyButton = new Button();
            SuspendLayout();
            // 
            // katalogMainTextBox
            // 
            katalogMainTextBox.BackColor = Color.White;
            katalogMainTextBox.BorderStyle = BorderStyle.FixedSingle;
            katalogMainTextBox.Font = new Font("Segoe UI", 10F);
            katalogMainTextBox.ForeColor = SystemColors.InfoText;
            katalogMainTextBox.Location = new Point(75, 135);
            katalogMainTextBox.Multiline = true;
            katalogMainTextBox.Name = "katalogMainTextBox";
            katalogMainTextBox.Size = new Size(369, 57);
            katalogMainTextBox.TabIndex = 32;
            katalogMainTextBox.Text = "Main katalog";
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
            ReadyButton.Location = new Point(356, 348);
            ReadyButton.Name = "ReadyButton";
            ReadyButton.Size = new Size(158, 54);
            ReadyButton.TabIndex = 33;
            ReadyButton.Text = "Start app";
            ReadyButton.UseVisualStyleBackColor = false;
            ReadyButton.Click += ReadyButton_Click;
            // 
            // DefiningKatalogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 414);
            Controls.Add(ReadyButton);
            Controls.Add(katalogMainTextBox);
            Name = "DefiningKatalogForm";
            Text = "DefiningKatalogForm";
            Load += DefiningKatalogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox katalogMainTextBox;
        public Button ReadyButton;
        //public static FolderBrowserDialog folderBrowserDialog1;
    }
}