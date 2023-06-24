using System;
using System.Net;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	[Serializable]
	public struct SteamIPAddress_t
	{
		// Token: 0x06000B88 RID: 2952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x98DD30", Offset = "0x98C330", VA = "0x18098DD30")]
		public SteamIPAddress_t(IPAddress iPAddress)
		{
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x98DF90", Offset = "0x98C590", VA = "0x18098DF90")]
		public IPAddress ToIPAddress()
		{
			return null;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x98E260", Offset = "0x98C860", VA = "0x18098E260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0000A274 File Offset: 0x00008474
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
		public ESteamIPType GetIPType()
		{
			return ESteamIPType.k_ESteamIPTypeIPv4;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0000A28C File Offset: 0x0000848C
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x98E2A0", Offset = "0x98C8A0", VA = "0x18098E2A0")]
		public bool IsSet()
		{
			return default(bool);
		}

		// Token: 0x04000AE4 RID: 2788
		[Token(Token = "0x4000AE4")]
		[FieldOffset(Offset = "0x0")]
		private long m_ip0;

		// Token: 0x04000AE5 RID: 2789
		[Token(Token = "0x4000AE5")]
		[FieldOffset(Offset = "0x8")]
		private long m_ip1;

		// Token: 0x04000AE6 RID: 2790
		[Token(Token = "0x4000AE6")]
		[FieldOffset(Offset = "0x10")]
		private ESteamIPType m_eType;
	}
}
