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

namespace Matricula
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconoMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconoMin.Visible = true;
            iconoMax.Visible = false;
        }

        private void iconoMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconoMin.Visible = false;
            iconoMax.Visible = true;
        }

        private void iconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelSup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelMostrar.Controls.Count > 0)
                this.panelMostrar.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelMostrar.Controls.Add(fh);
            this.panelMostrar.Tag = fh;
            fh.Show();

            Console.WriteLine("Hola");
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmAlumnos());
        }
    }
}
