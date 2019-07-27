using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DWBA_FinalExam_JosivanSantos
{
    public partial class frmTeamManagement : Form
    {
        public frmTeamManagement()
        {
            InitializeComponent();
        }

        public void loadDataGrid()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=TournamentManager;User ID=josivan;Password=josivan");
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Teams order by TeamName Asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            sqlcon.Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {           
                if (txtTeamName.Text == string.Empty)
                {
                    MessageBox.Show("Please, type a NAME!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtCoachName.Text == string.Empty)
                {
                    MessageBox.Show("Please, type a COACH NAME!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtDirectorName.Text == string.Empty)
                {
                    MessageBox.Show("Please, type a DIRECTOR NAME!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtAddressLine1.Text == string.Empty)
                {
                    MessageBox.Show("Please, type an ADDRESS!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtAddressLine2.Text == string.Empty)
                {
                    MessageBox.Show("Please, type a COMPLEMENT!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (txtPostCode.Text == string.Empty)
                {
                    MessageBox.Show("Please, type a POST-CODE!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtCity.Text == string.Empty)
                {
                    MessageBox.Show("Please, type a CITY!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtContactNumber.Text == string.Empty)
                {
                    MessageBox.Show("Please, type a CONTACT NUMBER!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (txtEmailAddress.Text == string.Empty)
                {
                    MessageBox.Show("Please, type an E-MAIL!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=TournamentManager;User ID=josivan;Password=josivan");
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into Teams values ('" + txtTeamName.Text + "','" + txtCoachName.Text + "','" + txtDirectorName.Text + "', '" + txtAddressLine1.Text + "', '" + txtAddressLine2.Text + "', '" + txtPostCode.Text + "','" + txtCity.Text + "','" + txtContactNumber.Text + "','" + txtEmailAddress.Text + "','Josivan Santos')";
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MessageBox.Show("Record inserted successfully!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtTeamId.Clear();
                    txtTeamName.Clear();
                    txtCoachName.Clear();
                    txtDirectorName.Clear();
                    txtAddressLine1.Clear();
                    txtAddressLine2.Clear();
                    txtPostCode.Clear();
                    txtCity.Clear();
                    txtContactNumber.Clear();
                    txtEmailAddress.Clear();

                    loadDataGrid();
                }            
            } 
            private void FrmTeamManagement_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu objFrmMenu = new MainMenu();
            objFrmMenu.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtAddressLine1.Clear();
            txtAddressLine2.Clear();
            txtCity.Clear();
            txtCoachName.Clear();
            txtContactNumber.Clear();            
            txtDirectorName.Clear();
            txtEmailAddress.Clear();
            txtPostCode.Clear();
            txtTeamId.Clear();
            txtTeamName.Clear();

            txtTeamId.Enabled = false;

            btnUpdate.Enabled = false;
            btnBack.Enabled = true;
            btnExit.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For update, please, fill all filds in the form and click on UPDATE BUTTON", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btnEdit.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnBack.Enabled = false;
            btnExit.Enabled = false;
            btnInsert.Enabled = false;

            txtTeamId.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");            

            if (txtTeamName.Text == string.Empty)
            {
                MessageBox.Show("Please, type a NAME!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtCoachName.Text == string.Empty)
            {
                MessageBox.Show("Please, type a COACH NAME!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtDirectorName.Text == string.Empty)
            {
                MessageBox.Show("Please, type a DIRECTOR NAME!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAddressLine1.Text == string.Empty)
            {
                MessageBox.Show("Please, type an ADDRESS!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAddressLine2.Text == string.Empty)
            {
                MessageBox.Show("Please, type a COMPLEMENT!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (txtPostCode.Text == string.Empty)
            {
                MessageBox.Show("Please, type a POST-CODE!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtCity.Text == string.Empty)
            {
                MessageBox.Show("Please, type a CITY!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtContactNumber.Text == string.Empty)
            {
                MessageBox.Show("Please, type a CONTACT NUMBER!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtEmailAddress.Text == string.Empty)
            {
                MessageBox.Show("Please, type an E-MAIL!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Update Teams set TeamName = '" + txtTeamName.Text + "' , CoachName = '" + txtCoachName.Text + "' , DirectorName = '" + txtDirectorName.Text + "', AddressLine1 = '" + txtAddressLine1.Text + "', AddressLine2 = '" + txtAddressLine2.Text + "', PostCode = '" + txtPostCode.Text + "', City = '" + txtCity.Text + "', ContactNumber = '" + txtContactNumber.Text + "', EmailAddress = '" + txtEmailAddress.Text + "' WHERE TeamId =  '" + txtTeamId.Text + "' ";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                txtTeamId.Enabled = false;

                txtAddressLine1.Clear();
                txtAddressLine2.Clear();
                txtCity.Clear();
                txtCoachName.Clear();
                txtContactNumber.Clear();                
                txtDirectorName.Clear();
                txtEmailAddress.Clear();
                txtPostCode.Clear();
                txtTeamId.Clear();
                txtTeamName.Clear();

                btnDelete.Enabled = false;
                btnBack.Enabled = true;
                btnUpdate.Enabled = false;
                btnExit.Enabled = true;
                btnCancel.Enabled = true;
                btnEdit.Enabled = true;
                btnInsert.Enabled = true;

                MessageBox.Show("Record updated successfully", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadDataGrid();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDelete objFrmMenu = new frmDelete();
            objFrmMenu.Show();           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDelete objFrmMenu = new frmDelete();
            objFrmMenu.Show();
        }
    }
}
