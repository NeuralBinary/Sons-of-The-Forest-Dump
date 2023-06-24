using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class Blend : ModuleBase
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x207EB60", Offset = "0x207D160", VA = "0x18207EB60")]
		public Blend()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x207EBF0", Offset = "0x207D1F0", VA = "0x18207EBF0")]
		public Blend(ModuleBase lhs, ModuleBase rhs, ModuleBase controller)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000010")]
		public ModuleBase Controller
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x207ED80", Offset = "0x207D380", VA = "0x18207ED80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x207EDB0", Offset = "0x207D3B0", VA = "0x18207EDB0")]
			set
			{
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x207EE10", Offset = "0x207D410", VA = "0x18207EE10", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
