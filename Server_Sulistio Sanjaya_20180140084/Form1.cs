﻿using ServiceMtk_P2_084;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Sulistio_Sanjaya_20180140084
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server Ob = new server();
            Ob.ON();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            server Ob = new server();
            Ob.OFF();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
