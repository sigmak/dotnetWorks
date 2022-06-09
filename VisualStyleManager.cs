using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace classTest1
{
    /// <summary>
    /// 사용법:
    // private void button1_Click(object sender, EventArgs e)
    // {
    //    VisualStyleManager.AddStyle("ButtonStyle1", button1);
    //
    //    //https://stackoverflow.com/questions/4630391/get-all-controls-of-a-specific-type
    //    foreach (var btn in this.Controls.OfType<Button>())
    //    {
    //        if (btn != button1)
    //        {
    //            VisualStyleManager.ApplyStyle("ButtonStyle1", btn);
    //        }
    //    }
    // }
    /// </summary>


    public static class VisualStyleManager
    {
        //public static Dictionary<string, VisualStyle> StyleDictionary { set; get; }
        //https://stackoverflow.com/questions/313324/declare-a-dictionary-inside-a-static-class
        public static IDictionary<string, VisualStyle> StyleDictionary { set; get; }
        = new Dictionary<string, VisualStyle>();

        public static void AddStyle(string name, Control control)
        {
            StyleDictionary.Add(name, new VisualStyle(control));
        }

        public static void ApplyStyle(string stylename, Control control)
        {
            //VisualStyle vs;
            //if (StyleDictionary.TryGetValue(stylename, out VisualStyle vs))
            if (StyleDictionary.TryGetValue(stylename, out VisualStyle vs))
            {
                control.BackColor = vs.CBackColor;
                control.ForeColor = vs.CForeColor;
                control.Font = vs.CFont;
            }
        }
    }

    public class VisualStyle
    {
        public Color CBackColor { set; get; }
        public Color CForeColor { set; get; }

        public Font CFont { set; get; }

        public VisualStyle(Control control)
        {
            CBackColor = control.BackColor;
            CForeColor = control.ForeColor;
            CFont = control.Font;
        }
    }
}
