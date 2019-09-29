using System.Drawing;
using System.Windows.Forms;

namespace WinFormAlingment
{
    public static class Align
    {
        public static void TopRight(Control form, int left = 30, int top = 30)
        {
            form.Left = (Screen.PrimaryScreen.Bounds.Width - form.Width - left);
            form.Top = top;
        }

        public static void TopLeft(Control form, int left = 30, int top = 30)
        {
            form.Location = new Point(left, top);
        }

        public static void BottomRight(Control form, int left = 30, int top = 30)
        {
            form.Left = (Screen.PrimaryScreen.WorkingArea.Size.Width - form.Width) - left;
            form.Top = (Screen.PrimaryScreen.WorkingArea.Size.Height - form.Height) - top;
        }

        public static void BottomLeft(Control form, int left = 30, int top = 30)
        {
            Rectangle workingArea = Screen.GetWorkingArea(form);
            form.Location = new Point(left, Screen.PrimaryScreen.WorkingArea.Bottom - (form.Height + top));
        }
    }
}

