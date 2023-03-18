using System;
using NAudio.Wave;
using Pacman.Models;

namespace Pacman.Controllers
{
    class MediaController
    {
        private static MediaController controller;
        private IWavePlayer waveOutDevice;

        public static MediaController Get()
        {
            if (controller == null)
                controller = new MediaController();
            return controller;
        }

        private MediaController()
        {
            waveOutDevice = new WaveOut();
            MemoryStream mp3file = new MemoryStream(Properties.Resources.DeathSquad);
            Mp3FileReader audioFileReader = new Mp3FileReader(mp3file);
            waveOutDevice.Init(audioFileReader);
        }

        public void Update(SoundSettings soundSettings)
        {
            waveOutDevice.Volume = soundSettings.Volume / 100.0f;
            if (soundSettings.isEnable && waveOutDevice.PlaybackState != PlaybackState.Playing)
            {
                waveOutDevice.Play();
            }
            else if (!soundSettings.isEnable)
            {
                waveOutDevice.Stop();
            }
        }
    }
}
