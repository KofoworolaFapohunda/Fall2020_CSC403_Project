using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public static class BgdTrack
    {
        public static SoundPlayer bgdTrackPlayer;
        private static bool isBackgroundTrackPlaying = false;

        static BgdTrack()
        {
            // Initialize the background music player
            bgdTrackPlayer = new SoundPlayer(Resources.AssassinsCreed2); // Name of choice track in the Resources is used
        }
        public static void PlayBackgroundTrack()
        {
            if (bgdTrackPlayer != null && !isBackgroundTrackPlaying)
            {
                bgdTrackPlayer.PlayLooping();
                isBackgroundTrackPlaying = true;
            }
        }
        public static void StopBackgroundTrack()
        {
            if (bgdTrackPlayer != null && isBackgroundTrackPlaying)
            {
                bgdTrackPlayer.Stop();
                isBackgroundTrackPlaying = false;
            }
        }
    }
}