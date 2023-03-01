using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200030C RID: 780
	[Token(Token = "0x200030C")]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	[ExecuteInEditMode]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		// Token: 0x06001426 RID: 5158 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x6001426")]
		[Address(RVA = "0x2C5FF50", Offset = "0x2C5EF50", VA = "0x182C5FF50", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001427")]
		[Address(RVA = "0x2C604C0", Offset = "0x2C5F4C0", VA = "0x182C604C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001428")]
		[Address(RVA = "0x2C60430", Offset = "0x2C5F430", VA = "0x182C60430")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001429")]
		[Address(RVA = "0x2C60780", Offset = "0x2C5F780", VA = "0x182C60780")]
		public void SetIdentityLut()
		{
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x600142A")]
		[Address(RVA = "0x2C60990", Offset = "0x2C5F990", VA = "0x182C60990")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142B")]
		[Address(RVA = "0x2C5FFD0", Offset = "0x2C5EFD0", VA = "0x182C5FFD0")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x2C60560", Offset = "0x2C5F560", VA = "0x182C60560")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142D")]
		[Address(RVA = "0x2C60AB0", Offset = "0x2C5FAB0", VA = "0x182C60AB0")]
		public ColorCorrectionLookup()
		{
		}

		// Token: 0x040013E5 RID: 5093
		[Token(Token = "0x40013E5")]
		[FieldOffset(Offset = "0x28")]
		public Shader shader;

		// Token: 0x040013E6 RID: 5094
		[Token(Token = "0x40013E6")]
		[FieldOffset(Offset = "0x30")]
		private Material material;

		// Token: 0x040013E7 RID: 5095
		[Token(Token = "0x40013E7")]
		[FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		// Token: 0x040013E8 RID: 5096
		[Token(Token = "0x40013E8")]
		[FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;
	}
}
