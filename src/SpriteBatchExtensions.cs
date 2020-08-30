using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Text;

namespace SpriteFontPlus
{
	public static class SpriteBatchExtensions
	{
		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, string text, Vector2 pos, Color color)
		{
			SpriteBatchGlyphRenderer.Instance.SpriteBatch = batch;
			return font.DrawString(SpriteBatchGlyphRenderer.Instance, text, pos, color);
		}

		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, string text, Vector2 pos, Color color, Vector2 scale)
		{
			SpriteBatchGlyphRenderer.Instance.SpriteBatch = batch;
			return font.DrawString(SpriteBatchGlyphRenderer.Instance, text, pos, color, scale);
		}

		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, string text, Vector2 pos, Color[] glyphColors)
		{
			SpriteBatchGlyphRenderer.Instance.SpriteBatch = batch;
			return font.DrawString(SpriteBatchGlyphRenderer.Instance, text, pos, glyphColors);
		}

		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, string text, Vector2 pos, Color[] glyphColors, Vector2 scale)
		{
			SpriteBatchGlyphRenderer.Instance.SpriteBatch = batch;
			return font.DrawString(SpriteBatchGlyphRenderer.Instance, text, pos, glyphColors, scale);
		}

		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, StringBuilder text, Vector2 pos, Color color)
		{
			SpriteBatchGlyphRenderer.Instance.SpriteBatch = batch;
			return font.DrawString(SpriteBatchGlyphRenderer.Instance, text, pos, color);
		}

		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, StringBuilder text, Vector2 pos, Color color, Vector2 scale)
		{
			SpriteBatchGlyphRenderer.Instance.SpriteBatch = batch;
			return font.DrawString(SpriteBatchGlyphRenderer.Instance, text, pos, color, scale);
		}

		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, StringBuilder text, Vector2 pos, Color[] glyphColors)
		{
			SpriteBatchGlyphRenderer.Instance.SpriteBatch = batch;
			return font.DrawString(SpriteBatchGlyphRenderer.Instance, text, pos, glyphColors);
		}

		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, StringBuilder text, Vector2 pos, Color[] glyphColors, Vector2 scale)
		{
			SpriteBatchGlyphRenderer.Instance.SpriteBatch = batch;
			return font.DrawString(SpriteBatchGlyphRenderer.Instance, text, pos, glyphColors, scale);
		}
	}
}