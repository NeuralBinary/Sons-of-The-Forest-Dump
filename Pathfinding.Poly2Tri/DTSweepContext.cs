using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class DTSweepContext : TriangulationContext
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x28AC1B0", Offset = "0x28AA7B0", VA = "0x1828AC1B0")]
		public DTSweepContext()
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		public TriangulationPoint Head
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public TriangulationPoint Tail
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002250 File Offset: 0x00000450
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public override bool IsDebugEnabled
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x8F37B0", Offset = "0x8F1DB0", VA = "0x1808F37B0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x28AC350", Offset = "0x28AA950", VA = "0x1828AC350", Slot = "9")]
			protected set
			{
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x28AC470", Offset = "0x28AAA70", VA = "0x1828AC470")]
		public void RemoveFromList(DelaunayTriangle triangle)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x28AC4D0", Offset = "0x28AAAD0", VA = "0x1828AC4D0")]
		public void MeshClean(DelaunayTriangle triangle)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x28AC4E0", Offset = "0x28AAAE0", VA = "0x1828AC4E0")]
		private void MeshCleanReq(DelaunayTriangle triangle)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x28AC5F0", Offset = "0x28AABF0", VA = "0x1828AC5F0", Slot = "7")]
		public override void Clear()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x28AC6C0", Offset = "0x28AACC0", VA = "0x1828AC6C0")]
		public void AddNode(AdvancingFrontNode node)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x28AC6C0", Offset = "0x28AACC0", VA = "0x1828AC6C0")]
		public void RemoveNode(AdvancingFrontNode node)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x28AC6E0", Offset = "0x28AACE0", VA = "0x1828AC6E0")]
		public AdvancingFrontNode LocateNode(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x28AC780", Offset = "0x28AAD80", VA = "0x1828AC780")]
		public void CreateAdvancingFront()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x28ACDE0", Offset = "0x28AB3E0", VA = "0x1828ACDE0")]
		public void MapTriangleToNodes(DelaunayTriangle t)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x28ACF00", Offset = "0x28AB500", VA = "0x1828ACF00", Slot = "5")]
		public override void PrepareTriangulation(Triangulatable t)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x28AD480", Offset = "0x28ABA80", VA = "0x1828AD480")]
		public void FinalizeTriangulation()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x28AD510", Offset = "0x28ABB10", VA = "0x1828AD510", Slot = "6")]
		public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b)
		{
			return null;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x1700000E")]
		public override TriangulationAlgorithm Algorithm
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
			get
			{
				return TriangulationAlgorithm.DTSweep;
			}
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x40")]
		private readonly float ALPHA;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x48")]
		public AdvancingFront Front;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x50")]
		public DTSweepBasin Basin;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x58")]
		public DTSweepEdgeEvent EdgeEvent;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x60")]
		private DTSweepPointComparator _comparator;
	}
}
