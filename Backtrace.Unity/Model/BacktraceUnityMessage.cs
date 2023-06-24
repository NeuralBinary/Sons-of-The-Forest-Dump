using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity.Model
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	internal class BacktraceUnityMessage
	{
		// Token: 0x060001CD RID: 461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x752C50", Offset = "0x751250", VA = "0x180752C50")]
		public BacktraceUnityMessage(BacktraceReport report)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x752F10", Offset = "0x751510", VA = "0x180752F10")]
		public BacktraceUnityMessage(string message, string stacktrace, LogType type)
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x7530C0", Offset = "0x7516C0", VA = "0x1807530C0")]
		private string GetFormattedMessage(bool backtraceFrame)
		{
			return null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x7535D0", Offset = "0x751BD0", VA = "0x1807535D0")]
		private string GetFormattedStackTrace(string stacktrace)
		{
			return null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x753660", Offset = "0x751C60", VA = "0x180753660")]
		public bool IsUnhandledException()
		{
			return default(bool);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _formattedMessage;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x18")]
		public readonly string Message;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x20")]
		public readonly string StackTrace;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x28")]
		public readonly LogType Type;
	}
}
