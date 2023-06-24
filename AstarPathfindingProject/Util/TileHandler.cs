using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.ClipperLib;
using Pathfinding.Poly2Tri;
using Pathfinding.Voxels;
using UnityEngine;

namespace Pathfinding.Util
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	public class TileHandler
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0000656C File Offset: 0x0000476C
		[Token(Token = "0x17000150")]
		private bool isBatching
		{
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x70FE00", Offset = "0x70E400", VA = "0x18070FE00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00006584 File Offset: 0x00004784
		[Token(Token = "0x17000151")]
		public bool isValid
		{
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x70FE10", Offset = "0x70E410", VA = "0x18070FE10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x70FF10", Offset = "0x70E510", VA = "0x18070FF10")]
		public TileHandler(NavmeshBase graph)
		{
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x7103B0", Offset = "0x70E9B0", VA = "0x1807103B0")]
		public void OnRecalculatedTiles(NavmeshTile[] recalculatedTiles)
		{
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0000659C File Offset: 0x0000479C
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x710460", Offset = "0x70EA60", VA = "0x180710460")]
		public int GetActiveRotation(Int2 p)
		{
			return 0;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x7104A0", Offset = "0x70EAA0", VA = "0x1807104A0")]
		public TileHandler.TileType RegisterTileType(Mesh source, Int3 centerOffset, int width = 1, int depth = 1)
		{
			return null;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x710650", Offset = "0x70EC50", VA = "0x180710650")]
		public void CreateTileTypesFromGraph()
		{
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x710740", Offset = "0x70ED40", VA = "0x180710740")]
		private void UpdateTileType(NavmeshTile tile)
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x710B20", Offset = "0x70F120", VA = "0x180710B20")]
		public void StartBatchLoad()
		{
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x710C20", Offset = "0x70F220", VA = "0x180710C20")]
		public void EndBatchLoad()
		{
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000065B4 File Offset: 0x000047B4
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x710DD0", Offset = "0x70F3D0", VA = "0x180710DD0")]
		private TileHandler.CuttingResult CutPoly(Int3[] verts, int[] tris, Int3[] extraShape, GraphTransform graphTransform, IntRect tiles, TileHandler.CutMode mode = TileHandler.CutMode.CutAll | TileHandler.CutMode.CutDual, int perturbate = -1)
		{
			return default(TileHandler.CuttingResult);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x7133A0", Offset = "0x7119A0", VA = "0x1807133A0")]
		private static List<TileHandler.Cut> PrepareNavmeshCutsForCutting(List<NavmeshCut> navmeshCuts, GraphTransform transform, IntRect cutSpaceBounds, int perturbate, bool anyNavmeshAdds)
		{
			return null;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x713B60", Offset = "0x712160", VA = "0x180713B60")]
		private static void PoolPolygon(Polygon polygon, Stack<Polygon> pool)
		{
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x714060", Offset = "0x712660", VA = "0x180714060")]
		private void CutAll(List<IntPoint> poly, List<int> intersectingCutIndices, List<TileHandler.Cut> cuts, PolyTree result)
		{
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x714240", Offset = "0x712840", VA = "0x180714240")]
		private void CutDual(List<IntPoint> poly, List<int> tmpIntersectingCuts, List<TileHandler.Cut> cuts, bool hasDual, List<List<IntPoint>> intermediateResult, PolyTree result)
		{
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x7145F0", Offset = "0x712BF0", VA = "0x1807145F0")]
		private void CutExtra(List<IntPoint> poly, List<IntPoint> extraClipShape, PolyTree result)
		{
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000065CC File Offset: 0x000047CC
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x7146F0", Offset = "0x712CF0", VA = "0x1807146F0")]
		private int ClipAgainstRectangle(Int3[] clipIn, Int3[] clipOut, Int2 size)
		{
			return 0;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x715180", Offset = "0x713780", VA = "0x180715180")]
		private static void CopyMesh(Int3[] vertices, int[] triangles, List<Int3> outVertices, List<int> outTriangles)
		{
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x7153D0", Offset = "0x7139D0", VA = "0x1807153D0")]
		private void DelaunayRefinement(Int3[] verts, int[] tris, ref int tCount, bool delaunay, bool colinear)
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x7162E0", Offset = "0x7148E0", VA = "0x1807162E0")]
		public void ClearTile(int x, int z)
		{
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x716550", Offset = "0x714B50", VA = "0x180716550")]
		public void ReloadInBounds(Bounds bounds)
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x7165C0", Offset = "0x714BC0", VA = "0x1807165C0")]
		public void ReloadInBounds(IntRect tiles)
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x716700", Offset = "0x714D00", VA = "0x180716700")]
		public void ReloadTile(int x, int z)
		{
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x7167B0", Offset = "0x714DB0", VA = "0x1807167B0")]
		public void LoadTile(TileHandler.TileType tile, int x, int z, int rotation, int yoffset)
		{
		}

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x40006C4")]
		[FieldOffset(Offset = "0x10")]
		public readonly NavmeshBase graph;

		// Token: 0x040006C5 RID: 1733
		[Token(Token = "0x40006C5")]
		[FieldOffset(Offset = "0x18")]
		private readonly int tileXCount;

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int tileZCount;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		[FieldOffset(Offset = "0x20")]
		private readonly Clipper clipper;

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<Int2, int> cached_Int2_int_dict;

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[FieldOffset(Offset = "0x30")]
		private readonly TileHandler.TileType[] activeTileTypes;

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		[FieldOffset(Offset = "0x38")]
		private readonly int[] activeTileRotations;

		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		[FieldOffset(Offset = "0x40")]
		private readonly int[] activeTileOffsets;

		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		[FieldOffset(Offset = "0x48")]
		private readonly bool[] reloadedInBatch;

		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x40006CD")]
		[FieldOffset(Offset = "0x50")]
		public readonly GridLookup<NavmeshClipper> cuts;

		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x40006CE")]
		[FieldOffset(Offset = "0x58")]
		private int batchDepth;

		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x40006CF")]
		[FieldOffset(Offset = "0x60")]
		private readonly Int3PolygonClipper simpleClipper;

		// Token: 0x0200013E RID: 318
		[Token(Token = "0x200013E")]
		public class TileType
		{
			// Token: 0x17000152 RID: 338
			// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00006614 File Offset: 0x00004814
			[Token(Token = "0x17000152")]
			public int Width
			{
				[Token(Token = "0x6000A0E")]
				[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0000662C File Offset: 0x0000482C
			[Token(Token = "0x17000153")]
			public int Depth
			{
				[Token(Token = "0x6000A0F")]
				[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000A10 RID: 2576 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x716CE0", Offset = "0x7152E0", VA = "0x180716CE0")]
			public TileType(Int3[] sourceVerts, int[] sourceTris, Int3 tileSize, Int3 centerOffset, int width = 1, int depth = 1)
			{
			}

			// Token: 0x06000A11 RID: 2577 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x717130", Offset = "0x715730", VA = "0x180717130")]
			public TileType(Mesh source, Int3 tileSize, Int3 centerOffset, int width = 1, int depth = 1)
			{
			}

			// Token: 0x06000A12 RID: 2578 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x717620", Offset = "0x715C20", VA = "0x180717620")]
			public void Load(out Int3[] verts, out int[] tris, int rotation, int yoffset)
			{
			}

			// Token: 0x040006D0 RID: 1744
			[Token(Token = "0x40006D0")]
			[FieldOffset(Offset = "0x10")]
			private Int3[] verts;

			// Token: 0x040006D1 RID: 1745
			[Token(Token = "0x40006D1")]
			[FieldOffset(Offset = "0x18")]
			private int[] tris;

			// Token: 0x040006D2 RID: 1746
			[Token(Token = "0x40006D2")]
			[FieldOffset(Offset = "0x20")]
			private Int3 offset;

			// Token: 0x040006D3 RID: 1747
			[Token(Token = "0x40006D3")]
			[FieldOffset(Offset = "0x2C")]
			private int lastYOffset;

			// Token: 0x040006D4 RID: 1748
			[Token(Token = "0x40006D4")]
			[FieldOffset(Offset = "0x30")]
			private int lastRotation;

			// Token: 0x040006D5 RID: 1749
			[Token(Token = "0x40006D5")]
			[FieldOffset(Offset = "0x34")]
			private int width;

			// Token: 0x040006D6 RID: 1750
			[Token(Token = "0x40006D6")]
			[FieldOffset(Offset = "0x38")]
			private int depth;

			// Token: 0x040006D7 RID: 1751
			[Token(Token = "0x40006D7")]
			[FieldOffset(Offset = "0x0")]
			private static readonly int[] Rotations;
		}

		// Token: 0x0200013F RID: 319
		[Token(Token = "0x200013F")]
		[Flags]
		public enum CutMode
		{
			// Token: 0x040006D9 RID: 1753
			[Token(Token = "0x40006D9")]
			CutAll = 1,
			// Token: 0x040006DA RID: 1754
			[Token(Token = "0x40006DA")]
			CutDual = 2,
			// Token: 0x040006DB RID: 1755
			[Token(Token = "0x40006DB")]
			CutExtra = 4
		}

		// Token: 0x02000140 RID: 320
		[Token(Token = "0x2000140")]
		private class Cut
		{
			// Token: 0x06000A14 RID: 2580 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Cut()
			{
			}

			// Token: 0x040006DC RID: 1756
			[Token(Token = "0x40006DC")]
			[FieldOffset(Offset = "0x10")]
			public IntRect bounds;

			// Token: 0x040006DD RID: 1757
			[Token(Token = "0x40006DD")]
			[FieldOffset(Offset = "0x20")]
			public Int2 boundsY;

			// Token: 0x040006DE RID: 1758
			[Token(Token = "0x40006DE")]
			[FieldOffset(Offset = "0x28")]
			public bool isDual;

			// Token: 0x040006DF RID: 1759
			[Token(Token = "0x40006DF")]
			[FieldOffset(Offset = "0x29")]
			public bool cutsAddedGeom;

			// Token: 0x040006E0 RID: 1760
			[Token(Token = "0x40006E0")]
			[FieldOffset(Offset = "0x30")]
			public List<IntPoint> contour;
		}

		// Token: 0x02000141 RID: 321
		[Token(Token = "0x2000141")]
		private struct CuttingResult
		{
			// Token: 0x040006E1 RID: 1761
			[Token(Token = "0x40006E1")]
			[FieldOffset(Offset = "0x0")]
			public Int3[] verts;

			// Token: 0x040006E2 RID: 1762
			[Token(Token = "0x40006E2")]
			[FieldOffset(Offset = "0x8")]
			public int[] tris;
		}
	}
}
