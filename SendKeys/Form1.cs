using SendKeys.BLL;
using SendKeys.BLL.ActiveWindow;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace SendKeys
{
    public partial class Form1 : Form
    {
        private ActiveWindowWatcher activeWindowWatcher;
        private ActiveWindowModel activeWindow = ActiveWindowModel.CreateEmpty();

        public Form1()
        {
            InitializeComponent();
            activeWindowWatcher = new ActiveWindowWatcher(TimeSpan.FromSeconds(1));
            activeWindowWatcher.ActiveWindowChanged += ActiveWindowWatcher_ActiveWindowChanged;
            activeWindowWatcher.Start();
        }

        private void ActiveWindowWatcher_ActiveWindowChanged(object sender, ActiveWindowChangedEventArgs e)
        {
            //activeWindow = ActiveWindowModel.Create(e.WindowHandle, e.WindowTitle);
            //lblCurrentlyActiveWindow.Text = $"Active Window: {e.WindowTitle}";
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            activeWindowWatcher.Stop();
            txtActiveWindow.Text = activeWindow.WindowTitle;
            txtWindowHandle.Text = activeWindow.WindowHandle.ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            WindowAPI.SendKeys(activeWindow.WindowHandle, rbtCTRL.Checked, rbtALT.Checked, cboLetter.Text);
        }





        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            WindowAPI.SendKeys(activeWindow.WindowHandle, e.KeyChar.ToString());
            WindowAPI.SetActiveWindow(Process.GetCurrentProcess().MainWindowHandle);
        }

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public IntPtr GetHandleWindow(string title)
        {
            return FindWindow(null, title);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (richTextBox1.SelectionStart < richTextBox1.Text.Length)
            {

                IntPtr handle = GetHandleWindow(txtActiveWindow.Text);
                txtWindowHandle.Text = handle != null ? handle.ToString() : "0";
                if (handle == null)
                    return;
                activeWindow = ActiveWindowModel.Create(handle, txtActiveWindow.Text);


                int cursorPosition = richTextBox1.SelectionStart;
                int lineIndex = richTextBox1.GetLineFromCharIndex(cursorPosition);
                string lineText = richTextBox1.Lines[lineIndex];
                richTextBox1.SelectionStart += lineText.Length + 1;
                lineText = lineText.Replace(' ', '\t');

                //MessageBox.Show(lineText);
                foreach (char c in lineText)
                    WindowAPI.SendKeys(handle, c.ToString());
                WindowAPI.SendKeys(handle, "\t");
                WindowAPI.SendKeys(handle, " ");
                Thread.Sleep(200);

                IntPtr handle2 = GetHandleWindow("Список обучающихся");
                WindowAPI.SendKeys(handle2, " ");

            }
            WindowAPI.SetActiveWindow(Process.GetCurrentProcess().MainWindowHandle);

        }
    }
}
