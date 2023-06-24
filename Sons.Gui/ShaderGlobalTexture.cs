using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[Serializable]
	public class ShaderGlobalTexture : ShaderGlobalValue<Texture>
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x3017A40", Offset = "0x3016040", VA = "0x183017A40")]
		public ShaderGlobalTexture(int nameId, Texture defaultValue)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x3017B00", Offset = "0x3016100", VA = "0x183017B00", Slot = "4")]
		public override void SetGlobal(int nameId, Texture sourceValue)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x3017B60", Offset = "0x3016160", VA = "0x183017B60", Slot = "5")]
		public override bool IsUnchanged()
		{
			return default(bool);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x3017C90", Offset = "0x3016290", VA = "0x183017C90")]
		public static void UpdateArray(List<ShaderGlobalTexture> list)
		{
		}
	}
}
