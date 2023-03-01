using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BlackfireStudio
{
	// Token: 0x020004D2 RID: 1234
	[Token(Token = "0x20004D2")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class ImageEffects : MonoBehaviour
	{
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001F96 RID: 8086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046B")]
		public static Texture2D RenderTexture
		{
			[Token(Token = "0x6001F96")]
			[Address(RVA = "0x2D2A970", Offset = "0x2D29970", VA = "0x182D2A970")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x6001F97")]
		public static bool IsPro<T>(GameObject go, Type type, Shader s) where T : MonoBehaviour
		{
			return default(bool);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F98")]
		[Address(RVA = "0x2D2A750", Offset = "0x2D29750", VA = "0x182D2A750")]
		public static void RenderImageEffect(Material m)
		{
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F99")]
		[Address(RVA = "0x2D2A590", Offset = "0x2D29590", VA = "0x182D2A590")]
		public void OnPostRender()
		{
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9A")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ImageEffects()
		{
		}

		// Token: 0x04001D28 RID: 7464
		[Token(Token = "0x4001D28")]
		[FieldOffset(Offset = "0x0")]
		private static int screenHeight;

		// Token: 0x04001D29 RID: 7465
		[Token(Token = "0x4001D29")]
		[FieldOffset(Offset = "0x4")]
		private static int screenwidth;

		// Token: 0x04001D2A RID: 7466
		[Token(Token = "0x4001D2A")]
		[FieldOffset(Offset = "0x8")]
		private static Texture2D renderTexture;
	}
}
