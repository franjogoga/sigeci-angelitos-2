using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using DevComponents.DotNetBar;

namespace sigeci_angelitos_2
{
    public partial class CitasForm : Office2007Form
    {
        public CitasForm()
        {
            InitializeComponent();
        }

        private void CitasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
