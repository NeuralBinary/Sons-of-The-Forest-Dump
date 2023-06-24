using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		// Token: 0x06001451 RID: 5201 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x6001451")]
		[Address(RVA = "0x3206200", Offset = "0x3204800", VA = "0x183206200", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001452")]
		[Address(RVA = "0x32062F0", Offset = "0x32048F0", VA = "0x1832062F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001453")]
		[Address(RVA = "0x3206420", Offset = "0x3204A20", VA = "0x183206420")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001454")]
		[Address(RVA = "0x3206550", Offset = "0x3204B50", VA = "0x183206550")]
		public void SetIdentityLut()
		{
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x3206880", Offset = "0x3204E80", VA = "0x183206880")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x32069A0", Offset = "0x3204FA0", VA = "0x1832069A0")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x3206ED0", Offset = "0x32054D0", VA = "0x183206ED0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x32071C0", Offset = "0x32057C0", VA = "0x1832071C0")]
		public ColorCorrectionLookup()
		{
		}

		// Token: 0x04001403 RID: 5123
		[Token(Token = "0x4001403")]
		[FieldOffset(Offset = "0x28")]
		public Shader shader;

		// Token: 0x04001404 RID: 5124
		[Token(Token = "0x4001404")]
		[FieldOffset(Offset = "0x30")]
		private Material material;

		// Token: 0x04001405 RID: 5125
		[Token(Token = "0x4001405")]
		[FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		// Token: 0x04001406 RID: 5126
		[Token(Token = "0x4001406")]
		[FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;
	}
}
