using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	[Serializable]
	public struct SteamNetworkingIdentity : IEquatable<SteamNetworkingIdentity>
	{
		// Token: 0x06000ACE RID: 2766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x953940", Offset = "0x951F40", VA = "0x180953940")]
		public void Clear()
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x000095FC File Offset: 0x000077FC
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x953A70", Offset = "0x952070", VA = "0x180953A70")]
		public bool IsInvalid()
		{
			return default(bool);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x98BBA0", Offset = "0x98A1A0", VA = "0x18098BBA0")]
		public void SetSteamID(CSteamID steamID)
		{
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00009614 File Offset: 0x00007814
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x98BD10", Offset = "0x98A310", VA = "0x18098BD10")]
		public CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x953E10", Offset = "0x952410", VA = "0x180953E10")]
		public void SetSteamID64(ulong steamID)
		{
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0000962C File Offset: 0x0000782C
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x953F50", Offset = "0x952550", VA = "0x180953F50")]
		public ulong GetSteamID64()
		{
			return 0UL;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x98BE70", Offset = "0x98A470", VA = "0x18098BE70")]
		public void SetIPAddr(SteamNetworkingIPAddr addr)
		{
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00009644 File Offset: 0x00007844
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x98C050", Offset = "0x98A650", VA = "0x18098C050")]
		public SteamNetworkingIPAddr GetIPAddr()
		{
			return default(SteamNetworkingIPAddr);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x954650", Offset = "0x952C50", VA = "0x180954650")]
		public void SetIPv4Addr(uint nIPv4, ushort nPort)
		{
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0000965C File Offset: 0x0000785C
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x954790", Offset = "0x952D90", VA = "0x180954790")]
		public uint GetIPv4()
		{
			return 0U;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00009674 File Offset: 0x00007874
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x9548C0", Offset = "0x952EC0", VA = "0x1809548C0")]
		public ESteamNetworkingFakeIPType GetFakeIPType()
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0000968C File Offset: 0x0000788C
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x98C090", Offset = "0x98A690", VA = "0x18098C090")]
		public bool IsFakeIP()
		{
			return default(bool);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x954B20", Offset = "0x953120", VA = "0x180954B20")]
		public void SetLocalHost()
		{
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000096A4 File Offset: 0x000078A4
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x954C50", Offset = "0x953250", VA = "0x180954C50")]
		public bool IsLocalHost()
		{
			return default(bool);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x000096BC File Offset: 0x000078BC
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x98C0B0", Offset = "0x98A6B0", VA = "0x18098C0B0")]
		public bool SetGenericString(string pszString)
		{
			return default(bool);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x98C330", Offset = "0x98A930", VA = "0x18098C330")]
		public string GetGenericString()
		{
			return null;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000096D4 File Offset: 0x000078D4
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x955040", Offset = "0x953640", VA = "0x180955040")]
		public bool SetGenericBytes(byte[] data, uint cbLen)
		{
			return default(bool);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x98C460", Offset = "0x98AA60", VA = "0x18098C460")]
		public byte[] GetGenericBytes(out int cbLen)
		{
			return null;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000096EC File Offset: 0x000078EC
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x9552E0", Offset = "0x9538E0", VA = "0x1809552E0", Slot = "4")]
		public bool Equals(SteamNetworkingIdentity x)
		{
			return default(bool);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x98C4A0", Offset = "0x98AAA0", VA = "0x18098C4A0")]
		public void ToString(out string buf)
		{
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00009704 File Offset: 0x00007904
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x98C6C0", Offset = "0x98ACC0", VA = "0x18098C6C0")]
		public bool ParseString(string pszStr)
		{
			return default(bool);
		}

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x0")]
		public ESteamNetworkingIdentityType m_eType;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x4")]
		private int m_cbSize;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x8")]
		private uint[] m_reserved;

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		public const int k_cchMaxString = 128;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		public const int k_cchMaxGenericString = 32;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		public const int k_cbMaxGenericBytes = 32;
	}
}
