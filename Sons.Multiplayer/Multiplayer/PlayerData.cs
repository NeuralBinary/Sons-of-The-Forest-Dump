using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[Serializable]
	public class PlayerData
	{
		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x30EF110", Offset = "0x30ED710", VA = "0x1830EF110")]
		public PlayerData(ulong steamId)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x30EF120", Offset = "0x30ED720", VA = "0x1830EF120")]
		[JsonConstructor]
		public PlayerData()
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public string GetPlayerName()
		{
			return null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x30EF130", Offset = "0x30ED730", VA = "0x1830EF130")]
		public string SetPlayerName(string value)
		{
			return null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x30EF190", Offset = "0x30ED790", VA = "0x1830EF190")]
		public bool IsAdmin()
		{
			return default(bool);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x30EF1A0", Offset = "0x30ED7A0", VA = "0x1830EF1A0")]
		public bool IsOwner()
		{
			return default(bool);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x30EF1B0", Offset = "0x30ED7B0", VA = "0x1830EF1B0")]
		public bool IsTrusted()
		{
			return default(bool);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x30EF1C0", Offset = "0x30ED7C0", VA = "0x1830EF1C0")]
		public bool IsGuest()
		{
			return default(bool);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x30EF1D0", Offset = "0x30ED7D0", VA = "0x1830EF1D0")]
		public bool IsTrustedOrAdmin()
		{
			return default(bool);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2AE38E0", Offset = "0x2AE1EE0", VA = "0x182AE38E0")]
		public bool IsBanned()
		{
			return default(bool);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x74DB00", Offset = "0x74C100", VA = "0x18074DB00")]
		public bool IsUnknown()
		{
			return default(bool);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public ulong GetPlayerSteamId()
		{
			return 0UL;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x141D8B0", Offset = "0x141BEB0", VA = "0x18141D8B0")]
		public bool Matches(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x30EF1F0", Offset = "0x30ED7F0", VA = "0x1830EF1F0")]
		public void SetGuest()
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x30EF200", Offset = "0x30ED800", VA = "0x1830EF200")]
		public void SetAdmin()
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x30EF120", Offset = "0x30ED720", VA = "0x1830EF120")]
		public void SetTrusted()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x218A400", Offset = "0x2188A00", VA = "0x18218A400")]
		public void SetBanned()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x30EF210", Offset = "0x30ED810", VA = "0x1830EF210")]
		public void SetOwner()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x30EF220", Offset = "0x30ED820", VA = "0x1830EF220")]
		public PlayerRoles GetRoleValue()
		{
			return PlayerRoles.Unknown;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x30EF240", Offset = "0x30ED840", VA = "0x1830EF240")]
		public void SetRoleValue(PlayerRoles role)
		{
		}

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("PlayerId")]
		[SerializeField]
		private ulong _playerSteamId;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[JsonProperty("LastKnownPlayerName")]
		private string _lastKnownPlayerName;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[JsonProperty("PlayerRole")]
		private PlayerRoles _playerRole;
	}
}
