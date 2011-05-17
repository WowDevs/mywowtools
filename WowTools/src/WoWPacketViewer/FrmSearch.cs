using System;
using System.Windows.Forms;

namespace WoWPacketViewer
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        public void FindNext()
        {
            var frmView = Owner as ISupportFind;
            var opcode = textBox1.Text;
            if (frmView != null && !String.IsNullOrEmpty(opcode))
                frmView.Search(opcode, radioButton1.Checked, !checkBox1.Checked);
        }

        private void FrmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                Owner.Activate();
            }
        }
    }
}
