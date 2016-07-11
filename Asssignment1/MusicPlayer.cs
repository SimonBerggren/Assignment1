using System.Runtime.InteropServices;
using System.Text;

namespace Asssignment1
{
    /// <summary>
    /// Music player
    /// Loads, plays, pauses and stops music
    /// </summary>
    class MusicPlayer
    {
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string lpstrCommand, StringBuilder lpstrigReturnString, int uReturnlength, int hwndCallback);

        /// <summary>
        /// Constructor
        /// </summary>
        public MusicPlayer()
        {

        }

        /// <summary>
        /// Opens song to musicplayer
        /// </summary>
        /// <param name="path">Path to song to open</param>
        public void Open(string path)
        {
            mciSendString("stop song", null, 0, 0);
            string command = "open \"" + path + "\" type MPEGVideo alias song";
            mciSendString(command, null, 0, 0);
        }

        /// <summary>
        /// Restarts currently loaded song
        /// </summary>
        public void PlayFromStart()
        {
            mciSendString("play song from 0", null, 0, 0);
        }

        /// <summary>
        /// Stops currently loaded song
        /// </summary>
        public void Stop()
        {
            mciSendString("stop song", null, 0, 0);
        }

        /// <summary>
        /// Resumes currently loaded song
        /// </summary>
        public void Resume()
        {
            mciSendString("play song", null, 0, 0);
        }

        /// <summary>
        /// Closes musicplayer
        /// </summary>
        public void Close()
        {
            mciSendString("close song", null, 0, 0);
        }
    }
}