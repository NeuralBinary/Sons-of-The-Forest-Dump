using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	public static class OceanBuilder
	{
		// Token: 0x0600020C RID: 524 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x9FE580", Offset = "0x9FCB80", VA = "0x1809FE580")]
		public static Transform GenerateMesh(OceanRenderer ocean, List<OceanChunkRenderer> tiles, int lodDataResolution, int geoDownSampleFactor, int lodCount)
		{
			return null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x9FED00", Offset = "0x9FD300", VA = "0x1809FED00")]
		public static void ClearOutTiles(OceanRenderer ocean, List<OceanChunkRenderer> tiles)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x9FF090", Offset = "0x9FD690", VA = "0x1809FF090")]
		private static void DestroyGO(Transform go)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x9FF140", Offset = "0x9FD740", VA = "0x1809FF140")]
		private static Mesh BuildOceanPatch(OceanBuilder.PatchType pt, float vertDensity, out Bounds bounds)
		{
			return null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x9FFE40", Offset = "0x9FE440", VA = "0x1809FFE40")]
		private static void CreateLOD(OceanRenderer ocean, List<OceanChunkRenderer> tiles, Transform parent, int lodIndex, int lodCount, Mesh[] meshData, Bounds[] meshBounds, int lodDataResolution, int geoDownSampleFactor, int oceanLayer)
		{
		}

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		private enum PatchType
		{
			// Token: 0x0400018E RID: 398
			[Token(Token = "0x400018E")]
			Interior,
			// Token: 0x0400018F RID: 399
			[Token(Token = "0x400018F")]
			Fat,
			// Token: 0x04000190 RID: 400
			[Token(Token = "0x4000190")]
			FatX,
			// Token: 0x04000191 RID: 401
			[Token(Token = "0x4000191")]
			FatXSlimZ,
			// Token: 0x04000192 RID: 402
			[Token(Token = "0x4000192")]
			FatXOuter,
			// Token: 0x04000193 RID: 403
			[Token(Token = "0x4000193")]
			FatXZ,
			// Token: 0x04000194 RID: 404
			[Token(Token = "0x4000194")]
			FatXZOuter,
			// Token: 0x04000195 RID: 405
			[Token(Token = "0x4000195")]
			SlimX,
			// Token: 0x04000196 RID: 406
			[Token(Token = "0x4000196")]
			SlimXZ,
			// Token: 0x04000197 RID: 407
			[Token(Token = "0x4000197")]
			SlimXFatZ,
			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			Count
		}
	}
}
