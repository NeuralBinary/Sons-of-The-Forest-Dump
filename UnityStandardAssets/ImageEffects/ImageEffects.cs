using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000314 RID: 788
	[Token(Token = "0x2000314")]
	[AddComponentMenu("")]
	public class ImageEffects
	{
		// Token: 0x0600144B RID: 5195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x2C66BF0", Offset = "0x2C65BF0", VA = "0x182C66BF0")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x2C66B90", Offset = "0x2C65B90", VA = "0x182C66B90")]
		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144D")]
		[Address(RVA = "0x2C66B20", Offset = "0x2C65B20", VA = "0x182C66B20")]
		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public ImageEffects()
		{
		}
	}
}
