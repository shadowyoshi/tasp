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

        public enum playerState
        {

            normalLeft,
            normalRight,
            normalLeftWalking,
            normalRightWalking

        }
        
        public Spritesheet originSheet;
        
        public Texture2D playerSprite;
        public Vector2   playerPosition;
        public Vector2   playerVelocity;

        public bool moving;

        private GraphicsDevice graphicsDevice;
        private SpriteBatch spriteBatch;
        
        private int spriteWidth;
        private int spriteHeight;
        private int hitboxWidth;
        private int hitboxHeight;

        private float velocityX = 0;
        private float velocityY = 0;

        public Player(GraphicsDevice __graphicsDevice)
        {

            graphicsDevice = __graphicsDevice;

            spriteBatch    = new SpriteBatch(graphicsDevice);
            originSheet    = new Spritesheet(SERVICES.LoadImageFromFile("F:\\bg.png", graphicsDevice));
            playerPosition = new Vector2();

        }

        public void Draw(int id)
        {

            if (id == 2)
            {

                originSheet.sheetPosition.Width  = 16;
                originSheet.sheetPosition.Height = 16;
                originSheet.sheetPosition.X      = 340;
                originSheet.sheetPosition.Y      = 340;

            }

            else
            {

                originSheet.sheetPosition.Width  = 16;
                originSheet.sheetPosition.Height = 16;
                originSheet.sheetPosition.X      = 0;
                originSheet.sheetPosition.Y      = 0;

            }
            
            playerSprite = originSheet.LoadFrame(graphicsDevice, originSheet.sheetPosition.Width, originSheet.sheetPosition.Height);

            spriteBatch.Begin();
            spriteBatch.Draw(playerSprite, playerPosition, originSheet.sheetPosition, Color.White);
            spriteBatch.End();

        }

        public void Update() 
        {
            
            playerVelocity = new Vector2(velocityX, velocityY);
            
            if (Keyboard.GetState().IsKeyDown(Keys.Left) == true)
            {

                velocityX = -1;

                moving = true;

            }

            else if (Keyboard.GetState().IsKeyDown(Keys.Right) == true)
            {

                velocityX = 1;

                moving = true;

            }

            else
            {

                velocityX = 0;

                moving = false;

            }

            playerPosition += playerVelocity;

        }

    }

}
