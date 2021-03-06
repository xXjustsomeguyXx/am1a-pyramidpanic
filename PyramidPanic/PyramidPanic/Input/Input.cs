﻿using System;
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
   public static class Input
    {
        //fields
       private static KeyboardState ks, oks;


       //constructor
       static Input()
       {
           ks = Keyboard.GetState();
           oks = ks;
       }

       //update
       public static void Update()
       {

           oks = ks;
           ks = Keyboard.GetState();

       }

       //Dit is een edgedertector voor het indrukken van een knop
       public static bool EdgeDetectKeyDown(Keys key)
       {
           return (ks.IsKeyDown(key) && oks.IsKeyUp(key));
       }



    }
}
