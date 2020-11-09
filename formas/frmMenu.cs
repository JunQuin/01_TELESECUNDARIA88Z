using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_TELESECUNDARIA88Z.formas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                this.Close();
            }
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private MenuStrip menuStrip123;
        private ToolStripMenuItem controlDeAlumnosToolStripMenuItem;
        private ToolStripMenuItem nuevoAlumnoToolStripMenuItem;
        private ToolStripMenuItem alumnadoToolStripMenuItem;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private ToolStripMenuItem nuevoProfesorToolStripMenuItem;
        private ToolStripMenuItem listaProfesoresToolStripMenuItem;
        private ToolStripMenuItem controlAcademicoToolStripMenuItem;
        private ToolStripMenuItem listasDeGruposToolStripMenuItem;
        private ToolStripMenuItem constaciasToolStripMenuItem;
        private ToolStripMenuItem cobranzaToolStripMenuItem;
        private ToolStripMenuItem emisionDeReciboToolStripMenuItem;
        private ToolStripMenuItem reciboToolStripMenuItem;


        private void controlDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cobranzaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private ToolStripMenuItem profesoresToolStripMenuItem1;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem horariosToolStripMenuItem;
        private ToolStripMenuItem datosGeneralesToolStripMenuItem;
        private ToolStripMenuItem datosGeneralesToolStripMenuItem1;
    }
}
