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
using Modelo;
using Controlador;

namespace sigeci_angelitos_2
{
    public partial class ServiciosFormulario : Office2007Form
    {
        private ControladorServicio controladorServicio = ControladorServicio.Instancia();
        private ServiciosForm padre;
        private int modo;
        private Servicio servicio;

        public ServiciosFormulario(ServiciosForm serviciosForm, int modo, Servicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.padre = serviciosForm;
            this.modo = modo;
            if (modo == 2) //modificar
            {
                llenaFormularioServicio(servicio);
            }
            if (modo == 1) //ver
            {
                llenaFormularioServicio(servicio);
                bloqueaFormularioServicio();
                btnAceptar.Enabled = false;
            }
            else
                btnAceptar.Enabled = true;
        }

        private void bloqueaFormularioServicio()
        {

        }

        private void llenaFormularioServicio(Servicio servicio)
        {

        }
        
    }
}
