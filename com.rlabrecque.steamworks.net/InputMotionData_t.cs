using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	public struct InputMotionData_t
	{
		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x4000987")]
		[FieldOffset(Offset = "0x0")]
		public float rotQuatX;

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x4")]
		public float rotQuatY;

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x8")]
		public float rotQuatZ;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0xC")]
		public float rotQuatW;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x10")]
		public float posAccelX;

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x14")]
		public float posAccelY;

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x18")]
		public float posAccelZ;

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x1C")]
		public float rotVelX;

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0x20")]
		public float rotVelY;

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x24")]
		public float rotVelZ;
	}
}
