namespace WinFormsApp1
{
    partial class UserSaveForm
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
            Idlabel = new Label();
            IdTextBox = new TextBox();
            MailCheckBox = new CheckBox();
            MailAddressTextBox = new TextBox();
            MailAddressLabel = new Label();
            groupBox1 = new GroupBox();
            BusinessRadioButton = new RadioButton();
            FreeRadioButton = new RadioButton();
            NoteLabel = new Label();
            EnableComboBox = new ComboBox();
            panel1 = new Panel();
            CloseButton = new Button();
            SaveButton = new Button();
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Idlabel
            // 
            Idlabel.AutoSize = true;
            Idlabel.Location = new Point(46, 38);
            Idlabel.Name = "Idlabel";
            Idlabel.Size = new Size(24, 20);
            Idlabel.TabIndex = 0;
            Idlabel.Text = "ID";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(139, 38);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 1;
            IdTextBox.TextChanged += IdTextBox_TextChanged;
            // 
            // MailCheckBox
            // 
            MailCheckBox.AutoSize = true;
            MailCheckBox.Location = new Point(46, 98);
            MailCheckBox.Name = "MailCheckBox";
            MailCheckBox.Size = new Size(128, 24);
            MailCheckBox.TabIndex = 2;
            MailCheckBox.Text = "メールを送信する";
            MailCheckBox.UseVisualStyleBackColor = true;
            MailCheckBox.CheckedChanged += MailCheckBox_CheckedChanged;
            // 
            // MailAddressTextBox
            // 
            MailAddressTextBox.Location = new Point(139, 147);
            MailAddressTextBox.Name = "MailAddressTextBox";
            MailAddressTextBox.Size = new Size(125, 27);
            MailAddressTextBox.TabIndex = 4;
            MailAddressTextBox.TextChanged += textBox1_TextChanged;
            // 
            // MailAddressLabel
            // 
            MailAddressLabel.AutoSize = true;
            MailAddressLabel.Location = new Point(35, 150);
            MailAddressLabel.Name = "MailAddressLabel";
            MailAddressLabel.Size = new Size(87, 20);
            MailAddressLabel.TabIndex = 3;
            MailAddressLabel.Text = "メールアドレス";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BusinessRadioButton);
            groupBox1.Controls.Add(FreeRadioButton);
            groupBox1.Location = new Point(46, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 68);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "プラン";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BusinessRadioButton
            // 
            BusinessRadioButton.AutoSize = true;
            BusinessRadioButton.Location = new Point(127, 23);
            BusinessRadioButton.Name = "BusinessRadioButton";
            BusinessRadioButton.Size = new Size(75, 24);
            BusinessRadioButton.TabIndex = 6;
            BusinessRadioButton.TabStop = true;
            BusinessRadioButton.Text = "ビジネス";
            BusinessRadioButton.UseVisualStyleBackColor = true;
            BusinessRadioButton.CheckedChanged += BusinessRadioButton_CheckedChanged;
            // 
            // FreeRadioButton
            // 
            FreeRadioButton.AutoSize = true;
            FreeRadioButton.Location = new Point(6, 23);
            FreeRadioButton.Name = "FreeRadioButton";
            FreeRadioButton.Size = new Size(60, 24);
            FreeRadioButton.TabIndex = 0;
            FreeRadioButton.TabStop = true;
            FreeRadioButton.Text = "無料";
            FreeRadioButton.UseVisualStyleBackColor = true;
            FreeRadioButton.CheckedChanged += FreeRadioButton_CheckedChanged;
            // 
            // NoteLabel
            // 
            NoteLabel.AutoSize = true;
            NoteLabel.Location = new Point(42, 298);
            NoteLabel.Name = "NoteLabel";
            NoteLabel.Size = new Size(116, 20);
            NoteLabel.TabIndex = 6;
            NoteLabel.Text = "無制限で使えます";
            NoteLabel.Click += NoteLabel_Click;
            // 
            // EnableComboBox
            // 
            EnableComboBox.FormattingEnabled = true;
            EnableComboBox.Location = new Point(46, 336);
            EnableComboBox.Name = "EnableComboBox";
            EnableComboBox.Size = new Size(151, 28);
            EnableComboBox.TabIndex = 7;
            EnableComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(SaveButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 361);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 76);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // CloseButton
            // 
            CloseButton.Dock = DockStyle.Left;
            CloseButton.Location = new Point(94, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 76);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "閉じる";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += button2_Click;
            // 
            // SaveButton
            // 
            SaveButton.Dock = DockStyle.Left;
            SaveButton.Location = new Point(0, 0);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 76);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel });
            statusStrip1.Location = new Point(0, 437);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(880, 26);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(151, 20);
            StatusLabel.Text = "toolStripStatusLabel1";
            // 
            // UserSaveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 463);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(EnableComboBox);
            Controls.Add(NoteLabel);
            Controls.Add(groupBox1);
            Controls.Add(MailAddressTextBox);
            Controls.Add(MailAddressLabel);
            Controls.Add(MailCheckBox);
            Controls.Add(IdTextBox);
            Controls.Add(Idlabel);
            Name = "UserSaveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ユーザー登録";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Idlabel;
        private TextBox IdTextBox;
        private CheckBox MailCheckBox;
        private TextBox MailAddressTextBox;
        private Label MailAddressLabel;
        private GroupBox groupBox1;
        private RadioButton FreeRadioButton;
        private RadioButton BusinessRadioButton;
        private Label NoteLabel;
        private ComboBox EnableComboBox;
        private Panel panel1;
        private Button CloseButton;
        private Button SaveButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
    }
}
