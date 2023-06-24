using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class Subtract : ModuleBase
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x207E8D0", Offset = "0x207CED0", VA = "0x18207E8D0")]
		public Subtract()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x207E960", Offset = "0x207CF60", VA = "0x18207E960")]
		public Subtract(ModuleBase lhs, ModuleBase rhs)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x20821E0", Offset = "0x20807E0", VA = "0x1820821E0", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
