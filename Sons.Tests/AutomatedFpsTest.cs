using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Tests
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[Serializable]
	public class AutomatedFpsTest : TestAction
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3149330", Offset = "0x3147930", VA = "0x183149330")]
		public AutomatedFpsTest()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x3149430", Offset = "0x3147A30", VA = "0x183149430")]
		private void TestCommandLine()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3149440", Offset = "0x3147A40", VA = "0x183149440", Slot = "23")]
		public override IEnumerator RunWorker(string args)
		{
			return null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3149540", Offset = "0x3147B40", VA = "0x183149540")]
		private bool ParseArgs(string args)
		{
			return default(bool);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3149B80", Offset = "0x3148180", VA = "0x183149B80")]
		private void ProcessArguments(AutomatedFpsTestArgs obj)
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _singlePlayerButtonSearch;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _sampleTime;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("_runMacro")]
		[SerializeField]
		private string _runCommand;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] ArgsSplitCharArray;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _sourceArgs;
	}
}
