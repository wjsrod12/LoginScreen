namespace LoginScreen
{
    partial class Form
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
            btnLogin = new Button();
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            lblErrorMsg = new Label();
            chkShow = new CheckBox();
            btnClearID = new Button();
            btnClearPW = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(183, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 46);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = SystemColors.Highlight;
            lblAppName.Location = new Point(182, 37);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(120, 50);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 18F);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(74, 115);
            txtID.Name = "txtID";
            txtID.Size = new Size(336, 39);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 18F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(74, 173);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(336, 39);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(72, 235);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(230, 15);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Location = new Point(74, 213);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(102, 19);
            chkShow.TabIndex = 5;
            chkShow.Text = "비밀번호 표시";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // btnClearID
            // 
            btnClearID.Location = new Point(416, 124);
            btnClearID.Name = "btnClearID";
            btnClearID.Size = new Size(25, 23);
            btnClearID.TabIndex = 6;
            btnClearID.Text = "x";
            btnClearID.UseVisualStyleBackColor = true;
            btnClearID.Click += btnClearID_Click;
            // 
            // btnClearPW
            // 
            btnClearPW.Location = new Point(416, 182);
            btnClearPW.Name = "btnClearPW";
            btnClearPW.Size = new Size(25, 23);
            btnClearPW.TabIndex = 7;
            btnClearPW.Text = "x";
            btnClearPW.UseVisualStyleBackColor = true;
            btnClearPW.Click += btnClearPW_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 380);
            Controls.Add(btnClearPW);
            Controls.Add(btnClearID);
            Controls.Add(chkShow);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Controls.Add(btnLogin);
            Name = "Form";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Label lblErrorMsg;
        private CheckBox chkShow;
        private Button btnClearID;
        private Button btnClearPW;
    }
}
