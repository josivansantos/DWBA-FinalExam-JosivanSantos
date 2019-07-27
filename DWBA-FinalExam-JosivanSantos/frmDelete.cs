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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void LblNumber_Click(object sender, EventArgs e)
        {

        }

        private void TxtTeamId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {            
            frmTeamManagement objFrmMenu = new frmTeamManagement();
            objFrmMenu.Show();
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtTeamId.Text == string.Empty)
            {
                MessageBox.Show("Please, type a TEAM ID!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                if (MessageBox.Show(" Are you sure you would like to delete TEAM: " + txtTeamId.Text + " ?", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=TournamentManager;User ID=josivan;Password=josivan");
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from Teams where TeamId = '" + txtTeamId.Text + "'";
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();                                        

                    MessageBox.Show("Record deleted successfully", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {                
                    txtTeamId.Clear();                    
                }
            }
        }

        private void FrmDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
