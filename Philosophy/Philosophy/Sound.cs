using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Philosophy
{
   static  class Musics
    {

       static bool enabled = true;

       static SoundPlayer soundfail = new SoundPlayer(Properties.Resources.Apocalyptica___Ruska);

        public static void play_sound()
        {
            if (enabled==true)
            {
                soundfail.Play();
            }
        }

        public static void sound_on()
        {
            enabled = true;
            soundfail.Play();
        }
        public static void sound_off()
        {
            enabled = false;
            soundfail.Stop();
        }

    }
}
