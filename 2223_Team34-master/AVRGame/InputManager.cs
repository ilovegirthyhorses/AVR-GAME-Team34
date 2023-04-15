using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVRGame;
      public static class InputManager
        {

            private static MouseState _lastmousestate;

            private static Vector2 _direction;

            public static Vector2 Direction => _direction;

            public static Vector2 Mouseposition => Mouse.GetState().Position.ToVector2();

            public static bool MouseClicked { get; private set; }
            
            public static void Update()
            {

                var keyboardState = Keyboard.GetState();

                _direction = Vector2.Zero;
                if (keyboardState.IsKeyDown(Keys.W)) _direction.Y--;
                if (keyboardState.IsKeyDown(Keys.S)) _direction.Y++;
                if (keyboardState.IsKeyDown(Keys.A)) _direction.X--;
                if (keyboardState.IsKeyDown(Keys.D)) _direction.X++;

        MouseClicked = (Mouse.GetState().LeftButton == ButtonState.Pressed) && (_lastmousestate.LeftButton == ButtonState.Released);
        _lastmousestate = Mouse.GetState();
            }

        }
    
