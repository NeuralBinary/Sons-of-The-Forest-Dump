using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	[Documentation(Ignore = true)]
	public struct Filter
	{
		// Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		internal Filter(int bits)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x8EBD80", Offset = "0x8EA380", VA = "0x1808EBD80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x8EBF80", Offset = "0x8EA580", VA = "0x1808EBF80")]
		public static implicit operator bool(Filter a)
		{
			return default(bool);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x634E90", Offset = "0x633490", VA = "0x180634E90")]
		public static Filter operator &(Filter a, Filter b)
		{
			return default(Filter);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x634EA0", Offset = "0x6334A0", VA = "0x180634EA0")]
		public static Filter operator |(Filter a, Filter b)
		{
			return default(Filter);
		}

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x0")]
		internal readonly int Bits;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x0")]
		internal static string[] Names;

		// Token: 0x020000A6 RID: 166
		[Token(Token = "0x20000A6")]
		[Documentation(Ignore = true)]
		public class EqualityComparer : IEqualityComparer<Filter>
		{
			// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			private EqualityComparer()
			{
			}

			// Token: 0x0600052E RID: 1326 RVA: 0x00003A80 File Offset: 0x00001C80
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x8EC040", Offset = "0x8EA640", VA = "0x1808EC040", Slot = "4")]
			private bool Equals(Filter a, Filter b)
			{
				return default(bool);
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x00003A98 File Offset: 0x00001C98
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x8EC050", Offset = "0x8EA650", VA = "0x1808EC050", Slot = "5")]
			private int GetHashCode(Filter f)
			{
				return 0;
			}

			// Token: 0x0400027A RID: 634
			[Token(Token = "0x400027A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Filter.EqualityComparer Instance;
		}
	}
}
