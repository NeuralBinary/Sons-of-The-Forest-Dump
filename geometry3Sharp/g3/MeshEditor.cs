using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	public class MeshEditor
	{
		// Token: 0x0600153B RID: 5435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public MeshEditor(DMesh3 mesh)
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x1E91630", Offset = "0x1E8FC30", VA = "0x181E91630", Slot = "4")]
		public virtual int[] AddTriangleStrip(IList<Frame3f> frames, IList<Interval1d> spans, int group_id = -1)
		{
			return null;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x1E91D30", Offset = "0x1E90330", VA = "0x181E91D30", Slot = "5")]
		public virtual int[] AddTriangleFan_OrderedVertexLoop(int center, int[] vertex_loop, int group_id = -1)
		{
			return null;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600153E")]
		[Address(RVA = "0x1E91F40", Offset = "0x1E90540", VA = "0x181E91F40", Slot = "6")]
		public virtual int[] AddTriangleFan_OrderedEdgeLoop(int center, int[] edge_loop, int group_id = -1)
		{
			return null;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600153F")]
		[Address(RVA = "0x1E92100", Offset = "0x1E90700", VA = "0x181E92100", Slot = "7")]
		public virtual int[] StitchLoop(int[] vloop1, int[] vloop2, int group_id = -1)
		{
			return null;
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001540")]
		[Address(RVA = "0x1E92420", Offset = "0x1E90A20", VA = "0x181E92420", Slot = "8")]
		public virtual int[] StitchVertexLoops_NearestV(int[] loop0, int[] loop1, int group_id = -1)
		{
			return null;
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001541")]
		[Address(RVA = "0x1E92740", Offset = "0x1E90D40", VA = "0x181E92740", Slot = "9")]
		public virtual int[] StitchUnorderedEdges(List<Index2i> EdgePairs, int group_id, bool bAbortOnFailure, out bool stitch_incomplete)
		{
			return null;
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001542")]
		[Address(RVA = "0x1E92B30", Offset = "0x1E91130", VA = "0x181E92B30", Slot = "10")]
		public virtual int[] StitchUnorderedEdges(List<Index2i> EdgePairs, int group_id = -1, bool bAbortOnFailure = true)
		{
			return null;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x1E92B70", Offset = "0x1E91170", VA = "0x181E92B70", Slot = "11")]
		public virtual int[] StitchSpan(IList<int> vspan1, IList<int> vspan2, int group_id = -1)
		{
			return null;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000104FC File Offset: 0x0000E6FC
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x1E92EA0", Offset = "0x1E914A0", VA = "0x181E92EA0")]
		public bool RemoveTriangles(IList<int> triangles, bool bRemoveIsolatedVerts)
		{
			return default(bool);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00010514 File Offset: 0x0000E714
		[Token(Token = "0x6001545")]
		[Address(RVA = "0x1E93090", Offset = "0x1E91690", VA = "0x181E93090")]
		public bool RemoveTriangles(IEnumerable<int> triangles, bool bRemoveIsolatedVerts)
		{
			return default(bool);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0001052C File Offset: 0x0000E72C
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x1E933A0", Offset = "0x1E919A0", VA = "0x181E933A0")]
		public bool RemoveTriangles(Func<int, bool> selectorF, bool bRemoveIsolatedVerts)
		{
			return default(bool);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00010544 File Offset: 0x0000E744
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x1E93570", Offset = "0x1E91B70", VA = "0x181E93570")]
		public static bool RemoveTriangles(DMesh3 Mesh, IList<int> triangles, bool bRemoveIsolatedVerts = true)
		{
			return default(bool);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0001055C File Offset: 0x0000E75C
		[Token(Token = "0x6001548")]
		[Address(RVA = "0x1E93630", Offset = "0x1E91C30", VA = "0x181E93630")]
		public static bool RemoveTriangles(DMesh3 Mesh, IEnumerable<int> triangles, bool bRemoveIsolatedVerts = true)
		{
			return default(bool);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00010574 File Offset: 0x0000E774
		[Token(Token = "0x6001549")]
		[Address(RVA = "0x1E936F0", Offset = "0x1E91CF0", VA = "0x181E936F0")]
		public static bool RemoveIsolatedTriangles(DMesh3 mesh)
		{
			return default(bool);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0001058C File Offset: 0x0000E78C
		[Token(Token = "0x600154A")]
		[Address(RVA = "0x1E93880", Offset = "0x1E91E80", VA = "0x181E93880")]
		public static int RemoveFinTriangles(DMesh3 mesh, [Optional] Func<DMesh3, int, bool> removeF, bool bRepeatToConvergence = true)
		{
			return 0;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000105A4 File Offset: 0x0000E7A4
		[Token(Token = "0x600154B")]
		[Address(RVA = "0x1E93CE0", Offset = "0x1E922E0", VA = "0x181E93CE0")]
		public bool SeparateTriangles(IEnumerable<int> triangles, bool bComputeEdgePairs, out List<Index2i> EdgePairs)
		{
			return default(bool);
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600154C")]
		[Address(RVA = "0x1E94870", Offset = "0x1E92E70", VA = "0x181E94870")]
		public List<int> DuplicateTriangles(IEnumerable<int> triangles, ref IndexMap MapV, int group_id = -1)
		{
			return null;
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600154D")]
		[Address(RVA = "0x1E94BE0", Offset = "0x1E931E0", VA = "0x181E94BE0")]
		public void ReverseTriangles(IEnumerable<int> triangles, bool bFlipVtxNormals = true)
		{
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600154E")]
		[Address(RVA = "0x1E95100", Offset = "0x1E93700", VA = "0x181E95100")]
		public void DisconnectBowtie(int vid)
		{
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000105BC File Offset: 0x0000E7BC
		[Token(Token = "0x600154F")]
		[Address(RVA = "0x1E958A0", Offset = "0x1E93EA0", VA = "0x181E958A0")]
		private static int bowtie_sorter(List<int> l1, List<int> l2)
		{
			return 0;
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x000105D4 File Offset: 0x0000E7D4
		[Token(Token = "0x6001550")]
		[Address(RVA = "0x1E95910", Offset = "0x1E93F10", VA = "0x181E95910")]
		public int DisconnectAllBowties(int nMaxIters = 10)
		{
			return 0;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000105EC File Offset: 0x0000E7EC
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x1E95B40", Offset = "0x1E94140", VA = "0x181E95B40")]
		public bool ReinsertSubmesh(DSubmesh3 sub, ref int[] new_tris, out IndexMap SubToNewV, MeshEditor.DuplicateTriBehavior eDuplicateBehavior = MeshEditor.DuplicateTriBehavior.AssertAbort)
		{
			return default(bool);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00010604 File Offset: 0x0000E804
		[Token(Token = "0x6001552")]
		[Address(RVA = "0x1E961A0", Offset = "0x1E947A0", VA = "0x181E961A0")]
		public bool AppendMesh(IMesh appendMesh, int appendGID = -1)
		{
			return default(bool);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0001061C File Offset: 0x0000E81C
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x1E961D0", Offset = "0x1E947D0", VA = "0x181E961D0")]
		public bool AppendMesh(IMesh appendMesh, out int[] mapV, int appendGID = -1)
		{
			return default(bool);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x1E968F0", Offset = "0x1E94EF0", VA = "0x181E968F0")]
		public static DMesh3 Combine(params IMesh[] appendMeshes)
		{
			return null;
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x1E96A30", Offset = "0x1E95030", VA = "0x181E96A30")]
		public static void Append(DMesh3 appendTo, DMesh3 append)
		{
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00010634 File Offset: 0x0000E834
		[Token(Token = "0x6001556")]
		[Address(RVA = "0x1E96AF0", Offset = "0x1E950F0", VA = "0x181E96AF0")]
		public bool AppendMesh(IMesh appendMesh, IndexMap mergeMapV, out int[] mapV, int appendGID = -1)
		{
			return default(bool);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001557")]
		[Address(RVA = "0x1E971F0", Offset = "0x1E957F0", VA = "0x181E971F0")]
		public void AppendBox(Frame3f frame, float size)
		{
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001558")]
		[Address(RVA = "0x1E97350", Offset = "0x1E95950", VA = "0x181E97350")]
		public void AppendBox(Frame3f frame, Vector3f size)
		{
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001559")]
		[Address(RVA = "0x1E97410", Offset = "0x1E95A10", VA = "0x181E97410")]
		public void AppendBox(Frame3f frame, Vector3f size, Colorf color)
		{
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x1E976D0", Offset = "0x1E95CD0", VA = "0x181E976D0")]
		public void AppendLine(Segment3d seg, float size)
		{
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x1E97A50", Offset = "0x1E96050", VA = "0x181E97A50")]
		public void AppendLine(Segment3d seg, float size, Colorf color)
		{
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x1E97D90", Offset = "0x1E96390", VA = "0x181E97D90")]
		public static void AppendBox(DMesh3 mesh, Vector3d pos, float size)
		{
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x1E97F00", Offset = "0x1E96500", VA = "0x181E97F00")]
		public static void AppendBox(DMesh3 mesh, Vector3d pos, float size, Colorf color)
		{
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x1E98130", Offset = "0x1E96730", VA = "0x181E98130")]
		public static void AppendBox(DMesh3 mesh, Vector3d pos, Vector3d normal, float size)
		{
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x1E98280", Offset = "0x1E96880", VA = "0x181E98280")]
		public static void AppendBox(DMesh3 mesh, Vector3d pos, Vector3d normal, float size, Colorf color)
		{
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x1E98440", Offset = "0x1E96A40", VA = "0x181E98440")]
		public static void AppendBox(DMesh3 mesh, Frame3f frame, Vector3f size, Colorf color)
		{
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x1E98540", Offset = "0x1E96B40", VA = "0x181E98540")]
		public static void AppendLine(DMesh3 mesh, Segment3d seg, float size)
		{
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001562")]
		[Address(RVA = "0x1E98920", Offset = "0x1E96F20", VA = "0x181E98920")]
		public void AppendPathSolid(IEnumerable<Vector3d> vertices, double radius, Colorf color)
		{
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0001064C File Offset: 0x0000E84C
		[Token(Token = "0x6001563")]
		[Address(RVA = "0x1E98C40", Offset = "0x1E97240", VA = "0x181E98C40")]
		public bool RemoveAllBowtieVertices(bool bRepeatUntilClean)
		{
			return default(bool);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00010664 File Offset: 0x0000E864
		[Token(Token = "0x6001564")]
		[Address(RVA = "0x1E99270", Offset = "0x1E97870", VA = "0x181E99270")]
		public int RemoveUnusedVertices()
		{
			return 0;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0001067C File Offset: 0x0000E87C
		[Token(Token = "0x6001565")]
		[Address(RVA = "0x1E99430", Offset = "0x1E97A30", VA = "0x181E99430")]
		public static int RemoveUnusedVertices(DMesh3 mesh)
		{
			return 0;
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00010694 File Offset: 0x0000E894
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x1E994C0", Offset = "0x1E97AC0", VA = "0x181E994C0")]
		public int RemoveSmallComponents(double min_volume, double min_area)
		{
			return 0;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000106AC File Offset: 0x0000E8AC
		[Token(Token = "0x6001567")]
		[Address(RVA = "0x1E99800", Offset = "0x1E97E00", VA = "0x181E99800")]
		public static int RemoveSmallComponents(DMesh3 mesh, double min_volume, double min_area)
		{
			return 0;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x000106C4 File Offset: 0x0000E8C4
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x1E998C0", Offset = "0x1E97EC0", VA = "0x181E998C0")]
		private bool remove_triangles(int[] tri_list, int count)
		{
			return default(bool);
		}

		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x0200025A RID: 602
		[Token(Token = "0x200025A")]
		public enum DuplicateTriBehavior
		{
			// Token: 0x040009F1 RID: 2545
			[Token(Token = "0x40009F1")]
			AssertContinue,
			// Token: 0x040009F2 RID: 2546
			[Token(Token = "0x40009F2")]
			AssertAbort,
			// Token: 0x040009F3 RID: 2547
			[Token(Token = "0x40009F3")]
			UseExisting,
			// Token: 0x040009F4 RID: 2548
			[Token(Token = "0x40009F4")]
			Replace
		}
	}
}
