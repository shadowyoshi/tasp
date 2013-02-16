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

namespace TASP.Backend
{
    
    class SERVICES
    {

        /* LoadFromFile is a shortcut for loading an image from a file (thanks Celarix). */
        public static Texture2D LoadFromFile(string path, GraphicsDevice graphicsDevice)
        {

            if (!path.EndsWith(".png")) throw new ArgumentException(path + " is not a PNG image file. Please convert or remake the image using an image editor such as Paint.NET.");
            if (!File.Exists(path))     throw new FileNotFoundException(path + " was not found. Please check the location of the file and try again.");

            using (Stream stream = File.OpenRead(path))
            {

                return Texture2D.FromStream(graphicsDevice, stream);

            }

        }

    }

}
