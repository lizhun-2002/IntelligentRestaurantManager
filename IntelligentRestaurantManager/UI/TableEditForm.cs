﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntelligentRestaurantManager.BLL;
using IntelligentRestaurantManager.Model;

namespace IntelligentRestaurantManager.UI
{
    public partial class TableEditForm : Form
    {
        public TableEditForm()
        {
            InitializeComponent();
        }
        public TableEditForm(Table table)
        {
            InitializeComponent();
        }
    }
}
