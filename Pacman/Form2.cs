using System;
using Pacman.Models;
using Pacman.Controllers;

namespace Pacman
{
    public partial class Form2 : Form
    {
        private Form returnForm;
        private SoundSettings soundSettings;

        public Form2(Form form)
        {
            returnForm = form;
            InitializeComponent();
            soundSettings = GameDbContext.GetContext().GetSoundSettings();
            SoundCheckBox.Checked = soundSettings.isEnable;
            SoundTrackBar.Value = soundSettings.Volume/100;
        }

        private void SoundButtonSubmit_Click(object sender, EventArgs e)
        {
            GameDbContext.GetContext().UpdateSoundSettings(soundSettings);
            Close();
        }

        private void SoundTrackBar_Scroll(object sender, EventArgs e)
        {
            soundSettings.Volume = SoundTrackBar.Value;
            MediaController.Get().Update(soundSettings);
        }

        private void SoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            soundSettings.isEnable = SoundCheckBox.Checked;
            MediaController.Get().Update(soundSettings);
        }

        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            returnForm.Enabled = true;
        }
    }
}
