using System;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public enum PlayerRoles
	{
		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		Unknown,
		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		Guest,
		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		Banned,
		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		Trusted = 4,
		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		Admin = 16,
		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		Owner = 32,
		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		Default = 4
	}
}
