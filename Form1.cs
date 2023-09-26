namespace Account_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studno1 = studno.Text.ToString();
            string combox1 = cbProgram.Text.ToString();
            string lname1 = lname.Text.ToString();
            string fname1 = fname.Text.ToString();
            string mname1 = mname.Text.ToString();
            string age1 = age.Text.ToString();
            string contactno1 = contactno.Text.ToString();
            string address1 = address.Text.ToString();

            long studentNo;
            if (long.TryParse(studno1, out studentNo))
            {
                StudentInfoClass.StudentNo = studentNo;
            }
            else
            {
                MessageBox.Show("Invalid student number");
                return;
            }

            StudentInfoClass.Program = combox1;
            StudentInfoClass.LastName = lname1;
            StudentInfoClass.FirstName = fname1;
            StudentInfoClass.MiddleName = mname1;

            long ageValue;
            if (long.TryParse(age1, out ageValue))
            {
                StudentInfoClass.Age = ageValue;
            }
            else
            {
                MessageBox.Show("Invalid age");
                return;
            }

            long contactNo;
            if (long.TryParse(contactno1, out contactNo))
            {
                StudentInfoClass.ContactNo = contactNo;
            }
            else
            {
                MessageBox.Show("Invalid contact number");
                return;
            }

            StudentInfoClass.Address = address1;
            frmConfirm form2 = new();
            form2.FormClosed += (s, args) =>
            {
                studno.Text = "";
                cbProgram.Text = "";
                lname.Text = "";
                fname.Text = "";
                address.Text = "";
                mname.Text = "";
                age.Text = "";
                contactno.Text = "";
                
            };
            this.Hide();
            form2.ShowDialog();

        }
    }
}