using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000307 RID: 775
	[Token(Token = "0x2000307")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		// Token: 0x0600147A RID: 5242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x320B5E0", Offset = "0x3209BE0", VA = "0x18320B5E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x320B640", Offset = "0x3209C40", VA = "0x18320B640")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x320BBB0", Offset = "0x320A1B0", VA = "0x18320BBB0")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x320C0F0", Offset = "0x320A6F0", VA = "0x18320C0F0")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PostEffectsHelper()
		{
		}
	}
}
