using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BlackfireStudio
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class ImageEffects : MonoBehaviour
	{
		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047A")]
		public static Texture2D RenderTexture
		{
			[Token(Token = "0x6001FFA")]
			[Address(RVA = "0x330E0A0", Offset = "0x330C6A0", VA = "0x18330E0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x6001FFB")]
		public static bool IsPro<T>(GameObject go, Type type, Shader s) where T : MonoBehaviour
		{
			return default(bool);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0x330E340", Offset = "0x330C940", VA = "0x18330E340")]
		public static void RenderImageEffect(Material m)
		{
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x330E820", Offset = "0x330CE20", VA = "0x18330E820")]
		public void OnPostRender()
		{
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ImageEffects()
		{
		}

		// Token: 0x04001D64 RID: 7524
		[Token(Token = "0x4001D64")]
		[FieldOffset(Offset = "0x0")]
		private static int screenHeight;

		// Token: 0x04001D65 RID: 7525
		[Token(Token = "0x4001D65")]
		[FieldOffset(Offset = "0x4")]
		private static int screenwidth;

		// Token: 0x04001D66 RID: 7526
		[Token(Token = "0x4001D66")]
		[FieldOffset(Offset = "0x8")]
		private static Texture2D renderTexture;
	}
}
