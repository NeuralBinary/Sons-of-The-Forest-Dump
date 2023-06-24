using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	[Documentation]
	[Serializable]
	public struct PrefabId
	{
		// Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		internal PrefabId(int value)
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x900F40", Offset = "0x8FF540", VA = "0x180900F40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x900FC0", Offset = "0x8FF5C0", VA = "0x180900FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(PrefabId a, PrefabId b)
		{
			return default(bool);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(PrefabId a, PrefabId b)
		{
			return default(bool);
		}

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x0")]
		public int Value;

		// Token: 0x020000E3 RID: 227
		[Token(Token = "0x20000E3")]
		public class Comparer : IComparer<PrefabId>
		{
			// Token: 0x060006E3 RID: 1763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			private Comparer()
			{
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x00004998 File Offset: 0x00002B98
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x901020", Offset = "0x8FF620", VA = "0x180901020", Slot = "4")]
			private int Compare(PrefabId x, PrefabId y)
			{
				return 0;
			}

			// Token: 0x0400034D RID: 845
			[Token(Token = "0x400034D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PrefabId.Comparer Instance;
		}

		// Token: 0x020000E4 RID: 228
		[Token(Token = "0x20000E4")]
		public class EqualityComparer : IEqualityComparer<PrefabId>
		{
			// Token: 0x060006E6 RID: 1766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			private EqualityComparer()
			{
			}

			// Token: 0x060006E7 RID: 1767 RVA: 0x000049B0 File Offset: 0x00002BB0
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x8EC040", Offset = "0x8EA640", VA = "0x1808EC040", Slot = "4")]
			private bool Equals(PrefabId x, PrefabId y)
			{
				return default(bool);
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x000049C8 File Offset: 0x00002BC8
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x8EC050", Offset = "0x8EA650", VA = "0x1808EC050", Slot = "5")]
			private int GetHashCode(PrefabId x)
			{
				return 0;
			}

			// Token: 0x0400034E RID: 846
			[Token(Token = "0x400034E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PrefabId.EqualityComparer Instance;
		}
	}
}
