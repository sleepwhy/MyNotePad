using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    internal class Shortcuts
    {
        private static Dictionary<Keys, Action<MainForm>> shortcutActions = new Dictionary<Keys, Action<MainForm>>();

        static Shortcuts()
        {
            /// File Shortcuts
            shortcutActions.Add(Keys.N | Keys.Control, form => FileClass.NewNote(form.MainRichTextBox));
            shortcutActions.Add(Keys.N | Keys.Shift | Keys.Control , form => FileClass.OpenNewWindow());
            shortcutActions.Add(Keys.O | Keys.Control, form => FileClass.OpenFile(form.MainRichTextBox));
            shortcutActions.Add(Keys.S | Keys.Control, form => FileClass.SaveFile(form.MainRichTextBox));
            shortcutActions.Add(Keys.E | Keys.Control, form => FileClass.ExitApplication());

            /// Edit Shortcuts
            shortcutActions.Add(Keys.F | Keys.Control, form => EditClass.openFindForm(form.MainRichTextBox));
            shortcutActions.Add(Keys.F5, form => EditClass.addTime(form.MainRichTextBox));

            /// Format Shortcuts
            shortcutActions.Add(Keys.G | Keys.Control, form => form.MainRichTextBox.WordWrap = !form.MainRichTextBox.WordWrap);
            shortcutActions.Add(Keys.F | Keys.Control | Keys.Shift, form => form.ChangeFont());

            /// Zoom Shortcuts
            shortcutActions.Add(Keys.F7 , form => ZoomClass.ZoomIn(form.MainRichTextBox));
            shortcutActions.Add(Keys.F8, form => ZoomClass.ZoomOut(form.MainRichTextBox));

            
        }

        public static void AllShortcuts(object sender, KeyEventArgs e, MainForm form)
        {

            var keyWithModifiers = e.KeyCode | e.Modifiers;

            if (shortcutActions.ContainsKey(keyWithModifiers))
            {
                shortcutActions[keyWithModifiers].Invoke(form);
                e.Handled = true;
            }
        }


    }
}
