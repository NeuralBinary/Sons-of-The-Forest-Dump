using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	public struct InputAnalogActionData_t
	{
		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x0")]
		public EInputSourceMode eMode;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		[FieldOffset(Offset = "0x4")]
		public float x;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		[FieldOffset(Offset = "0x8")]
		public float y;

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		[FieldOffset(Offset = "0xC")]
		public byte bActive;
	}
}
