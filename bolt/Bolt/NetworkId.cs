using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	[StructLayout(2)]
	public struct NetworkId
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x17000140")]
		public bool IsZero
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x902DE0", Offset = "0x9013E0", VA = "0x180902DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x17000141")]
		public ulong PackedValue
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public NetworkId(ulong packed)
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x902E00", Offset = "0x901400", VA = "0x180902E00")]
		internal NetworkId(uint connection, uint entity)
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x902E10", Offset = "0x901410", VA = "0x180902E10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(NetworkId a, NetworkId b)
		{
			return default(bool);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x8DB2B0", Offset = "0x8D98B0", VA = "0x1808DB2B0")]
		public static bool operator !=(NetworkId a, NetworkId b)
		{
			return default(bool);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x9031A0", Offset = "0x9017A0", VA = "0x1809031A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ulong Packed;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly uint Connection;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal readonly uint Entity;

		// Token: 0x020000F5 RID: 245
		[Token(Token = "0x20000F5")]
		public class EqualityComparer : IEqualityComparer<NetworkId>
		{
			// Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			private EqualityComparer()
			{
			}

			// Token: 0x06000732 RID: 1842 RVA: 0x00004CE0 File Offset: 0x00002EE0
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x903220", Offset = "0x901820", VA = "0x180903220", Slot = "4")]
			private bool Equals(NetworkId x, NetworkId y)
			{
				return default(bool);
			}

			// Token: 0x06000733 RID: 1843 RVA: 0x00004CF8 File Offset: 0x00002EF8
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x903230", Offset = "0x901830", VA = "0x180903230", Slot = "5")]
			private int GetHashCode(NetworkId x)
			{
				return 0;
			}

			// Token: 0x0400036C RID: 876
			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly NetworkId.EqualityComparer Instance;
		}
	}
}
