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
   public class Menu
    {
       //Fields
       //Maak een enumeration voor de buttons op het scherm te zien zijn
       private enum Buttons { Start, Load, Help, Scores, Quit}
       //                       0       1   2       3       4
       //maak een variabele van het type buttons en geef hem de waarde buttons.start
       private Buttons buttonActive = Buttons.Start;

       //maak een variabele(reference) van het type Image
       private Image start;
       private Image load;
       private Image help;
       private Image scores;
       private Image quit;

       //maak een variabele (reference) van het type Pyramidpanic
       private PyramidPanic game;

       //maak een variabele aan activeColor. dit is de kleur van de active knop
       private Color activeColor = Color.Gold;

       //maak een variabele van het type List<Image>
       private List<Image> buttonList;
       
       //Constructor
       public Menu(PyramidPanic game)
       {
           this.game = game;
           this.initialize();
       }

       public void initialize()
       {
           this.LoadContent();
       }

       public void LoadContent()
       {
           //maak een instantie aan van de list<Image> type en stop deze in de variabele this.button
           this.buttonList = new List<Image>();
           this.buttonList.Add(this.start = new Image(this.game, @"StartScene\Button_start", new Vector2(15, 430f)));
           this.buttonList.Add(this.load = new Image(this.game, @"StartScene\Button_load", new Vector2(135f, 430f)));
           this.buttonList.Add(this.help = new Image(this.game, @"StartScene\Button_help", new Vector2(265f, 430f)));
           this.buttonList.Add(this.scores = new Image(this.game, @"StartScene\Button_scores", new Vector2(405f, 430f)));
           this.buttonList.Add(this.quit = new Image(this.game, @"StartScene\Button_quit", new Vector2(525f, 430f)));
       }

       

       //Update
       public void Update(GameTime gameTime)
       {
           //deze if - instructie checked of er oop de rechterpijltoets wordt gedrukt.
           //De actie die daarop volgt is het ophogen van de variabele buttonActive
           if (Input.EdgeDetectKeyDown(Keys.Right))
           {
               this.ChangeButtonColorToNormal();
               this.buttonActive++;
           }

           if (Input.EdgeDetectKeyDown(Keys.Left))
           {
               this.ChangeButtonColorToNormal();
               this.buttonActive--;
           }
           //maak een switch case constructie voor de variabele buttonActive
           switch (this.buttonActive)
           {
               case Buttons.Start:
                   if (Input.EdgeDetectKeyDown(Keys.Enter))
                   {
                       this.game.IState = this.game.PlayScene;
                   }
                   else
                   {

                   }
                   this.start.Color = this.activeColor;
                   break;
               case Buttons.Load:
                   this.load.Color = this.activeColor;
                   break;
               case Buttons.Help:
                   this.help.Color = this.activeColor;
                   break;
               case Buttons.Scores:
                   this.scores.Color = this.activeColor;
                   break;
               case Buttons.Quit:
                   this.quit.Color = this.activeColor;
                   break;
           }
       }

       //Draw
       public void Draw(GameTime gameTime)
       {
           foreach (Image image in this.buttonList)
           {
               image.Draw(gameTime);
           }
       }

       /* helper method voor het met wit licht beschijnen van de buttons
        */
       private void ChangeButtonColorToNormal()
       {
           //We doorlopen de List<Image> this.buttonList met een foreach instructie
           //en we roepen voor ieder image-object de propertie Color op en geven deze de waarde Color.white

           foreach (Image image in this.buttonList)
           {
               image.Color = Color.White;
           }
       }
    }
}
