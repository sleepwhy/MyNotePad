using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    internal class ZoomClass
    {
        public static void ZoomIn(RichTextBox mainRichTextBox)
        {
            if (mainRichTextBox.ZoomFactor * 2 < 64)
            {
                mainRichTextBox.ZoomFactor *= 2;
            }
            
        }
        public static void ZoomOut(RichTextBox mainRichTextBox)
        {
            if (mainRichTextBox.ZoomFactor / 2 > 0.05)
            {
                mainRichTextBox.ZoomFactor /= 2;
            }

        }
    }
}
