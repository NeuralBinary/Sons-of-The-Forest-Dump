using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity.Model.Breadcrumbs
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	internal sealed class BacktraceBreadcrumbs : IBacktraceBreadcrumbs
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00002BDC File Offset: 0x00000DDC
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000085")]
		public BacktraceBreadcrumbType BreadcrumbsLevel
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return BacktraceBreadcrumbType.None;
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002BF4 File Offset: 0x00000DF4
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000086")]
		public UnityEngineLogLevel UnityLogLevel
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			[CompilerGenerated]
			get
			{
				return UnityEngineLogLevel.None;
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x75D420", Offset = "0x75BA20", VA = "0x18075D420")]
		public BacktraceBreadcrumbs(IBacktraceLogManager logManager, BacktraceBreadcrumbType level, UnityEngineLogLevel unityLogLevel)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x75D600", Offset = "0x75BC00", VA = "0x18075D600", Slot = "24")]
		public void UnregisterEvents()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x75D620", Offset = "0x75BC20", VA = "0x18075D620", Slot = "7")]
		public bool ClearBreadcrumbs()
		{
			return default(bool);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x75D670", Offset = "0x75BC70", VA = "0x18075D670", Slot = "6")]
		public bool EnableBreadcrumbs(BacktraceBreadcrumbType level, UnityEngineLogLevel unityLogLevel)
		{
			return default(bool);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x75D680", Offset = "0x75BC80", VA = "0x18075D680", Slot = "5")]
		public bool EnableBreadcrumbs()
		{
			return default(bool);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x75D700", Offset = "0x75BD00", VA = "0x18075D700", Slot = "20")]
		public bool FromBacktrace(BacktraceReport report)
		{
			return default(bool);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x75D760", Offset = "0x75BD60", VA = "0x18075D760", Slot = "21")]
		public bool FromMonoBehavior(string message, LogType type, IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x75D7C0", Offset = "0x75BDC0", VA = "0x18075D7C0", Slot = "22")]
		public string GetBreadcrumbLogPath()
		{
			return null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x75D810", Offset = "0x75BE10", VA = "0x18075D810", Slot = "12")]
		public bool Info(string message)
		{
			return default(bool);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x75D850", Offset = "0x75BE50", VA = "0x18075D850", Slot = "13")]
		public bool Info(string message, IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x75D890", Offset = "0x75BE90", VA = "0x18075D890", Slot = "14")]
		public bool Warning(string message)
		{
			return default(bool);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x75D8D0", Offset = "0x75BED0", VA = "0x18075D8D0", Slot = "15")]
		public bool Warning(string message, IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x75D910", Offset = "0x75BF10", VA = "0x18075D910", Slot = "11")]
		public bool Debug(string message, IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x75D950", Offset = "0x75BF50", VA = "0x18075D950", Slot = "10")]
		public bool Debug(string message)
		{
			return default(bool);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x75D990", Offset = "0x75BF90", VA = "0x18075D990", Slot = "18")]
		public bool Exception(string message)
		{
			return default(bool);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x75D9D0", Offset = "0x75BFD0", VA = "0x18075D9D0", Slot = "17")]
		public bool Exception(Exception exception, IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x75DA50", Offset = "0x75C050", VA = "0x18075DA50", Slot = "16")]
		public bool Exception(Exception exception)
		{
			return default(bool);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x75DAC0", Offset = "0x75C0C0", VA = "0x18075DAC0", Slot = "19")]
		public bool Exception(string message, IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x75DB00", Offset = "0x75C100", VA = "0x18075DB00", Slot = "9")]
		public bool Log(string message, LogType type)
		{
			return default(bool);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x75DB20", Offset = "0x75C120", VA = "0x18075DB20", Slot = "8")]
		public bool Log(string message, LogType logType, IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x75DBA0", Offset = "0x75C1A0", VA = "0x18075DBA0")]
		internal bool AddBreadcrumbs(string message, BreadcrumbLevel level, UnityEngineLogLevel type, [Optional] IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x75DCB0", Offset = "0x75C2B0", VA = "0x18075DCB0")]
		internal bool ShouldLog(UnityEngineLogLevel type)
		{
			return default(bool);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x75DCD0", Offset = "0x75C2D0", VA = "0x18075DCD0")]
		internal static UnityEngineLogLevel ConvertLogTypeToLogLevel(LogType type)
		{
			return UnityEngineLogLevel.None;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x75DD00", Offset = "0x75C300", VA = "0x18075DD00", Slot = "23")]
		public double BreadcrumbId()
		{
			return 0.0;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x75DD50", Offset = "0x75C350", VA = "0x18075DD50", Slot = "25")]
		public void Update()
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x75DEE0", Offset = "0x75C4E0", VA = "0x18075DEE0")]
		public static bool CanStoreBreadcrumbs(UnityEngineLogLevel logLevel, BacktraceBreadcrumbType backtraceBreadcrumbsLevel)
		{
			return default(bool);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x75DEF0", Offset = "0x75C4F0", VA = "0x18075DEF0", Slot = "26")]
		public string Archive()
		{
			return null;
		}

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly IBacktraceLogManager LogManager;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal readonly BacktraceBreadcrumbsEventHandler EventHandler;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _enabled;
	}
}
