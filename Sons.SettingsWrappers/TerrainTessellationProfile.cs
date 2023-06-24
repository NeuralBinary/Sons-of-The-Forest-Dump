using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Settings
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Serializable]
	public class TerrainTessellationProfile
	{
		// Token: 0x060000CC RID: 204 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x209A1F0", Offset = "0x20987F0", VA = "0x18209A1F0")]
		private bool ValidateMinTessellation(int value)
		{
			return default(bool);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x31425F0", Offset = "0x3140BF0", VA = "0x1831425F0")]
		public void Apply(MSColorMapFeature msColorMapFeature)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3142640", Offset = "0x3140C40", VA = "0x183142640")]
		public TerrainTessellationProfile()
		{
		}

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x10")]
		[Range(1f, 32f)]
		[SerializeField]
		private int _terrainTessellationMax;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x14")]
		[Range(1f, 3f)]
		[SerializeField]
		private int _terrainTessellationMin;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x18")]
		[Range(1f, 32f)]
		[SerializeField]
		private int _terrainTessellationShadowMax;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _terrainTessellationMaxDistance;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _terrainTessellationMinDistance;
	}
}
