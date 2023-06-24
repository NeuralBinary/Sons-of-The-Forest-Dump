using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	[Serializable]
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		// Token: 0x06000B52 RID: 2898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public AppId_t(uint value)
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x98A610", Offset = "0x988C10", VA = "0x18098A610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00009EB4 File Offset: 0x000080B4
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x98D7D0", Offset = "0x98BDD0", VA = "0x18098D7D0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00009ECC File Offset: 0x000080CC
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00009EE4 File Offset: 0x000080E4
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00009EFC File Offset: 0x000080FC
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x98D870", Offset = "0x98BE70", VA = "0x18098D870")]
		public static bool operator !=(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00009F14 File Offset: 0x00008114
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator AppId_t(uint value)
		{
			return default(AppId_t);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00009F2C File Offset: 0x0000812C
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator uint(AppId_t that)
		{
			return 0U;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00009F44 File Offset: 0x00008144
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(AppId_t other)
		{
			return default(bool);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00009F5C File Offset: 0x0000815C
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x98A710", Offset = "0x988D10", VA = "0x18098A710", Slot = "5")]
		public int CompareTo(AppId_t other)
		{
			return 0;
		}

		// Token: 0x04000ADB RID: 2779
		[Token(Token = "0x4000ADB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AppId_t Invalid;

		// Token: 0x04000ADC RID: 2780
		[Token(Token = "0x4000ADC")]
		[FieldOffset(Offset = "0x0")]
		public uint m_AppId;
	}
}
