using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class Exponent : ModuleBase
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2080580", Offset = "0x207EB80", VA = "0x182080580")]
		public Exponent()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2080610", Offset = "0x207EC10", VA = "0x182080610")]
		public Exponent(ModuleBase input)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2080700", Offset = "0x207ED00", VA = "0x182080700")]
		public Exponent(double exponent, ModuleBase input)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000019")]
		public double Value
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2080810", Offset = "0x207EE10", VA = "0x182080810", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		private double _exponent;
	}
}
