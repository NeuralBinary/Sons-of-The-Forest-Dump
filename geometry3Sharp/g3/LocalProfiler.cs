using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public class LocalProfiler : IDisposable
	{
		// Token: 0x060003AF RID: 943 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1F46F70", Offset = "0x1F45570", VA = "0x181F46F70")]
		public BlockTimer Start(string label)
		{
			return null;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1F47280", Offset = "0x1F45880", VA = "0x181F47280")]
		public BlockTimer StopAllAndStartNew(string label)
		{
			return null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1F472B0", Offset = "0x1F458B0", VA = "0x181F472B0")]
		public BlockTimer Get(string label)
		{
			return null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1F47310", Offset = "0x1F45910", VA = "0x181F47310")]
		public void Stop(string label)
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1F47380", Offset = "0x1F45980", VA = "0x181F47380")]
		public void StopAll()
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1F47580", Offset = "0x1F45B80", VA = "0x181F47580")]
		public void StopAndAccumulate(string label, bool bReset = false)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1F47690", Offset = "0x1F45C90", VA = "0x181F47690")]
		public void Reset(string label)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1F47700", Offset = "0x1F45D00", VA = "0x181F47700")]
		public void ResetAccumulated(string label)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1F477A0", Offset = "0x1F45DA0", VA = "0x181F477A0")]
		public void ResetAllAccumulated(string label)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1F479D0", Offset = "0x1F45FD0", VA = "0x181F479D0")]
		public void DivideAllAccumulated(int div)
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1F47BE0", Offset = "0x1F461E0", VA = "0x181F47BE0")]
		public string Elapsed(string label)
		{
			return null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1F47C50", Offset = "0x1F46250", VA = "0x181F47C50")]
		public string Accumulated(string label)
		{
			return null;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1F47CF0", Offset = "0x1F462F0", VA = "0x181F47CF0")]
		public string AllTicks(string prefix = "Times:")
		{
			return null;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1F47FB0", Offset = "0x1F465B0", VA = "0x181F47FB0")]
		public string AllAccumulatedTicks(string prefix = "Times:")
		{
			return null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1F482B0", Offset = "0x1F468B0", VA = "0x181F482B0")]
		public string AllTimes(string prefix = "Times:", string separator = " ")
		{
			return null;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1F485B0", Offset = "0x1F46BB0", VA = "0x181F485B0")]
		public string AllAccumulatedTimes(string prefix = "Times:", string separator = " ")
		{
			return null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1F488A0", Offset = "0x1F46EA0", VA = "0x181F488A0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1F48B80", Offset = "0x1F47180", VA = "0x181F48B80")]
		public LocalProfiler()
		{
		}

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, BlockTimer> Timers;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x18")]
		private List<string> Order;
	}
}
