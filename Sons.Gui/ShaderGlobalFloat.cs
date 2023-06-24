using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Gui
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[Serializable]
	public class ShaderGlobalFloat : ShaderGlobalValue<float>
	{
		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x30172A0", Offset = "0x30158A0", VA = "0x1830172A0")]
		public ShaderGlobalFloat(int nameId, float defaultValue)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x3017320", Offset = "0x3015920", VA = "0x183017320", Slot = "4")]
		public override void SetGlobal(int nameId, float sourceValue)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x3017380", Offset = "0x3015980", VA = "0x183017380", Slot = "5")]
		public override bool IsUnchanged()
		{
			return default(bool);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x3017390", Offset = "0x3015990", VA = "0x183017390")]
		public static void UpdateArray(List<ShaderGlobalFloat> list)
		{
		}
	}
}
