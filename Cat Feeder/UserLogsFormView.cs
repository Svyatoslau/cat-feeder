﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;

namespace Cat_Feeder
{
    public partial class UserLogsFormView : Form, IUserLogsFormVeiw
    {
        public UserLogsFormView()
        {
            InitializeComponent();
        }

        public event Action ChooseUser;
        public event Action ChooseLog;
        public event Action PrintAllLogs;
        public event Action ExportLogs;

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserLogsFormView_Load(object sender, EventArgs e)
        {

        }
    }
}
