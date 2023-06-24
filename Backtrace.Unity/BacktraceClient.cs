using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Breadcrumbs;
using Backtrace.Unity.Model.JsonData;
using Backtrace.Unity.Runtime.Native;
using Backtrace.Unity.Services;
using Backtrace.Unity.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class BacktraceClient : MonoBehaviour, IBacktraceClient
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public IBacktraceBreadcrumbs Breadcrumbs
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000206C File Offset: 0x0000026C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public bool Enabled
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		internal AttributeProvider AttributeProvider
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x7366A0", Offset = "0x734CA0", VA = "0x1807366A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000004")]
		public IBacktraceMetrics Metrics
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x736750", Offset = "0x734D50", VA = "0x180736750", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000005")]
		internal System.Random Random
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x736940", Offset = "0x734F40", VA = "0x180736940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		[Token(Token = "0x17000006")]
		public string this[string index]
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x736A30", Offset = "0x735030", VA = "0x180736A30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x736AA0", Offset = "0x7350A0", VA = "0x180736AA0")]
			set
			{
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x736B70", Offset = "0x735170", VA = "0x180736B70")]
		public void AddAttachment(string pathToAttachment)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
		public IEnumerable<string> GetAttachments()
		{
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x736BE0", Offset = "0x7351E0", VA = "0x180736BE0")]
		public void SetAttributes(Dictionary<string, string> attributes)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x736E10", Offset = "0x735410", VA = "0x180736E10")]
		public int GetAttributesCount()
		{
			return 0;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000007")]
		public static BacktraceClient Instance
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x736E70", Offset = "0x735470", VA = "0x180736E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000008")]
		public Action<Exception> OnServerError
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x736EB0", Offset = "0x7354B0", VA = "0x180736EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x736F80", Offset = "0x735580", VA = "0x180736F80")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000009")]
		public Func<string, BacktraceData, BacktraceResult> RequestHandler
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x737050", Offset = "0x735650", VA = "0x180737050")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x737120", Offset = "0x735720", VA = "0x180737120")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000A")]
		public Action<BacktraceResult> OnServerResponse
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x7371F0", Offset = "0x7357F0", VA = "0x1807371F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x7372C0", Offset = "0x7358C0", VA = "0x1807372C0")]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000B")]
		public Action<BacktraceReport> OnClientReportLimitReached
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x737390", Offset = "0x735990", VA = "0x180737390")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700000C")]
		internal INativeClient NativeClient
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x1700000D")]
		public bool EnablePerformanceStatistics
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x737430", Offset = "0x735A30", VA = "0x180737430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x1700000E")]
		public int GameObjectDepth
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x737450", Offset = "0x735A50", VA = "0x180737450")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000F")]
		internal IBacktraceApi BacktraceApi
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x737480", Offset = "0x735A80", VA = "0x180737480")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000010")]
		internal ReportLimitWatcher ReportLimitWatcher
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x737520", Offset = "0x735B20", VA = "0x180737520")]
			set
			{
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x7375B0", Offset = "0x735BB0", VA = "0x1807375B0")]
		public static BacktraceClient Initialize(BacktraceConfiguration configuration, [Optional] Dictionary<string, string> attributes, string gameObjectName = "BacktraceClient")
		{
			return null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x7379C0", Offset = "0x735FC0", VA = "0x1807379C0")]
		public static BacktraceClient Initialize(string url, string databasePath, [Optional] Dictionary<string, string> attributes, string gameObjectName = "BacktraceClient")
		{
			return null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x737B50", Offset = "0x736150", VA = "0x180737B50")]
		public static BacktraceClient Initialize(string url, string databasePath, [Optional] Dictionary<string, string> attributes, [Optional] string[] attachments, string gameObjectName = "BacktraceClient")
		{
			return null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x737CE0", Offset = "0x7362E0", VA = "0x180737CE0")]
		public static BacktraceClient Initialize(string url, [Optional] Dictionary<string, string> attributes, string gameObjectName = "BacktraceClient")
		{
			return null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x737E40", Offset = "0x736440", VA = "0x180737E40")]
		public static BacktraceClient Initialize(string url, [Optional] Dictionary<string, string> attributes, [Optional] string[] attachments, string gameObjectName = "BacktraceClient")
		{
			return null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x737F70", Offset = "0x736570", VA = "0x180737F70")]
		public void OnDisable()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x737F80", Offset = "0x736580", VA = "0x180737F80", Slot = "9")]
		public void Refresh()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x7387F0", Offset = "0x736DF0", VA = "0x1807387F0", Slot = "10")]
		public bool EnableBreadcrumbsSupport()
		{
			return default(bool);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x738840", Offset = "0x736E40", VA = "0x180738840", Slot = "12")]
		public bool EnableMetrics()
		{
			return default(bool);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x738850", Offset = "0x736E50", VA = "0x180738850")]
		private bool EnableMetrics(bool enableIfConfigurationIsDisabled = true)
		{
			return default(bool);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x738A30", Offset = "0x737030", VA = "0x180738A30")]
		public bool EnableMetrics(string uniqueAttributeName = "guid")
		{
			return default(bool);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x738BA0", Offset = "0x7371A0", VA = "0x180738BA0", Slot = "13")]
		public bool EnableMetrics(string uniqueEventsSubmissionUrl, string summedEventsSubmissionUrl, uint timeIntervalInSec = 1800U, string uniqueAttributeName = "guid")
		{
			return default(bool);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x738E40", Offset = "0x737440", VA = "0x180738E40")]
		private void StartupMetrics()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x738F30", Offset = "0x737530", VA = "0x180738F30")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x738F80", Offset = "0x737580", VA = "0x180738F80")]
		private void Awake()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x738FE0", Offset = "0x7375E0", VA = "0x180738FE0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x7391A0", Offset = "0x7377A0", VA = "0x1807391A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x739360", Offset = "0x737960", VA = "0x180739360", Slot = "8")]
		public void SetClientReportLimit(uint reportPerMin)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x739430", Offset = "0x737A30", VA = "0x180739430", Slot = "6")]
		public void Send(string message, [Optional] List<string> attachmentPaths, [Optional] Dictionary<string, string> attributes)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x739550", Offset = "0x737B50", VA = "0x180739550", Slot = "7")]
		public void Send(Exception exception, [Optional] List<string> attachmentPaths, [Optional] Dictionary<string, string> attributes)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x739670", Offset = "0x737C70", VA = "0x180739670", Slot = "5")]
		public void Send(BacktraceReport report, [Optional] Action<BacktraceResult> sendCallback)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x739720", Offset = "0x737D20", VA = "0x180739720")]
		private void SendReport(BacktraceReport report, [Optional] Action<BacktraceResult> sendCallback)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x7398F0", Offset = "0x737EF0", VA = "0x1807398F0")]
		private IEnumerator CollectDataAndSend(BacktraceReport report, Action<BacktraceResult> sendCallback)
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x739A50", Offset = "0x738050", VA = "0x180739A50")]
		private BacktraceData SetupBacktraceData(BacktraceReport report)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x739CB0", Offset = "0x7382B0", VA = "0x180739CB0")]
		private void CaptureUnityMessages()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x739F30", Offset = "0x738530", VA = "0x180739F30")]
		internal void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x73A110", Offset = "0x738710", VA = "0x18073A110")]
		internal void HandleUnityBackgroundException(string message, string stackTrace, LogType type)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x73A170", Offset = "0x738770", VA = "0x18073A170")]
		internal void HandleUnityMessage(string message, string stackTrace, LogType type)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x73A3C0", Offset = "0x7389C0", VA = "0x18073A3C0")]
		private bool SamplingShouldSkip()
		{
			return default(bool);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x73A5B0", Offset = "0x738BB0", VA = "0x18073A5B0")]
		private void SendUnhandledException(BacktraceUnhandledException exception, bool invokeSkipApi = true)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x73A670", Offset = "0x738C70", VA = "0x18073A670")]
		private bool ShouldSendReport(Exception exception, List<string> attachmentPaths, Dictionary<string, string> attributes, bool invokeSkipApi = true)
		{
			return default(bool);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x73AA40", Offset = "0x739040", VA = "0x18073AA40")]
		private bool ShouldSendReport(string message, List<string> attachmentPaths, Dictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x73ACC0", Offset = "0x7392C0", VA = "0x18073ACC0")]
		private bool ShouldSendReport(BacktraceReport report)
		{
			return default(bool);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x73AEF0", Offset = "0x7394F0", VA = "0x18073AEF0")]
		private void HandleInnerException(BacktraceReport report)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x73B090", Offset = "0x739690", VA = "0x18073B090")]
		private bool ValidClientConfiguration()
		{
			return default(bool);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x73B110", Offset = "0x739710", VA = "0x18073B110")]
		private bool ShouldSkipReport(ReportFilterType type, Exception exception, string message)
		{
			return default(bool);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x73B170", Offset = "0x739770", VA = "0x18073B170")]
		internal IList<string> GetNativeAttachments()
		{
			return null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x73B410", Offset = "0x739A10", VA = "0x18073B410")]
		public BacktraceClient()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		public const string VERSION = "3.7.8";

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		internal const string DefaultBacktraceGameObjectName = "BacktraceClient";

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BacktraceConfiguration Configuration;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BacktraceBreadcrumbs _breadcrumbs;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AttributeProvider _attributeProvider;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BacktraceMetrics _metrics;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private System.Random _random;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal Stack<BacktraceReport> BackgroundExceptions;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private HashSet<string> _clientReportAttachments;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BacktraceClient _instance;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public IBacktraceDatabase Database;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private IBacktraceApi _backtraceApi;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ReportLimitWatcher _reportLimitWatcher;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private BacktraceLogManager _backtraceLogManager;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal Action<BacktraceReport> _onClientReportLimitReached;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Func<BacktraceData, BacktraceData> BeforeSend;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Func<ReportFilterType, Exception, string, bool> SkipReport;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Action<Exception> OnUnhandledApplicationException;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private INativeClient _nativeClient;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Thread _current;
	}
}
