using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Backtrace.Unity.Services
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	internal class BacktraceApi : IBacktraceApi
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001E")]
		[Obsolete("RequestHandler is obsolete. BacktraceApi won't be able to provide BacktraceData in every situation")]
		public Func<string, BacktraceData, BacktraceResult> RequestHandler
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001F")]
		public Action<Exception> OnServerError
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000020")]
		public Action<BacktraceResult> OnServerResponse
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000233C File Offset: 0x0000053C
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000021")]
		public bool EnablePerformanceStatistics
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000022")]
		public string ServerUrl
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x73F470", Offset = "0x73DA70", VA = "0x18073F470", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x73F4A0", Offset = "0x73DAA0", VA = "0x18073F4A0")]
		public BacktraceApi(BacktraceCredentials credentials, bool ignoreSslValidation = false)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x73F710", Offset = "0x73DD10", VA = "0x18073F710", Slot = "14")]
		public IEnumerator SendMinidump(string minidumpPath, IEnumerable<string> attachments, IDictionary<string, string> attributes, [Optional] Action<BacktraceResult> callback)
		{
			return null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x73F920", Offset = "0x73DF20", VA = "0x18073F920", Slot = "5")]
		public IEnumerator Send(BacktraceData data, [Optional] Action<BacktraceResult> callback)
		{
			return null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x73FA80", Offset = "0x73E080", VA = "0x18073FA80", Slot = "6")]
		public IEnumerator Send(string json, IEnumerable<string> attachments, int deduplication, Action<BacktraceResult> callback)
		{
			return null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x73FC50", Offset = "0x73E250", VA = "0x18073FC50", Slot = "7")]
		public IEnumerator Send(string json, IEnumerable<string> attachments, Dictionary<string, string> attributes, Action<BacktraceResult> callback)
		{
			return null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x73FE60", Offset = "0x73E460", VA = "0x18073FE60")]
		private void PrintLog(UnityWebRequest request)
		{
		}

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BacktraceHttpClient _httpClient;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _shouldDisplayFailureMessage;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Uri _serverUrl;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string _minidumpUrl;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly BacktraceCredentials _credentials;
	}
}
