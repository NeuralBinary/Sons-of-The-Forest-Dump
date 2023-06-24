using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class Clamp : ModuleBase
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x207F190", Offset = "0x207D790", VA = "0x18207F190")]
		public Clamp()
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x207F230", Offset = "0x207D830", VA = "0x18207F230")]
		public Clamp(ModuleBase input)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x207F330", Offset = "0x207D930", VA = "0x18207F330")]
		public Clamp(double min, double max, ModuleBase input)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000022F4 File Offset: 0x000004F4
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000012")]
		public double Maximum
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x5FD5B0", Offset = "0x5FBBB0", VA = "0x1805FD5B0")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000230C File Offset: 0x0000050C
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000013")]
		public double Minimum
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x207F450", Offset = "0x207DA50", VA = "0x18207F450")]
		public void SetBounds(double min, double max)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x207F460", Offset = "0x207DA60", VA = "0x18207F460", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x20")]
		private double _min;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x28")]
		private double _max;
	}
}
