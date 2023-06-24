using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Loading;
using UnityEngine;

namespace Sons.Tests
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[Serializable]
	public abstract class TestAction : ITestAction
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void InfoBoxDummy()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "19")]
		public virtual string GetName()
		{
			return null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820", Slot = "10")]
		public float GetDelay()
		{
			return 0f;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080", Slot = "17")]
		public void SetCoroutine(Coroutine coroutine)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700001E")]
		private string IsRunningMessage
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x314FA90", Offset = "0x314E090", VA = "0x18314FA90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x1700001F")]
		private Color IsRunningColor
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x314FAE0", Offset = "0x314E0E0", VA = "0x18314FAE0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		private void CaptureSubActionResponse(TestResponse result)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
		internal TestResponse GetSubActionResponse()
		{
			return null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x314FB00", Offset = "0x314E100", VA = "0x18314FB00", Slot = "11")]
		public string GetStage()
		{
			return null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x314FB60", Offset = "0x314E160", VA = "0x18314FB60", Slot = "13")]
		public void StopTest()
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x314FBB0", Offset = "0x314E1B0", VA = "0x18314FBB0")]
		private void SanitizeName()
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x17000020")]
		public bool ShutdownOnComplete
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
		public void SetShutdownOnComplete(bool value)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x314FCD0", Offset = "0x314E2D0", VA = "0x18314FCD0", Slot = "12")]
		public void SetStage(string stage)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		internal void SetName(string name)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0", Slot = "7")]
		public bool IsRunning()
		{
			return default(bool);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "8")]
		public TestResponse GetResult()
		{
			return null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x98F610", Offset = "0x98DC10", VA = "0x18098F610", Slot = "20")]
		public virtual bool IsComplete()
		{
			return default(bool);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x314FDC0", Offset = "0x314E3C0", VA = "0x18314FDC0", Slot = "21")]
		public virtual void Run(string args)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x314FF70", Offset = "0x314E570", VA = "0x18314FF70")]
		private static string GenerateTimeStamp()
		{
			return null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x3150020", Offset = "0x314E620", VA = "0x183150020")]
		private bool VerifyManager()
		{
			return default(bool);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x3150110", Offset = "0x314E710", VA = "0x183150110")]
		internal Coroutine StartCoroutine(IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x3150160", Offset = "0x314E760", VA = "0x183150160")]
		internal void StopCoroutine(Coroutine coroutine)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x31501B0", Offset = "0x314E7B0", VA = "0x1831501B0")]
		internal bool IsCoroutineRunning(Coroutine coroutine)
		{
			return default(bool);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x3150210", Offset = "0x314E810", VA = "0x183150210", Slot = "22")]
		public virtual void Initialize()
		{
		}

		// Token: 0x060000B2 RID: 178
		[Token(Token = "0x60000B2")]
		public abstract IEnumerator RunWorker(string args);

		// Token: 0x060000B3 RID: 179 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x3150320", Offset = "0x314E920", VA = "0x183150320")]
		internal static IEnumerator WaitForThenPressButton(string buttonSearch, ITestAction testAction)
		{
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x3150420", Offset = "0x314EA20", VA = "0x183150420")]
		internal static IEnumerator WaitForThenPressButton(string buttonSearch, float timeout, ITestAction testAction)
		{
			return null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x3150540", Offset = "0x314EB40", VA = "0x183150540")]
		internal static bool FindObjectMatching(string singlePlayerButtonSearch, out GameObject result)
		{
			return default(bool);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x31506A0", Offset = "0x314ECA0", VA = "0x1831506A0")]
		internal static IEnumerator WaitForSceneLoaded(string sceneName, ITestAction testAction)
		{
			return null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x31507A0", Offset = "0x314EDA0", VA = "0x1831507A0")]
		internal static IEnumerator WaitForSceneLoaded(string sceneName, float timeout, ITestAction testAction)
		{
			return null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x31508C0", Offset = "0x314EEC0", VA = "0x1831508C0")]
		internal static bool SceneIsLoaded(string sceneName)
		{
			return default(bool);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x3150B10", Offset = "0x314F110", VA = "0x183150B10")]
		internal static IEnumerator WaitForSeconds(float time, ITestAction testAction)
		{
			return null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3150BC0", Offset = "0x314F1C0", VA = "0x183150BC0")]
		internal static IEnumerator WaitForAllScenesLoadingComplete(ITestAction testAction)
		{
			return null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x3150C50", Offset = "0x314F250", VA = "0x183150C50")]
		internal static IEnumerator WaitForAllScenesLoadingComplete(float timeout, ITestAction testAction)
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x3150D00", Offset = "0x314F300", VA = "0x183150D00")]
		internal static bool IsInventoryOpen()
		{
			return default(bool);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x3150D20", Offset = "0x314F320", VA = "0x183150D20")]
		internal static IEnumerator OpenInventory(TestAction testAction, float timeout = 30f)
		{
			return null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x3150DE0", Offset = "0x314F3E0", VA = "0x183150DE0")]
		internal static IEnumerator CloseInventory(TestAction testAction, float timeout = 30f)
		{
			return null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x3150EA0", Offset = "0x314F4A0", VA = "0x183150EA0")]
		internal IEnumerator WaitForMainSceneAndSkipCutscenes()
		{
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x3150F30", Offset = "0x314F530", VA = "0x183150F30")]
		internal IEnumerator DoWanderAndInventory()
		{
			return null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x3150FC0", Offset = "0x314F5C0", VA = "0x183150FC0")]
		internal IEnumerator CheckOpenInventoryTimer(TestAction.BoolResult openSuccess)
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x31510C0", Offset = "0x314F6C0", VA = "0x1831510C0")]
		internal static bool AllScenesLoadingComplete()
		{
			return default(bool);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x3151100", Offset = "0x314F700", VA = "0x183151100")]
		internal void SetFailed(TestResponse response)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x3151120", Offset = "0x314F720", VA = "0x183151120", Slot = "18")]
		public void SetFailed([Optional] string message)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x3151350", Offset = "0x314F950", VA = "0x183151350")]
		internal void SetPassed(TestResponse response)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x3151370", Offset = "0x314F970", VA = "0x183151370")]
		internal void SetPassed([Optional] string message)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x3151540", Offset = "0x314FB40", VA = "0x183151540")]
		internal static IEnumerator SkipAllCutScenes(float delayBetween, ITestAction automatedFpsTest)
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x31515F0", Offset = "0x314FBF0", VA = "0x1831515F0")]
		private static bool SkippingCurrentCutscene()
		{
			return default(bool);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x31516D0", Offset = "0x314FCD0", VA = "0x1831516D0")]
		internal void WriteOutTestLog(string resultsString, string extension, [Optional] string prefix, [Optional] string suffix)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x60000CA")]
		internal static bool TryFindObjectOfType<T>(out T sampleFpsTool, bool includeInactive = false, [Optional] Action<string> setFailedAction) where T : Component
		{
			return default(bool);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x3151900", Offset = "0x314FF00", VA = "0x183151900")]
		internal static bool RunDebugCommand(string command, [Optional] Action<string> setFailedAction)
		{
			return default(bool);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x3151AD0", Offset = "0x31500D0", VA = "0x183151AD0")]
		internal Coroutine RunSubTestAction(string testName)
		{
			return null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x3151CA0", Offset = "0x31502A0", VA = "0x183151CA0")]
		internal IEnumerator RunSubTestActionWorker(string testName)
		{
			return null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3151DA0", Offset = "0x31503A0", VA = "0x183151DA0")]
		internal bool EnsurePassed(TestResponse source)
		{
			return default(bool);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x3151E20", Offset = "0x3150420", VA = "0x183151E20", Slot = "15")]
		public void ReceivedTimeout()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected TestAction()
		{
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		protected const string DebugGodmodeOnCommand = "godmode on";

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		internal const string SonsMainSceneName = "SonsMain";

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _shutdownOnComplete;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _delay;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal TestResponse _testResult;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TestsManager _manager;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _running;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _complete;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _stage;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TestResponse _subActionResponse;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Coroutine _coroutine;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string _timeoutMessage;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static LoadScene _loadScene;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool _loadSceneCompleted;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string _timeStamp;

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		internal class BoolResult
		{
			// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public BoolResult()
			{
			}

			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool Value;
		}
	}
}
