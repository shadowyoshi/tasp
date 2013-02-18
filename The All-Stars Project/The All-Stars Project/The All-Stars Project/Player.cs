using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using TASP;
using TASP.Backend;
using TASP.Base;

namespace TASP
{

    class Player
    {

        public Spritesheet originSheet;
        
        public Texture2D playerSprite;
        public Vector2   playerPosition;
        public Vector2   playerVelocity;
        
        private int spriteWidth;
        private int spriteHeight;
        private int hitboxWidth;
        private int hitboxHeight;

        private float velocityX = 0;
        private float velocityY = 0;

        public Rectangle rectangle = new Rectangle(0, 0, 32, 32);

        public Player(Spritesheet __originSheet, Vector2 __playerPosition)
        {

            originSheet    = __originSheet;
            playerPosition = __playerPosition;

        }

        public Texture2D Draw(GraphicsDevice graphicsDevice)
        {

            originSheet  = new Spritesheet(SERVICES.LoadFromFile("F:\\bg.png", graphicsDevice), 0, 0);
            playerSprite = new Texture2D(graphicsDevice, 16, 16);

            return playerSprite;

        }

        public void Update() 
        {

            playerVelocity = new Vector2(velocityX, velocityY);
            
            if (Keyboard.GetState().IsKeyDown(Keys.Left) == true)
            {

                velocityX = -1;

            }

            else if (Keyboard.GetState().IsKeyDown(Keys.Right) == true)
            {

                velocityX = 1;

            }

            else
            {

                velocityX = 0;

            }

            playerPosition += playerVelocity;

        }

    }

}
