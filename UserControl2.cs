﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHAT_WALLSHEET
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; label1.Text = value; AddHeighttext(); }
        }
        void AddHeighttext()
        {
            UserControl2 user = new UserControl2();
            user.BringToFront();
            label1.Height = Class1.GeTTextHeight(label1) + 10;
            user.Height = label1.Top + label1.Height;
            this.Height = user.Bottom + 10;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            AddHeighttext();
        }
    }
}
