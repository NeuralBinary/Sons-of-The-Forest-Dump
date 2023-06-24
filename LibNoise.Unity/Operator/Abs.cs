using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public class Abs : ModuleBase
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x207E6A0", Offset = "0x207CCA0", VA = "0x18207E6A0")]
		public Abs()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x207E730", Offset = "0x207CD30", VA = "0x18207E730")]
		public Abs(ModuleBase input)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x207E810", Offset = "0x207CE10", VA = "0x18207E810", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
