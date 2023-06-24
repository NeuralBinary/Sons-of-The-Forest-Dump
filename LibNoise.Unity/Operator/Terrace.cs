using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class Terrace : ModuleBase
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x20822B0", Offset = "0x20808B0", VA = "0x1820822B0")]
		public Terrace()
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x20823F0", Offset = "0x20809F0", VA = "0x1820823F0")]
		public Terrace(ModuleBase input)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2082590", Offset = "0x2080B90", VA = "0x182082590")]
		public Terrace(bool inverted, ModuleBase input)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x17000026")]
		public int ControlPointCount
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2082730", Offset = "0x2080D30", VA = "0x182082730")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000027")]
		public List<double> ControlPoints
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000025DC File Offset: 0x000007DC
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000028")]
		public bool IsInverted
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
			set
			{
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2082770", Offset = "0x2080D70", VA = "0x182082770")]
		public void Add(double input)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2082A40", Offset = "0x2081040", VA = "0x182082A40")]
		public void Clear()
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2082A90", Offset = "0x2081090", VA = "0x182082A90")]
		public void Generate(int steps)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2082B90", Offset = "0x2081190", VA = "0x182082B90", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<double> _data;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x28")]
		private bool _inverted;
	}
}
