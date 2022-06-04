using System;
using System.Media;
using System.Windows.Forms;

namespace GoToBed
{
    public static class GoToBedRoutines
    {

        public static SoundPlayer goToBedPlayer = null;

        public static void InitializeSound()
        {

            try
            {
                goToBedPlayer = new SoundPlayer(Properties.Resources.goToBed);
            } catch (Exception) { }

        }

        // Sexer.


        private static IntPtr progman = W32.FindWindow("Progman", null);
        private static IntPtr result = IntPtr.Zero;
        public static IntPtr workerW = IntPtr.Zero;

        public static void InitializeBackgroundWindow()
        {
            W32.SendMessageTimeout(progman,
                       0x052C,
                       new IntPtr(0),
                       IntPtr.Zero,
                       W32.SendMessageTimeoutFlags.SMTO_NORMAL,
                       1000,
                       out result);
            W32.EnumWindows(new W32.EnumWindowsProc((tophandle, topparamhandle) =>
            {
                IntPtr p = W32.FindWindowEx(tophandle,
                                            IntPtr.Zero,
                                            "SHELLDLL_DefView",
                                            IntPtr.Zero);
                if (p != IntPtr.Zero)
                {
                    workerW = W32.FindWindowEx(IntPtr.Zero,
                                               tophandle,
                                               "WorkerW",
                                               IntPtr.Zero);
                }
                return true;
            }), IntPtr.Zero);
        }

        public static void CreateSexerWindow(ref Form formObject)
        {

            formObject = new Sexer();
            formObject.Text = "";
            formObject.Size = Screen.PrimaryScreen.Bounds.Size;
            formObject.Location = new System.Drawing.Point(0, 0);
            formObject.FormBorderStyle = FormBorderStyle.None;
            formObject.ShowInTaskbar = false;

            W32.SetParent(formObject.Handle, workerW);

        }

        public static void DisposeSexer(ref Form formObject)
        {
            W32.SendMessage(progman, 0x0034, 4, IntPtr.Zero);
        }

    }

}
