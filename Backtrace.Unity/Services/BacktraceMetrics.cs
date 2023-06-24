using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Attributes;
using Backtrace.Unity.Model.JsonData;
using Backtrace.Unity.Model.Metrics;
using Il2CppDummyDll;

namespace Backtrace.Unity.Services
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	internal sealed class BacktraceMetrics : IBacktraceMetrics, IScopeAttributeProvider
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000030")]
		public string StartupUniqueAttributeName
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000025AC File Offset: 0x000007AC
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000031")]
		public uint MaximumUniqueEvents
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x745070", Offset = "0x743670", VA = "0x180745070", Slot = "6")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x7450B0", Offset = "0x7436B0", VA = "0x1807450B0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000025C4 File Offset: 0x000007C4
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000032")]
		public uint MaximumSummedEvents
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x745100", Offset = "0x743700", VA = "0x180745100", Slot = "4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x745140", Offset = "0x743740", VA = "0x180745140", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000033")]
		public string UniqueEventsSubmissionUrl
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x745190", Offset = "0x743790", VA = "0x180745190", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x7451D0", Offset = "0x7437D0", VA = "0x1807451D0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000034")]
		public string SummedEventsSubmissionUrl
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x745270", Offset = "0x743870", VA = "0x180745270", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x7452B0", Offset = "0x7438B0", VA = "0x1807452B0", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		public bool IgnoreSslValidation
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x745350", Offset = "0x743950", VA = "0x180745350")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000036")]
		public LinkedList<UniqueEvent> UniqueEvents
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x7453E0", Offset = "0x7439E0", VA = "0x1807453E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000037")]
		internal LinkedList<SummedEvent> SummedEvents
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x745400", Offset = "0x743A00", VA = "0x180745400")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x745420", Offset = "0x743A20", VA = "0x180745420")]
		public BacktraceMetrics(AttributeProvider attributeProvider, long timeIntervalInSec, string uniqueEventsSubmissionUrl, string summedEventsSubmissionUrl)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x7458C0", Offset = "0x743EC0", VA = "0x1807458C0")]
		internal void OverrideHttpClient(IBacktraceHttpClient client)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x7459A0", Offset = "0x743FA0", VA = "0x1807459A0")]
		public void SendStartupEvent()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x745A20", Offset = "0x744020", VA = "0x180745A20")]
		public void Tick(float time)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x745F10", Offset = "0x744510", VA = "0x180745F10", Slot = "12")]
		public void Send()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x745F80", Offset = "0x744580", VA = "0x180745F80")]
		public bool AddUniqueEvent(string attributeName)
		{
			return default(bool);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x745F90", Offset = "0x744590", VA = "0x180745F90")]
		public bool AddUniqueEvent(string attributeName, [Optional] IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x7462E0", Offset = "0x7448E0", VA = "0x1807462E0")]
		public int Count()
		{
			return 0;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x746350", Offset = "0x744950", VA = "0x180746350", Slot = "13")]
		public bool AddSummedEvent(string metricsGroupName)
		{
			return default(bool);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x746460", Offset = "0x744A60", VA = "0x180746460", Slot = "14")]
		public bool AddSummedEvent(string metricsGroupName, [Optional] IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x746570", Offset = "0x744B70", VA = "0x180746570")]
		private void SendPendingSubmissionJobs(float time)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x7465F0", Offset = "0x744BF0", VA = "0x1807465F0")]
		internal static string GetDefaultUniqueEventsUrl(string universeName, string token)
		{
			return null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x746640", Offset = "0x744C40", VA = "0x180746640")]
		internal static string GetDefaultSummedEventsUrl(string universeName, string token)
		{
			return null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x746690", Offset = "0x744C90", VA = "0x180746690")]
		private static string GetDefaultSubmissionUrl(string serviceName, string universeName, string token)
		{
			return null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x746830", Offset = "0x744E30", VA = "0x180746830", Slot = "15")]
		public void GetAttributes(IDictionary<string, string> attributes)
		{
		}

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Guid SessionId;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		public const string DefaultSubmissionUrl = "https://events.backtrace.io/api/";

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		public const uint DefaultTimeIntervalInMin = 30U;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		public const uint DefaultTimeIntervalInSec = 1800U;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		public const string DefaultUniqueAttributeName = "guid";

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		public const int MaxTimeBetweenRequests = 300;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		public const int MaxNumberOfAttempts = 3;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		internal const string ApplicationSessionKey = "application.session";

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal readonly UniqueEventsSubmissionQueue _uniqueEventsSubmissionQueue;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal readonly SummedEventsSubmissionQueue _summedEventsSubmissionQueue;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		private const string StartupEventName = "Application Launches";

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly long _timeIntervalInSec;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _lastUpdateTime;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly AttributeProvider _attributeProvider;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private object _object;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string _sessionId;
	}
}
