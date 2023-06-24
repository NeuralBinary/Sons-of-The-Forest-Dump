using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Json;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Backtrace.Unity.Model
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	internal sealed class BacktraceHttpClient : IBacktraceHttpClient
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002834 File Offset: 0x00000A34
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000040")]
		public bool IgnoreSslValidation
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x74C610", Offset = "0x74AC10", VA = "0x18074C610", Slot = "6")]
		public void Post(string submissionUrl, BacktraceJObject jObject, Action<long, bool, string> onComplete)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x74C950", Offset = "0x74AF50", VA = "0x18074C950", Slot = "7")]
		public UnityWebRequest Post(string submissionUrl, string json, IEnumerable<string> attachments, IDictionary<string, string> attributes)
		{
			return null;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x74CB30", Offset = "0x74B130", VA = "0x18074CB30", Slot = "8")]
		public UnityWebRequest Post(string submissionUrl, byte[] minidump, IEnumerable<string> attachments, IDictionary<string, string> attributes)
		{
			return null;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x74CCA0", Offset = "0x74B2A0", VA = "0x18074CCA0")]
		private UnityWebRequest Post(string submissionUrl, List<IMultipartFormSection> formData)
		{
			return null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x74CEB0", Offset = "0x74B4B0", VA = "0x18074CEB0")]
		private List<IMultipartFormSection> CreateJsonFormData(byte[] json, IEnumerable<string> attachments, IDictionary<string, string> attributes)
		{
			return null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x74D050", Offset = "0x74B650", VA = "0x18074D050")]
		private List<IMultipartFormSection> CreateMinidumpFormData(byte[] minidump, IEnumerable<string> attachments, IDictionary<string, string> attributes)
		{
			return null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x74D1A0", Offset = "0x74B7A0", VA = "0x18074D1A0")]
		private void AddAttributesToFormData(List<IMultipartFormSection> formData, IDictionary<string, string> attributes)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x74D3F0", Offset = "0x74B9F0", VA = "0x18074D3F0")]
		private void AddAttachmentToFormData(List<IMultipartFormSection> formData, IEnumerable<string> attachments)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BacktraceHttpClient()
		{
		}

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		private const string DiagnosticFileName = "upload_file";

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		private const int RequestTimeout = 15000;
	}
}
