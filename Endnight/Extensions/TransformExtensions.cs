using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Extensions
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	public static class TransformExtensions
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044D")]
		[Address(RVA = "0xAA7810", Offset = "0xAA5E10", VA = "0x180AA7810")]
		public static void AlignToTerrain(Transform targetTransform, float maxDistance = 900f, int heightRayStartOffset = 100, bool alignRotation = true)
		{
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044E")]
		[Address(RVA = "0xAA78B0", Offset = "0xAA5EB0", VA = "0x180AA78B0")]
		public static void AlignToTerrain(Transform targetTransform, LayerMask layerMask, float maxDistance = 900f, int heightRayStartOffset = 100, bool alignRotation = true)
		{
		}

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LayerMask DefaultTerrainAlignLayerMask;
	}
}
