using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Breadcrumbs;
using Backtrace.Unity.Model.Database;
using Backtrace.Unity.Services;
using Backtrace.Unity.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[RequireComponent(typeof(BacktraceClient))]
	public class BacktraceDatabase : MonoBehaviour, IBacktraceDatabase
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000013")]
		public IBacktraceBreadcrumbs Breadcrumbs
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x73C0C0", Offset = "0x73A6C0", VA = "0x18073C0C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000014")]
		public string DatabasePath
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002204 File Offset: 0x00000404
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000015")]
		public int ScreenshotQuality
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x73C1D0", Offset = "0x73A7D0", VA = "0x18073C1D0", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x73C220", Offset = "0x73A820", VA = "0x18073C220", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000221C File Offset: 0x0000041C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000016")]
		public int ScreenshotMaxHeight
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x73C280", Offset = "0x73A880", VA = "0x18073C280", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x73C2D0", Offset = "0x73A8D0", VA = "0x18073C2D0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000017")]
		public static BacktraceDatabase Instance
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x73C330", Offset = "0x73A930", VA = "0x18073C330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002234 File Offset: 0x00000434
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000018")]
		public DeduplicationStrategy DeduplicationStrategy
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x73C370", Offset = "0x73A970", VA = "0x18073C370")]
			get
			{
				return DeduplicationStrategy.None;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x73C3F0", Offset = "0x73A9F0", VA = "0x18073C3F0")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000019")]
		protected BacktraceDatabaseSettings DatabaseSettings
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001A")]
		public IBacktraceApi BacktraceApi
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001B")]
		protected virtual IBacktraceDatabaseContext BacktraceDatabaseContext
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001C")]
		internal IBacktraceDatabaseFileContext BacktraceDatabaseFileContext
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000224C File Offset: 0x0000044C
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001D")]
		public bool Enable
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x671150", Offset = "0x66F750", VA = "0x180671150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x671160", Offset = "0x66F760", VA = "0x180671160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x73C4B0", Offset = "0x73AAB0", VA = "0x18073C4B0", Slot = "19")]
		public void Reload()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x73CD40", Offset = "0x73B340", VA = "0x18073CD40")]
		public void OnDisable()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x73CD50", Offset = "0x73B350", VA = "0x18073CD50")]
		private void Awake()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x73CD60", Offset = "0x73B360", VA = "0x18073CD60")]
		internal void Update()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x73CF30", Offset = "0x73B530", VA = "0x18073CF30")]
		private void Start()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0", Slot = "10")]
		public void SetApi(IBacktraceApi backtraceApi)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x671150", Offset = "0x66F750", VA = "0x180671150", Slot = "21")]
		public bool Enabled()
		{
			return default(bool);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "16")]
		public BacktraceDatabaseSettings GetSettings()
		{
			return null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x73D2C0", Offset = "0x73B8C0", VA = "0x18073D2C0", Slot = "11")]
		public void Clear()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x73D390", Offset = "0x73B990", VA = "0x18073D390", Slot = "20")]
		public BacktraceDatabaseRecord Add(BacktraceData data, bool @lock = true)
		{
			return null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x73D9E0", Offset = "0x73BFE0", VA = "0x18073D9E0", Slot = "13")]
		[Obsolete("Please use Add method with Backtrace data parameter instead")]
		public BacktraceDatabaseRecord Add(BacktraceReport backtraceReport, Dictionary<string, string> attributes, MiniDumpType miniDumpType = MiniDumpType.None)
		{
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x73DA40", Offset = "0x73C040", VA = "0x18073DA40", Slot = "14")]
		public IEnumerable<BacktraceDatabaseRecord> Get()
		{
			return null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x73DB00", Offset = "0x73C100", VA = "0x18073DB00", Slot = "15")]
		public void Delete(BacktraceDatabaseRecord record)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x73DBC0", Offset = "0x73C1C0", VA = "0x18073DBC0", Slot = "9")]
		public void Flush()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x73DC70", Offset = "0x73C270", VA = "0x18073DC70")]
		public void Send()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x73DD20", Offset = "0x73C320", VA = "0x18073DD20")]
		private void FlushRecord(BacktraceDatabaseRecord record)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x73E0A0", Offset = "0x73C6A0", VA = "0x18073E0A0")]
		private void SendData(BacktraceDatabaseRecord record)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x73E430", Offset = "0x73CA30", VA = "0x18073E430")]
		public int Count()
		{
			return 0;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x73E490", Offset = "0x73CA90", VA = "0x18073E490", Slot = "25")]
		protected virtual void RemoveOrphaned()
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x73E520", Offset = "0x73CB20", VA = "0x18073E520", Slot = "26")]
		protected virtual void SetupMultisceneSupport()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x73E680", Offset = "0x73CC80", VA = "0x18073E680", Slot = "27")]
		protected virtual bool InitializeDatabasePaths()
		{
			return default(bool);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x73E840", Offset = "0x73CE40", VA = "0x18073E840", Slot = "28")]
		protected virtual void LoadReports(string breadcrumbPath, string breadcrumbArchive)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x73EAC0", Offset = "0x73D0C0", VA = "0x18073EAC0")]
		private bool ValidateDatabaseSize()
		{
			return default(bool);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x73EC00", Offset = "0x73D200", VA = "0x18073EC00")]
		private bool ReachedDiskSpaceLimit()
		{
			return default(bool);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x73ECB0", Offset = "0x73D2B0", VA = "0x18073ECB0")]
		private bool ReachedMaximumNumberOfRecords()
		{
			return default(bool);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x73ED60", Offset = "0x73D360", VA = "0x18073ED60", Slot = "12")]
		public bool ValidConsistency()
		{
			return default(bool);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x73EDB0", Offset = "0x73D3B0", VA = "0x18073EDB0", Slot = "17")]
		public long GetDatabaseSize()
		{
			return 0L;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10", Slot = "18")]
		public void SetReportWatcher(ReportLimitWatcher reportLimitWatcher)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x73EE70", Offset = "0x73D470", VA = "0x18073EE70")]
		private void IncrementBatchRetry()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x73F160", Offset = "0x73D760", VA = "0x18073F160")]
		internal string GetBreadcrumbsPath()
		{
			return null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x73F1F0", Offset = "0x73D7F0", VA = "0x18073F1F0", Slot = "22")]
		public bool EnableBreadcrumbsSupport()
		{
			return default(bool);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BacktraceDatabase()
		{
		}

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x20")]
		private bool _timerBackgroundWork;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x28")]
		public BacktraceConfiguration Configuration;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x30")]
		private BacktraceBreadcrumbs _breadcrumbs;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x38")]
		private BacktraceClient _client;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		internal static float LastFrameTime;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x8")]
		private static BacktraceDatabase _instance;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x50")]
		private float _lastConnection;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x78")]
		private ReportLimitWatcher _reportLimitWatcher;
	}
}
