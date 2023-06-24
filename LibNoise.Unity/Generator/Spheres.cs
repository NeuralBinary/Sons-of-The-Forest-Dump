using System;
using Il2CppDummyDll;

namespace LibNoise.Generator
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public class Spheres : ModuleBase
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2084080", Offset = "0x2082680", VA = "0x182084080")]
		public Spheres()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x20840C0", Offset = "0x20826C0", VA = "0x1820840C0")]
		public Spheres(double frequency)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000299C File Offset: 0x00000B9C
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000046")]
		public double Frequency
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2084AE0", Offset = "0x20830E0", VA = "0x182084AE0", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x20")]
		private double _frequency;
	}
}
