using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	[CallbackIdentity(714)]
	public struct GamepadTextInputDismissed_t
	{
		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		public const int k_iCallback = 714;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x0")]
		public bool m_bSubmitted;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x4")]
		public uint m_unSubmittedText;
	}
}
