using System;
using Il2CppDummyDll;
using Sons.Save;

namespace Sons.Multiplayer
{
	// Token: 0x02000555 RID: 1365
	[Token(Token = "0x2000555")]
	public static class NamedIntDataBoltExtensions
	{
		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x0000A998 File Offset: 0x00008B98
		[Token(Token = "0x170004D6")]
		public static bool OfflineOrServer
		{
			[Token(Token = "0x6002439")]
			[Address(RVA = "0x3384790", Offset = "0x3382D90", VA = "0x183384790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x3384830", Offset = "0x3382E30", VA = "0x183384830")]
		public static void UpdateFromBoltNetwork(this NamedIntData source)
		{
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x3384A00", Offset = "0x3383000", VA = "0x183384A00")]
		public static void UpdateInBoltNetwork(this NamedIntData source, bool ifServerOnly = false)
		{
		}
	}
}
