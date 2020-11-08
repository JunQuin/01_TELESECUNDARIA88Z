using _01_TELESECUNDARIA88Z.clases;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_TELESECUNDARIA88Z.formas
{
    public partial class frmLogin : Form
    {
        string sNivel;
        string sUserName;
        string dtDateTimeA;
        string dtDateTimeM;
        string dtDateTimeD;
        string dtDateTimeH;

        clases.conexion objConexion;
        MySqlConnection mySqlConex;
        public frmLogin()
        {
            InitializeComponent();
            txtUser.Focus();
            lblCargando.Visible = false;
            txtPassword.Enabled = false;
            btningresar.Enabled = false;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            dateTime.ToString("yyyy-MM-dd H:mm:ss");
            objConexion = new clases.conexion();
            mySqlConex = new MySqlConnection(objConexion.conn());
            mySqlConex.Open();
            string mySqlQuery = "UPDATE usuarios SET us_fecha = @us_fecha WHERE usuarios.us_login = @us_login";
            MySqlCommand mySqlCommand = new MySqlCommand(mySqlQuery, mySqlConex);
            mySqlCommand.Parameters.Clear();
            mySqlCommand.Parameters.AddWithValue("@us_fecha", dateTime);
            mySqlCommand.Parameters.AddWithValue("@us_login", txtUser.Text);
            mySqlCommand.ExecuteNonQuery();

            formas.frmMenu frmMenu = new frmMenu();
            frmMenu.Text = "TELESECUNDARIA#88Z ver. 0.1.23.1" + "       " + "USUARIO: " + sUserName + "       " + "NIVEL: " + txtNivel.Text;
            MessageBox.Show("Bienvenido al sistema: " + sUserName + " " + "Nivel: " + txtNivel.Text);
            frmMenu.ShowDialog();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(txtUser.Text.Trim()))
                {
                    MessageBox.Show("ESTE CAAMPO NO PUEDE SER NULO!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Clear();
                    txtUser.Focus();
                }
                else
                {
                    lblCargando.Visible = true;
                    objConexion = new clases.conexion();
                    mySqlConex = new MySqlConnection(objConexion.conn());
                    mySqlConex.Open();
                    string mySqlQuery = "select * from usuarios where us_login = @us_login;";
                    MySqlCommand mySqlCommand = new MySqlCommand(mySqlQuery, mySqlConex);
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.AddWithValue("@us_login", txtUser.Text);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    if (mySqlDataReader.Read())
                    {
                        sUserName = mySqlDataReader["us_nombre"].ToString();
                        sNivel = mySqlDataReader["us_nivel"].ToString();
                        /*dtDateTime = Convert.ToDateTime(mySqlDataReader["us_fecha"]).ToString("dd/MM/yyyy/HHmmss");*/
                        dtDateTimeA = Convert.ToDateTime(mySqlDataReader["us_fecha"]).ToString("yyyy");
                        dtDateTimeM = Convert.ToDateTime(mySqlDataReader["us_fecha"]).ToString("MMMM");
                        dtDateTimeD = Convert.ToDateTime(mySqlDataReader["us_fecha"]).ToString("dd");
                        dtDateTimeH = Convert.ToDateTime(mySqlDataReader["us_fecha"]).ToString("h:mm:ss tt");

                        if (sNivel == "1")
                        {
                            txtNivel.Text = "Administrador";
                        }
                        else if (sNivel == "2")
                        {
                            txtNivel.Text = "Operador";
                        }
                        //dateTimePicker1.Value = Convert.ToDateTime(dtDateTime);
                        txtDateTime.Text = dtDateTimeD + " de " + dtDateTimeM + " del " + dtDateTimeA + ", " + dtDateTimeH;
                        txtPassword.Enabled = true;
                        txtPassword.Focus();
                        txtUser.Enabled = false;

                        try
                        {
                            MemoryStream memoryStream = new MemoryStream((byte[])mySqlDataReader["us_imagen"]);
                            Bitmap bitmap = new Bitmap(memoryStream);
                            pboxUser.Image = bitmap;
                        }
                        catch
                        {
                            var bitmap = new Bitmap(_01_TELESECUNDARIA88Z.Properties.Resources.usuario);
                            pboxUser.Image = bitmap;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario Invalido!","Usuario No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUser.Clear();
                        txtUser.Focus();
                    }
                    mySqlConex.Close();
                    lblCargando.Visible = false;
                }
            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                txtUser.Clear();
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                txtPassword.Clear();
                txtUser.Clear();
                txtNivel.Clear();
                txtDateTime.Clear();
                txtUser.Enabled = true;
                txtPassword.Enabled = false;
                var bitmap = new Bitmap(_01_TELESECUNDARIA88Z.Properties.Resources.usuario);
                pboxUser.Image = bitmap;
                txtUser.Focus();
                lblCargando.Visible = false;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {                
                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    MessageBox.Show("ESTE CAMPO NO PUEDE SER NULO!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
                var source = txtPassword.Text;             
                using (var md5Hash = MD5.Create())
                {
                    // Byte array representation of source string
                    var sourceBytes = Encoding.UTF8.GetBytes(source);

                    // Generate hash value(Byte Array) for input data
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);

                    // Convert hash byte array to string
                    var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                    // Output the MD5 hash
                    // Console.WriteLine("The MD5 hash of " + source + " is: " + hash);
                    source = hash;
                }
                objConexion = new clases.conexion();
                mySqlConex = new MySqlConnection(objConexion.conn());
                mySqlConex.Open();
                string mySqlQuery = "select * from usuarios where us_login = @us_login and us_password = @us_password;";
                MySqlCommand mySqlCommand = new MySqlCommand(mySqlQuery, mySqlConex);
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.AddWithValue("@us_login", txtUser.Text);
                mySqlCommand.Parameters.AddWithValue("@us_password", source);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    txtPassword.Enabled = false;
                    btningresar.Enabled = true;
                    btningresar.Focus();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                mySqlConex.Close();
            }
        }

        private void btningresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                txtNivel.Clear();
                txtPassword.Clear();
                txtUser.Clear();
                txtDateTime.Clear();
                txtPassword.Enabled = false;
                btningresar.Enabled = false;
                txtUser.Enabled = true;
                txtUser.Focus();
                lblCargando.Visible = false;
                var bitmap = new Bitmap(_01_TELESECUNDARIA88Z.Properties.Resources.usuario);
                pboxUser.Image = bitmap;
            }
        }
    }
}