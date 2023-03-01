using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	[RequireComponent(typeof(Camera))]
	internal class Fisheye : PostEffectsBase
	{
		// Token: 0x06001440 RID: 5184 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x6001440")]
		[Address(RVA = "0x2C64CD0", Offset = "0x2C63CD0", VA = "0x182C64CD0", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001441")]
		[Address(RVA = "0x2C64D50", Offset = "0x2C63D50", VA = "0x182C64D50")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001442")]
		[Address(RVA = "0x2C64ED0", Offset = "0x2C63ED0", VA = "0x182C64ED0")]
		public Fisheye()
		{
		}

		// Token: 0x04001407 RID: 5127
		[Token(Token = "0x4001407")]
		[FieldOffset(Offset = "0x28")]
		public float strengthX;

		// Token: 0x04001408 RID: 5128
		[Token(Token = "0x4001408")]
		[FieldOffset(Offset = "0x2C")]
		public float strengthY;

		// Token: 0x04001409 RID: 5129
		[Token(Token = "0x4001409")]
		[FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		// Token: 0x0400140A RID: 5130
		[Token(Token = "0x400140A")]
		[FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;
	}
}
