namespace WinFormsApp1
{
    partial class UserListForm
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
            UserDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)UserDataGrid).BeginInit();
            SuspendLayout();
            // 
            // UserDataGrid
            // 
            UserDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGrid.Dock = DockStyle.Fill;
            UserDataGrid.Location = new Point(0, 0);
            UserDataGrid.Name = "UserDataGrid";
            UserDataGrid.RowHeadersWidth = 51;
            UserDataGrid.Size = new Size(800, 450);
            UserDataGrid.TabIndex = 0;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserDataGrid);
            Name = "UserListForm";
            Text = "ユーザーリスト";
            ((System.ComponentModel.ISupportInitialize)UserDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UserDataGrid;
    }
}