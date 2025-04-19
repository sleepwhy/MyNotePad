using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    internal class StatusStrp
    {
        public static string findLineAndRow(RichTextBox textBox)
        {
            if (textBox.Text.Length == 0)
            {
                return "Ln: 0, Column: 0";
            }

            // İmlecin bulunduğu karakter konumu
            int selectionIndex = textBox.SelectionStart;

            // Satır numarasını doğrudan alabiliyoruz
            int line = textBox.GetLineFromCharIndex(selectionIndex);

            // Satırın başlangıcındaki karakter indeksini al
            int lineStartIndex = textBox.GetFirstCharIndexFromLine(line);

            // Sütun = imleç index'i - satır başlangıç index'i
            int column = selectionIndex - lineStartIndex;

            return $"Ln: {line + 1}, Column: {column + 1}";
        }




    }
}
