using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity.Model
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	internal class BacktraceLogManager
	{
		// Token: 0x0600017C RID: 380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x74D980", Offset = "0x74BF80", VA = "0x18074D980")]
		public BacktraceLogManager(uint numberOfLogs)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x17000041")]
		public int Size
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x74DAC0", Offset = "0x74C0C0", VA = "0x18074DAC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x17000042")]
		public bool Disabled
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x74DB00", Offset = "0x74C100", VA = "0x18074DB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x74DB10", Offset = "0x74C110", VA = "0x18074DB10")]
		public bool Enqueue(BacktraceReport report)
		{
			return default(bool);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x74DB80", Offset = "0x74C180", VA = "0x18074DB80")]
		public bool Enqueue(string message, string stackTrace, LogType type)
		{
			return default(bool);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x74DC20", Offset = "0x74C220", VA = "0x18074DC20")]
		public bool Enqueue(BacktraceUnityMessage unityMessage)
		{
			return default(bool);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x74DE50", Offset = "0x74C450", VA = "0x18074DE50")]
		public string ToSourceCode()
		{
			return null;
		}

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x10")]
		internal readonly Queue<string> LogQueue;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x18")]
		private readonly object lockObject;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x20")]
		private readonly uint _limit;
	}
}
