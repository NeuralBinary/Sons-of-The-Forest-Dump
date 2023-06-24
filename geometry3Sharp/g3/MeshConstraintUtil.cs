using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000253 RID: 595
	[Token(Token = "0x2000253")]
	public static class MeshConstraintUtil
	{
		// Token: 0x0600151C RID: 5404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x1E8D8C0", Offset = "0x1E8BEC0", VA = "0x181E8D8C0")]
		public static void FixEdges(MeshConstraints cons, DMesh3 mesh, IEnumerable<int> edges)
		{
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x1E8DC70", Offset = "0x1E8C270", VA = "0x181E8DC70")]
		public static void FixAllBoundaryEdges(MeshConstraints cons, DMesh3 mesh)
		{
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x1E8DF00", Offset = "0x1E8C500", VA = "0x181E8DF00")]
		public static void FixAllBoundaryEdges(Remesher r)
		{
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600151F")]
		[Address(RVA = "0x1E8DFE0", Offset = "0x1E8C5E0", VA = "0x181E8DFE0")]
		public static void FixAllBoundaryEdges_AllowCollapse(MeshConstraints cons, DMesh3 mesh, int setID)
		{
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001520")]
		[Address(RVA = "0x1E8E2D0", Offset = "0x1E8C8D0", VA = "0x181E8E2D0")]
		public static void FixAllBoundaryEdges_AllowSplit(MeshConstraints cons, DMesh3 mesh, int setID)
		{
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x1E8E5C0", Offset = "0x1E8CBC0", VA = "0x181E8E5C0")]
		public static void FixSubmeshBoundaryEdges(MeshConstraints cons, DSubmesh3 sub)
		{
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001522")]
		[Address(RVA = "0x1E8E9B0", Offset = "0x1E8CFB0", VA = "0x181E8E9B0")]
		public static void FixAllGroupBoundaryEdges(MeshConstraints cons, DMesh3 mesh, bool bPinVertices)
		{
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001523")]
		[Address(RVA = "0x1E8EC50", Offset = "0x1E8D250", VA = "0x181E8EC50")]
		public static void FixAllGroupBoundaryEdges(Remesher r, bool bPinVertices)
		{
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001524")]
		[Address(RVA = "0x1E8ED30", Offset = "0x1E8D330", VA = "0x181E8ED30")]
		public static void ConstrainVtxLoopTo(MeshConstraints cons, DMesh3 mesh, IList<int> loopV, IProjectionTarget target, int setID = -1)
		{
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001525")]
		[Address(RVA = "0x1E8F150", Offset = "0x1E8D750", VA = "0x181E8F150")]
		public static void ConstrainVtxLoopTo(Remesher r, int[] loopV, IProjectionTarget target, int setID = -1)
		{
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001526")]
		[Address(RVA = "0x1E8F260", Offset = "0x1E8D860", VA = "0x181E8F260")]
		public static void ConstrainVtxSpanTo(MeshConstraints cons, DMesh3 mesh, IList<int> spanV, IProjectionTarget target, int setID = -1)
		{
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001527")]
		[Address(RVA = "0x1E8F7D0", Offset = "0x1E8DDD0", VA = "0x181E8F7D0")]
		public static void ConstrainVtxSpanTo(Remesher r, int[] spanV, IProjectionTarget target, int setID = -1)
		{
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x1E8F8E0", Offset = "0x1E8DEE0", VA = "0x181E8F8E0")]
		public static void PreserveBoundaryLoops(MeshConstraints cons, DMesh3 mesh)
		{
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x1E8FBC0", Offset = "0x1E8E1C0", VA = "0x181E8FBC0")]
		public static void PreserveBoundaryLoops(Remesher r)
		{
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x1E8FCA0", Offset = "0x1E8E2A0", VA = "0x181E8FCA0")]
		public static void AddTrackedEdges(MeshConstraints cons, int[] edges, int setID)
		{
		}
	}
}
