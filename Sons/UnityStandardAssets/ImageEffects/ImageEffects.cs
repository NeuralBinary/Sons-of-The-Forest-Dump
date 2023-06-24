using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000306 RID: 774
	[Token(Token = "0x2000306")]
	[AddComponentMenu("")]
	public class ImageEffects
	{
		// Token: 0x06001476 RID: 5238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x320B1A0", Offset = "0x32097A0", VA = "0x18320B1A0")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x320B510", Offset = "0x3209B10", VA = "0x18320B510")]
		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x320B570", Offset = "0x3209B70", VA = "0x18320B570")]
		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImageEffects()
		{
		}
	}
}
