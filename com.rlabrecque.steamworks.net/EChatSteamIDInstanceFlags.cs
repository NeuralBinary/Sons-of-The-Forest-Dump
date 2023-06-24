using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	[Flags]
	public enum EChatSteamIDInstanceFlags
	{
		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		k_EChatAccountInstanceMask = 4095,
		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		k_EChatInstanceFlagClan = 524288,
		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		k_EChatInstanceFlagLobby = 262144,
		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		k_EChatInstanceFlagMMSLobby = 131072
	}
}
