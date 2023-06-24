using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	public struct SimplexCounts
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x000047B4 File Offset: 0x000029B4
		[Token(Token = "0x17000106")]
		public int simplexCount
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x27DDE40", Offset = "0x27DC440", VA = "0x1827DDE40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x65F570", Offset = "0x65DB70", VA = "0x18065F570")]
		public SimplexCounts(int pointCount, int edgeCount, int triangleCount)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x27DDE50", Offset = "0x27DC450", VA = "0x1827DDE50")]
		public int GetSimplexStartAndSize(int index, out int size)
		{
			return 0;
		}

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x0")]
		public int pointCount;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x4")]
		public int edgeCount;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x8")]
		public int triangleCount;
	}
}
