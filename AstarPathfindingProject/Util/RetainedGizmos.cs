using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public class RetainedGizmos
	{
		// Token: 0x06000A47 RID: 2631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x71A340", Offset = "0x718940", VA = "0x18071A340")]
		public GraphGizmoHelper GetSingleFrameGizmoHelper(AstarPath active)
		{
			return null;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x71A4F0", Offset = "0x718AF0", VA = "0x18071A4F0")]
		public GraphGizmoHelper GetGizmoHelper(AstarPath active, RetainedGizmos.Hasher hasher)
		{
			return null;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x71A590", Offset = "0x718B90", VA = "0x18071A590")]
		private void PoolMesh(Mesh mesh)
		{
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x71A630", Offset = "0x718C30", VA = "0x18071A630")]
		private Mesh GetMesh()
		{
			return null;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x000067AC File Offset: 0x000049AC
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x71A700", Offset = "0x718D00", VA = "0x18071A700")]
		public bool HasCachedMesh(RetainedGizmos.Hasher hasher)
		{
			return default(bool);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000067C4 File Offset: 0x000049C4
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x71A760", Offset = "0x718D60", VA = "0x18071A760")]
		public bool Draw(RetainedGizmos.Hasher hasher)
		{
			return default(bool);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x71A810", Offset = "0x718E10", VA = "0x18071A810")]
		public void DrawExisting()
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x71A8F0", Offset = "0x718EF0", VA = "0x18071A8F0")]
		public void FinalizeDraw()
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x71AEE0", Offset = "0x7194E0", VA = "0x18071AEE0")]
		public void ClearCache()
		{
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x71B0D0", Offset = "0x7196D0", VA = "0x18071B0D0")]
		private void RemoveUnusedMeshes(List<RetainedGizmos.MeshWithHash> meshList)
		{
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x71B2F0", Offset = "0x7198F0", VA = "0x18071B2F0")]
		public RetainedGizmos()
		{
		}

		// Token: 0x0400070C RID: 1804
		[Token(Token = "0x400070C")]
		[FieldOffset(Offset = "0x10")]
		private List<RetainedGizmos.MeshWithHash> meshes;

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<ulong> usedHashes;

		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<ulong> existingHashes;

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		[FieldOffset(Offset = "0x28")]
		private Stack<Mesh> cachedMeshes;

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0x30")]
		public Material surfaceMaterial;

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x38")]
		public Material lineMaterial;

		// Token: 0x0200014B RID: 331
		[Token(Token = "0x200014B")]
		public struct Hasher
		{
			// Token: 0x06000A52 RID: 2642 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x71B510", Offset = "0x719B10", VA = "0x18071B510")]
			public Hasher(AstarPath active)
			{
			}

			// Token: 0x06000A53 RID: 2643 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x71B680", Offset = "0x719C80", VA = "0x18071B680")]
			public void AddHash(int hash)
			{
			}

			// Token: 0x06000A54 RID: 2644 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x71B6A0", Offset = "0x719CA0", VA = "0x18071B6A0")]
			public void HashNode(GraphNode node)
			{
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000A55 RID: 2645 RVA: 0x000067DC File Offset: 0x000049DC
			[Token(Token = "0x17000158")]
			public ulong Hash
			{
				[Token(Token = "0x6000A55")]
				[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720")]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x04000712 RID: 1810
			[Token(Token = "0x4000712")]
			[FieldOffset(Offset = "0x0")]
			private ulong hash;

			// Token: 0x04000713 RID: 1811
			[Token(Token = "0x4000713")]
			[FieldOffset(Offset = "0x8")]
			private bool includePathSearchInfo;

			// Token: 0x04000714 RID: 1812
			[Token(Token = "0x4000714")]
			[FieldOffset(Offset = "0x9")]
			private bool includeAreaInfo;

			// Token: 0x04000715 RID: 1813
			[Token(Token = "0x4000715")]
			[FieldOffset(Offset = "0x10")]
			private PathHandler debugData;
		}

		// Token: 0x0200014C RID: 332
		[Token(Token = "0x200014C")]
		public class Builder : IAstarPooledObject
		{
			// Token: 0x06000A56 RID: 2646 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x71B790", Offset = "0x719D90", VA = "0x18071B790")]
			public void DrawMesh(RetainedGizmos gizmos, Vector3[] vertices, List<int> triangles, Color[] colors)
			{
			}

			// Token: 0x06000A57 RID: 2647 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x71B9A0", Offset = "0x719FA0", VA = "0x18071B9A0")]
			public void DrawWireCube(GraphTransform tr, Bounds bounds, Color color)
			{
			}

			// Token: 0x06000A58 RID: 2648 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x71C1F0", Offset = "0x71A7F0", VA = "0x18071C1F0")]
			public void DrawLine(Vector3 start, Vector3 end, Color color)
			{
			}

			// Token: 0x06000A59 RID: 2649 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x71C420", Offset = "0x71AA20", VA = "0x18071C420")]
			public void Submit(RetainedGizmos gizmos, RetainedGizmos.Hasher hasher)
			{
			}

			// Token: 0x06000A5A RID: 2650 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x71C470", Offset = "0x71AA70", VA = "0x18071C470")]
			private void SubmitMeshes(RetainedGizmos gizmos, ulong hash)
			{
			}

			// Token: 0x06000A5B RID: 2651 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x71C6F0", Offset = "0x71ACF0", VA = "0x18071C6F0")]
			private void SubmitLines(RetainedGizmos gizmos, ulong hash)
			{
			}

			// Token: 0x06000A5C RID: 2652 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x71CF60", Offset = "0x71B560", VA = "0x18071CF60", Slot = "4")]
			private void OnEnterPool()
			{
			}

			// Token: 0x06000A5D RID: 2653 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x71D000", Offset = "0x71B600", VA = "0x18071D000")]
			public Builder()
			{
			}

			// Token: 0x04000716 RID: 1814
			[Token(Token = "0x4000716")]
			[FieldOffset(Offset = "0x10")]
			private List<Vector3> lines;

			// Token: 0x04000717 RID: 1815
			[Token(Token = "0x4000717")]
			[FieldOffset(Offset = "0x18")]
			private List<Color32> lineColors;

			// Token: 0x04000718 RID: 1816
			[Token(Token = "0x4000718")]
			[FieldOffset(Offset = "0x20")]
			private List<Mesh> meshes;
		}

		// Token: 0x0200014D RID: 333
		[Token(Token = "0x200014D")]
		private struct MeshWithHash
		{
			// Token: 0x04000719 RID: 1817
			[Token(Token = "0x4000719")]
			[FieldOffset(Offset = "0x0")]
			public ulong hash;

			// Token: 0x0400071A RID: 1818
			[Token(Token = "0x400071A")]
			[FieldOffset(Offset = "0x8")]
			public Mesh mesh;

			// Token: 0x0400071B RID: 1819
			[Token(Token = "0x400071B")]
			[FieldOffset(Offset = "0x10")]
			public bool lines;
		}
	}
}
