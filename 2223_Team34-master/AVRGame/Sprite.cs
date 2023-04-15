using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AVRGame;

public class Sprite
{

    protected readonly Texture2D texture;

    protected readonly Vector2 origin;

    protected Vector2 position;

    protected int speed;


    public Sprite(Texture2D tex, Vector2 pos)
    {
        texture = tex;
        position = pos;
        speed = 15;
        origin = new(tex.Width / 2, tex.Height / 2);
    
    }
    
    public virtual void Draw()
    {
       
        Global.SpriteBatch.Draw(texture, position, null, Color.White, 0, origin, 0.1f, SpriteEffects.None, 1);
    }



}