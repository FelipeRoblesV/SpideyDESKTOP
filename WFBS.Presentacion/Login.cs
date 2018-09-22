using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


using System.Threading;

namespace WFBS.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lbl_error.Text = "";
            lbl_pass.Text = "";
            lbl_user.Text = "";

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wsmg, int wparam, int lparam);


        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int contado = 1;
            if (txt_user.Text.Trim() == "USUARIO")
            {
                lbl_user.Text = "Ingrese datos en usuario porfavor";
            }
            else
            {
                contado++;
                lbl_user.Text = "";
            }

            if (txt_pass.Text.Trim() == "CONTRASEÑA")
            {
                lbl_pass.Text = "Ingrese datos en contraseña porfavor";
            }
            else
            {
                contado++;
                lbl_pass.Text = "";
            }

            if (contado == 3)
            {
                try
                {
                    WSReference.MainWSClient WS = new WSReference.MainWSClient();
                    WSReference.clUsuario usu = new WSReference.clUsuario();
                    usu.run = int.Parse(txt_user.Text);
                    usu.pass = txt_pass.Text;
                    if (WS.Login_Administrador(usu))
                    {
                        int rol = WS.recuperar_rol_login(usu);

                        if (rol != 3)
                        {
                            lbl_error.Text = "Usuario no tiene permisos para ingresar.";
                        }
                        else
                        {
                            try
                            {
                                //FormularioPrincipal ini = new FormularioPrincipal();
                                //ini.Show();
                            }
                            catch (Exception ex)
                            {

                                lbl_error.Text = ex.Message;
                            }
                            finally
                            {
                                this.Hide();
                            }
                       
                           
                        }
                    }


                    else { lbl_error.Text = "Credenciales incorrectos"; }
                }
                
                catch (Exception ex)
                {

                    lbl_error.Text = ex.Message ;
                }

            }
        }

        private void txt_user_Enter_1(object sender, EventArgs e)
        {
            if (txt_user.Text == "USUARIO")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.Snow;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "USUARIO";
                txt_user.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "CONTRASEÑA")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.Snow;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "CONTRASEÑA";
                txt_pass.ForeColor = Color.WhiteSmoke;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_Login.validarUsuario(e);
        }

        private void lbl_error_Click(object sender, EventArgs e)
        {

        }
    }
}
