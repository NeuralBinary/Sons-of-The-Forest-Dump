using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	[Serializable]
	public struct SteamNetworkingIPAddr : IEquatable<SteamNetworkingIPAddr>
	{
		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
		public void Clear()
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0000971C File Offset: 0x0000791C
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x952AB0", Offset = "0x9510B0", VA = "0x180952AB0")]
		public bool IsIPv6AllZeros()
		{
			return default(bool);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x952BD0", Offset = "0x9511D0", VA = "0x180952BD0")]
		public void SetIPv6(byte[] ipv6, ushort nPort)
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x952D00", Offset = "0x951300", VA = "0x180952D00")]
		public void SetIPv4(uint nIP, ushort nPort)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00009734 File Offset: 0x00007934
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x952E20", Offset = "0x951420", VA = "0x180952E20")]
		public bool IsIPv4()
		{
			return default(bool);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0000974C File Offset: 0x0000794C
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x952F40", Offset = "0x951540", VA = "0x180952F40")]
		public uint GetIPv4()
		{
			return 0U;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x953060", Offset = "0x951660", VA = "0x180953060")]
		public void SetIPv6LocalHost(ushort nPort = 0)
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00009764 File Offset: 0x00007964
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x953180", Offset = "0x951780", VA = "0x180953180")]
		public bool IsLocalHost()
		{
			return default(bool);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x98C940", Offset = "0x98AF40", VA = "0x18098C940")]
		public void ToString(out string buf, bool bWithPort)
		{
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0000977C File Offset: 0x0000797C
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x98CB60", Offset = "0x98B160", VA = "0x18098CB60")]
		public bool ParseString(string pszStr)
		{
			return default(bool);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00009794 File Offset: 0x00007994
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x953550", Offset = "0x951B50", VA = "0x180953550", Slot = "4")]
		public bool Equals(SteamNetworkingIPAddr x)
		{
			return default(bool);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000097AC File Offset: 0x000079AC
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x953700", Offset = "0x951D00", VA = "0x180953700")]
		public ESteamNetworkingFakeIPType GetFakeIPType()
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x000097C4 File Offset: 0x000079C4
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x98CDA0", Offset = "0x98B3A0", VA = "0x18098CDA0")]
		public bool IsFakeIP()
		{
			return default(bool);
		}

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0x0")]
		public byte[] m_ipv6;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x8")]
		public ushort m_port;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		public const int k_cchMaxString = 48;
	}
}
