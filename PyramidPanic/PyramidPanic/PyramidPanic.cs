// Met using kan je een XNA codebibliotheek toevoegen en gebruiken in je class
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    
    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
       private GraphicsDeviceManager graphics;
       private SpriteBatch spriteBatch;

        //Dit is de constructor. heeft altijd dezelfde naam als class
        public PyramidPanic()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

    
        protected override void Initialize()
        {
            // Verander de titel van het canvas
            Window.Title = "Pyramid Panic Beta 00.00.00.01";

            //Maakt de muis zichtbaar
            IsMouseVisible = true;
            
            //Verandert de breedte van het canvas
            
            this.graphics.PreferredBackBufferWidth = 640;
            
            //verandert de hoogte van het canvas

            this.graphics.PreferredBackBufferHeight= 480;

            //Past de nieuwe hoogt en breedte toe.

            this.graphics.ApplyChanges();
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Een spritebatch is nodig voor het tekenen van textures op het canvas
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }
        protected override void UnloadContent()
        {

        }
        protected override void Update(GameTime gameTime)
        {
            // Zorgt dat het spel stopt wanneer je op de gamepad button back indrukt.
            if ((GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) ||
                (Keyboard.GetState().IsKeyDown(Keys.Escape)))
                this.Exit();

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            //geef de achtergrond en kleur
            GraphicsDevice.Clear(Color.OrangeRed);
            base.Draw(gameTime);
        }
    }
}
