using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000304 RID: 772
	[Token(Token = "0x2000304")]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class GlobalFog : PostEffectsBase
	{
		// Token: 0x0600146E RID: 5230 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x600146E")]
		[Address(RVA = "0x3209D80", Offset = "0x3208380", VA = "0x183209D80", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146F")]
		[Address(RVA = "0x3209E30", Offset = "0x3208430", VA = "0x183209E30")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x320A970", Offset = "0x3208F70", VA = "0x18320A970")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x320AD60", Offset = "0x3209360", VA = "0x18320AD60")]
		public GlobalFog()
		{
		}

		// Token: 0x04001429 RID: 5161
		[Token(Token = "0x4001429")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog;

		// Token: 0x0400142A RID: 5162
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0x29")]
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		// Token: 0x0400142B RID: 5163
		[Token(Token = "0x400142B")]
		[FieldOffset(Offset = "0x2A")]
		[Tooltip("Apply height-based fog?")]
		public bool heightFog;

		// Token: 0x0400142C RID: 5164
		[Token(Token = "0x400142C")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Fog top Y coordinate")]
		public float height;

		// Token: 0x0400142D RID: 5165
		[Token(Token = "0x400142D")]
		[FieldOffset(Offset = "0x30")]
		[Range(0.001f, 10f)]
		public float heightDensity;

		// Token: 0x0400142E RID: 5166
		[Token(Token = "0x400142E")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		// Token: 0x0400142F RID: 5167
		[Token(Token = "0x400142F")]
		[FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		// Token: 0x04001430 RID: 5168
		[Token(Token = "0x4001430")]
		[FieldOffset(Offset = "0x40")]
		private Material fogMaterial;
	}
}
