using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	[CallbackIdentity(1110)]
	public struct GlobalAchievementPercentagesReady_t
	{
		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		public const int k_iCallback = 1110;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
}
