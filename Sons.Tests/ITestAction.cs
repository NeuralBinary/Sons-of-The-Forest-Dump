using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Tests
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public interface ITestAction
	{
		// Token: 0x06000020 RID: 32
		[Token(Token = "0x6000020")]
		string GetName();

		// Token: 0x06000021 RID: 33
		[Token(Token = "0x6000021")]
		void Run(string args);

		// Token: 0x06000022 RID: 34
		[Token(Token = "0x6000022")]
		bool IsComplete();

		// Token: 0x06000023 RID: 35
		[Token(Token = "0x6000023")]
		bool IsRunning();

		// Token: 0x06000024 RID: 36
		[Token(Token = "0x6000024")]
		TestResponse GetResult();

		// Token: 0x06000025 RID: 37
		[Token(Token = "0x6000025")]
		IEnumerator RunWorker(string args);

		// Token: 0x06000026 RID: 38
		[Token(Token = "0x6000026")]
		float GetDelay();

		// Token: 0x06000027 RID: 39
		[Token(Token = "0x6000027")]
		string GetStage();

		// Token: 0x06000028 RID: 40
		[Token(Token = "0x6000028")]
		void SetStage(string message);

		// Token: 0x06000029 RID: 41
		[Token(Token = "0x6000029")]
		void StopTest();

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002A RID: 42
		[Token(Token = "0x17000007")]
		bool ShutdownOnComplete { [Token(Token = "0x600002A")] get; }

		// Token: 0x0600002B RID: 43
		[Token(Token = "0x600002B")]
		void ReceivedTimeout();

		// Token: 0x0600002C RID: 44
		[Token(Token = "0x600002C")]
		void Initialize();

		// Token: 0x0600002D RID: 45
		[Token(Token = "0x600002D")]
		void SetCoroutine(Coroutine result);

		// Token: 0x0600002E RID: 46
		[Token(Token = "0x600002E")]
		void SetFailed(string message);
	}
}
