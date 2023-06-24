using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public class Translate : ModuleBase
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2081310", Offset = "0x207F910", VA = "0x182081310")]
		public Translate()
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x20813B0", Offset = "0x207F9B0", VA = "0x1820813B0")]
		public Translate(ModuleBase input)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x20814B0", Offset = "0x207FAB0", VA = "0x1820814B0")]
		public Translate(double x, double y, double z, ModuleBase input)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002624 File Offset: 0x00000824
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000029")]
		public double X
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002A")]
		public double Y
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x5FD5B0", Offset = "0x5FBBB0", VA = "0x1805FD5B0")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002654 File Offset: 0x00000854
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002B")]
		public double Z
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1FE2E00", Offset = "0x1FE1400", VA = "0x181FE2E00")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x20815F0", Offset = "0x207FBF0", VA = "0x1820815F0")]
			set
			{
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2082EF0", Offset = "0x20814F0", VA = "0x182082EF0", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		private double _x;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x28")]
		private double _y;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x30")]
		private double _z;
	}
}
