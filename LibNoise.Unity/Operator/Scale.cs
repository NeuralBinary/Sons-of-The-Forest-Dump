using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class Scale : ModuleBase
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2081310", Offset = "0x207F910", VA = "0x182081310")]
		public Scale()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x20813B0", Offset = "0x207F9B0", VA = "0x1820813B0")]
		public Scale(ModuleBase input)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x20814B0", Offset = "0x207FAB0", VA = "0x1820814B0")]
		public Scale(double x, double y, double z, ModuleBase input)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000024A4 File Offset: 0x000006A4
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001D")]
		public double X
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000024BC File Offset: 0x000006BC
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001E")]
		public double Y
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x5FD5B0", Offset = "0x5FBBB0", VA = "0x1805FD5B0")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000024D4 File Offset: 0x000006D4
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001F")]
		public double Z
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x1FE2E00", Offset = "0x1FE1400", VA = "0x181FE2E00")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x20815F0", Offset = "0x207FBF0", VA = "0x1820815F0")]
			set
			{
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2081600", Offset = "0x207FC00", VA = "0x182081600", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x20")]
		private double _x;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x28")]
		private double _y;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x30")]
		private double _z;
	}
}
