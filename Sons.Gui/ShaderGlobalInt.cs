using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[Serializable]
	public class ShaderGlobalInt : ShaderGlobalValue<int>
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x30173D0", Offset = "0x30159D0", VA = "0x1830173D0")]
		public ShaderGlobalInt(int nameId, int defaultValue)
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x3017450", Offset = "0x3015A50", VA = "0x183017450", Slot = "4")]
		public override void SetGlobal(int nameId, int sourceValue)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x30174B0", Offset = "0x3015AB0", VA = "0x1830174B0", Slot = "5")]
		public override bool IsUnchanged()
		{
			return default(bool);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x30174C0", Offset = "0x3015AC0", VA = "0x1830174C0")]
		public static void UpdateArray(List<ShaderGlobalInt> list)
		{
		}
	}
}
