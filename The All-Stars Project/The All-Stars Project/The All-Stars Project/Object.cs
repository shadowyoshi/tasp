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

    class Object
    {

        /* Integer (whole number) properties of a generic object. See subclasses for more specific properties. */
        private int positionx;
        private int positiony;

        /* String (letters) properties of a generic object. See subclasses for more specific properties. */
        private string configlocation;
        private string graphiclocation;

        /* Constructor method. */
        public Object(int __positionx, int __positiony, string __configlocation, string __graphiclocation)
        {

            __positionx       = positionx;
            __positiony       = positiony;

            __configlocation  = configlocation;
            __graphiclocation = graphiclocation;

        }

        public Object LoadObject(int positionx, int positiony) // **I don't know whether or not this method is really necessary
        {

            return new Object(1, 2, "C:\\SMBX", "C:\\SMBX");

        }

    }

}
