using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x20001F8")]
	public class ScalarMap
	{
		// Token: 0x0600107F RID: 4223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600107F")]
		[Address(RVA = "0x1E455A0", Offset = "0x1E43BA0", VA = "0x181E455A0")]
		public ScalarMap()
		{
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x1E45690", Offset = "0x1E43C90", VA = "0x181E45690")]
		public void AddPoint(double t, double value)
		{
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0000C77C File Offset: 0x0000A97C
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x1E45940", Offset = "0x1E43F40", VA = "0x181E45940")]
		public double Linear(double t)
		{
			return 0.0;
		}

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x10")]
		private List<ScalarMap.Sample> points;

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x18")]
		private Interval1d validRange;

		// Token: 0x020001F9 RID: 505
		[Token(Token = "0x20001F9")]
		private struct Sample
		{
			// Token: 0x0400081E RID: 2078
			[Token(Token = "0x400081E")]
			[FieldOffset(Offset = "0x0")]
			public double t;

			// Token: 0x0400081F RID: 2079
			[Token(Token = "0x400081F")]
			[FieldOffset(Offset = "0x8")]
			public double value;
		}
	}
}
