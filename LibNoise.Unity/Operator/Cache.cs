using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class Cache : ModuleBase
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x207E6A0", Offset = "0x207CCA0", VA = "0x18207E6A0")]
		public Cache()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x207E730", Offset = "0x207CD30", VA = "0x18207E730")]
		public Cache(ModuleBase input)
		{
		}

		// Token: 0x17000011 RID: 17
		[Token(Token = "0x17000011")]
		public override ModuleBase this[int index]
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x207B970", Offset = "0x2079F70", VA = "0x18207B970", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x207EFB0", Offset = "0x207D5B0", VA = "0x18207EFB0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x207F0D0", Offset = "0x207D6D0", VA = "0x18207F0D0", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x20")]
		private double _value;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x28")]
		private bool _cached;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x30")]
		private double _x;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x38")]
		private double _y;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x40")]
		private double _z;
	}
}
