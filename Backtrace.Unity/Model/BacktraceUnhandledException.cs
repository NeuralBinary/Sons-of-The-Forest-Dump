using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity.Model
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class BacktraceUnhandledException : Exception
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x17000050")]
		public bool Header
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x7282E0", Offset = "0x7268E0", VA = "0x1807282E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000051")]
		public override string Message
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000052")]
		public string Classifier
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x750FB0", Offset = "0x74F5B0", VA = "0x180750FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000053")]
		public override string StackTrace
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000290C File Offset: 0x00000B0C
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000054")]
		public LogType Type
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x7283D0", Offset = "0x7269D0", VA = "0x1807283D0")]
			[CompilerGenerated]
			get
			{
				return LogType.Error;
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x7283E0", Offset = "0x7269E0", VA = "0x1807283E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x751020", Offset = "0x74F620", VA = "0x180751020")]
		public BacktraceUnhandledException(string message, string stacktrace)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x751480", Offset = "0x74FA80", VA = "0x180751480")]
		private string GetStackTraceErrorMessage(string beginningOfTheFrame)
		{
			return null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x751570", Offset = "0x74FB70", VA = "0x180751570")]
		private List<BacktraceStackFrame> ConvertStackFrames(IEnumerable<string> frames)
		{
			return null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x7517A0", Offset = "0x74FDA0", VA = "0x1807517A0")]
		private BacktraceStackFrame ConvertFrame(string frameString, int methodNameEndIndex)
		{
			return null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x751870", Offset = "0x74FE70", VA = "0x180751870")]
		private BacktraceStackFrame SetJITStackTraceInformation(string frameString)
		{
			return null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x751C50", Offset = "0x750250", VA = "0x180751C50")]
		private BacktraceStackFrame SetNativeStackTraceInformation(string frameString)
		{
			return null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x7521D0", Offset = "0x7507D0", VA = "0x1807521D0")]
		private BacktraceStackFrame SetAndroidStackTraceInformation(string frameString, int parameterStart, int parameterEnd)
		{
			return null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x752490", Offset = "0x750A90", VA = "0x180752490")]
		private BacktraceStackFrame SetDefaultStackTraceInformation(string frameString, int methodNameEndIndex)
		{
			return null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x752900", Offset = "0x750F00", VA = "0x180752900")]
		private void TrySetClassifier()
		{
		}

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x90")]
		private bool _header;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x0")]
		private static string[] _javaExtensions;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x98")]
		private string _message;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0xA8")]
		private readonly string _stacktrace;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0xB8")]
		public readonly List<BacktraceStackFrame> StackFrames;
	}
}
