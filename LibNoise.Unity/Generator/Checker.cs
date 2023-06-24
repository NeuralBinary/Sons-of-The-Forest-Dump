using System;
using Il2CppDummyDll;

namespace LibNoise.Generator
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public class Checker : ModuleBase
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2083F00", Offset = "0x2082500", VA = "0x182083F00")]
		public Checker()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2083F30", Offset = "0x2082530", VA = "0x182083F30", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
