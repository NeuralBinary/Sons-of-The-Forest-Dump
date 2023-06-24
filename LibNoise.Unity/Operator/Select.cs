using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class Select : ModuleBase
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2081960", Offset = "0x207FF60", VA = "0x182081960")]
		public Select()
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2081A00", Offset = "0x2080000", VA = "0x182081A00")]
		public Select(ModuleBase inputA, ModuleBase inputB, ModuleBase controller)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2081BA0", Offset = "0x20801A0", VA = "0x182081BA0")]
		public Select(double min, double max, double fallOff, ModuleBase inputA, ModuleBase inputB)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000022")]
		public ModuleBase Controller
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x207ED80", Offset = "0x207D380", VA = "0x18207ED80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x207EDB0", Offset = "0x207D3B0", VA = "0x18207EDB0")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000254C File Offset: 0x0000074C
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000023")]
		public double FallOff
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x2081DE0", Offset = "0x20803E0", VA = "0x182081DE0")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000024")]
		public double Maximum
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x1D0B420", Offset = "0x1D09A20", VA = "0x181D0B420")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x2081E10", Offset = "0x2080410", VA = "0x182081E10")]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000257C File Offset: 0x0000077C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000025")]
		public double Minimum
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x1FE2E00", Offset = "0x1FE1400", VA = "0x181FE2E00")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2081E40", Offset = "0x2080440", VA = "0x182081E40")]
			set
			{
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2081E70", Offset = "0x2080470", VA = "0x182081E70")]
		public void SetBounds(double min, double max)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2081EB0", Offset = "0x20804B0", VA = "0x182081EB0", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x20")]
		private double _fallOff;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x28")]
		private double _raw;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x30")]
		private double _min;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x38")]
		private double _max;
	}
}
