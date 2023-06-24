using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;

namespace Sons.Multiplayer
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public class MultiplayerPlayerRoles : SingletonBehaviour<MultiplayerPlayerRoles>, ISaveGameSerializer<MultiplayerPlayerRoleData>, IBlobSerializer<MultiplayerPlayerRoles.BannedPlayersDataList>
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x30E86E0", Offset = "0x30E6CE0", VA = "0x1830E86E0")]
		public void SetPlayerBanned(BoltConnection connection, BoltEntity playerEntity)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x30E8750", Offset = "0x30E6D50", VA = "0x1830E8750")]
		public void SetPlayerBanned(BoltEntity playerEntity)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x30E87B0", Offset = "0x30E6DB0", VA = "0x1830E87B0")]
		public void SetPlayerAdmin(ulong steamId)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x30E8910", Offset = "0x30E6F10", VA = "0x1830E8910")]
		public void SetPlayerGuest(ulong steamId)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x30E8A70", Offset = "0x30E7070", VA = "0x1830E8A70")]
		public void KickPlayer(ulong steamid, int duration = -1, string message = "HOST_KICKED_YOU")
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x30E8B10", Offset = "0x30E7110", VA = "0x1830E8B10")]
		public void KickPlayerByConnectionId(int connectionId, int duration = -1, string message = "HOST_KICKED_YOU")
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x30E8BA0", Offset = "0x30E71A0", VA = "0x1830E8BA0")]
		public void KickPlayer(BoltEntity playerEntity, int duration, string message = "HOST_KICKED_YOU")
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x30E8BD0", Offset = "0x30E71D0", VA = "0x1830E8BD0")]
		public void KickPlayer(BoltConnection connection, BoltEntity playerEntity, int duration, string message = "HOST_KICKED_YOU")
		{
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000009")]
		public event Action OnBannedPlayersDownloaded
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x30E9110", Offset = "0x30E7710", VA = "0x1830E9110")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x30E9200", Offset = "0x30E7800", VA = "0x1830E9200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x30E92F0", Offset = "0x30E78F0", VA = "0x1830E92F0")]
		public static bool CheckPlayerIsBanned(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x30E9390", Offset = "0x30E7990", VA = "0x1830E9390")]
		private void OnEnable()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x30E9430", Offset = "0x30E7A30", VA = "0x1830E9430")]
		private void OnDisable()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x30E94C0", Offset = "0x30E7AC0", VA = "0x1830E94C0")]
		public bool IsGuest(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x30E9510", Offset = "0x30E7B10", VA = "0x1830E9510")]
		public bool IsTrusted(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x30E9560", Offset = "0x30E7B60", VA = "0x1830E9560")]
		public bool IsTrustedOrAdmin(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x30E95C0", Offset = "0x30E7BC0", VA = "0x1830E95C0")]
		public bool IsAdmin(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x30E9610", Offset = "0x30E7C10", VA = "0x1830E9610")]
		public bool IsOwner(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x30E9660", Offset = "0x30E7C60", VA = "0x1830E9660")]
		public bool IsBanned(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x30E96B0", Offset = "0x30E7CB0", VA = "0x1830E96B0")]
		public void SetPlayerTrusted(ulong steamId)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x30E9810", Offset = "0x30E7E10", VA = "0x1830E9810")]
		private bool TryGetIndex(ulong steamId, out int index)
		{
			return default(bool);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x30E9830", Offset = "0x30E7E30", VA = "0x1830E9830")]
		private bool TryGetData(ulong steamId, out PlayerData data)
		{
			return default(bool);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000045")]
		public string SerializedName
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x30E9850", Offset = "0x30E7E50", VA = "0x1830E9850", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x17000046")]
		public bool ShouldSerialize
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x30E9880", Offset = "0x30E7E80", VA = "0x1830E9880", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x17000047")]
		public bool IncludeInPlayerSave
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x30E9880", Offset = "0x30E7E80", VA = "0x1830E9880", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x30E9900", Offset = "0x30E7F00", VA = "0x1830E9900", Slot = "11")]
		public MultiplayerPlayerRoleData OnSerialize()
		{
			return null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x30E9920", Offset = "0x30E7F20", VA = "0x1830E9920", Slot = "12")]
		public void OnDeserialize(MultiplayerPlayerRoleData data)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x30E9980", Offset = "0x30E7F80", VA = "0x1830E9980")]
		private void ApplyOwnersWhitelist()
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x30E9A30", Offset = "0x30E8030", VA = "0x1830E9A30")]
		private HashSet<ulong> ReadOwnersWhitelist()
		{
			return null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x30E9BF0", Offset = "0x30E81F0", VA = "0x1830E9BF0")]
		public static bool CreateOwnersWhitelistIfNotExist()
		{
			return default(bool);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x17000048")]
		public bool UniqueFile
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x30E9F30", Offset = "0x30E8530", VA = "0x1830E9F30")]
		public void UpdatePlayerName(ulong steamId)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x30EA0A0", Offset = "0x30E86A0", VA = "0x1830EA0A0")]
		public void UpdatePlayerName(ulong steamId, string playerName)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x30EA180", Offset = "0x30E8780", VA = "0x1830EA180")]
		public void ClearPlayer(ulong steamId)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x30EA240", Offset = "0x30E8840", VA = "0x1830EA240")]
		public static void RegisterPlayerRoleChanged(Action<PlayerData> onPlayerRoleChanged)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x30EA290", Offset = "0x30E8890", VA = "0x1830EA290")]
		public static void UnregisterPlayerRoleChanged(Action<PlayerData> onPlayerRoleChanged)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x30EA480", Offset = "0x30E8A80", VA = "0x1830EA480")]
		public void GetBannedPlayers(out List<PlayerData> playerData)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x30EA720", Offset = "0x30E8D20", VA = "0x1830EA720")]
		public PlayerRoles GetRoleValue(ulong steamId)
		{
			return PlayerRoles.Unknown;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x30EA780", Offset = "0x30E8D80", VA = "0x1830EA780")]
		public void SetRoleValue(ulong steamId, PlayerRoles statePlayerRole)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x30EA810", Offset = "0x30E8E10", VA = "0x1830EA810", Slot = "17")]
		private MultiplayerPlayerRoles.BannedPlayersDataList OnSerialize()
		{
			return default(MultiplayerPlayerRoles.BannedPlayersDataList);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x30EA8D0", Offset = "0x30E8ED0", VA = "0x1830EA8D0", Slot = "18")]
		private void OnDeserialize(MultiplayerPlayerRoles.BannedPlayersDataList data)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x30EAC40", Offset = "0x30E9240", VA = "0x1830EAC40")]
		public MultiplayerPlayerRoles()
		{
		}

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x28")]
		private MultiplayerPlayerRoleData _playerRoleData;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		public const byte BannedListBlobChannel = 20;

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		[Serializable]
		public struct BannedPlayersDataList
		{
			// Token: 0x040000BD RID: 189
			[Token(Token = "0x40000BD")]
			[FieldOffset(Offset = "0x0")]
			public PlayerData[] Players;
		}
	}
}
