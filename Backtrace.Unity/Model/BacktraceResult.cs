using System;
using Backtrace.Unity.Types;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public class BacktraceResult
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004A")]
		public string Message
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004B")]
		public string Object
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x74F020", Offset = "0x74D620", VA = "0x18074F020")]
			set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004C")]
		public string RxId
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x74F090", Offset = "0x74D690", VA = "0x18074F090")]
			set
			{
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x74F100", Offset = "0x74D700", VA = "0x18074F100")]
		internal static BacktraceResult OnLimitReached()
		{
			return null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x74F1A0", Offset = "0x74D7A0", VA = "0x18074F1A0")]
		internal static BacktraceResult OnNetworkError(Exception exception)
		{
			return null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x74F260", Offset = "0x74D860", VA = "0x18074F260")]
		internal void AddInnerResult(BacktraceResult innerResult)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x74F2E0", Offset = "0x74D8E0", VA = "0x18074F2E0")]
		public static BacktraceResult FromJson(string json)
		{
			return null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x74F4C0", Offset = "0x74DAC0", VA = "0x18074F4C0")]
		public BacktraceResult()
		{
		}

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x10")]
		public BacktraceResult InnerExceptionResult;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x20")]
		public string response;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x28")]
		public BacktraceResultStatus Status;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x30")]
		private string @object;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x38")]
		public string _rxId;

		// Token: 0x02000037 RID: 55
		[Token(Token = "0x2000037")]
		[Serializable]
		private class BacktraceRawResult
		{
			// Token: 0x060001A5 RID: 421 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public BacktraceRawResult()
			{
			}

			// Token: 0x0400016D RID: 365
			[Token(Token = "0x400016D")]
			[FieldOffset(Offset = "0x10")]
			public string response;

			// Token: 0x0400016E RID: 366
			[Token(Token = "0x400016E")]
			[FieldOffset(Offset = "0x18")]
			public string _rxid;
		}
	}
}
