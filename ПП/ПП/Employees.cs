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
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmployees();
        }
        private void ShowEmployees()
        {
            string Query = "select * from EmployeeTbl";
            EmployeesList.DataSource = Con.GetData(Query);
        }

        private void Emloyees_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || PasswordTb.Text == "" || EmpGenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = EmpGenCb.SelectedItem.ToString();
                    string Phone = EmpPhoneTb.Text;
                    string Pass = PasswordTb.Text;
                    string Add = AddTb.Text;
                    string Query = "update  EmployeeTbl set EmpName = '{0}', EmpGen = '{1}',EmpPhone = '{2}',EmpPass = '{3}',EmpAdd = '{4}' where EmpId = {5}";
                    Query = string.Format(Query, Name, Gender, Phone, Pass, Add, Key);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Updated!!!");
                    EmpNameTb.Text = "";
                    EmpPhoneTb.Text = "";
                    PasswordTb.Text = "";
                    AddTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void CategoriesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeesList.SelectedRows[0].Cells[1].Value.ToString();
            EmpGenCb.Text = EmployeesList.SelectedRows[0].Cells[2].Value.ToString();
            EmpPhoneTb.Text = EmployeesList.SelectedRows[0].Cells[3].Value.ToString();
            PasswordTb.Text = EmployeesList.SelectedRows[0].Cells[4].Value.ToString();
            AddTb.Text = EmployeesList.SelectedRows[0].Cells[5].Value.ToString();
            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeesList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CapNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == ""|| EmpPhoneTb.Text ==""|| PasswordTb.Text == "" || EmpGenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = EmpGenCb.SelectedItem.ToString();
                    string Phone = EmpPhoneTb.Text;
                    string Pass = PasswordTb.Text;
                    string Add = AddTb.Text;
                    string Query = "insert into EmployeeTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, Name, Gender,Phone,Pass,Add);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Added!!!");
                    EmpNameTb.Text = "";
                    EmpPhoneTb.Text = "";
                    PasswordTb.Text = "";
                    AddTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || PasswordTb.Text == "" || EmpGenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                   
                    string Query = "delete from  EmployeeTbl  where EmpId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Deleted!!!");
                    EmpNameTb.Text = "";
                    EmpPhoneTb.Text = "";
                    PasswordTb.Text = "";
                    AddTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void categoryLbl_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();  
            Obj.Show();
            this.Hide();    
        }

        private void LeaveLbl_Click(object sender, EventArgs e)
        {
           Leaves Obj = new Leaves();
            Obj.Show();
            this.Hide();
        }
    }
}
