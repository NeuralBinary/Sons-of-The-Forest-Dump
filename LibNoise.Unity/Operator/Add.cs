using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class Add : ModuleBase
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x207E8D0", Offset = "0x207CED0", VA = "0x18207E8D0")]
		public Add()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x207E960", Offset = "0x207CF60", VA = "0x18207E960")]
		public Add(ModuleBase lhs, ModuleBase rhs)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x207EA90", Offset = "0x207D090", VA = "0x18207EA90", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
