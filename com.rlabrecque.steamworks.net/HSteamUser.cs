using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001ED RID: 493
	[Token(Token = "0x20001ED")]
	[Serializable]
	public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		// Token: 0x06000BC1 RID: 3009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public HSteamUser(int value)
		{
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x634F00", Offset = "0x633500", VA = "0x180634F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0000A664 File Offset: 0x00008864
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x98E6C0", Offset = "0x98CCC0", VA = "0x18098E6C0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0000A67C File Offset: 0x0000887C
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0000A694 File Offset: 0x00008894
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0000A6AC File Offset: 0x000088AC
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0000A6C4 File Offset: 0x000088C4
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator HSteamUser(int value)
		{
			return default(HSteamUser);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0000A6DC File Offset: 0x000088DC
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator int(HSteamUser that)
		{
			return 0;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0000A6F4 File Offset: 0x000088F4
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(HSteamUser other)
		{
			return default(bool);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0000A70C File Offset: 0x0000890C
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x98B0A0", Offset = "0x9896A0", VA = "0x18098B0A0", Slot = "5")]
		public int CompareTo(HSteamUser other)
		{
			return 0;
		}

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0x0")]
		public int m_HSteamUser;
	}
}
