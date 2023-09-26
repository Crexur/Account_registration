using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Account_registration.StudentInfoClass;

namespace Account_registration
{
    public partial class frmConfirm : Form
    {

        public delegate string DelegateText();
        public delegate long DelegateNumber();
        private DelegateText getTextDelegate;
        private DelegateText getLastNameDelegate;
        private DelegateText getFirstNameDelegate;
        private DelegateText getMiddleNameDelegate;
        private DelegateText getAddressDelegate;
        private DelegateNumber getAgeDelegate;
        private DelegateNumber getContactNoDelegate;
        private DelegateNumber getStudentNoDelegate;

        public frmConfirm()
        {
            InitializeComponent();
            this.FormClosing += frmConfirm_FormClosing;
            getTextDelegate = StudentInfoClass.GetProgram;
            getLastNameDelegate = StudentInfoClass.GetLastName;
            getFirstNameDelegate = StudentInfoClass.GetFirstName;
            getMiddleNameDelegate = StudentInfoClass.GetMiddleName;
            getAddressDelegate = StudentInfoClass.GetAddress;
            getAgeDelegate = StudentInfoClass.GetAge;
            getContactNoDelegate = StudentInfoClass.GetContactNo;
            getStudentNoDelegate = StudentInfoClass.GetStudentNo;
            

        }

        private void frmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            lblProgram.Text = getTextDelegate.Invoke();
            lblLastName.Text = getLastNameDelegate.Invoke();
            lblFirstName.Text = getFirstNameDelegate.Invoke();
            lblMiddleName.Text = getMiddleNameDelegate.Invoke();
            lblAddress.Text = getAddressDelegate.Invoke();
            lblAge.Text = getAgeDelegate.Invoke().ToString();
            lblContactNo.Text = getContactNoDelegate.Invoke().ToString();
            lblStudentNo.Text = getStudentNoDelegate.Invoke().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
