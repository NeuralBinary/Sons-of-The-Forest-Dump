using System;
using System.Collections.Generic;
using Backtrace.Unity.Model;
using Il2CppDummyDll;

namespace Backtrace.Unity.Services
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class ReportLimitWatcher
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x746910", Offset = "0x744F10", VA = "0x180746910")]
		internal ReportLimitWatcher(uint reportPerMin)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x746B80", Offset = "0x745180", VA = "0x180746B80")]
		internal void SetClientReportLimit(uint reportPerMin)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x746BF0", Offset = "0x7451F0", VA = "0x180746BF0")]
		public bool WatchReport(long timestamp, bool displayMessageOnLimitHit = true)
		{
			return default(bool);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x746F70", Offset = "0x745570", VA = "0x180746F70")]
		public bool WatchReport(BacktraceReport report, bool displayMessageOnLimitHit = true)
		{
			return default(bool);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x746F90", Offset = "0x745590", VA = "0x180746F90")]
		internal bool ShouldDisplayMessage()
		{
			return default(bool);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x746FA0", Offset = "0x7455A0", VA = "0x180746FA0")]
		private void DisplayReportLimitHitMessage()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x747050", Offset = "0x745650", VA = "0x180747050")]
		private void Clear()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120")]
		internal void Reset()
		{
		}

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x10")]
		internal readonly Queue<long> _reportQueue;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x18")]
		internal readonly object _object;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x20")]
		private readonly long _queueReportTime;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x28")]
		private bool _watcherEnable;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x2C")]
		private int _reportPerMin;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x30")]
		private bool _displayMessage;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x31")]
		private bool _limitHit;
	}
}
