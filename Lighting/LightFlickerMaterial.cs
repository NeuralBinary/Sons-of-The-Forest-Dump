using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lighting
{
	// Token: 0x02000579 RID: 1401
	[Token(Token = "0x2000579")]
	[AddComponentMenu("Sons/Lighting/LightFlickerMaterial")]
	public class LightFlickerMaterial : LightFlickerBase
	{
		// Token: 0x06002451 RID: 9297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002451")]
		[Address(RVA = "0x2D83DE0", Offset = "0x2D82DE0", VA = "0x182D83DE0")]
		private void Awake()
		{
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002452")]
		[Address(RVA = "0x2D83E80", Offset = "0x2D82E80", VA = "0x182D83E80", Slot = "4")]
		public override void SetLightIntensity(float intensity)
		{
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002453")]
		[Address(RVA = "0x2D83DB0", Offset = "0x2D82DB0", VA = "0x182D83DB0")]
		public LightFlickerMaterial()
		{
		}

		// Token: 0x040020B7 RID: 8375
		[Token(Token = "0x40020B7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _baseEmissionColor;

		// Token: 0x040020B8 RID: 8376
		[Token(Token = "0x40020B8")]
		[FieldOffset(Offset = "0x58")]
		private Renderer _renderer;

		// Token: 0x040020B9 RID: 8377
		[Token(Token = "0x40020B9")]
		[FieldOffset(Offset = "0x60")]
		private MaterialPropertyBlock _materialPropertyBlock;

		// Token: 0x040020BA RID: 8378
		[Token(Token = "0x40020BA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int EmissionColorId;
	}
}
