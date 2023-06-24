using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[Serializable]
	public class MultiplayerPlayerRoleData
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x30E7290", Offset = "0x30E5890", VA = "0x1830E7290")]
		internal void ApplyOwnersWhitelist(HashSet<ulong> whitelist)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x30E7750", Offset = "0x30E5D50", VA = "0x1830E7750")]
		public int GetIndex(ulong steamId)
		{
			return 0;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x30E7800", Offset = "0x30E5E00", VA = "0x1830E7800")]
		public void RemovePlayerAtIndex(int resultIndex)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x30E7860", Offset = "0x30E5E60", VA = "0x1830E7860")]
		public void SetPlayerTrusted(ulong steamId)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x30E79B0", Offset = "0x30E5FB0", VA = "0x1830E79B0")]
		internal bool TryGetData(ulong steamId, out PlayerData result)
		{
			return default(bool);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x30E7B10", Offset = "0x30E6110", VA = "0x1830E7B10")]
		internal bool TryGetIndex(ulong steamId, out int resultIndex)
		{
			return default(bool);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x30E7BD0", Offset = "0x30E61D0", VA = "0x1830E7BD0")]
		internal PlayerData AddPlayer(ulong steamId)
		{
			return null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x30E7D30", Offset = "0x30E6330", VA = "0x1830E7D30")]
		public void SetPlayerBanned(ulong steamId)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x30E7E80", Offset = "0x30E6480", VA = "0x1830E7E80")]
		public void SetPlayerAdmin(ulong steamId)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x30E7FD0", Offset = "0x30E65D0", VA = "0x1830E7FD0")]
		public void SetPlayerGuest(ulong steamId)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x30E8120", Offset = "0x30E6720", VA = "0x1830E8120")]
		public static void RegisterPlayerRoleChanged(Action<PlayerData> onPlayerRoleChanged)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x30E8320", Offset = "0x30E6920", VA = "0x1830E8320")]
		public static void UnregisterPlayerRoleChanged(Action<PlayerData> onPlayerRoleChanged)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x30E84E0", Offset = "0x30E6AE0", VA = "0x1830E84E0")]
		public MultiplayerPlayerRoleData()
		{
		}

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerData> PlayerList;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x0")]
		private static List<Action<PlayerData>> _onPlayerDataChanged;
	}
}
