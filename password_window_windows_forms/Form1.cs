namespace password_window_windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';  
            UpdateCharacterCount();  

          
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyPress += txtPassword_KeyPress;
            txtPassword.KeyDown += txtPassword_KeyDown;
        }


      
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true; 
            }
        }

     
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                UpdateCharacterCount();  
            }
        }

        
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateCharacterCount();  
        }

      
        private void UpdateCharacterCount()
        {
          
            if (lblCharCount != null)
            {
                lblCharCount.Text = $"Символів: {txtPassword.Text.Length}";
            }
        }

        
        private void lblCharCount_Click(object sender, EventArgs e)
        {
           
        }
    }
}
