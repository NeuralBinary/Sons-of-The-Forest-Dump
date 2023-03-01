using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	public static class ImageEffectHelper
	{
		// Token: 0x06001499 RID: 5273 RVA: 0x00006A98 File Offset: 0x00004C98
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x2CB2B30", Offset = "0x2CB1B30", VA = "0x182CB2B30")]
		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			return default(bool);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x2CB2A60", Offset = "0x2CB1A60", VA = "0x182CB2A60")]
		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			return null;
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[Token(Token = "0x170002DE")]
		public static bool supportsDX11
		{
			[Token(Token = "0x600149B")]
			[Address(RVA = "0x2CB2E90", Offset = "0x2CB1E90", VA = "0x182CB2E90")]
			get
			{
				return default(bool);
			}
		}
	}
}
