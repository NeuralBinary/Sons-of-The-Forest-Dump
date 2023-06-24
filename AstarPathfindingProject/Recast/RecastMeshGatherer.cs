using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Voxels;
using UnityEngine;

namespace Pathfinding.Recast
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	internal class RecastMeshGatherer
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x6F96B0", Offset = "0x6F7CB0", VA = "0x1806F96B0")]
		public RecastMeshGatherer(Bounds bounds, int terrainSampleSize, LayerMask mask, List<string> tagMask, float colliderRasterizeDetail)
		{
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x6F9880", Offset = "0x6F7E80", VA = "0x1806F9880")]
		private static List<MeshFilter> FilterMeshes(MeshFilter[] meshFilters, List<string> tagMask, LayerMask layerMask)
		{
			return null;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x6F9BF0", Offset = "0x6F81F0", VA = "0x1806F9BF0")]
		public void CollectSceneMeshes(List<RasterizationMesh> meshes)
		{
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x6FA2F0", Offset = "0x6F88F0", VA = "0x1806FA2F0")]
		public void CollectRecastMeshObjs(List<RasterizationMesh> buffer)
		{
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x6FAD40", Offset = "0x6F9340", VA = "0x1806FAD40")]
		public void CollectTerrainMeshes(bool rasterizeTrees, float desiredChunkSize, List<RasterizationMesh> result)
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x6FAF90", Offset = "0x6F9590", VA = "0x1806FAF90")]
		private void GenerateTerrainChunks(Terrain terrain, Bounds bounds, float desiredChunkSize, List<RasterizationMesh> result)
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0000620C File Offset: 0x0000440C
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x6FB7C0", Offset = "0x6F9DC0", VA = "0x1806FB7C0")]
		private static int CeilDivision(int lhs, int rhs)
		{
			return 0;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x6FB7D0", Offset = "0x6F9DD0", VA = "0x1806FB7D0")]
		private RasterizationMesh GenerateHeightmapChunk(float[,] heights, Vector3 sampleSize, Vector3 offset, int x0, int z0, int width, int depth, int stride)
		{
			return null;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x6FBCB0", Offset = "0x6FA2B0", VA = "0x1806FBCB0")]
		private void CollectTreeMeshes(Terrain terrain, List<RasterizationMesh> result)
		{
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x6FC700", Offset = "0x6FAD00", VA = "0x1806FC700")]
		public void CollectColliderMeshes(List<RasterizationMesh> result)
		{
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x6FCB60", Offset = "0x6FB160", VA = "0x1806FCB60")]
		private RasterizationMesh RasterizeCollider(Collider col)
		{
			return null;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x6FCC90", Offset = "0x6FB290", VA = "0x1806FCC90")]
		private RasterizationMesh RasterizeCollider(Collider col, Matrix4x4 localToWorldMatrix)
		{
			return null;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x6FD660", Offset = "0x6FBC60", VA = "0x1806FD660")]
		private RasterizationMesh RasterizeBoxCollider(BoxCollider collider, Matrix4x4 localToWorldMatrix)
		{
			return null;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x6FDA00", Offset = "0x6FC000", VA = "0x1806FDA00")]
		private RasterizationMesh RasterizeCapsuleCollider(float radius, float height, Bounds bounds, Matrix4x4 localToWorldMatrix)
		{
			return null;
		}

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0x10")]
		private readonly int terrainSampleSize;

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0x14")]
		private readonly LayerMask mask;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<string> tagMask;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x20")]
		private readonly float colliderRasterizeDetail;

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x24")]
		private readonly Bounds bounds;

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] BoxColliderTris;

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector3[] BoxColliderVerts;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x40")]
		private List<RecastMeshGatherer.CapsuleCache> capsuleCache;

		// Token: 0x0200011C RID: 284
		[Token(Token = "0x200011C")]
		private class CapsuleCache
		{
			// Token: 0x06000934 RID: 2356 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CapsuleCache()
			{
			}

			// Token: 0x04000660 RID: 1632
			[Token(Token = "0x4000660")]
			[FieldOffset(Offset = "0x10")]
			public int rows;

			// Token: 0x04000661 RID: 1633
			[Token(Token = "0x4000661")]
			[FieldOffset(Offset = "0x14")]
			public float height;

			// Token: 0x04000662 RID: 1634
			[Token(Token = "0x4000662")]
			[FieldOffset(Offset = "0x18")]
			public Vector3[] verts;

			// Token: 0x04000663 RID: 1635
			[Token(Token = "0x4000663")]
			[FieldOffset(Offset = "0x20")]
			public int[] tris;
		}
	}
}
