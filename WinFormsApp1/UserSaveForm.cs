using System.Text;

namespace WinFormsApp1
{
    public partial class UserSaveForm : Form
    {
        public UserSaveForm()
        {
            InitializeComponent();
            StatusLabel.Text = "必要事項を入力して保存してください";
            EnableComboBox.Items.Add("有効");
            EnableComboBox.Items.Add("無効");
            EnableComboBox.SelectedIndex = 0;
            EnableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MailCheckBox.Checked = true;
            FreeRadioButton.Checked = true;
            SetMailAddressTextBox();

            PlanChange();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetMailAddressTextBox();

        }

        private void SetMailAddressTextBox()
        {
            MailAddressTextBox.Enabled = MailCheckBox.Checked;
            MailAddressLabel.Enabled = MailCheckBox.Checked;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BusinessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlanChange();
        }

        private void PlanChange()
        {
            NoteLabel.Visible = BusinessRadioButton.Checked;
        }

        private void FreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NoteLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("IDを入力してください",
                   "警告",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                IdTextBox.Focus();
                return;
            }
              
            if (IdTextBox.Text.Contains(","))
            {
                MessageBox.Show("IDにカンマは入力できません",
                   "警告",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                IdTextBox.Focus();
                return;
            }
            if (MailAddressTextBox.Text.Contains(","))
            {
                MessageBox.Show("メールアドレスにカンマは入力できません",
                    "警告",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                MailAddressTextBox.Focus();
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                "保存しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                using (var sw = new
                      System.IO.StreamWriter(
                      "save.csv",
                      true,
                      Encoding.
                     UTF8))
                {
                    sw.Write(IdTextBox.Text);
                    sw.Write(",");
                    sw.Write(MailCheckBox.Checked);
                    sw.Write(",");
                    sw.Write(MailAddressTextBox.Text);
                    sw.Write(",");
                    if (BusinessRadioButton.Checked)
                    {
                        sw.Write("1");
                    }
                    else
                    {
                        sw.Write("0");
                    }
                    sw.Write(",");

                    sw.Write(EnableComboBox.Text);
                    sw.WriteLine("");

                }
                StatusLabel.Text = "保存しました";
            }
            else if (dialogResult == DialogResult.No)
            {
                StatusLabel.Text = "キャンセルしました";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
