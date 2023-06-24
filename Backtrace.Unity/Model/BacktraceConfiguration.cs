using System;
using System.Collections.Generic;
using Backtrace.Unity.Model.Breadcrumbs;
using Backtrace.Unity.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity.Model
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[CreateAssetMenu(fileName = "Backtrace Configuration", menuName = "Backtrace/Configuration", order = 0)]
	[Serializable]
	public class BacktraceConfiguration : ScriptableObject
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x74A700", Offset = "0x748D00", VA = "0x18074A700")]
		public HashSet<string> GetAttachmentPaths()
		{
			return null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x74A850", Offset = "0x748E50", VA = "0x18074A850")]
		public string GetUniverseName()
		{
			return null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x74AA10", Offset = "0x749010", VA = "0x18074AA10")]
		public string GetToken()
		{
			return null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x74AAF0", Offset = "0x7490F0", VA = "0x18074AAF0")]
		public string GetFullDatabasePath()
		{
			return null;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700003A")]
		public string CrashpadDatabasePath
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x74AB60", Offset = "0x749160", VA = "0x18074AB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x74AC00", Offset = "0x749200", VA = "0x18074AC00")]
		public string GetValidServerUrl()
		{
			return null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x74AC10", Offset = "0x749210", VA = "0x18074AC10")]
		public static string UpdateServerUrl(string value)
		{
			return null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x74ADD0", Offset = "0x7493D0", VA = "0x18074ADD0")]
		public static bool ValidateServerUrl(string value)
		{
			return default(bool);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x74AE30", Offset = "0x749430", VA = "0x18074AE30")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x74AE90", Offset = "0x749490", VA = "0x18074AE90")]
		public uint GetEventAggregationIntervalTimerInMs()
		{
			return 0U;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x74AEA0", Offset = "0x7494A0", VA = "0x18074AEA0")]
		public BacktraceCredentials ToCredentials()
		{
			return null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x74AF00", Offset = "0x749500", VA = "0x18074AF00")]
		public BacktraceConfiguration()
		{
		}

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		private const BacktraceBreadcrumbType AllBreadcrumbsTypes = BacktraceBreadcrumbType.Manual | BacktraceBreadcrumbType.Log | BacktraceBreadcrumbType.Navigation | BacktraceBreadcrumbType.Http | BacktraceBreadcrumbType.System | BacktraceBreadcrumbType.User | BacktraceBreadcrumbType.Configuration;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		private const UnityEngineLogLevel AllLogTypes = UnityEngineLogLevel.Debug | UnityEngineLogLevel.Warning | UnityEngineLogLevel.Info | UnityEngineLogLevel.Fatal | UnityEngineLogLevel.Error;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		public const int DefaultAnrWatchdogTimeout = 5000;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		public const int DefaultRetryLimit = 3;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		public const int DefaultReportPerMin = 50;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		public const int DefaultGameObjectDepth = -1;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		public const int DefaultNumberOfLogs = 10;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		public const int DefaultMaxRecordCount = 8;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		public const int DefaultMaxDatabaseSize = 0;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		public const int DefaultRetryInterval = 60;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x18")]
		[Header("Backtrace client configuration")]
		[Tooltip("This field is required to submit exceptions from your Unity project to your Backtrace instance.\n \nMore information about how to retrieve this value for your instance is our docs at What is a submission URL and What is a submission token?\n\nNOTE: the backtrace-unity plugin will expect full URL with token to your Backtrace instance.")]
		public string ServerUrl;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x20")]
		public string Token;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Reports per minute: Limits the number of reports the client will send per minutes. If set to 0, there is no limit. If set to a higher value and the value is reached, the client will not send any reports until the next minute. Default: 50")]
		public int ReportPerMin;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Disable error reporting integration in editor mode.")]
		public bool DisableInEditor;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x2D")]
		[Tooltip("Toggle this on or off to set the library to handle unhandled exceptions that are not captured by try-catch blocks.")]
		public bool HandleUnhandledExceptions;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x2E")]
		[Tooltip("Unity by default will validate ssl certificates. By using this option you can avoid ssl certificates validation. However, if you don't need to ignore ssl validation, please set this option to false.")]
		public bool IgnoreSslValidation;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x2F")]
		[Tooltip("Backtrace-client by default will be available on each scene. Once you initialize Backtrace integration, you can fetch Backtrace game object from every scene. In case if you don't want to have Backtrace-unity integration available by default in each scene, please set this value to true.")]
		public bool DestroyOnLoad;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Log random sampling rate - Enables a random sampling mechanism for Unity.Error logs - by default sampling is equal to 0.01 - which means only 1% of randomply sampling reports will be send to Backtrace. \n* 1 - means 100% of error reports will be reported by library,\n* 0.1 - means 10% of error reports will be reported by library,\n* 0 - means library is going to drop all errors.")]
		[Range(0f, 1f)]
		public double Sampling;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Report filter allows to filter specific type of reports. Possible options:\n* Disable - Disable report filtering - send every type of report.\n* Message - Prevent message reports.\n* Exception - Prevent exception reports.\n* Unhandled exception- Prevent unhandled exception reports.\n* Hang - Prevent sending reports when game hang.\n* Error log - Prevent sending error logs.")]
		public ReportFilterType ReportFilterType;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Allows developer to filter number of game object childrens in Backtrace report.")]
		public int GameObjectDepth;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Number of logs collected by Backtrace-Unity")]
		public uint NumberOfLogs;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Enable performance statistics")]
		public bool PerformanceStatistics;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x45")]
		[Tooltip("Try to find game native crashes and send them on Game startup")]
		public bool SendUnhandledGameCrashesOnGameStartup;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x46")]
		[Tooltip("Capture native Crashes")]
		public bool CaptureNativeCrashes;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x47")]
		[Tooltip("Capture ANR events - Application not responding")]
		public bool HandleANR;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x48")]
		public int AnrWatchdogTimeout;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Client-side deduplication allows the backtrace-unity library to group multiple error reports into a single one based on various factors. Factors include:\n\n* Disable - Client-side deduplication rules are disabled.\n* Everything - Use all the options as a factor in client-side deduplication.\n* Faulting callstack - Use the faulting callstack as a factor in client-side deduplication.\n* Exception type - Use the exception type as a factor in client-side deduplication.\n* Exception message - Use the exception message as a factor in client-side deduplication.")]
		public DeduplicationStrategy DeduplicationStrategy;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Enable breadcurmbs integration that will include game breadcrumbs in each report (native + managed).")]
		public bool EnableBreadcrumbsSupport;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Breadcrumbs support breadcrumbs level- Backtrace breadcrumbs log level controls what type of information will be available in the breadcrumb file")]
		public BacktraceBreadcrumbType BacktraceBreadcrumbsLevel;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Breadcrumbs log level")]
		public UnityEngineLogLevel LogLevel;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("If exception does not have a stack trace, use a normalized exception message to generate fingerprint.")]
		public bool UseNormalizedExceptionMessage;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Type of minidump that will be attached to Backtrace report in the report generated on Windows machine.")]
		public MiniDumpType MinidumpType;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("Generate and attach screenshot of frame as exception occurs")]
		public bool GenerateScreenshotOnException;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("List of path to attachments that Backtrace client will include in the native and managed reports.")]
		public string[] AttachmentPaths;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("This is the path to directory where the Backtrace database will store reports on your game. NOTE: Backtrace database will remove all existing files on database start.")]
		public string DatabasePath;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("This toggles the periodic (default: every 30 minutes) transmission of session information to the Backtrace endpoints. This will enable metrics such as crash free users and crash free sessions.")]
		public bool EnableMetricsSupport;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("How often events should be sent to the Backtrace endpoints, in minutes. Zero (0) disables auto send and will require manual periodic sending using the API. For more information, see the README.")]
		[Range(0f, 60f)]
		public uint TimeIntervalInMin;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("When this setting is toggled, the backtrace-unity plugin will configure an offline database that will store reports if they can't be submitted do to being offline or not finding a network. When toggled on, there are a number of Database settings to configure.")]
		[Header("Backtrace database configuration")]
		public bool Enabled;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x81")]
		[Tooltip("Add Unity player log file to Backtrace report")]
		public bool AddUnityLogToReport;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x82")]
		[Tooltip("When toggled on, the database will send automatically reports to Backtrace server based on the Retry Settings below. When toggled off, the developer will need to use the Flush method to attempt to send and clear. Recommend that this is toggled on.")]
		public bool AutoSendMode;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x83")]
		[Tooltip("If toggled, the library will create the offline database directory if the provided path doesn't exists.")]
		public bool CreateDatabase;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x84")]
		[Tooltip("This is one of two limits you can impose for controlling the growth of the offline store. This setting is the maximum number of stored reports in database. If value is equal to zero, then limit not exists, When the limit is reached, the database will remove the oldest entries.")]
		public int MaxRecordCount;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("This is the second limit you can impose for controlling the growth of the offline store. This setting is the maximum database size in MB. If value is equal to zero, then size is unlimited, When the limit is reached, the database will remove the oldest entries.")]
		public long MaxDatabaseSize;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("If the database is unable to send its record, this setting specifies how many seconds the library should wait between retries.")]
		public int RetryInterval;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x94")]
		[Tooltip("If the database is unable to send its record, this setting specifies the maximum number of retries before the system gives up.")]
		public int RetryLimit;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x98")]
		[Tooltip("This specifies in which order records are sent to the Backtrace server.")]
		public RetryOrder RetryOrder;
	}
}
