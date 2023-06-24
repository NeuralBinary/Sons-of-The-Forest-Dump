using System;
using Il2CppDummyDll;

namespace Sons.Animation.Mae
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class AlignToParams
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public AlignToParams()
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x10")]
		public float TurnSpeed;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x14")]
		public float AngleThreshold;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x18")]
		public float CancelAngle;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x1C")]
		public AlignToType AlignToType;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		public Action CompletedCallback;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x28")]
		public Action InterruptedCallback;
	}
}
