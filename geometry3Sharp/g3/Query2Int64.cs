using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	public class Query2Int64 : Query2d
	{
		// Token: 0x0600105B RID: 4187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600105B")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public Query2Int64(IList<Vector2d> Vertices)
		{
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		[Token(Token = "0x600105C")]
		[Address(RVA = "0x1E431D0", Offset = "0x1E417D0", VA = "0x181E431D0", Slot = "11")]
		public override int ToLine(ref Vector2d test, int v0, int v1)
		{
			return 0;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		[Token(Token = "0x600105D")]
		[Address(RVA = "0x1E433B0", Offset = "0x1E419B0", VA = "0x181E433B0", Slot = "15")]
		public override int ToCircumcircle(ref Vector2d test, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0000C4DC File Offset: 0x0000A6DC
		[Token(Token = "0x600105E")]
		[Address(RVA = "0x1E436E0", Offset = "0x1E41CE0", VA = "0x181E436E0")]
		private long Dot(long x0, long y0, long x1, long y1)
		{
			return 0L;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		[Token(Token = "0x600105F")]
		[Address(RVA = "0x1E436F0", Offset = "0x1E41CF0", VA = "0x181E436F0")]
		private long Det2(long x0, long y0, long x1, long y1)
		{
			return 0L;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0000C50C File Offset: 0x0000A70C
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x1E43710", Offset = "0x1E41D10", VA = "0x181E43710")]
		private long Det3(long x0, long y0, long z0, long x1, long y1, long z1, long x2, long y2, long z2)
		{
			return 0L;
		}
	}
}
