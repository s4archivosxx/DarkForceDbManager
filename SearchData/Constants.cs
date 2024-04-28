using System;
using System.Drawing;
using System.Windows.Forms;

namespace SearchData
{
    public class Constants
    {
        /// <summary>
        /// Detecta si es que el objeto es nulo retornando verdadero sino falso
        /// </summary>
        /// <param name="value">objeto</param>
        /// <returns></returns>
        public bool DetectNull(Control control)
        {
            return string.IsNullOrWhiteSpace(control.Text) || control.Text == "0" ? true : false;
        }

        /// <summary>
        /// Detecta si es que el objeto es nulo retornando verdadero sino falso
        /// </summary>
        /// <param name="t">objeto</param>
        /// <returns></returns>
        public bool DetectNull(ToolStripMenuItem t)
        {
            return string.IsNullOrWhiteSpace(t.Text) || t.Text == "0" ? true : false;
        }

        public bool DetectNull(int value)
        {
            return value == 0 ? true : false;
        }

        public bool SetControlColor(Control control, Color b, Color f)
        {
            control.BackColor = b;
            control.ForeColor = f;
            control.Focus();
            return true;
        }

        public void SetControlEnabled(Control c, bool e)
        {
            c.Enabled = e;
        }

        public void SetControlEnabled(ToolStripMenuItem t, bool e)
        {
            t.Enabled = e;
        }

        /// <summary>
        /// Detecta si los objetos coinciden retornando verdadero sino falso
        /// </summary>
        /// <param name="value"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public bool DetectEquality(object value, object value2)
        {
            return value.Equals(value2);
        }
    }
}
