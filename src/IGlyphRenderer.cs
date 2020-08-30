using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace SpriteFontPlus
{
    public interface IGlyphRenderer
    {
        GraphicsDevice GraphicsDevice { get; }
        
        void Draw(Texture2D texture, Rectangle destRect, Rectangle sourceRect, Color color, float rotation, Vector2 origin,
            SpriteEffects effect, float depth);
    }

    public class SpriteBatchGlyphRenderer : IGlyphRenderer
    {
        public SpriteBatch SpriteBatch { get; set; }
        
        private SpriteBatchGlyphRenderer()
        {
        }

        public SpriteBatchGlyphRenderer(SpriteBatch batch)
        {
            SpriteBatch = batch ?? throw new ArgumentNullException(nameof(batch));
        }

        public GraphicsDevice GraphicsDevice => SpriteBatch.GraphicsDevice;

        public void Draw(Texture2D texture, Rectangle destRect, Rectangle sourceRect, Color color, float rotation,
            Vector2 origin,
            SpriteEffects effect, float depth)
        {
            SpriteBatch.Draw(texture, destRect, sourceRect, color, rotation, origin, effect, depth);
        }
        
        public static readonly SpriteBatchGlyphRenderer Instance = new SpriteBatchGlyphRenderer();
    }
}