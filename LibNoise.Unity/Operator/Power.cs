using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class Power : ModuleBase
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x207E8D0", Offset = "0x207CED0", VA = "0x18207E8D0")]
		public Power()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x207E960", Offset = "0x207CF60", VA = "0x18207E960")]
		public Power(ModuleBase lhs, ModuleBase rhs)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2080CD0", Offset = "0x207F2D0", VA = "0x182080CD0", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
