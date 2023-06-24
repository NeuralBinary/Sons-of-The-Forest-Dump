using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[Serializable]
	public class ShaderGlobalColor : ShaderGlobalValue<Color>
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x30170A0", Offset = "0x30156A0", VA = "0x1830170A0")]
		public ShaderGlobalColor(int nameId, Vector4 defaultValue)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x3017150", Offset = "0x3015750", VA = "0x183017150", Slot = "4")]
		public override void SetGlobal(int nameId, Color sourceValue)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x30171F0", Offset = "0x30157F0", VA = "0x1830171F0", Slot = "5")]
		public override bool IsUnchanged()
		{
			return default(bool);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x3017260", Offset = "0x3015860", VA = "0x183017260")]
		public static void UpdateArray(List<ShaderGlobalColor> list)
		{
		}
	}
}
