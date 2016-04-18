using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionPuntoDeVenta
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        SPSQL SQL = new SPSQL();
        int cbUnidadID;
        private void FormMenu_Load(object sender, EventArgs e)
        {
            SQL.BindComboTipoMenu(cbTipo);
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUnidadID = ((KeyValuePair<int, string>)cbTipo.SelectedItem).Key;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SQL.InsertNewMenuItem(cbUnidadID.ToString(), txtDesc.Text, txtPrecio.Text);
        }
    }
}
