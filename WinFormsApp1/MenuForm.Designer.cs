namespace WinFormsApp1
{
    partial class MenuForm
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
            UserSaveFormButton = new Button();
            UserListFormFormButton = new Button();
            SuspendLayout();
            // 
            // UserSaveFormButton
            // 
            UserSaveFormButton.Dock = DockStyle.Top;
            UserSaveFormButton.Location = new Point(0, 0);
            UserSaveFormButton.Name = "UserSaveFormButton";
            UserSaveFormButton.Size = new Size(541, 79);
            UserSaveFormButton.TabIndex = 0;
            UserSaveFormButton.Text = "ユーザー登録";
            UserSaveFormButton.UseVisualStyleBackColor = true;
            UserSaveFormButton.Click += button1_Click;
            // 
            // UserListFormFormButton
            // 
            UserListFormFormButton.Dock = DockStyle.Top;
            UserListFormFormButton.Location = new Point(0, 79);
            UserListFormFormButton.Name = "UserListFormFormButton";
            UserListFormFormButton.Size = new Size(541, 79);
            UserListFormFormButton.TabIndex = 1;
            UserListFormFormButton.Text = "ユーザーリスト";
            UserListFormFormButton.UseVisualStyleBackColor = true;
            UserListFormFormButton.Click += UserListFormFormButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 252);
            Controls.Add(UserListFormFormButton);
            Controls.Add(UserSaveFormButton);
            Name = "MenuForm";
            Text = "メニュー";
            ResumeLayout(false);
        }

        #endregion

        private Button UserSaveFormButton;
        private Button UserListFormFormButton;
    }
}