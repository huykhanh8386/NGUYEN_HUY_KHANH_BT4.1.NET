namespace Baitap4._1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            btnLogin = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            SuspendLayout();

            lblUsername.Text = "Username";
            lblUsername.Location = new System.Drawing.Point(30,30);

            txtUsername.Name = "txtUsername";
            txtUsername.Location = new System.Drawing.Point(120,27);

            lblPassword.Text = "Password";
            lblPassword.Location = new System.Drawing.Point(30,70);

            txtPassword.Name = "txtPassword";
            txtPassword.Location = new System.Drawing.Point(120,67);

            chkShowPassword.Text = "Show Password";
            chkShowPassword.Location = new System.Drawing.Point(120,105);
            chkShowPassword.CheckedChanged += new System.EventHandler(chkShowPassword_CheckedChanged);

            btnLogin.Text = "Login";
            btnLogin.Name = "btnLogin";
            btnLogin.Location = new System.Drawing.Point(120,150);
            btnLogin.Click += new System.EventHandler(btnLogin_Click);

            btnExit.Text = "Exit";
            btnExit.Name = "btnExit";
            btnExit.Location = new System.Drawing.Point(220,150);
            btnExit.Click += new System.EventHandler(btnExit_Click);

            AcceptButton = btnLogin;
            CancelButton = btnExit;

            Controls.AddRange(new System.Windows.Forms.Control[] {
                lblUsername,lblPassword,txtUsername,txtPassword,
                chkShowPassword,btnLogin,btnExit
            });

            Text = "Login Form";
            ClientSize = new System.Drawing.Size(400,230);
            ResumeLayout(false);
        }
    }
}
