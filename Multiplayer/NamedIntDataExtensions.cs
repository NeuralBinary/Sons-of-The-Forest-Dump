using System;
using Il2CppDummyDll;
using Sons.Save;

namespace Sons.Multiplayer
{
	// Token: 0x0200054B RID: 1355
	[Token(Token = "0x200054B")]
	public static class NamedIntDataExtensions
	{
		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x170004C2")]
		public static bool OfflineOrServer
		{
			[Token(Token = "0x6002344")]
			[Address(RVA = "0x2D5F4B0", Offset = "0x2D5E4B0", VA = "0x182D5F4B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002345")]
		[Address(RVA = "0x2D5F2D0", Offset = "0x2D5E2D0", VA = "0x182D5F2D0")]
		public static void UpdateInBoltNetwork(this NamedIntData source, bool ifServerOnly = false)
		{
		}
	}
}
