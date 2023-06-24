using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	public struct SteamParamStringArray_t
	{
		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr m_ppStrings;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x8")]
		public int m_nNumStrings;
	}
}
