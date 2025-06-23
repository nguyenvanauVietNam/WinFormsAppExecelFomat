using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppExecelFomat.View.MainScreen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MinimizeBox = false; // Ẩn nút Minimize
            this.MaximizeBox = false; // Ẩn nút Maximize
            this.FormBorderStyle = FormBorderStyle.None; // Ẩn header (thanh tiêu đề)
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }

        private void btn_ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();//Thoát ứng dụng
        }
    }
}
