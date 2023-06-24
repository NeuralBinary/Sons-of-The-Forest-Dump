using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x20001E1")]
	[Serializable]
	public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		// Token: 0x06000B48 RID: 2888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public AccountID_t(uint value)
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00009DF4 File Offset: 0x00007FF4
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x98D750", Offset = "0x98BD50", VA = "0x18098D750", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00009E0C File Offset: 0x0000800C
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00009E24 File Offset: 0x00008024
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00009E3C File Offset: 0x0000803C
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00009E54 File Offset: 0x00008054
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator AccountID_t(uint value)
		{
			return default(AccountID_t);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00009E6C File Offset: 0x0000806C
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(AccountID_t that)
		{
			return 0U;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00009E84 File Offset: 0x00008084
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(AccountID_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00009E9C File Offset: 0x0000809C
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(AccountID_t other)
		{
			return 0;
		}

		// Token: 0x04000ADA RID: 2778
		[Token(Token = "0x4000ADA")]
		[FieldOffset(Offset = "0x0")]
		public uint m_AccountID;
	}
}
