using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	[Documentation]
	[StructLayout(2)]
	public struct UniqueId
	{
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700012F")]
		public string IdString
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x900470", Offset = "0x8FEA70", VA = "0x180900470")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x17000130")]
		public bool IsNone
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x9004F0", Offset = "0x8FEAF0", VA = "0x1809004F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x900580", Offset = "0x8FEB80", VA = "0x180900580")]
		public UniqueId(string guid)
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x9006A0", Offset = "0x8FECA0", VA = "0x1809006A0")]
		public UniqueId(byte[] bytes)
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x9007B0", Offset = "0x8FEDB0", VA = "0x1809007B0")]
		public UniqueId(byte byte0, byte byte1, byte byte2, byte byte3, byte byte4, byte byte5, byte byte6, byte byte7, byte byte8, byte byte9, byte byte10, byte byte11, byte byte12, byte byte13, byte byte14, byte byte15)
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x900830", Offset = "0x8FEE30", VA = "0x180900830")]
		public byte[] ToByteArray()
		{
			return null;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x900840", Offset = "0x8FEE40", VA = "0x180900840", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x900850", Offset = "0x8FEE50", VA = "0x180900850", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x900910", Offset = "0x8FEF10", VA = "0x180900910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x17000131")]
		public static UniqueId None
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x9009B0", Offset = "0x8FEFB0", VA = "0x1809009B0")]
			get
			{
				return default(UniqueId);
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x9009C0", Offset = "0x8FEFC0", VA = "0x1809009C0")]
		public static UniqueId New()
		{
			return default(UniqueId);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x900A20", Offset = "0x8FF020", VA = "0x180900A20")]
		public static UniqueId Parse(string text)
		{
			return default(UniqueId);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x900B10", Offset = "0x8FF110", VA = "0x180900B10")]
		public static bool operator ==(UniqueId a, UniqueId b)
		{
			return default(bool);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x8DB240", Offset = "0x8D9840", VA = "0x1808DB240")]
		public static bool operator !=(UniqueId a, UniqueId b)
		{
			return default(bool);
		}

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Guid guid;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal uint uint0;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal uint uint1;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal uint uint2;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal uint uint3;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte byte0;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private byte byte1;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private byte byte2;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private byte byte3;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private byte byte4;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		private byte byte5;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private byte byte6;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		private byte byte7;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte byte8;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private byte byte9;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private byte byte10;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		private byte byte11;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private byte byte12;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		private byte byte13;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		private byte byte14;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		private byte byte15;

		// Token: 0x020000DF RID: 223
		[Token(Token = "0x20000DF")]
		public class EqualityComparer : IEqualityComparer<UniqueId>
		{
			// Token: 0x060006D0 RID: 1744 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			private EqualityComparer()
			{
			}

			// Token: 0x060006D1 RID: 1745 RVA: 0x00004860 File Offset: 0x00002A60
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x900B70", Offset = "0x8FF170", VA = "0x180900B70", Slot = "4")]
			private bool Equals(UniqueId x, UniqueId y)
			{
				return default(bool);
			}

			// Token: 0x060006D2 RID: 1746 RVA: 0x00004878 File Offset: 0x00002A78
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x900BD0", Offset = "0x8FF1D0", VA = "0x180900BD0", Slot = "5")]
			private int GetHashCode(UniqueId x)
			{
				return 0;
			}

			// Token: 0x04000343 RID: 835
			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UniqueId.EqualityComparer Instance;
		}
	}
}
