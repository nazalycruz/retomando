using Pract.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region EVENT
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            openContactsDetails();
        }
        #endregion

        #region PRIVATE METHODS 
        private void openContactsDetails()
        {
            //se agrega la referencia de gui para tener acceso a la capa de presentacion
            ContactDetails contDet = new ContactDetails();
            contDet.ShowDialog();
        }
        #endregion
    }
}
