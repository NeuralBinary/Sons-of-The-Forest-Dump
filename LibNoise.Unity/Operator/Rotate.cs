using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class Rotate : ModuleBase
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2080DF0", Offset = "0x207F3F0", VA = "0x182080DF0")]
		public Rotate()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x207E730", Offset = "0x207CD30", VA = "0x18207E730")]
		public Rotate(ModuleBase input)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2080EA0", Offset = "0x207F4A0", VA = "0x182080EA0")]
		public Rotate(double x, double y, double z, ModuleBase input)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002444 File Offset: 0x00000644
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001A")]
		public double X
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2080FD0", Offset = "0x207F5D0", VA = "0x182080FD0")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000245C File Offset: 0x0000065C
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001B")]
		public double Y
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x151E5F0", Offset = "0x151CBF0", VA = "0x18151E5F0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x2081000", Offset = "0x207F600", VA = "0x182081000")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002474 File Offset: 0x00000674
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001C")]
		public double Z
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2081030", Offset = "0x207F630", VA = "0x182081030")]
			set
			{
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2081060", Offset = "0x207F660", VA = "0x182081060")]
		private void SetAngles(double x, double y, double z)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2081250", Offset = "0x207F850", VA = "0x182081250", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x20")]
		private double _x;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x28")]
		private double _x1Matrix;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x30")]
		private double _x2Matrix;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x38")]
		private double _x3Matrix;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x40")]
		private double _y;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x48")]
		private double _y1Matrix;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x50")]
		private double _y2Matrix;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x58")]
		private double _y3Matrix;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x60")]
		private double _z;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x68")]
		private double _z1Matrix;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x70")]
		private double _z2Matrix;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x78")]
		private double _z3Matrix;
	}
}
