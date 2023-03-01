using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		// Token: 0x06001443 RID: 5187 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x6001443")]
		[Address(RVA = "0x2C64F00", Offset = "0x2C63F00", VA = "0x182C64F00", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001444")]
		[Address(RVA = "0x2C650E0", Offset = "0x2C640E0", VA = "0x182C650E0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x2C64F80", Offset = "0x2C63F80", VA = "0x182C64F80")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001446")]
		[Address(RVA = "0x2C65CB0", Offset = "0x2C64CB0", VA = "0x182C65CB0")]
		public GlobalFog()
		{
		}

		// Token: 0x0400140B RID: 5131
		[Token(Token = "0x400140B")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog;

		// Token: 0x0400140C RID: 5132
		[Token(Token = "0x400140C")]
		[FieldOffset(Offset = "0x29")]
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		// Token: 0x0400140D RID: 5133
		[Token(Token = "0x400140D")]
		[FieldOffset(Offset = "0x2A")]
		[Tooltip("Apply height-based fog?")]
		public bool heightFog;

		// Token: 0x0400140E RID: 5134
		[Token(Token = "0x400140E")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Fog top Y coordinate")]
		public float height;

		// Token: 0x0400140F RID: 5135
		[Token(Token = "0x400140F")]
		[FieldOffset(Offset = "0x30")]
		[Range(0.001f, 10f)]
		public float heightDensity;

		// Token: 0x04001410 RID: 5136
		[Token(Token = "0x4001410")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		// Token: 0x04001411 RID: 5137
		[Token(Token = "0x4001411")]
		[FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		// Token: 0x04001412 RID: 5138
		[Token(Token = "0x4001412")]
		[FieldOffset(Offset = "0x40")]
		private Material fogMaterial;
	}
}
