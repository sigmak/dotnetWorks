using System;
using System.Linq;
using System.Windows.Forms;

namespace classTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisualStyleManager.AddStyle("ButtonStyle1", button1);

            //https://stackoverflow.com/questions/4630391/get-all-controls-of-a-specific-type
            foreach (var btn in this.Controls.OfType<Button>()) 
            {
                if (btn != button1)
                {
                    VisualStyleManager.ApplyStyle("ButtonStyle1", btn);
                }
            }
        }
    }
}
