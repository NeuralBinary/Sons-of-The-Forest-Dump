using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	public class SampledArcLengthParam2d : IArcLengthParam2d
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1F931D0", Offset = "0x1F917D0", VA = "0x181F931D0")]
		public SampledArcLengthParam2d(IEnumerable<Vector2d> samples, int nCountHint = -1)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x170000C0")]
		public double ArcLength
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x1F92A50", Offset = "0x1F91050", VA = "0x181F92A50", Slot = "4")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1F935F0", Offset = "0x1F91BF0", VA = "0x181F935F0", Slot = "5")]
		public CurveSample2d Sample(double f)
		{
			return default(CurveSample2d);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000046AC File Offset: 0x000028AC
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1F93960", Offset = "0x1F91F60", VA = "0x181F93960")]
		protected Vector2d tangent(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x10")]
		private double[] arc_len;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x18")]
		private Vector2d[] positions;
	}
}
