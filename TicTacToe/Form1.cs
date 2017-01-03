using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool _is_click = true;
        int _click_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button _btn = (Button)sender;
            if (_is_click)
                _btn.Text = "X";
            else
                _btn.Text = "O";
            _is_click = !_is_click;
            _btn.Enabled = false;
            _click_count++;
            _winner();
        }
        private void _winner()
        {
            bool _win = false;
            if ((a11.Text == a12.Text) && (a12.Text == a13.Text)&&(!a11.Enabled))
                _win = true;
            else if ((a21.Text == a22.Text) && (a22.Text == a23.Text) && (!a21.Enabled))
                _win = true;
            else if ((a31.Text == a32.Text) && (a32.Text == a33.Text) && (!a31.Enabled))
                _win = true;
            else if ((a11.Text == a21.Text) && (a21.Text == a31.Text) && (!a11.Enabled))
                _win = true;
            else if ((a12.Text == a22.Text) && (a22.Text == a32.Text) && (!a12.Enabled))
                _win = true;
            else if ((a13.Text == a23.Text) && (a23.Text == a33.Text) && (!a13.Enabled))
                _win = true;
            else if ((a11.Text == a22.Text) && (a22.Text == a33.Text) && (!a11.Enabled))
                _win = true;
            else if ((a33.Text == a22.Text) && (a22.Text == a11.Text) && (!a33.Enabled))
                _win = true;
            if (_win)
            {
                _disable_btn();
                string _winner = "";
                if (_is_click)
                    _winner = "O";
                else
                    _winner = "X";
                MessageBox.Show(_winner + " 赢了", "结果");
            }
            else
            {
                if (9 == _click_count)
                {
                    MessageBox.Show("平局","结果");
                }
            }

        }
        private void _disable_btn()
        {
            try { 
            foreach (Control c in Controls)
            {
                Button _btn = (Button)c;
                _btn.Enabled = false;
            }
            }
            catch{}
        }
        private void ReStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _is_click = true;
            _click_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button _btn = (Button)c;
                    _btn.Enabled = true;
                    _btn.Text = "";
                }
            }
            catch { }
        }
        
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("by " + System.Web.HttpUtility.HtmlDecode("\u5f20\u9759") + "\n\n" + System.Web.HttpUtility.HtmlDecode("&#49;&#54;&#52;&#48;&#53;&#48;&#57;&#48;&#49;&#48;&#55;"), System.Web.HttpUtility.HtmlDecode("\u8bbe\u8ba1\u6a21\u5f0f\u4f5c\u4e1a"));
        }
    }
}
