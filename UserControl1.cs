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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private string _tittle;
        public string Title
        {
            get { return _tittle; } set { _tittle = value; label1.Text = value; }
        }
        private Image _icon;
        public Image Icon
        { get { return _icon; } set { _icon = value; pictureBox1.Image = value; } }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
