using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	[Serializable]
	public class TextureInterpolationBlock : BaseTextureGeneratorBlock
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0xABF5D0", Offset = "0xABDBD0", VA = "0x180ABF5D0")]
		private void Start()
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0xABF670", Offset = "0xABDC70", VA = "0x180ABF670")]
		private void Update()
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xABF8E0", Offset = "0xABDEE0", VA = "0x180ABF8E0")]
		private void reallocateTargetIfNecessary()
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x6000240")]
		[Address(RVA = "0xABFE20", Offset = "0xABE420", VA = "0x180ABFE20")]
		private bool validateParameters()
		{
			return default(bool);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0xAC00A0", Offset = "0xABE6A0", VA = "0x180AC00A0")]
		private void render()
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "4")]
		public override RTHandle GetTexture()
		{
			return null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xAC08F0", Offset = "0xABEEF0", VA = "0x180AC08F0", Slot = "5")]
		public override void ForceUpdate()
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xAC0A70", Offset = "0xABF070", VA = "0x180AC0A70")]
		public void EnableRendering()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0xAC0A80", Offset = "0xABF080", VA = "0x180AC0A80")]
		public void DisableRendering()
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		[Address(RVA = "0xAC0A90", Offset = "0xABF090", VA = "0x180AC0A90")]
		public TextureInterpolationBlock()
		{
		}

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("First texture to lerp.")]
		public BaseTextureGeneratorBlock m_textureA;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Second texture to lerp.")]
		public BaseTextureGeneratorBlock m_textureB;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Amount to lerp textures.")]
		public float m_blend;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x34")]
		[Min(0f)]
		[Tooltip("Amount to tile texture A.")]
		public float m_tileA;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x38")]
		[Min(0f)]
		[Tooltip("Amount to tile texture B.")]
		public float m_tileB;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("If enabled, amortizes interpolation across multiple frames (16, to be specific). This can drastically improve performance.")]
		public bool m_amortize;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x40")]
		private RTHandle m_target;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x48")]
		private bool m_render;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x50")]
		private ComputeShader m_CS;
	}
}
