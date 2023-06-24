using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedTerrainGrass
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[PreferBinarySerialization]
	[Serializable]
	public class GrassTerrainDefinitions : ScriptableObject
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public GrassTerrainDefinitions()
		{
		}

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x18")]
		[Header("Serialized Grass Data")]
		public Vector3 TerrainPosition;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public List<DetailLayerMap> DensityMaps;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x30")]
		public GrassCell[] Cells;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x38")]
		public GrassCellContent[] CellContent;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x40")]
		public int maxBucketDensity;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x48")]
		public int[] LayersMaxDensity;
	}
}
