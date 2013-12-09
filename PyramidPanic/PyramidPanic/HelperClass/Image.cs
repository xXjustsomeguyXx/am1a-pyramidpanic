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
   public class Image
    {
       //fields
       private Texture2D texture;

       //maak een rectangle voor het detecteren van collisions
       private Rectangle rectangle;

       //maak een variabele aan om de game instantie in op te slaan.
       private PyramidPanic game;

       //constructor
       public Image(PyramidPanic game, String pathnameAsset, Vector2 position)
       {
           this.game = game;
           this.texture = game.Content.Load<Texture2D>(pathnameAsset);
           this.rectangle = new Rectangle((int)position.X,
                                          (int)position.Y,
                                          this.texture.Width,
                                          this.texture.Height);
       }


       //update


       //draw
       public void Draw(GameTime gameTime)
       {
           this.game.SpriteBatch.Draw(this.texture, this.rectangle, Color.White);
       }

       //helper Methods
    }
}
