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

namespace TASP.Base
{
    
    class Spritesheet
    {

        private Texture2D   originImage;
        private Texture2D[] frames;

        public Rectangle sheetPosition = new Rectangle();

        public Spritesheet(Texture2D __originImage)
        {

            originImage = __originImage;

        }

        public Texture2D LoadFrame(GraphicsDevice graphicsDevice, int width, int height)
        {
            
            Texture2D frame = new Texture2D(graphicsDevice, width, height);

            frame = SERVICES.LoadImageFromFile("F:\\bg.png", graphicsDevice);

            return frame;

        }

    }

}
