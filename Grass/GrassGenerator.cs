using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Grass
{
	// Token: 0x020005AB RID: 1451
	[Token(Token = "0x20005AB")]
	[CreateAssetMenu(menuName = "Sons/Grass/Generator", fileName = "GrassGenerator")]
	public class GrassGenerator : ScriptableObject
	{
		// Token: 0x06002564 RID: 9572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002564")]
		[Address(RVA = "0x2D83050", Offset = "0x2D82050", VA = "0x182D83050")]
		public GrassGenerator()
		{
		}

		// Token: 0x040021BA RID: 8634
		[Token(Token = "0x40021BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TerrainData _terrainData;

		// Token: 0x040021BB RID: 8635
		[Token(Token = "0x40021BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture2D _detailMap01;

		// Token: 0x040021BC RID: 8636
		[Token(Token = "0x40021BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D _detailMap02;

		// Token: 0x040021BD RID: 8637
		[Token(Token = "0x40021BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _density;
	}
}
