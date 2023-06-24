using System;
using System.Collections.Generic;
using Backtrace.Unity.Json;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Backtrace.Unity.Model
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	internal interface IBacktraceHttpClient
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001DD RID: 477
		// (set) Token: 0x060001DE RID: 478
		[Token(Token = "0x17000059")]
		bool IgnoreSslValidation { [Token(Token = "0x60001DD")] get; [Token(Token = "0x60001DE")] set; }

		// Token: 0x060001DF RID: 479
		[Token(Token = "0x60001DF")]
		void Post(string submissionUrl, BacktraceJObject jObject, Action<long, bool, string> onComplete);

		// Token: 0x060001E0 RID: 480
		[Token(Token = "0x60001E0")]
		UnityWebRequest Post(string submissionUrl, string json, IEnumerable<string> attachments, IDictionary<string, string> attributes);

		// Token: 0x060001E1 RID: 481
		[Token(Token = "0x60001E1")]
		UnityWebRequest Post(string submissionUrl, byte[] minidump, IEnumerable<string> attachments, IDictionary<string, string> attributes);
	}
}
