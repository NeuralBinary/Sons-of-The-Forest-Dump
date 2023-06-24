using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	public class Segment2dBox
	{
		// Token: 0x060010AF RID: 4271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Segment2dBox()
		{
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010B0")]
		[Address(RVA = "0x5FD4C0", Offset = "0x5FBAC0", VA = "0x1805FD4C0")]
		public Segment2dBox(Segment2d seg)
		{
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0000CA94 File Offset: 0x0000AC94
		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x1E47AA0", Offset = "0x1E460A0", VA = "0x181E47AA0")]
		public static implicit operator Segment2d(Segment2dBox box)
		{
			return default(Segment2d);
		}

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x10")]
		public Segment2d Segment;
	}
}
