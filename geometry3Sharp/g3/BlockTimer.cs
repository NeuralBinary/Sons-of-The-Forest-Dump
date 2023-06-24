using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public class BlockTimer
	{
		// Token: 0x060003A6 RID: 934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1F46A40", Offset = "0x1F45040", VA = "0x181F46A40")]
		public BlockTimer(string label, bool bStart)
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1F46BF0", Offset = "0x1F451F0", VA = "0x181F46BF0")]
		public void Start()
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1F46C50", Offset = "0x1F45250", VA = "0x181F46C50")]
		public void Stop()
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00003C2C File Offset: 0x00001E2C
		[Token(Token = "0x17000078")]
		public bool Running
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x1F46C70", Offset = "0x1F45270", VA = "0x181F46C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1F46C90", Offset = "0x1F45290", VA = "0x181F46C90")]
		public void Accumulate(bool bReset = false)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1F46D50", Offset = "0x1F45350", VA = "0x181F46D50")]
		public void Reset()
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000079")]
		public string AccumulatedString
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x1F46DE0", Offset = "0x1F453E0", VA = "0x181F46DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1F46E50", Offset = "0x1F45450", VA = "0x181F46E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1F46EE0", Offset = "0x1F454E0", VA = "0x181F46EE0")]
		public static string TimeFormatString(TimeSpan span)
		{
			return null;
		}

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x10")]
		public Stopwatch Watch;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x18")]
		public string Label;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x20")]
		public TimeSpan Accumulated;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		private const string minute_format = "{0:mm}:{0:ss}.{0:fffffff}";

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		private const string second_format = "{0:ss}.{0:fffffff}";
	}
}
