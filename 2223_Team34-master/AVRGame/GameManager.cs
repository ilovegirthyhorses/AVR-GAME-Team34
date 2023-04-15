using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AVRGame;

   public class GameManager
{

    private readonly OrbKeyboard _orbkeyboard;
   
    public GameManager()
    {
        var _image = Global.Content.Load<Texture2D>("UFO2");
       
        _orbkeyboard = new(_image, new(0, 0));
        
    }
    
    public void Update() 
    {
    InputManager.Update();
        _orbkeyboard.Update();
    }

    public void Draw()
    {

        _orbkeyboard.Draw();
    }

}
/*
public class background
{
    private readonly background _backgroundclass;

    public background() {
        var _image2 = Global.Content.Load<Texture2D>("Background");
        _backgroundclass = new();


    } 

    public void Draw()
    {
        _backgroundclass.Draw();
    }


}
*/