using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x0200054A RID: 1354
	[Token(Token = "0x200054A")]
	public class IdObject
	{
		// Token: 0x0600233E RID: 9022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233E")]
		[Address(RVA = "0x2D5E110", Offset = "0x2D5D110", VA = "0x182D5E110")]
		public static List<string> ListForDropdown()
		{
			return null;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233F")]
		[Address(RVA = "0x2D5E0A0", Offset = "0x2D5D0A0", VA = "0x182D5E0A0")]
		public static string ConvertToNamedKey(int index)
		{
			return null;
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x6002340")]
		[Address(RVA = "0x2D5E010", Offset = "0x2D5D010", VA = "0x182D5E010")]
		public static int ConvertToIndex(string key)
		{
			return default(int);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x6002341")]
		[Address(RVA = "0x2D5E2A0", Offset = "0x2D5D2A0", VA = "0x182D5E2A0")]
		public static bool TryConvertToIndex(string sourceKey, out int index)
		{
			return default(bool);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002342")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public IdObject()
		{
		}

		// Token: 0x04001FC3 RID: 8131
		[Token(Token = "0x4001FC3")]
		public const int None = -1;

		// Token: 0x04001FC4 RID: 8132
		[Token(Token = "0x4001FC4")]
		public const int CaveBSluggy = 0;

		// Token: 0x04001FC5 RID: 8133
		[Token(Token = "0x4001FC5")]
		public const int LuxuryBunkerEntranceDoor = 1;

		// Token: 0x04001FC6 RID: 8134
		[Token(Token = "0x4001FC6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] NamedKeys;

		// Token: 0x04001FC7 RID: 8135
		[Token(Token = "0x4001FC7")]
		[FieldOffset(Offset = "0x8")]
		private static List<string> _listForDropDown;
	}
}
