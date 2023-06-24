using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	[Serializable]
	public struct HServerListRequest : IEquatable<HServerListRequest>
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public HServerListRequest(IntPtr value)
		{
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x98B400", Offset = "0x989A00", VA = "0x18098B400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000090A4 File Offset: 0x000072A4
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x98B410", Offset = "0x989A10", VA = "0x18098B410", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x000090BC File Offset: 0x000072BC
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x000090D4 File Offset: 0x000072D4
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x000090EC File Offset: 0x000072EC
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x98B4B0", Offset = "0x989AB0", VA = "0x18098B4B0")]
		public static bool operator !=(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00009104 File Offset: 0x00007304
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator HServerListRequest(IntPtr value)
		{
			return default(HServerListRequest);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0000911C File Offset: 0x0000731C
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator IntPtr(HServerListRequest that)
		{
			return 0;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00009134 File Offset: 0x00007334
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(HServerListRequest other)
		{
			return default(bool);
		}

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HServerListRequest Invalid;

		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4000AA2")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr m_HServerListRequest;
	}
}
