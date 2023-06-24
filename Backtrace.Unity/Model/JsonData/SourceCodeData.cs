using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.JsonData
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class SourceCodeData
	{
		// Token: 0x06000235 RID: 565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x759D90", Offset = "0x758390", VA = "0x180759D90")]
		internal SourceCodeData(IEnumerable<BacktraceStackFrame> exceptionStack)
		{
		}

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, SourceCodeData.SourceCode> data;

		// Token: 0x0200004F RID: 79
		[Token(Token = "0x200004F")]
		public class SourceCode
		{
			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000236 RID: 566 RVA: 0x00002A2C File Offset: 0x00000C2C
			// (set) Token: 0x06000237 RID: 567 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000069")]
			public int StartLine
			{
				[Token(Token = "0x6000236")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000237")]
				[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000238 RID: 568 RVA: 0x00002A44 File Offset: 0x00000C44
			// (set) Token: 0x06000239 RID: 569 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700006A")]
			public int StartColumn
			{
				[Token(Token = "0x6000238")]
				[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000239")]
				[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600023A RID: 570 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600023B RID: 571 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700006B")]
			private string _sourceCodeFullPath
			{
				[Token(Token = "0x600023A")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600023B")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x0600023C RID: 572 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600023D RID: 573 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700006C")]
			public string SourceCodeFullPath
			{
				[Token(Token = "0x600023C")]
				[Address(RVA = "0x75A060", Offset = "0x758660", VA = "0x18075A060")]
				get
				{
					return null;
				}
				[Token(Token = "0x600023D")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				set
				{
				}
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x75A0E0", Offset = "0x7586E0", VA = "0x18075A0E0")]
			public static SourceCodeData.SourceCode FromExceptionStack(BacktraceStackFrame stackFrame)
			{
				return null;
			}

			// Token: 0x0600023F RID: 575 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SourceCode()
			{
			}
		}
	}
}
