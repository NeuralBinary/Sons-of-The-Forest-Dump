using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Json;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Breadcrumbs.Storage
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	internal sealed class BacktraceStorageLogManager : IBacktraceLogManager, IArchiveableBreadcrumbManager
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008A")]
		public string BreadcrumbsFilePath
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00002E34 File Offset: 0x00001034
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008B")]
		public long BreadcrumbsSize
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x75F510", Offset = "0x75DB10", VA = "0x18075F510")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008C")]
		internal IBreadcrumbFile BreadcrumbFile
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x75F580", Offset = "0x75DB80", VA = "0x18075F580")]
		public BacktraceStorageLogManager(string storagePath)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x75F8F0", Offset = "0x75DEF0", VA = "0x18075F8F0", Slot = "7")]
		public bool Enable()
		{
			return default(bool);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x75FB50", Offset = "0x75E150", VA = "0x18075FB50", Slot = "5")]
		public bool Add(string message, BreadcrumbLevel level, UnityEngineLogLevel type, IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x75FE30", Offset = "0x75E430", VA = "0x18075FE30")]
		private BacktraceJObject CreateBreadcrumbJson(double id, string message, BreadcrumbLevel level, UnityEngineLogLevel type, IDictionary<string, string> attributes)
		{
			return null;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x760360", Offset = "0x75E960", VA = "0x180760360")]
		private bool AppendBreadcrumb(byte[] bytes)
		{
			return default(bool);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x7606E0", Offset = "0x75ECE0", VA = "0x1807606E0")]
		private void ClearOldLogs()
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x760BC0", Offset = "0x75F1C0", VA = "0x180760BC0")]
		private long GetNextStartPosition()
		{
			return 0L;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x760D00", Offset = "0x75F300", VA = "0x180760D00", Slot = "6")]
		public bool Clear()
		{
			return default(bool);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x760D90", Offset = "0x75F390", VA = "0x180760D90", Slot = "8")]
		public int Length()
		{
			return 0;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0", Slot = "9")]
		public double BreadcrumbId()
		{
			return 0.0;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x760DD0", Offset = "0x75F3D0", VA = "0x180760DD0", Slot = "10")]
		public string Archive()
		{
			return null;
		}

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		public const int MinimumBreadcrumbsFileSize = 10000;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x18")]
		private long _breadcrumbsSize;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		internal const string BreadcrumbLogFilePrefix = "bt-breadcrumbs";

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		internal const string BreadcrumbLogFileName = "bt-breadcrumbs-0";

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x0")]
		internal static byte[] NewRow;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x8")]
		internal static byte[] EndOfDocument;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x10")]
		internal static byte[] StartOfDocument;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x20")]
		private bool _emptyFile;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x28")]
		private double _breadcrumbId;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x30")]
		private object _lockObject;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x38")]
		private long currentSize;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x40")]
		private readonly Queue<long> _logSize;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x48")]
		private readonly string _storagePath;
	}
}
