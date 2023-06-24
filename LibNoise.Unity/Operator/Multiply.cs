using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class Multiply : ModuleBase
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x207E8D0", Offset = "0x207CED0", VA = "0x18207E8D0")]
		public Multiply()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x207E960", Offset = "0x207CF60", VA = "0x18207E960")]
		public Multiply(ModuleBase lhs, ModuleBase rhs)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2080C00", Offset = "0x207F200", VA = "0x182080C00", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
