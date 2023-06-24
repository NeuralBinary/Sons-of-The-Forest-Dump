using System;
using Il2CppDummyDll;

namespace Sons.Animation.Mae
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public class SurfacePathParams
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SurfacePathParams()
		{
		}

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x10")]
		public SpeedRangeSet Speeds;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x18")]
		public float StopMinDistance;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x20")]
		public Action CompletedCallback;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x28")]
		public Action InterruptedCallback;
	}
}
