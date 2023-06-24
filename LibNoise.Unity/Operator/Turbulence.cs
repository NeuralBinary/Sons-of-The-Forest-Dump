using System;
using Il2CppDummyDll;
using LibNoise.Generator;

namespace LibNoise.Operator
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public class Turbulence : ModuleBase
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2082F50", Offset = "0x2081550", VA = "0x182082F50")]
		public Turbulence()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2083210", Offset = "0x2081810", VA = "0x182083210")]
		public Turbulence(ModuleBase input)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2083510", Offset = "0x2081B10", VA = "0x182083510")]
		public Turbulence(double power, ModuleBase input)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2083690", Offset = "0x2081C90", VA = "0x182083690")]
		public Turbulence(Perlin x, Perlin y, Perlin z, double power, ModuleBase input)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002684 File Offset: 0x00000884
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002C")]
		public double Frequency
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x20838B0", Offset = "0x2081EB0", VA = "0x1820838B0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x20838D0", Offset = "0x2081ED0", VA = "0x1820838D0")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000269C File Offset: 0x0000089C
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002D")]
		public double Power
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002E")]
		public int Roughness
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2083910", Offset = "0x2081F10", VA = "0x182083910")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2083930", Offset = "0x2081F30", VA = "0x182083930")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000026CC File Offset: 0x000008CC
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002F")]
		public int Seed
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x20839C0", Offset = "0x2081FC0", VA = "0x1820839C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x20839E0", Offset = "0x2081FE0", VA = "0x1820839E0")]
			set
			{
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2083A20", Offset = "0x2082020", VA = "0x182083A20", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		private const double X0 = 0.189422607421875;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		private const double Y0 = 0.99371337890625;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		private const double Z0 = 0.4781646728515625;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		private const double X1 = 0.4046478271484375;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		private const double Y1 = 0.276611328125;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		private const double Z1 = 0.9230499267578125;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		private const double X2 = 0.82122802734375;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		private const double Y2 = 0.1710968017578125;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		private const double Z2 = 0.6842803955078125;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x20")]
		private double _power;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x28")]
		private readonly Perlin _xDistort;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x30")]
		private readonly Perlin _yDistort;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x38")]
		private readonly Perlin _zDistort;
	}
}
