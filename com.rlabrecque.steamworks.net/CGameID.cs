using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	[Serializable]
	public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
	{
		// Token: 0x060009AC RID: 2476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public CGameID(ulong GameID)
		{
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x989D60", Offset = "0x988360", VA = "0x180989D60")]
		public CGameID(AppId_t nAppID)
		{
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x989D70", Offset = "0x988370", VA = "0x180989D70")]
		public CGameID(AppId_t nAppID, uint nModID)
		{
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0000830C File Offset: 0x0000650C
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x989DC0", Offset = "0x9883C0", VA = "0x180989DC0")]
		public bool IsSteamApp()
		{
			return default(bool);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00008324 File Offset: 0x00006524
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x989DD0", Offset = "0x9883D0", VA = "0x180989DD0")]
		public bool IsMod()
		{
			return default(bool);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0000833C File Offset: 0x0000653C
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x989DE0", Offset = "0x9883E0", VA = "0x180989DE0")]
		public bool IsShortcut()
		{
			return default(bool);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00008354 File Offset: 0x00006554
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x989DF0", Offset = "0x9883F0", VA = "0x180989DF0")]
		public bool IsP2PFile()
		{
			return default(bool);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0000836C File Offset: 0x0000656C
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x989E00", Offset = "0x988400", VA = "0x180989E00")]
		public AppId_t AppID()
		{
			return default(AppId_t);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00008384 File Offset: 0x00006584
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x989E10", Offset = "0x988410", VA = "0x180989E10")]
		public CGameID.EGameIDType Type()
		{
			return CGameID.EGameIDType.k_EGameIDTypeApp;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0000839C File Offset: 0x0000659C
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x989E20", Offset = "0x988420", VA = "0x180989E20")]
		public uint ModID()
		{
			return 0U;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x000083B4 File Offset: 0x000065B4
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x989E30", Offset = "0x988430", VA = "0x180989E30")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void Reset()
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public void Set(ulong GameID)
		{
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x989F90", Offset = "0x988590", VA = "0x180989F90")]
		private void SetAppID(AppId_t other)
		{
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x98A000", Offset = "0x988600", VA = "0x18098A000")]
		private void SetType(CGameID.EGameIDType other)
		{
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x98A020", Offset = "0x988620", VA = "0x18098A020")]
		private void SetModID(uint other)
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000083CC File Offset: 0x000065CC
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x98A050", Offset = "0x988650", VA = "0x18098A050", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000083E4 File Offset: 0x000065E4
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000083FC File Offset: 0x000065FC
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(CGameID x, CGameID y)
		{
			return default(bool);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00008414 File Offset: 0x00006614
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool operator !=(CGameID x, CGameID y)
		{
			return default(bool);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0000842C File Offset: 0x0000662C
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator CGameID(ulong value)
		{
			return default(CGameID);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00008444 File Offset: 0x00006644
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(CGameID that)
		{
			return 0UL;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0000845C File Offset: 0x0000665C
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(CGameID other)
		{
			return default(bool);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00008474 File Offset: 0x00006674
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(CGameID other)
		{
			return 0;
		}

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_GameID;

		// Token: 0x020001B0 RID: 432
		[Token(Token = "0x20001B0")]
		public enum EGameIDType
		{
			// Token: 0x04000A63 RID: 2659
			[Token(Token = "0x4000A63")]
			k_EGameIDTypeApp,
			// Token: 0x04000A64 RID: 2660
			[Token(Token = "0x4000A64")]
			k_EGameIDTypeGameMod,
			// Token: 0x04000A65 RID: 2661
			[Token(Token = "0x4000A65")]
			k_EGameIDTypeShortcut,
			// Token: 0x04000A66 RID: 2662
			[Token(Token = "0x4000A66")]
			k_EGameIDTypeP2P
		}
	}
}
