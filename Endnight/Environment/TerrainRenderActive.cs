using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Environment
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	public class TerrainRenderActive : MonoBehaviour
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000472")]
		[Address(RVA = "0xAA8E90", Offset = "0xAA7490", VA = "0x180AA8E90")]
		public void SetTerrainRendererOn()
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000473")]
		[Address(RVA = "0xAA8EA0", Offset = "0xAA74A0", VA = "0x180AA8EA0")]
		public void SetTerrainRendererOff()
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000474")]
		[Address(RVA = "0xAA8EB0", Offset = "0xAA74B0", VA = "0x180AA8EB0")]
		public void SetEnabled(bool value)
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000475")]
		[Address(RVA = "0xAA90B0", Offset = "0xAA76B0", VA = "0x180AA90B0")]
		private void Initialize()
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000476")]
		[Address(RVA = "0xAA91A0", Offset = "0xAA77A0", VA = "0x180AA91A0")]
		public TerrainRenderActive()
		{
		}

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _autoFindTerrain;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		[Tooltip("Apply to drawHeightmap and drawTreesAndFoliage directly instead of disabling the terrain component")]
		private bool _terrainElements;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Terrain _targetTerrain;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x30")]
		private bool _initialized;
	}
}
