using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment1
{
    class MusicPlayer
    {
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string lpstrCommand, StringBuilder lpstrigReturnString, int uReturnlength, int hwndCallback);

        public void Open(string path)
        {
            mciSendString("stop song", null, 0, 0);
            string command = "open \"" + path + "\" type MPEGVideo alias song";
            mciSendString(command, null, 0, 0);
            mciSendString("play song", null, 0, 0);
        }

        public void Play()
        {
            mciSendString("play song", null, 0, 0);
        }

        public void Stop()
        {
            mciSendString("stop song", null, 0, 0);
            mciSendString("close song", null, 0, 0);
        }
    }
}
