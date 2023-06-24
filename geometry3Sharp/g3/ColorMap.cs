using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public class ColorMap
	{
		// Token: 0x0600015C RID: 348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1E20BF0", Offset = "0x1E1F1F0", VA = "0x181E20BF0")]
		public ColorMap()
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1E20CE0", Offset = "0x1E1F2E0", VA = "0x181E20CE0")]
		public ColorMap(float[] t, Colorf[] c)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1E20E40", Offset = "0x1E1F440", VA = "0x181E20E40")]
		public void AddPoint(float t, Colorf c)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1E210F0", Offset = "0x1E1F6F0", VA = "0x181E210F0")]
		public Colorf Linear(float t)
		{
			return default(Colorf);
		}

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x10")]
		private List<ColorMap.ColorPoint> points;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x18")]
		private Interval1d validRange;

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x200004A")]
		private struct ColorPoint
		{
			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x0")]
			public float t;

			// Token: 0x0400019A RID: 410
			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x4")]
			public Colorf c;
		}
	}
}
