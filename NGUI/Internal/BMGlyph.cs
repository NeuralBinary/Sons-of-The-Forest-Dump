using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NGUI.Internal
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[Serializable]
	public class BMGlyph
	{
		// Token: 0x0600036A RID: 874 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x26624B0", Offset = "0x2660AB0", VA = "0x1826624B0")]
		public int GetKerning(int previousChar)
		{
			return 0;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2662560", Offset = "0x2660B60", VA = "0x182662560")]
		public void SetKerning(int previousChar, int amount)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2662790", Offset = "0x2660D90", VA = "0x182662790")]
		public void Trim(int xMin, int yMin, int xMax, int yMax)
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BMGlyph()
		{
		}

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x14")]
		public int x;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x18")]
		public int y;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x1C")]
		public int width;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x20")]
		public int height;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x24")]
		public int offsetX;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x28")]
		public int offsetY;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x2C")]
		public int advance;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x30")]
		public int channel;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x38")]
		public List<int> kerning;
	}
}
