using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Direccion : UserControl
    {
        public Direccion()
        {
            InitializeComponent();
        }

        


        public override string Text { get => textBox1.Text.ToLower(); set => textBox1.Text = value; }

        private void Direccion_Load(object sender, EventArgs e)
        {

        }
    }
}
