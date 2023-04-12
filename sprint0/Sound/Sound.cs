using System;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Content;
using sprint0;

namespace sprint0.Sound
{
	public class Sound
	{
        private Song backgroundMusic;
        private Game1 game;
        public Sound()
		{
            backgroundMusic = game.Content.Load<Song>("dungeonmusic");
            MediaPlayer.Play(backgroundMusic);
            MediaPlayer.IsRepeating = true;
            MediaPlayer.MediaStateChanged += MediaPlayer_MediaStateChanged;
        }

        private void MediaPlayer_MediaStateChanged(object sender, EventArgs e)
        {
            MediaPlayer.Volume -= 0.1f;
            MediaPlayer.Play(backgroundMusic);
        }
    
	}
}

