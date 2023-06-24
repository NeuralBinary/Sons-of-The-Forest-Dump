using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Backtrace.Unity.Model;
using Il2CppDummyDll;

namespace Backtrace.Unity.Interfaces
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public interface IBacktraceApi
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600031A RID: 794
		[Token(Token = "0x17000093")]
		string ServerUrl { [Token(Token = "0x600031A")] get; }

		// Token: 0x0600031B RID: 795
		[Token(Token = "0x600031B")]
		IEnumerator Send(BacktraceData data, [Optional] Action<BacktraceResult> callback);

		// Token: 0x0600031C RID: 796
		[Token(Token = "0x600031C")]
		IEnumerator Send(string json, IEnumerable<string> attachments, int deduplication, Action<BacktraceResult> callback);

		// Token: 0x0600031D RID: 797
		[Token(Token = "0x600031D")]
		IEnumerator Send(string json, IEnumerable<string> attachments, Dictionary<string, string> queryAttributes, Action<BacktraceResult> callback);

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600031E RID: 798
		// (set) Token: 0x0600031F RID: 799
		[Token(Token = "0x17000094")]
		Action<Exception> OnServerError { [Token(Token = "0x600031E")] get; [Token(Token = "0x600031F")] set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000320 RID: 800
		// (set) Token: 0x06000321 RID: 801
		[Token(Token = "0x17000095")]
		Action<BacktraceResult> OnServerResponse { [Token(Token = "0x6000320")] get; [Token(Token = "0x6000321")] set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000322 RID: 802
		// (set) Token: 0x06000323 RID: 803
		[Token(Token = "0x17000096")]
		Func<string, BacktraceData, BacktraceResult> RequestHandler { [Token(Token = "0x6000322")] get; [Token(Token = "0x6000323")] set; }

		// Token: 0x06000324 RID: 804
		[Token(Token = "0x6000324")]
		IEnumerator SendMinidump(string minidumpPath, IEnumerable<string> attachments, IDictionary<string, string> queryAttributes, [Optional] Action<BacktraceResult> callback);

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000325 RID: 805
		// (set) Token: 0x06000326 RID: 806
		[Token(Token = "0x17000097")]
		bool EnablePerformanceStatistics { [Token(Token = "0x6000325")] get; [Token(Token = "0x6000326")] set; }
	}
}
