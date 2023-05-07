using System;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using sprint0.Content;
namespace sprint0.Sound
{
	public class PlaySoundEffects
    {
		private ContentManager myContent;
		private SoundEffect itemPickup;
        private SoundEffect keyPickup;
        private SoundEffect linkDeath;
		private SoundEffect pickTriforce;
		
        public PlaySoundEffects(ContentManager content)
		{
			myContent = content;
		}


		public void LoadContent()
		{
			itemPickup = myContent.Load<SoundEffect>("itempickup");
			linkDeath = myContent.Load<SoundEffect>("linkdeath");
			keyPickup = myContent.Load<SoundEffect>("keypickup");
		}

		public void ItemPickup()
		{
			itemPickup.Play();
		}


        public void KeyPickup()
        {
            keyPickup.Play();
        }

        public void LinkDeath()
        {
            linkDeath.Play();
        }

        public void PickTriforce()
        {

        }
    }
}

