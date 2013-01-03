using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

/// TASP Source Code
/// 2012-2013 Joey Miller (Shadow Yoshi), et. al
/// 
/// http://tasp.stardustfields.net (see the Wiki for detailed documentation)

namespace TASP
{

    public class Program : Microsoft.Xna.Framework.Game
    {

        public GraphicsDeviceManager graphics;
        public SpriteBatch           spriteBatch;

        public Program()
        {

            graphics                           = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth  = 256;
            graphics.PreferredBackBufferHeight = 224;

        }

        /* This is where TASP will initialize. */
        protected override void Initialize()
        {

            base.Initialize();

        }

        /* Looks like we should load all the content, right? */
        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        /* We gotta unload it too, I guess. */
        protected override void UnloadContent()
        {



        }

        /* Logic is fed to TASP here so it doesn't argue with you like a 12 year old boy. */
        protected override void Update(GameTime gameTime)
        {

            base.Update(gameTime);

        }

        /* TASP will draw itself here. */
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        /* This is where TASP will run. */
        static void Main(string[] args)
        {

            using (Program TASP = new Program())
            {

                TASP.Run();

            }

        }

    }

}