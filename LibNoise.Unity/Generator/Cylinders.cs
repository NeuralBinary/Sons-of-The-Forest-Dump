using System;
using Il2CppDummyDll;

namespace LibNoise.Generator
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class Cylinders : ModuleBase
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2084080", Offset = "0x2082680", VA = "0x182084080")]
		public Cylinders()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x20840C0", Offset = "0x20826C0", VA = "0x1820840C0")]
		public Cylinders(double frequency)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000027EC File Offset: 0x000009EC
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000037")]
		public double Frequency
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2084120", Offset = "0x2082720", VA = "0x182084120", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x20")]
		private double _frequency;
	}
}
