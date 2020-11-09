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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlAcademicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasDeGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constaciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobranzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emisionDeReciboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosGeneralesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeAlumnosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.controlAcademicoToolStripMenuItem,
            this.cobranzaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlDeAlumnosToolStripMenuItem
            // 
            this.controlDeAlumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAlumnoToolStripMenuItem,
            this.alumnadoToolStripMenuItem,
            this.profesoresToolStripMenuItem1,
            this.materiasToolStripMenuItem,
            this.horariosToolStripMenuItem,
            this.datosGeneralesToolStripMenuItem,
            this.datosGeneralesToolStripMenuItem1});
            this.controlDeAlumnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controlDeAlumnosToolStripMenuItem.Image")));
            this.controlDeAlumnosToolStripMenuItem.Name = "controlDeAlumnosToolStripMenuItem";
            this.controlDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.controlDeAlumnosToolStripMenuItem.Text = "Registros";
            this.controlDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.controlDeAlumnosToolStripMenuItem_Click);
            // 
            // nuevoAlumnoToolStripMenuItem
            // 
            this.nuevoAlumnoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoAlumnoToolStripMenuItem.Image")));
            this.nuevoAlumnoToolStripMenuItem.Name = "nuevoAlumnoToolStripMenuItem";
            this.nuevoAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoAlumnoToolStripMenuItem.Text = "Alumnos";
            // 
            // alumnadoToolStripMenuItem
            // 
            this.alumnadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnadoToolStripMenuItem.Image")));
            this.alumnadoToolStripMenuItem.Name = "alumnadoToolStripMenuItem";
            this.alumnadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alumnadoToolStripMenuItem.Text = "Calificaciones";
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProfesorToolStripMenuItem,
            this.listaProfesoresToolStripMenuItem});
            this.profesoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profesoresToolStripMenuItem.Image")));
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.profesoresToolStripMenuItem.Text = "Informes";
            // 
            // nuevoProfesorToolStripMenuItem
            // 
            this.nuevoProfesorToolStripMenuItem.Name = "nuevoProfesorToolStripMenuItem";
            this.nuevoProfesorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoProfesorToolStripMenuItem.Text = "Listado de Alumnos";
            // 
            // listaProfesoresToolStripMenuItem
            // 
            this.listaProfesoresToolStripMenuItem.Name = "listaProfesoresToolStripMenuItem";
            this.listaProfesoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            // 
            // controlAcademicoToolStripMenuItem
            // 
            this.controlAcademicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasDeGruposToolStripMenuItem,
            this.constaciasToolStripMenuItem});
            this.controlAcademicoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controlAcademicoToolStripMenuItem.Image")));
            this.controlAcademicoToolStripMenuItem.Name = "controlAcademicoToolStripMenuItem";
            this.controlAcademicoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.controlAcademicoToolStripMenuItem.Text = "Utilerias";
            // 
            // listasDeGruposToolStripMenuItem
            // 
            this.listasDeGruposToolStripMenuItem.Name = "listasDeGruposToolStripMenuItem";
            this.listasDeGruposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            // 
            // constaciasToolStripMenuItem
            // 
            this.constaciasToolStripMenuItem.Name = "constaciasToolStripMenuItem";
            this.constaciasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            // 
            // cobranzaToolStripMenuItem
            // 
            this.cobranzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emisionDeReciboToolStripMenuItem,
            this.reciboToolStripMenuItem});
            this.cobranzaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cobranzaToolStripMenuItem.Image")));
            this.cobranzaToolStripMenuItem.Name = "cobranzaToolStripMenuItem";
            this.cobranzaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cobranzaToolStripMenuItem.Text = "Salir";
            this.cobranzaToolStripMenuItem.Click += new System.EventHandler(this.cobranzaToolStripMenuItem_Click);
            // 
            // emisionDeReciboToolStripMenuItem
            // 
            this.emisionDeReciboToolStripMenuItem.Name = "emisionDeReciboToolStripMenuItem";
            this.emisionDeReciboToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            // 
            // reciboToolStripMenuItem
            // 
            this.reciboToolStripMenuItem.Name = "reciboToolStripMenuItem";
            this.reciboToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            // 
            // profesoresToolStripMenuItem1
            // 
            this.profesoresToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("profesoresToolStripMenuItem1.Image")));
            this.profesoresToolStripMenuItem1.Name = "profesoresToolStripMenuItem1";
            this.profesoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.profesoresToolStripMenuItem1.Text = "Profesores";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("materiasToolStripMenuItem.Image")));
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("horariosToolStripMenuItem.Image")));
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horariosToolStripMenuItem.Text = "Horarios";
            // 
            // datosGeneralesToolStripMenuItem
            // 
            this.datosGeneralesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("datosGeneralesToolStripMenuItem.Image")));
            this.datosGeneralesToolStripMenuItem.Name = "datosGeneralesToolStripMenuItem";
            this.datosGeneralesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosGeneralesToolStripMenuItem.Text = "Localidades";
            // 
            // datosGeneralesToolStripMenuItem1
            // 
            this.datosGeneralesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("datosGeneralesToolStripMenuItem1.Image")));
            this.datosGeneralesToolStripMenuItem1.Name = "datosGeneralesToolStripMenuItem1";
            this.datosGeneralesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.datosGeneralesToolStripMenuItem1.Text = "Datos Generales";
            // 
            // frmMenu
            // 
            this.ClientSize = new System.Drawing.Size(625, 312);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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
