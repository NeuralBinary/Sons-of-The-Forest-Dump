using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[Serializable]
	public class TextureNebulaeBlock : MonoBehaviour
	{
		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0xAC0AF0", Offset = "0xABF0F0", VA = "0x180AC0AF0")]
		private void Start()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0xAC0AF0", Offset = "0xABF0F0", VA = "0x180AC0AF0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0xAC0BD0", Offset = "0xABF1D0", VA = "0x180AC0BD0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Update()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xAC0C20", Offset = "0xABF220", VA = "0x180AC0C20")]
		public TextureNebulaeBlock()
		{
		}

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The nebulae as a cubemap texture.")]
		public Cubemap m_nebulaeTexture;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The intensity of the nebulae.")]
		[Min(0f)]
		public float m_intensity;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Tint to the nebulae texture.")]
		public Color m_tint;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("The rotation of the nebulae texture.")]
		public Vector3 m_rotation;
	}
}
