using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class BacktraceReport
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000043")]
		public string Fingerprint
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000044")]
		public string Factor
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000045")]
		public Dictionary<string, string> Attributes
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000046")]
		public string Message
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000047")]
		public Exception Exception
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000048")]
		public List<string> AttachmentPaths
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000049")]
		public List<BacktraceStackFrame> DiagnosticStack
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x74DF40", Offset = "0x74C540", VA = "0x18074DF40")]
		public BacktraceReport(string message, [Optional] Dictionary<string, string> attributes, [Optional] List<string> attachmentPaths)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x74DFD0", Offset = "0x74C5D0", VA = "0x18074DFD0")]
		public BacktraceReport(Exception exception, [Optional] Dictionary<string, string> attributes, [Optional] List<string> attachmentPaths)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x74E300", Offset = "0x74C900", VA = "0x18074E300")]
		private void SetDefaultAttributes()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x74E410", Offset = "0x74CA10", VA = "0x18074E410")]
		internal void AssignSourceCodeToReport(string text)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x74E7B0", Offset = "0x74CDB0", VA = "0x18074E7B0")]
		private void SetClassifierInfo()
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x74EBD0", Offset = "0x74D1D0", VA = "0x18074EBD0")]
		internal void SetReportFingerprint(bool generateFingerprint)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x74ED70", Offset = "0x74D370", VA = "0x18074ED70")]
		internal BacktraceData ToBacktraceData(Dictionary<string, string> clientAttributes, int gameObjectDepth)
		{
			return null;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x74EDF0", Offset = "0x74D3F0", VA = "0x18074EDF0")]
		internal void SetStacktraceInformation()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x74EEB0", Offset = "0x74D4B0", VA = "0x18074EEB0")]
		internal BacktraceReport CreateInnerReport()
		{
			return null;
		}

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		private const string ErrorTypeAttributeName = "error.type";

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Guid Uuid;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly long Timestamp;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly bool ExceptionTypeReport;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Classifier;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public BacktraceSourceCode SourceCode;
	}
}
