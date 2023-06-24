using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[ExecuteInEditMode]
	[Serializable]
	public class CreativeFog : MonoBehaviour
	{
		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0xAC13C0", Offset = "0xABF9C0", VA = "0x180AC13C0")]
		private void Update()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xAC14F0", Offset = "0xABFAF0", VA = "0x180AC14F0")]
		public CreativeFog()
		{
		}

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x20")]
		public AtmosphereLayerBlock m_fogBlock;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x28")]
		[Min(0f)]
		[Tooltip("Color of the fog. Realistic fog is pure grey.")]
		public Color m_color;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x38")]
		[Min(0f)]
		[Tooltip("How dense the fog is.")]
		public float m_density;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x3C")]
		[Min(0f)]
		[Tooltip("How far away from the player the fog extends.")]
		public float m_radius;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x40")]
		[Min(0f)]
		[Tooltip("How high off the ground the fog extends.")]
		public float m_thickness;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("How smoggy the fog looks.")]
		[Range(0f, 1f)]
		public float m_smog;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("How intense the sun glare from the fog is.")]
		[Range(0f, 1f)]
		public float m_glare;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x4C")]
		private float kNormalizationConstant;
	}
}
