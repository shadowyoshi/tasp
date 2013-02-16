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

        public Rectangle rectangle = new Rectangle(0, 0, 32, 32);

        public Player(Texture2D __originSheet, Vector2 __playerPosition)
        {

            __originSheet    = playerSprite;
            __playerPosition = playerPosition;

        }

        public Texture2D Draw(GraphicsDevice graphicsDevice)
        {

            playerSprite = SERVICES.LoadFromFile("C:\\Users\\Joey\\Documents\\GitHub\\tasp\\The All-Stars Project\\The All-Stars Project\\The All-Stars Project\\smb3-goomba.png", graphicsDevice);

            return playerSprite;

        }

        public void Update() 
        {

            if (Keyboard.GetState().IsKeyDown(Keys.Left) == true)
            {

                playerVelocity = new Vector2(-1, 0);

            }

            else if (Keyboard.GetState().IsKeyDown(Keys.Right) == true)
            {

                playerVelocity = new Vector2(1, 0);

            }

            else
            {

                playerVelocity = Vector2.Zero;

            }

            playerPosition += playerVelocity;

        }

    }

}
