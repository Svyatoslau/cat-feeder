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
    public partial class AdminPageView : Form, IAdminPageView
    {
        public AdminPageView()
        {
            InitializeComponent();
        }

        public event Action ShowAdminRegFormView;
        public event Action ShowAdminMonitorFeedView;
        public event Action ShowAdminLogsFormView;
        public event Action ShowAdminTimetableView;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
