using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class Min : ModuleBase
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x207E8D0", Offset = "0x207CED0", VA = "0x18207E8D0")]
		public Min()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x207E960", Offset = "0x207CF60", VA = "0x18207E960")]
		public Min(ModuleBase lhs, ModuleBase rhs)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2080AB0", Offset = "0x207F0B0", VA = "0x182080AB0", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
