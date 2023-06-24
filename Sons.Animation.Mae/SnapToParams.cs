using System;
using Il2CppDummyDll;

namespace Sons.Animation.Mae
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public class SnapToParams
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SnapToParams()
		{
		}

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x10")]
		public SnapTo.SnapToType MotionType;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x14")]
		public bool SnapRotation;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x15")]
		public bool SnapVertical;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x16")]
		public bool CheckReserveLocation;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x18")]
		public float StopDistance;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x1C")]
		public float SnapTime;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x20")]
		public float GravityMultiplier;
	}
}
