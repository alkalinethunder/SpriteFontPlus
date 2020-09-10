﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace SpriteFontPlus.FontStashSharp
{
	internal class FontGlyph
	{
		private readonly Dictionary<int, int> _kernings = new Dictionary<int, int>();

		public Font Font;
		public FontAtlas Atlas;
		public int Codepoint;
		public int Index;
		public int Size;
		public Rectangle Bounds;
		public int XAdvance;
		public int XOffset;
		public int YOffset;

		public bool IsEmpty
		{
			get
			{
				return Bounds.Width == 0 || Bounds.Height == 0;
			}
		}

		public int GetKerning(FontGlyph nextGlyph)
		{
			int result;
			if (_kernings.TryGetValue(nextGlyph.Index, out result))
			{
				return result;
			}
			result = StbTrueTypeSharp.StbTrueType.stbtt_GetGlyphKernAdvance(Font._font, Index, nextGlyph.Index);
			_kernings[nextGlyph.Index] = result;

			return result;
		}
	}
}
