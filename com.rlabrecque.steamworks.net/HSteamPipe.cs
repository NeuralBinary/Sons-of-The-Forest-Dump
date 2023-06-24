using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001EC RID: 492
	[Token(Token = "0x20001EC")]
	[Serializable]
	public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		// Token: 0x06000BB7 RID: 2999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public HSteamPipe(int value)
		{
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x634F00", Offset = "0x633500", VA = "0x180634F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0000A5A4 File Offset: 0x000087A4
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x98E640", Offset = "0x98CC40", VA = "0x18098E640", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0000A5BC File Offset: 0x000087BC
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0000A5D4 File Offset: 0x000087D4
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0000A5EC File Offset: 0x000087EC
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0000A604 File Offset: 0x00008804
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator HSteamPipe(int value)
		{
			return default(HSteamPipe);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0000A61C File Offset: 0x0000881C
		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static explicit operator int(HSteamPipe that)
		{
			return 0;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0000A634 File Offset: 0x00008834
		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(HSteamPipe other)
		{
			return default(bool);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0000A64C File Offset: 0x0000884C
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x98B0A0", Offset = "0x9896A0", VA = "0x18098B0A0", Slot = "5")]
		public int CompareTo(HSteamPipe other)
		{
			return 0;
		}

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x0")]
		public int m_HSteamPipe;
	}
}
