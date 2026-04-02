namespace LoginScreen
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
                txtPW.UseSystemPasswordChar = false;
            }
        }

        string myID = "admin";
        string myPW = "superman";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;
            if (inputID == myID && inputPW == myPW)
            {
                lblErrorMsg.Visible = false;
                MessageBox.Show("로그인 성공!");
            }
            else
            {
                //MessageBox.Show("로그인 실패~");
                //MessageBox.Show("로그인에 실패하였습니다.", "다시 시도하세요", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMsg.Visible = true;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPW.Focus();
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPW.UseSystemPasswordChar = !chkShow.Checked;
            }

        }

        private void btnClearID_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtID.Focus();
        }

        private void btnClearPW_Click(object sender, EventArgs e)
        {
            txtPW.Clear();
            txtPW.Focus();
        }
    }
}
