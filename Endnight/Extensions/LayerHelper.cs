using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Extensions
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public static class LayerHelper
	{
		// Token: 0x060003CA RID: 970 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x60003CA")]
		public static LayerMask GetMask<T>(params T[] layerIndexes) where T : Enum
		{
			return default(LayerMask);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xAA58D0", Offset = "0xAA3ED0", VA = "0x180AA58D0")]
		public static LayerMask GetMask(params int[] layerIndexes)
		{
			return default(LayerMask);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xAA5930", Offset = "0xAA3F30", VA = "0x180AA5930")]
		public static LayerMask GetMask(int layerIndex)
		{
			return default(LayerMask);
		}
	}
}
