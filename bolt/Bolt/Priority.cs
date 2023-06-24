using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	public struct Priority
	{
		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x0")]
		public int PropertyIndex;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x4")]
		public int PropertyPriority;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x8")]
		public int PropertyUpdated;

		// Token: 0x020000BF RID: 191
		[Token(Token = "0x20000BF")]
		public class Comparer : IComparer<Priority>
		{
			// Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			private Comparer()
			{
			}

			// Token: 0x060005ED RID: 1517 RVA: 0x00003DF8 File Offset: 0x00001FF8
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x8F56F0", Offset = "0x8F3CF0", VA = "0x1808F56F0", Slot = "4")]
			private int Compare(Priority x, Priority y)
			{
				return 0;
			}

			// Token: 0x040002CC RID: 716
			[Token(Token = "0x40002CC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Priority.Comparer Instance;
		}
	}
}
