using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[CallbackIdentity(337)]
	public struct GameRichPresenceJoinRequested_t
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public string m_rgchConnect
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x97DCF0", Offset = "0x97C2F0", VA = "0x18097DCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x97DD90", Offset = "0x97C390", VA = "0x18097DD90")]
			set
			{
			}
		}

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		public const int k_iCallback = 337;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_rgchConnect_;
	}
}
