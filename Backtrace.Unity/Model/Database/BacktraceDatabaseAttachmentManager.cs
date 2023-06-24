using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Database
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	internal class BacktraceDatabaseAttachmentManager
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00002A74 File Offset: 0x00000C74
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006F")]
		internal int ScreenshotMaxHeight
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00002A8C File Offset: 0x00000C8C
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000070")]
		internal int ScreenshotQuality
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x75AD80", Offset = "0x759380", VA = "0x18075AD80")]
		public BacktraceDatabaseAttachmentManager(BacktraceDatabaseSettings settings)
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x75AEC0", Offset = "0x7594C0", VA = "0x18075AEC0")]
		public IEnumerable<string> GetReportAttachments(BacktraceData data)
		{
			return null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x75B2C0", Offset = "0x7598C0", VA = "0x18075B2C0")]
		private void AddIfPathIsNotEmpty(List<string> source, string attachmentPath)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x75B360", Offset = "0x759960", VA = "0x18075B360")]
		private string GetMinidumpPath(BacktraceData backtraceData, string dataPrefix)
		{
			return null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x75B4C0", Offset = "0x759AC0", VA = "0x18075B4C0")]
		private string GetScreenshotPath(string dataPrefix)
		{
			return null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x75BF60", Offset = "0x75A560", VA = "0x18075BF60")]
		private string GetUnityPlayerLogFile(BacktraceData backtraceData, string dataPrefix)
		{
			return null;
		}

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x18")]
		private readonly BacktraceDatabaseSettings _settings;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x20")]
		private float _lastScreenTime;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x28")]
		private string _lastScreenPath;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x30")]
		private readonly object _lock;
	}
}
