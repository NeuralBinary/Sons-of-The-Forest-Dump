using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000322 RID: 802
	[Token(Token = "0x2000322")]
	public static class ImageEffectHelper
	{
		// Token: 0x060014C4 RID: 5316 RVA: 0x00006CD8 File Offset: 0x00004ED8
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x325EE90", Offset = "0x325D490", VA = "0x18325EE90")]
		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			return default(bool);
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x325F1B0", Offset = "0x325D7B0", VA = "0x18325F1B0")]
		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			return null;
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x170002E6")]
		public static bool supportsDX11
		{
			[Token(Token = "0x60014C6")]
			[Address(RVA = "0x325F300", Offset = "0x325D900", VA = "0x18325F300")]
			get
			{
				return default(bool);
			}
		}
	}
}
