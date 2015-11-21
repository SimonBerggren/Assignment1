using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Asssignment1
{
    class MusicPlayer
    {
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string lpstrCommand, StringBuilder lpstrigReturnString, int uReturnlength, int hwndCallback);

        public MusicPlayer()
        {

        }

        public void Open(string path)
        {
            mciSendString("stop song", null, 0, 0);
            string command = "open \"" + path + "\" type MPEGVideo alias song";
            mciSendString(command, null, 0, 0);
        }

        public void PlayFromStart()
        {
            mciSendString("play song from 0", null, 0, 0);
        }

        public void Stop()
        {
            mciSendString("stop song", null, 0, 0);
        }

        public void Resume()
        {
            mciSendString("play song", null, 0, 0);
        }

        public void Close()
        {
            mciSendString("close song", null, 0, 0);
        }
    }
}