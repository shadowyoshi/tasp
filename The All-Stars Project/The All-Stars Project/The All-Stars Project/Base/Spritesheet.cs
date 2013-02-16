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

        private Texture2D image;
        private string    path;
        
        private int startX; // Starting X position
        private int startY; // Starting Y position

        private Rectangle sheetPosition = new Rectangle();

        public Spritesheet(Texture2D __image, string __path, int __startX, int __startY)
        {
            
            path   = __path;
            startX = __startX;
            startY = __startY;

        }

        //public Texture2D Draw(GraphicsDevice graphicsDevice)
        //{

        //    //

        //}

    }

}
