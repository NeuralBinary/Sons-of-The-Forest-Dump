using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Grass
{
	// Token: 0x020005BB RID: 1467
	[Token(Token = "0x20005BB")]
	[CreateAssetMenu(menuName = "Sons/Grass/Generator", fileName = "GrassGenerator")]
	public class GrassGenerator : ScriptableObject
	{
		// Token: 0x06002663 RID: 9827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002663")]
		[Address(RVA = "0x33AB6E0", Offset = "0x33A9CE0", VA = "0x1833AB6E0")]
		public GrassGenerator()
		{
		}

		// Token: 0x0400228E RID: 8846
		[Token(Token = "0x400228E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TerrainData _terrainData;

		// Token: 0x0400228F RID: 8847
		[Token(Token = "0x400228F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture2D _detailMap01;

		// Token: 0x04002290 RID: 8848
		[Token(Token = "0x4002290")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D _detailMap02;

		// Token: 0x04002291 RID: 8849
		[Token(Token = "0x4002291")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _density;
	}
}
