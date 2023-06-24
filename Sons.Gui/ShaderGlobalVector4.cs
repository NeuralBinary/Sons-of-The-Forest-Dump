using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[Serializable]
	public class ShaderGlobalVector4 : ShaderGlobalValue<Vector4>
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x3017CD0", Offset = "0x30162D0", VA = "0x183017CD0")]
		public ShaderGlobalVector4(int nameId, Vector4 defaultValue)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x3017D60", Offset = "0x3016360", VA = "0x183017D60", Slot = "4")]
		public override void SetGlobal(int nameId, Vector4 sourceValue)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x3017DC0", Offset = "0x30163C0", VA = "0x183017DC0", Slot = "5")]
		public override bool IsUnchanged()
		{
			return default(bool);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x3017E30", Offset = "0x3016430", VA = "0x183017E30")]
		public static void UpdateArray(List<ShaderGlobalVector4> list)
		{
		}
	}
}
