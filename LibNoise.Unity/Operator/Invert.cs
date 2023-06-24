using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class Invert : ModuleBase
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x207E6A0", Offset = "0x207CCA0", VA = "0x18207E6A0")]
		public Invert()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x207E730", Offset = "0x207CD30", VA = "0x18207E730")]
		public Invert(ModuleBase input)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2080910", Offset = "0x207EF10", VA = "0x182080910", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
