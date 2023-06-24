using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	[Serializable]
	public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
	{
		// Token: 0x060009C5 RID: 2501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x98A100", Offset = "0x988700", VA = "0x18098A100")]
		public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x98A110", Offset = "0x988710", VA = "0x18098A110")]
		public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public CSteamID(ulong ulSteamID)
		{
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x98A140", Offset = "0x988740", VA = "0x18098A140")]
		public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x98A110", Offset = "0x988710", VA = "0x18098A110")]
		public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void Clear()
		{
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x98A1C0", Offset = "0x9887C0", VA = "0x18098A1C0")]
		public void CreateBlankAnonLogon(EUniverse eUniverse)
		{
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x98A1F0", Offset = "0x9887F0", VA = "0x18098A1F0")]
		public void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0000848C File Offset: 0x0000668C
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x98A220", Offset = "0x988820", VA = "0x18098A220")]
		public bool BBlankAnonAccount()
		{
			return default(bool);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000084A4 File Offset: 0x000066A4
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x98A250", Offset = "0x988850", VA = "0x18098A250")]
		public bool BGameServerAccount()
		{
			return default(bool);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000084BC File Offset: 0x000066BC
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x98A270", Offset = "0x988870", VA = "0x18098A270")]
		public bool BPersistentGameServerAccount()
		{
			return default(bool);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000084D4 File Offset: 0x000066D4
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x98A280", Offset = "0x988880", VA = "0x18098A280")]
		public bool BAnonGameServerAccount()
		{
			return default(bool);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000084EC File Offset: 0x000066EC
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x98A290", Offset = "0x988890", VA = "0x18098A290")]
		public bool BContentServerAccount()
		{
			return default(bool);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00008504 File Offset: 0x00006704
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x98A2A0", Offset = "0x9888A0", VA = "0x18098A2A0")]
		public bool BClanAccount()
		{
			return default(bool);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0000851C File Offset: 0x0000671C
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x98A2B0", Offset = "0x9888B0", VA = "0x18098A2B0")]
		public bool BChatAccount()
		{
			return default(bool);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00008534 File Offset: 0x00006734
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x98A2C0", Offset = "0x9888C0", VA = "0x18098A2C0")]
		public bool IsLobby()
		{
			return default(bool);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0000854C File Offset: 0x0000674C
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x98A2F0", Offset = "0x9888F0", VA = "0x18098A2F0")]
		public bool BIndividualAccount()
		{
			return default(bool);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00008564 File Offset: 0x00006764
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x98A310", Offset = "0x988910", VA = "0x18098A310")]
		public bool BAnonAccount()
		{
			return default(bool);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0000857C File Offset: 0x0000677C
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x98A330", Offset = "0x988930", VA = "0x18098A330")]
		public bool BAnonUserAccount()
		{
			return default(bool);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00008594 File Offset: 0x00006794
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x98A340", Offset = "0x988940", VA = "0x18098A340")]
		public bool BConsoleUserAccount()
		{
			return default(bool);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x98A350", Offset = "0x988950", VA = "0x18098A350")]
		public void SetAccountID(AccountID_t other)
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x98A370", Offset = "0x988970", VA = "0x18098A370")]
		public void SetAccountInstance(uint other)
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x98A390", Offset = "0x988990", VA = "0x18098A390")]
		public void SetEAccountType(EAccountType other)
		{
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x98A3B0", Offset = "0x9889B0", VA = "0x18098A3B0")]
		public void SetEUniverse(EUniverse other)
		{
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000085AC File Offset: 0x000067AC
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
		public AccountID_t GetAccountID()
		{
			return default(AccountID_t);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000085C4 File Offset: 0x000067C4
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x98A3D0", Offset = "0x9889D0", VA = "0x18098A3D0")]
		public uint GetUnAccountInstance()
		{
			return 0U;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000085DC File Offset: 0x000067DC
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x98A3E0", Offset = "0x9889E0", VA = "0x18098A3E0")]
		public EAccountType GetEAccountType()
		{
			return EAccountType.k_EAccountTypeInvalid;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000085F4 File Offset: 0x000067F4
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x98A3F0", Offset = "0x9889F0", VA = "0x18098A3F0")]
		public EUniverse GetEUniverse()
		{
			return EUniverse.k_EUniverseInvalid;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0000860C File Offset: 0x0000680C
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x98A400", Offset = "0x988A00", VA = "0x18098A400")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00008624 File Offset: 0x00006824
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x98A470", Offset = "0x988A70", VA = "0x18098A470", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0000863C File Offset: 0x0000683C
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00008654 File Offset: 0x00006854
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0000866C File Offset: 0x0000686C
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x98A510", Offset = "0x988B10", VA = "0x18098A510")]
		public static bool operator !=(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00008684 File Offset: 0x00006884
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator CSteamID(ulong value)
		{
			return default(CSteamID);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0000869C File Offset: 0x0000689C
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(CSteamID that)
		{
			return 0UL;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000086B4 File Offset: 0x000068B4
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(CSteamID other)
		{
			return default(bool);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000086CC File Offset: 0x000068CC
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(CSteamID other)
		{
			return 0;
		}

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CSteamID Nil;

		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4000A68")]
		[FieldOffset(Offset = "0x8")]
		public static readonly CSteamID OutofDateGS;

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		[FieldOffset(Offset = "0x10")]
		public static readonly CSteamID LanModeGS;

		// Token: 0x04000A6A RID: 2666
		[Token(Token = "0x4000A6A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly CSteamID NotInitYetGS;

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly CSteamID NonSteamGS;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;
	}
}
