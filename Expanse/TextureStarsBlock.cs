using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[ExecuteInEditMode]
	[Serializable]
	public class TextureStarsBlock : MonoBehaviour
	{
		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0xAC0C90", Offset = "0xABF290", VA = "0x180AC0C90")]
		private void Start()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xAC0C90", Offset = "0xABF290", VA = "0x180AC0C90")]
		private void OnEnable()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xAC0D70", Offset = "0xABF370", VA = "0x180AC0D70")]
		private void OnDisable()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xAC0C20", Offset = "0xABF220", VA = "0x180AC0C20")]
		public TextureStarsBlock()
		{
		}

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The stars as a cubemap texture.")]
		public Cubemap m_starTexture;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The intensity of the stars.")]
		public float m_intensity;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Tint to the stars.")]
		public Color m_tint;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("The rotation of the stars.")]
		public Vector3 m_rotation;
	}
}
