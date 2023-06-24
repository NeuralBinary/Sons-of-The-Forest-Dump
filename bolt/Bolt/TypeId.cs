using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	[Documentation]
	[Serializable]
	public struct TypeId
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		internal TypeId(int value)
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x901170", Offset = "0x8FF770", VA = "0x180901170", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x9011F0", Offset = "0x8FF7F0", VA = "0x1809011F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x8FFBA0", Offset = "0x8FE1A0", VA = "0x1808FFBA0")]
		public static bool operator ==(TypeId a, TypeId b)
		{
			return default(bool);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x8DB230", Offset = "0x8D9830", VA = "0x1808DB230")]
		public static bool operator !=(TypeId a, TypeId b)
		{
			return default(bool);
		}

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x0")]
		public int Value;

		// Token: 0x020000E6 RID: 230
		[Token(Token = "0x20000E6")]
		public class Comparer : IComparer<TypeId>
		{
			// Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			private Comparer()
			{
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x00004A40 File Offset: 0x00002C40
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x901020", Offset = "0x8FF620", VA = "0x180901020", Slot = "4")]
			private int Compare(TypeId x, TypeId y)
			{
				return 0;
			}

			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			[FieldOffset(Offset = "0x0")]
			public static readonly TypeId.Comparer Instance;
		}

		// Token: 0x020000E7 RID: 231
		[Token(Token = "0x20000E7")]
		public class EqualityComparer : IEqualityComparer<TypeId>
		{
			// Token: 0x060006F3 RID: 1779 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			private EqualityComparer()
			{
			}

			// Token: 0x060006F4 RID: 1780 RVA: 0x00004A58 File Offset: 0x00002C58
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x8EC040", Offset = "0x8EA640", VA = "0x1808EC040", Slot = "4")]
			private bool Equals(TypeId x, TypeId y)
			{
				return default(bool);
			}

			// Token: 0x060006F5 RID: 1781 RVA: 0x00004A70 File Offset: 0x00002C70
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x8EC050", Offset = "0x8EA650", VA = "0x1808EC050", Slot = "5")]
			private int GetHashCode(TypeId x)
			{
				return 0;
			}

			// Token: 0x04000351 RID: 849
			[Token(Token = "0x4000351")]
			[FieldOffset(Offset = "0x0")]
			public static readonly TypeId.EqualityComparer Instance;
		}
	}
}
