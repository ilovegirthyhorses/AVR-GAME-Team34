using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVRGame;

   public class GameManager
{

    private readonly OrbKeyboard _orbkeyboard;
    public GameManager()
    {
        _orbkeyboard = new(Global.Content.Load<Texture2D>("orb-red"), new(300, 300));
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
