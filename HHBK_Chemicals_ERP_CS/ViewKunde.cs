﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS
{
    public partial class ViewKunde : Form, IViewKunde
    {
        private IModel model;
        private IControllerKunde controllerKunde;
        IModel IViewKunde.IModel1 { set => this.model=value; }
        IControllerKunde IViewKunde.IControllerKunde1 { set => this.controllerKunde=value; }

        public ViewKunde()
        {
            InitializeComponent();
        }

    }
}
