using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	[Serializable]
	public struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID>
	{
		// Token: 0x06000AFD RID: 2813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public SteamNetworkingPOPID(uint value)
		{
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000098B4 File Offset: 0x00007AB4
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x98D020", Offset = "0x98B620", VA = "0x18098D020", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000098CC File Offset: 0x00007ACC
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x000098E4 File Offset: 0x00007AE4
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(SteamNetworkingPOPID x, SteamNetworkingPOPID y)
		{
			return default(bool);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000098FC File Offset: 0x00007AFC
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(SteamNetworkingPOPID x, SteamNetworkingPOPID y)
		{
			return default(bool);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00009914 File Offset: 0x00007B14
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator SteamNetworkingPOPID(uint value)
		{
			return default(SteamNetworkingPOPID);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0000992C File Offset: 0x00007B2C
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(SteamNetworkingPOPID that)
		{
			return 0U;
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00009944 File Offset: 0x00007B44
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(SteamNetworkingPOPID other)
		{
			return default(bool);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0000995C File Offset: 0x00007B5C
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(SteamNetworkingPOPID other)
		{
			return 0;
		}

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x0")]
		public uint m_SteamNetworkingPOPID;
	}
}
