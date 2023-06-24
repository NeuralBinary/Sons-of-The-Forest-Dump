using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	[Serializable]
	public class NightSkyBlock : MonoBehaviour
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0xAB9380", Offset = "0xAB7980", VA = "0x180AB9380")]
		private void Start()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0xAB9380", Offset = "0xAB7980", VA = "0x180AB9380")]
		private void OnEnable()
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0xAB9460", Offset = "0xAB7A60", VA = "0x180AB9460")]
		private void OnDisable()
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0xAB94B0", Offset = "0xAB7AB0", VA = "0x180AB94B0")]
		public NightSkyBlock()
		{
		}

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The rotation of the night sky specified as euler angles.")]
		public Vector3 m_rotation;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Overall intensity of the night sky.")]
		[Min(0f)]
		public float m_intensity;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Tint to the night sky.")]
		public Color m_tint;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x40")]
		[Min(0f)]
		[Tooltip("Intensity of light scattered up from the ground used for modeling light pollution. Specified in lux.")]
		public float m_lightPollutionIntensity;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Color of light coming from the ground used for modeling light pollution.")]
		public Color m_lightPollutionTint;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x54")]
		[Min(0f)]
		[Tooltip("Expanse computes sky scattering using the average color of the sky texture. There are so many light sources in the night sky that this is really the only computationally tractable option. However, this can sometimes result in scattering that's too intense, or not intense enough, depending on your use case. This parameter is an artistic override to help mitigate that issue.")]
		public float m_scatterIntensity;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("An additional tint applied on top of the night sky tint, but only to the scattering. This is useful as an artistsic override for if the average color of your sky texture doesn't quite get you the scattering behavior you want. For instance, you may want the scattering to be bluer.")]
		public Color m_scatterTint;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x68")]
		[Min(0f)]
		[Tooltip("Multiplier to sky cubemap ambient lighting.")]
		public float m_ambientMultiplier;
	}
}
