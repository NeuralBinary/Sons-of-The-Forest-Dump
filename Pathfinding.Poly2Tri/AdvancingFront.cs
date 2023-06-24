using System;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class AdvancingFront
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x28A6E30", Offset = "0x28A5430", VA = "0x1828A6E30")]
		public AdvancingFront(AdvancingFrontNode head, AdvancingFrontNode tail)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void AddNode(AdvancingFrontNode node)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void RemoveNode(AdvancingFrontNode node)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x28A6F50", Offset = "0x28A5550", VA = "0x1828A6F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		private AdvancingFrontNode FindSearchNode(double x)
		{
			return null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x28A7050", Offset = "0x28A5650", VA = "0x1828A7050")]
		public AdvancingFrontNode LocateNode(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x28A70F0", Offset = "0x28A56F0", VA = "0x1828A70F0")]
		private AdvancingFrontNode LocateNode(double x)
		{
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x28A7180", Offset = "0x28A5780", VA = "0x1828A7180")]
		public AdvancingFrontNode LocatePoint(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x10")]
		public AdvancingFrontNode Head;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		public AdvancingFrontNode Tail;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		protected AdvancingFrontNode Search;
	}
}
