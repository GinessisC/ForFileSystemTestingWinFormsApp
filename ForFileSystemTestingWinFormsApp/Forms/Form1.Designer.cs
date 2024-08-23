namespace ForFileSystemTestingWinFormsApp
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
            monthesComboBox = new ComboBox();
            ReadyButton = new Button();
            daysTextBox = new TextBox();
            SuspendLayout();
            // 
            // monthesComboBox
            // 
            monthesComboBox.BackColor = Color.FromArgb(74, 79, 99);
            monthesComboBox.Font = new Font("Segoe UI", 12F);
            monthesComboBox.ForeColor = SystemColors.ScrollBar;
            monthesComboBox.FormattingEnabled = true;
            monthesComboBox.Items.AddRange(new object[] { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" });
            monthesComboBox.Location = new Point(216, 211);
            monthesComboBox.Name = "monthesComboBox";
            monthesComboBox.Size = new Size(297, 36);
            monthesComboBox.TabIndex = 29;
            monthesComboBox.Text = "Month";
            monthesComboBox.KeyDown += monthesComboBox_KeyDown;
            // 
            // ReadyButton
            // 
            ReadyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ReadyButton.BackColor = Color.FromArgb(24, 30, 54);
            ReadyButton.BackgroundImageLayout = ImageLayout.None;
            ReadyButton.FlatStyle = FlatStyle.Flat;
            ReadyButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ReadyButton.ForeColor = Color.Chartreuse;
            ReadyButton.Location = new Point(525, 428);
            ReadyButton.Name = "ReadyButton";
            ReadyButton.Size = new Size(158, 54);
            ReadyButton.TabIndex = 30;
            ReadyButton.Text = "Ready";
            ReadyButton.UseVisualStyleBackColor = false;
            ReadyButton.Click += ReadyButton_Click;
            // 
            // daysTextBox
            // 
            daysTextBox.BackColor = Color.FromArgb(74, 79, 99);
            daysTextBox.BorderStyle = BorderStyle.None;
            daysTextBox.Font = new Font("Segoe UI", 12F);
            daysTextBox.ForeColor = SystemColors.ScrollBar;
            daysTextBox.Location = new Point(216, 107);
            daysTextBox.Multiline = true;
            daysTextBox.Name = "daysTextBox";
            daysTextBox.Size = new Size(297, 36);
            daysTextBox.TabIndex = 31;
            daysTextBox.Text = "Day";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 45, 59);
            ClientSize = new Size(720, 519);
            Controls.Add(daysTextBox);
            Controls.Add(ReadyButton);
            Controls.Add(monthesComboBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public ComboBox monthesComboBox;
        public Button ReadyButton;
        public TextBox daysTextBox;
    }
}