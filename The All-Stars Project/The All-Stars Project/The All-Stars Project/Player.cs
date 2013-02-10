using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace TASP
{

    class Player
    {

        public Texture2D playerSprite;
        public Vector2   playerPosition;
        
        private int spritewidth;
        private int spriteheight;
        private int hitboxwidth;
        private int hitboxheight;

        public Player(Texture2D __playerSprite, Vector2 __playerPosition)
        {

            __playerSprite   = playerSprite;
            __playerPosition = playerPosition;

        }

    }

}
