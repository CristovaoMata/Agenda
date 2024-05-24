using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MessageBoxCustomizada;

namespace MessageBoxCustomizada
{
    public abstract class CMMessageBox
    {

        public static DialogResult Show(string text)
        {
            DialogResult resultado;
            using (var msgForm = new FormMessageBox(text))
                resultado = msgForm.ShowDialog();
            return resultado;
        }
        public static DialogResult Show(string text, string caption)
        {
            DialogResult resultado;
            using (var msgForm = new FormMessageBox(text,caption))
                resultado = msgForm.ShowDialog();
            return resultado;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult resultado;
            using (var msgForm = new FormMessageBox(text, caption, buttons))
                resultado = msgForm.ShowDialog();
            return resultado;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult resultado;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon))
                resultado = msgForm.ShowDialog();
            return resultado;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult resultado;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon, defaultButton))
                resultado = msgForm.ShowDialog();
            return resultado;
        }



        public static DialogResult Show(IWin32Window owner, string text)
        {
            DialogResult resultado;
            using (var msgForm = new FormMessageBox(text))
                resultado = msgForm.ShowDialog(owner);
            return resultado;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            DialogResult resultado;
            using (var msgForm = new FormMessageBox(text, caption))
                resultado = msgForm.ShowDialog(owner);
            return resultado;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult resultado;
            using (var msgForm = new FormMessageBox(text, caption, buttons))
                resultado = msgForm.ShowDialog(owner);
            return resultado;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult resultado;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon))
                resultado = msgForm.ShowDialog(owner);
            return resultado;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult resultado;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon, defaultButton))
                resultado = msgForm.ShowDialog(owner);
            return resultado;
        }


    }
}
