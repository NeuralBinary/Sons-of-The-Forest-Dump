using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2000315")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		// Token: 0x0600144F RID: 5199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x2C69300", Offset = "0x2C68300", VA = "0x182C69300")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x2C68E70", Offset = "0x2C67E70", VA = "0x182C68E70")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001451")]
		[Address(RVA = "0x2C68AC0", Offset = "0x2C67AC0", VA = "0x182C68AC0")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001452")]
		[Address(RVA = "0x2C69130", Offset = "0x2C68130", VA = "0x182C69130")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001453")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PostEffectsHelper()
		{
		}
	}
}
