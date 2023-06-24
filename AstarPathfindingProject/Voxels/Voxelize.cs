using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding.Voxels
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	public class Voxelize
	{
		// Token: 0x060008E4 RID: 2276 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x6ED390", Offset = "0x6EB990", VA = "0x1806ED390")]
		public void BuildContours(float maxError, int maxEdgeLength, VoxelContourSet cset, int buildFlags)
		{
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x6EDF60", Offset = "0x6EC560", VA = "0x1806EDF60")]
		private void GetClosestIndices(int[] vertsa, int nvertsa, int[] vertsb, int nvertsb, ref int ia, ref int ib)
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x6EE1D0", Offset = "0x6EC7D0", VA = "0x1806EE1D0")]
		private static void ReleaseContours(VoxelContourSet cset)
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00005F3C File Offset: 0x0000413C
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x6EE340", Offset = "0x6EC940", VA = "0x1806EE340")]
		public static bool MergeContours(ref VoxelContour ca, ref VoxelContour cb, int ia, int ib)
		{
			return default(bool);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x6EE700", Offset = "0x6ECD00", VA = "0x1806EE700")]
		public void SimplifyContour(List<int> verts, List<int> simplified, float maxError, int maxEdgeLenght, int buildFlags)
		{
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x6EF600", Offset = "0x6EDC00", VA = "0x1806EF600")]
		public void WalkContour(int x, int z, int i, ushort[] flags, List<int> verts)
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00005F54 File Offset: 0x00004154
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x6EFAC0", Offset = "0x6EE0C0", VA = "0x1806EFAC0")]
		public int GetCornerHeight(int x, int z, int i, int dir, ref bool isBorderVertex)
		{
			return 0;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x6F01C0", Offset = "0x6EE7C0", VA = "0x1806F01C0")]
		public void RemoveDegenerateSegments(List<int> simplified)
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00005F6C File Offset: 0x0000416C
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x6F0320", Offset = "0x6EE920", VA = "0x1806F0320")]
		public int CalcAreaOfPolygon2D(int[] verts, int nverts)
		{
			return 0;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00005F84 File Offset: 0x00004184
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x6F0400", Offset = "0x6EEA00", VA = "0x1806F0400")]
		public static bool Ileft(int a, int b, int c, int[] va, int[] vb, int[] vc)
		{
			return default(bool);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00005F9C File Offset: 0x0000419C
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x6F04E0", Offset = "0x6EEAE0", VA = "0x1806F04E0")]
		public static bool Diagonal(int i, int j, int n, int[] verts, int[] indices)
		{
			return default(bool);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00005FB4 File Offset: 0x000041B4
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x6F0670", Offset = "0x6EEC70", VA = "0x1806F0670")]
		public static bool InCone(int i, int j, int n, int[] verts, int[] indices)
		{
			return default(bool);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00005FCC File Offset: 0x000041CC
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x6F07D0", Offset = "0x6EEDD0", VA = "0x1806F07D0")]
		public static bool Left(int a, int b, int c, int[] verts)
		{
			return default(bool);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00005FE4 File Offset: 0x000041E4
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x6F07F0", Offset = "0x6EEDF0", VA = "0x1806F07F0")]
		public static bool LeftOn(int a, int b, int c, int[] verts)
		{
			return default(bool);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00005FFC File Offset: 0x000041FC
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x6F0810", Offset = "0x6EEE10", VA = "0x1806F0810")]
		public static bool Collinear(int a, int b, int c, int[] verts)
		{
			return default(bool);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00006014 File Offset: 0x00004214
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x6F0830", Offset = "0x6EEE30", VA = "0x1806F0830")]
		public static int Area2(int a, int b, int c, int[] verts)
		{
			return 0;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0000602C File Offset: 0x0000422C
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x6F08E0", Offset = "0x6EEEE0", VA = "0x1806F08E0")]
		private static bool Diagonalie(int i, int j, int n, int[] verts, int[] indices)
		{
			return default(bool);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00006044 File Offset: 0x00004244
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x6F0B10", Offset = "0x6EF110", VA = "0x1806F0B10")]
		public static bool Xorb(bool x, bool y)
		{
			return default(bool);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0000605C File Offset: 0x0000425C
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x6F0B20", Offset = "0x6EF120", VA = "0x1806F0B20")]
		public static bool IntersectProp(int a, int b, int c, int d, int[] verts)
		{
			return default(bool);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00006074 File Offset: 0x00004274
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x6F0C70", Offset = "0x6EF270", VA = "0x1806F0C70")]
		private static bool Between(int a, int b, int c, int[] verts)
		{
			return default(bool);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0000608C File Offset: 0x0000428C
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x6F0D80", Offset = "0x6EF380", VA = "0x1806F0D80")]
		private static bool Intersect(int a, int b, int c, int d, int[] verts)
		{
			return default(bool);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000060A4 File Offset: 0x000042A4
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x6F0F30", Offset = "0x6EF530", VA = "0x1806F0F30")]
		private static bool Vequal(int a, int b, int[] verts)
		{
			return default(bool);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x000060BC File Offset: 0x000042BC
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x6F0F90", Offset = "0x6EF590", VA = "0x1806F0F90")]
		public static int Prev(int i, int n)
		{
			return 0;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000060D4 File Offset: 0x000042D4
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x6F0FA0", Offset = "0x6EF5A0", VA = "0x1806F0FA0")]
		public static int Next(int i, int n)
		{
			return 0;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x6F0FB0", Offset = "0x6EF5B0", VA = "0x1806F0FB0")]
		public void BuildPolyMesh(VoxelContourSet cset, int nvp, out VoxelMesh mesh)
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x000060EC File Offset: 0x000042EC
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x6F1820", Offset = "0x6EFE20", VA = "0x1806F1820")]
		private int Triangulate(int n, int[] verts, ref int[] indices, ref int[] tris)
		{
			return 0;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000145")]
		public GraphTransform transformVoxel2Graph
		{
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00006104 File Offset: 0x00004304
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x6F1D70", Offset = "0x6F0370", VA = "0x1806F1D70")]
		public Vector3 CompactSpanToVector(int x, int z, int i)
		{
			return default(Vector3);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x6F1E40", Offset = "0x6F0440", VA = "0x1806F1E40")]
		public void VectorToIndex(Vector3 p, out int x, out int z)
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x6F1F00", Offset = "0x6F0500", VA = "0x1806F1F00")]
		public Voxelize(float ch, float cs, float walkableClimb, float walkableHeight, float maxSlope, float maxEdgeLength)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x6F2020", Offset = "0x6F0620", VA = "0x1806F2020")]
		public void Init()
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x6F2190", Offset = "0x6F0790", VA = "0x1806F2190")]
		public void VoxelizeInput(GraphTransform graphTransform, Bounds graphSpaceBounds)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x6F3600", Offset = "0x6F1C00", VA = "0x1806F3600")]
		public void DebugDrawSpans()
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x6F39A0", Offset = "0x6F1FA0", VA = "0x1806F39A0")]
		public void BuildCompactField()
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x6F3E30", Offset = "0x6F2430", VA = "0x1806F3E30")]
		public void BuildVoxelConnections()
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x6F41F0", Offset = "0x6F27F0", VA = "0x1806F41F0")]
		private void DrawLine(int a, int b, int[] indices, int[] verts, Color color)
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0000611C File Offset: 0x0000431C
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x6F4510", Offset = "0x6F2B10", VA = "0x1806F4510")]
		public Vector3 VoxelToWorld(int x, int y, int z)
		{
			return default(Vector3);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00006134 File Offset: 0x00004334
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x6F45C0", Offset = "0x6F2BC0", VA = "0x1806F45C0")]
		public Int3 VoxelToWorldInt3(Int3 voxelPosition)
		{
			return default(Int3);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0000614C File Offset: 0x0000434C
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x6F4750", Offset = "0x6F2D50", VA = "0x1806F4750")]
		private Vector3 ConvertPosWithoutOffset(int x, int y, int z)
		{
			return default(Vector3);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00006164 File Offset: 0x00004364
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x6F4820", Offset = "0x6F2E20", VA = "0x1806F4820")]
		private Vector3 ConvertPosition(int x, int z, int i)
		{
			return default(Vector3);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x6F48F0", Offset = "0x6F2EF0", VA = "0x1806F48F0")]
		public void ErodeWalkableArea(int radius)
		{
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x6F4A40", Offset = "0x6F3040", VA = "0x1806F4A40")]
		public void BuildDistanceField()
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x6F4C00", Offset = "0x6F3200", VA = "0x1806F4C00")]
		[Obsolete("This function is not complete and should not be used")]
		public void ErodeVoxels(int radius)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x6F4E60", Offset = "0x6F3460", VA = "0x1806F4E60")]
		public void FilterLowHeightSpans(uint voxelWalkableHeight, float cs, float ch)
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x6F4F80", Offset = "0x6F3580", VA = "0x1806F4F80")]
		public void FilterLedges(uint voxelWalkableHeight, int voxelWalkableClimb, float cs, float ch)
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0000617C File Offset: 0x0000437C
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x6F5410", Offset = "0x6F3A10", VA = "0x1806F5410")]
		public bool FloodRegion(int x, int z, int i, uint level, ushort r, ushort[] srcReg, ushort[] srcDist, Int3[] stack, [Optional] int[] flags, [Optional] bool[] closed)
		{
			return default(bool);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x6F5AB0", Offset = "0x6F40B0", VA = "0x1806F5AB0")]
		public void MarkRectWithRegion(int minx, int maxx, int minz, int maxz, ushort region, ushort[] srcReg)
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00006194 File Offset: 0x00004394
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x6F5BE0", Offset = "0x6F41E0", VA = "0x1806F5BE0")]
		public ushort CalculateDistanceField(ushort[] src)
		{
			return 0;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x6F65C0", Offset = "0x6F4BC0", VA = "0x1806F65C0")]
		public ushort[] BoxBlur(ushort[] src, ushort[] dst)
		{
			return null;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x6F6910", Offset = "0x6F4F10", VA = "0x1806F6910")]
		public void BuildRegions()
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000061AC File Offset: 0x000043AC
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x6F7BC0", Offset = "0x6F61C0", VA = "0x1806F7BC0")]
		private static int union_find_find(int[] arr, int x)
		{
			return 0;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x6F7C30", Offset = "0x6F6230", VA = "0x1806F7C30")]
		private static void union_find_union(int[] arr, int a, int b)
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x6F7D40", Offset = "0x6F6340", VA = "0x1806F7D40")]
		public void FilterSmallRegions(ushort[] reg, int minRegionSize, int maxRegions)
		{
		}

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<RasterizationMesh> inputMeshes;

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly int voxelWalkableClimb;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly uint voxelWalkableHeight;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly float cellSize;

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly float cellHeight;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int minRegionSize;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int borderSize;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxEdgeLength;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxSlope;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RecastGraph.RelevantGraphSurfaceMode relevantGraphSurfaceMode;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Bounds forcedBounds;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public VoxelArea voxelArea;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public VoxelContourSet countourSet;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GraphTransform transform;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int width;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int depth;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 voxelOffset;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		public const uint NotConnected = 63U;

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		private const int MaxLayers = 65535;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		private const int MaxRegions = 500;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		private const int UnwalkableArea = 0;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		private const ushort BorderReg = 32768;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		private const int RC_BORDER_VERTEX = 65536;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		private const int RC_AREA_BORDER = 131072;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		private const int VERTEX_BUCKET_COUNT = 4096;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		public const int RC_CONTOUR_TESS_WALL_EDGES = 1;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		public const int RC_CONTOUR_TESS_AREA_EDGES = 2;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		public const int RC_CONTOUR_TESS_TILE_EDGES = 4;

		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		private const int ContourRegMask = 65535;

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private readonly Vector3 cellScale;
	}
}
