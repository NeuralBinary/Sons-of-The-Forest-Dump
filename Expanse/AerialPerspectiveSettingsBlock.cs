using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	[Serializable]
	public class AerialPerspectiveSettingsBlock : MonoBehaviour
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xAB5280", Offset = "0xAB3880", VA = "0x180AB5280")]
		private void OnEnable()
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xAB5360", Offset = "0xAB3960", VA = "0x180AB5360")]
		private void OnDisable()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xAB53B0", Offset = "0xAB39B0", VA = "0x180AB53B0")]
		public AerialPerspectiveSettingsBlock()
		{
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x20")]
		[Min(0f)]
		[Tooltip("How aggressively aerial perspective due to Rayleigh and Isotropic (\"uniform\") layers is attenuated as a consequence of approximate volumetric shadowing. To see the effect, put the sun behind a big piece of geometry (like a mountain) and play around with this parameter. Expanse does not accurately model atmospheric volumetric shadows due to the performance cost, and instead uses this approximation to avoid visual artifacts.")]
		public float m_uniformOcclusionSpread;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Provides a way of offsetting the attenuation of aerial perspective as a consequence of approximate volumetric shadowing (for Rayleigh and Isotropic (\"uniform\") layers). To see the effect, put the sun behind a big piece of geometry (like a mountain) and play around with this parameter. Expanse does not accurately model atmospheric volumetric shadows due to the performance cost, and instead uses this approximation to avoid visual artifacts.")]
		[Min(0f)]
		public float m_uniformOcclusionBias;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("How aggressively aerial perspective due to Mie (\"directional\") layers is attenuated as a consequence of approximate volumetric shadowing. To see the effect, put the sun behind a big piece of geometry (like a mountain) and play around with this parameter. Expanse does not accurately model atmospheric volumetric shadows due to the performance cost, and instead uses this approximation to avoid visual artifacts.")]
		[Min(0f)]
		public float m_directionalOcclusionSpread;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Provides a way of offsetting the attenuation of aerial perspective as a consequence of approximate volumetric shadowing (for Mie (\"directional\") layers). To see the effect, put the sun behind a big piece of geometry (like a mountain) and play around with this parameter. Expanse does not accurately model atmospheric volumetric shadows due to the performance cost, and instead uses this approximation to avoid visual artifacts.")]
		[Min(0f)]
		public float m_directionalOcclusionBias;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("The night scattering effect can sometimes be either too intense or not intense enough for aerial perspective. This artistic override allows for attenuation of night scattering for aerial perspective only.")]
		[Min(0f)]
		public float m_nightScatteringMultiplier;
	}
}
