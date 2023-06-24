using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000303 RID: 771
	[Token(Token = "0x2000303")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	internal class Fisheye : PostEffectsBase
	{
		// Token: 0x0600146B RID: 5227 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x600146B")]
		[Address(RVA = "0x3209AF0", Offset = "0x32080F0", VA = "0x183209AF0", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146C")]
		[Address(RVA = "0x3209BA0", Offset = "0x32081A0", VA = "0x183209BA0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146D")]
		[Address(RVA = "0x3209D20", Offset = "0x3208320", VA = "0x183209D20")]
		public Fisheye()
		{
		}

		// Token: 0x04001425 RID: 5157
		[Token(Token = "0x4001425")]
		[FieldOffset(Offset = "0x28")]
		public float strengthX;

		// Token: 0x04001426 RID: 5158
		[Token(Token = "0x4001426")]
		[FieldOffset(Offset = "0x2C")]
		public float strengthY;

		// Token: 0x04001427 RID: 5159
		[Token(Token = "0x4001427")]
		[FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		// Token: 0x04001428 RID: 5160
		[Token(Token = "0x4001428")]
		[FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;
	}
}
