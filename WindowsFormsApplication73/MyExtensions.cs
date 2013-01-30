using System;
using System.Windows.Forms;

namespace WindowsFormsApplication73
{
    public static class FormExtensions
    {
        public static DialogResult ShowWithTimeout(this Form form, TimeSpan timeout)
        {
            form.TopMost = true;
            form.AutoSize = true;
            var timoutTimer = new Timer
            {
                Interval = (int)timeout.TotalMilliseconds,
                Enabled = true
            };
            form.Disposed += delegate { timoutTimer.Dispose(); };
            timoutTimer.Tick += delegate
            {
                form.DialogResult = DialogResult.Abort;
                form.Close();
                Console.WriteLine("timed out");
            };
            return form.ShowDialog();
        }
    }
}