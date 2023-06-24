using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lighting
{
	// Token: 0x02000589 RID: 1417
	[Token(Token = "0x2000589")]
	[AddComponentMenu("Sons/Lighting/LightFlickerMaterial")]
	public class LightFlickerMaterial : LightFlickerBase
	{
		// Token: 0x06002550 RID: 9552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002550")]
		[Address(RVA = "0x339B3F0", Offset = "0x33999F0", VA = "0x18339B3F0")]
		private void Awake()
		{
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002551")]
		[Address(RVA = "0x339B5D0", Offset = "0x3399BD0", VA = "0x18339B5D0", Slot = "4")]
		public override void SetLightIntensity(float intensity)
		{
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002552")]
		[Address(RVA = "0x339B030", Offset = "0x3399630", VA = "0x18339B030")]
		public LightFlickerMaterial()
		{
		}

		// Token: 0x0400218B RID: 8587
		[Token(Token = "0x400218B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _baseEmissionColor;

		// Token: 0x0400218C RID: 8588
		[Token(Token = "0x400218C")]
		[FieldOffset(Offset = "0x58")]
		private Renderer _renderer;

		// Token: 0x0400218D RID: 8589
		[Token(Token = "0x400218D")]
		[FieldOffset(Offset = "0x60")]
		private MaterialPropertyBlock _materialPropertyBlock;

		// Token: 0x0400218E RID: 8590
		[Token(Token = "0x400218E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int EmissionColorId;
	}
}
