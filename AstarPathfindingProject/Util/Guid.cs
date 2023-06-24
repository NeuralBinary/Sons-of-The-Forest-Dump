using System;
using System.Text;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public struct Guid
	{
		// Token: 0x06000A2B RID: 2603 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x717F50", Offset = "0x716550", VA = "0x180717F50")]
		public Guid(byte[] bytes)
		{
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x7180D0", Offset = "0x7166D0", VA = "0x1807180D0")]
		public Guid(string str)
		{
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000066BC File Offset: 0x000048BC
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x7184A0", Offset = "0x716AA0", VA = "0x1807184A0")]
		public static Guid Parse(string input)
		{
			return default(Guid);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000066D4 File Offset: 0x000048D4
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x7184C0", Offset = "0x716AC0", VA = "0x1807184C0")]
		private static ulong SwapEndianness(ulong value)
		{
			return 0UL;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x718540", Offset = "0x716B40", VA = "0x180718540")]
		public byte[] ToByteArray()
		{
			return null;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000066EC File Offset: 0x000048EC
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x718680", Offset = "0x716C80", VA = "0x180718680")]
		public static Guid NewGuid()
		{
			return default(Guid);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00006704 File Offset: 0x00004904
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x718730", Offset = "0x716D30", VA = "0x180718730")]
		public static bool operator ==(Guid lhs, Guid rhs)
		{
			return default(bool);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0000671C File Offset: 0x0000491C
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x718750", Offset = "0x716D50", VA = "0x180718750")]
		public static bool operator !=(Guid lhs, Guid rhs)
		{
			return default(bool);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00006734 File Offset: 0x00004934
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x718770", Offset = "0x716D70", VA = "0x180718770", Slot = "0")]
		public override bool Equals(object _rhs)
		{
			return default(bool);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0000674C File Offset: 0x0000494C
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x718810", Offset = "0x716E10", VA = "0x180718810", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x718830", Offset = "0x716E30", VA = "0x180718830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		private const string hex = "0123456789ABCDEF";

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid zero;

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string zeroString;

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x0")]
		private readonly ulong _a;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x8")]
		private readonly ulong _b;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x18")]
		private static Random random;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x20")]
		private static StringBuilder text;
	}
}
