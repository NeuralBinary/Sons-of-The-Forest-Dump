using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	public class DGraph2Resampler
	{
		// Token: 0x0600066D RID: 1645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1FABF50", Offset = "0x1FAA550", VA = "0x181FABF50")]
		public DGraph2Resampler(DGraph2 graph)
		{
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1FAC160", Offset = "0x1FAA760", VA = "0x181FAC160")]
		public void SplitToMaxEdgeLength(double fMaxLen)
		{
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1FAC7A0", Offset = "0x1FAADA0", VA = "0x181FAC7A0")]
		public void CollapseFlatVertices(double fMaxDeviationDeg = 5.0)
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1FACAC0", Offset = "0x1FAB0C0", VA = "0x181FACAC0")]
		public void CollapseDegenerateEdges(double fDegenLenThresh = 1.1920928955078125E-07)
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1FACD30", Offset = "0x1FAB330", VA = "0x181FACD30")]
		public void CollapseToMinEdgeLength(double fMinLen)
		{
		}

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x10")]
		public DGraph2 Graph;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x18")]
		public Func<int, bool> FixedEdgeFilterF;
	}
}
