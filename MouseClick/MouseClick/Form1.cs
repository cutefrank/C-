using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Runtime.InteropServices;//DllImport要加這行

namespace MouseClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "GetDoubleClickTime")]
        public extern static int GetDoubleClickTime(); //回傳int，以毫秒為單位

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "連按兩下滑鼠的時間間隔為：";
            label1.Text = GetDoubleClickTime() + "毫秒";//顯示連按兩下滑鼠的時間間隔
        }
    }
}
