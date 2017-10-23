using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong
{

    /// Game background representation

    public class Background : Sprite
    {
        public Background(int width, int height) : base(width, height)
        {
        }
    }
 
    /// Game ball object representation

    public class Ball : Sprite
    {

        /// Defines current ball speed in time .

        public float _speed;

        public float Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > GameConstants.MaxBallSpeed)
                {
                    _speed = GameConstants.MaxBallSpeed;
                }
                else
                {
                    _speed = value;
                }
            }
        }
        public float BumpSpeedIncreaseFactor { get; set; }
      
        /// Defines ball direction .
        /// Valid values ( -1 , -1) , (1 ,1) , (1 , -1) , ( -1 ,1).
        /// Using Vector2 to simplify game calculation . Potentially
        /// dangerous because vector 2 can swallow other values as well .
        /// OPTIONAL TODO : create your own , more suitable type
     
        public Vector2 Direction { get; set; }
        public Ball(int size, float speed, float
            defaultBallBumpSpeedIncreaseFactor) : base(size, size)
        {
            _speed = speed;
            BumpSpeedIncreaseFactor = defaultBallBumpSpeedIncreaseFactor;
            // Initial direction
            Direction = new Vector2(1, 1);
        }
    }
   
    /// Represents player paddle .

    public class Paddle : Sprite
    {
      
        /// Current paddle speed in time
     
        public float Speed { get; set; }
        public Paddle(int width, int height, float initialSpeed) : base(width,
            height)
        {
            Speed = initialSpeed;
        }
     
        /// Overriding draw method . Masking paddle texture with black color .
      
        public override void DrawSpriteOnScreen(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, new Vector2(X, Y), new Rectangle(0, 0,
                Width, Height), Color.GhostWhite);
        }
    }
}
