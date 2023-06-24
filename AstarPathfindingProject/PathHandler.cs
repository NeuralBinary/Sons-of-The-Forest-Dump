using System;
using System.Text;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public class PathHandler
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00004514 File Offset: 0x00002714
		[Token(Token = "0x170000E7")]
		public ushort PathID
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x6740C0", Offset = "0x6726C0", VA = "0x1806740C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x6740D0", Offset = "0x6726D0", VA = "0x1806740D0")]
		public PathHandler(int threadID, int totalThreadCount)
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x674310", Offset = "0x672910", VA = "0x180674310")]
		public void InitializeForPath(Path p)
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x674390", Offset = "0x672990", VA = "0x180674390")]
		public void DestroyNode(GraphNode node)
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x6744A0", Offset = "0x672AA0", VA = "0x1806744A0")]
		public void InitializeNode(GraphNode node)
		{
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x6747A0", Offset = "0x672DA0", VA = "0x1806747A0")]
		public PathNode GetPathNode(int nodeIndex)
		{
			return null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x6747D0", Offset = "0x672DD0", VA = "0x1806747D0")]
		public PathNode GetPathNode(GraphNode node)
		{
			return null;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x674810", Offset = "0x672E10", VA = "0x180674810")]
		public void ClearPathIDs()
		{
		}

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x10")]
		private ushort pathID;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x14")]
		public readonly int threadID;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x18")]
		public readonly int totalThreadCount;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x20")]
		public readonly BinaryHeap heap;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x28")]
		public PathNode[] nodes;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x30")]
		public readonly StringBuilder DebugStringBuilder;
	}
}
