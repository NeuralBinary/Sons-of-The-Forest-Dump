using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class Curve : ModuleBase
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x207F4F0", Offset = "0x207DAF0", VA = "0x18207F4F0")]
		public Curve()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x207F630", Offset = "0x207DC30", VA = "0x18207F630")]
		public Curve(ModuleBase input)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x17000014")]
		public int ControlPointCount
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x207F7D0", Offset = "0x207DDD0", VA = "0x18207F7D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000015")]
		public List<KeyValuePair<double, double>> ControlPoints
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x207F810", Offset = "0x207DE10", VA = "0x18207F810")]
		public void Add(double input, double output)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x207FB50", Offset = "0x207E150", VA = "0x18207FB50")]
		public void Clear()
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x207FBA0", Offset = "0x207E1A0", VA = "0x18207FBA0", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<KeyValuePair<double, double>> _data;
	}
}
