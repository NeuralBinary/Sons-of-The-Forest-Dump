using System;
using System.Collections;
using System.Collections.Generic;
using Endnight.Types;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using Sons.Utils;
using UnityEngine;

namespace Sons.Tests
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public class TestsManager : SingletonBehaviour<TestsManager>
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x1700003F")]
		public static bool IsTestRunning
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x31562F0", Offset = "0x31548F0", VA = "0x1831562F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x3156350", Offset = "0x3154950", VA = "0x183156350")]
		public static bool Run(string testNameRegex, string args)
		{
			return default(bool);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x31563F0", Offset = "0x31549F0", VA = "0x1831563F0")]
		private void RunInternal(string testNameRegex, string args)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x3156720", Offset = "0x3154D20", VA = "0x183156720")]
		private void OnEnable()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x3156810", Offset = "0x3154E10", VA = "0x183156810")]
		private void TestCommandLine()
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x3156910", Offset = "0x3154F10", VA = "0x183156910")]
		private static bool RunCommandLineTest()
		{
			return default(bool);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x3156A10", Offset = "0x3155010", VA = "0x183156A10")]
		private static string ReadTestArgsFile(CommandLineArgs.Options options)
		{
			return null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x3156C50", Offset = "0x3155250", VA = "0x183156C50")]
		private static void LogInfo(object message)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x3156CD0", Offset = "0x31552D0", VA = "0x183156CD0")]
		private static void LogError(object message)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x3156D50", Offset = "0x3155350", VA = "0x183156D50")]
		private bool HasRunningTests()
		{
			return default(bool);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x3156F00", Offset = "0x3155500", VA = "0x183156F00")]
		private void StopAll()
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x3157120", Offset = "0x3155720", VA = "0x183157120")]
		private void RunAll()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x3157290", Offset = "0x3155890", VA = "0x183157290")]
		private void Update()
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x3157B30", Offset = "0x3156130", VA = "0x183157B30")]
		private static void Shutdown(int exitCode)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x3157BD0", Offset = "0x31561D0", VA = "0x183157BD0")]
		private static void RunTest(ITestAction eachTest, string args)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x3157C30", Offset = "0x3156230", VA = "0x183157C30")]
		public Coroutine StartTestWorker(ITestAction testAction, string args)
		{
			return null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x3157F20", Offset = "0x3156520", VA = "0x183157F20")]
		private Coroutine StartTestWorkerInternal(ITestAction testAction, string args)
		{
			return null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x3158020", Offset = "0x3156620", VA = "0x183158020")]
		private IEnumerator DelayStartTestWorker(ITestAction testAction, string args)
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x3158180", Offset = "0x3156780", VA = "0x183158180")]
		public bool TryGetTestAction(string testName, out ITestAction result)
		{
			return default(bool);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x31584B0", Offset = "0x3156AB0", VA = "0x1831584B0")]
		private static bool TestMatches(string testName, ITestAction eachTest)
		{
			return default(bool);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x31585B0", Offset = "0x3156BB0", VA = "0x1831585B0")]
		public bool HasCoroutine(Coroutine subCoroutine)
		{
			return default(bool);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x3158730", Offset = "0x3156D30", VA = "0x183158730")]
		public Coroutine GetCoroutine(string testName)
		{
			return null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x3158A00", Offset = "0x3157000", VA = "0x183158A00")]
		public TestsManager()
		{
		}

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		private const int TestShutdownExitCode = 16;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _commandLineTest;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _commandLineTestArgs;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeReference]
		private List<ITestAction> _tests;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x40")]
		private List<string> _activeTestReadout;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<ITestAction, Coroutine> _activeTests;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x50")]
		private RealtimeAutoTimer _upTimeTimer;
	}
}
