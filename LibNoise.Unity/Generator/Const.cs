using System;
using Il2CppDummyDll;

namespace LibNoise.Generator
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class Const : ModuleBase
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2083F00", Offset = "0x2082500", VA = "0x182083F00")]
		public Const()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2084030", Offset = "0x2082630", VA = "0x182084030")]
		public Const(double value)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000027BC File Offset: 0x000009BC
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000036")]
		public double Value
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x20")]
		private double _value;
	}
}
