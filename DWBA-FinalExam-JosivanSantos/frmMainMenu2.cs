﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWBA_FinalExam_JosivanSantos
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {            
            frmTeamManagement objFrmMenu = new frmTeamManagement();
            objFrmMenu.Show();
        }

        private void BtnExitSetup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
