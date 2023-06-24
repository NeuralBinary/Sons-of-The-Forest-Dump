using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class Max : ModuleBase
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x207E8D0", Offset = "0x207CED0", VA = "0x18207E8D0")]
		public Max()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x207E960", Offset = "0x207CF60", VA = "0x18207E960")]
		public Max(ModuleBase lhs, ModuleBase rhs)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2080960", Offset = "0x207EF60", VA = "0x182080960", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
