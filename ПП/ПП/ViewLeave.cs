using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПП
{
    public partial class ViewLeave : Form
    {
        Functions Con;
        public ViewLeave()
        {
            InitializeComponent();
            Con = new Functions();
            EmpIdLbl.Text = Login.EmpId + "";
            EmpNameLbl.Text = Login.EmpName;
            ShowLeaves();
        }

        private void ShowLeaves()
        {
            string Query = "select * from LeaveTbl where Employee = {0} ";
            Query = string.Format(Query,Login.EmpId);
            LeaveList.DataSource = Con.GetData(Query);
        }

        private void ViewLeave_Load(object sender, EventArgs e)
        {

        }

        private void LeaveList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
