using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	[Serializable]
	public struct RemotePlaySessionID_t : IEquatable<RemotePlaySessionID_t>, IComparable<RemotePlaySessionID_t>
	{
		// Token: 0x06000B07 RID: 2823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public RemotePlaySessionID_t(uint value)
		{
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00009974 File Offset: 0x00007B74
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x98D0A0", Offset = "0x98B6A0", VA = "0x18098D0A0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0000998C File Offset: 0x00007B8C
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x000099A4 File Offset: 0x00007BA4
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(RemotePlaySessionID_t x, RemotePlaySessionID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000099BC File Offset: 0x00007BBC
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(RemotePlaySessionID_t x, RemotePlaySessionID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x000099D4 File Offset: 0x00007BD4
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator RemotePlaySessionID_t(uint value)
		{
			return default(RemotePlaySessionID_t);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000099EC File Offset: 0x00007BEC
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(RemotePlaySessionID_t that)
		{
			return 0U;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00009A04 File Offset: 0x00007C04
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(RemotePlaySessionID_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00009A1C File Offset: 0x00007C1C
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(RemotePlaySessionID_t other)
		{
			return 0;
		}

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		[FieldOffset(Offset = "0x0")]
		public uint m_RemotePlaySessionID;
	}
}
