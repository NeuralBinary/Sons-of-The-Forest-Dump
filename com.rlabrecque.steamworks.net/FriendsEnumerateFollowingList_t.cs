using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[CallbackIdentity(346)]
	public struct FriendsEnumerateFollowingList_t
	{
		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		public const int k_iCallback = 346;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID[] m_rgSteamID;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x10")]
		public int m_nResultsReturned;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x14")]
		public int m_nTotalResultCount;
	}
}
