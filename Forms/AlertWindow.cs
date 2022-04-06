﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.WindowsForms
{
    public partial class AlertWindow : Form
    {
        public AlertWindow()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
            Application.OpenForms[1].Close();
            QuestionWindow.index = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
