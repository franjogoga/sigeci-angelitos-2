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
    public partial class UsuariosForm : Office2007Form
    {
        private PrincipalForm principalForm;
        public UsuariosForm(PrincipalForm principalForm)
        {
            InitializeComponent();
            this.principalForm = principalForm;
        }

        private void UsuariosForm_FormClosing(object sender, FormClosingEventArgs e)
        {            
            this.Dispose();
        }
    }
}
