using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Backtrace.Unity.Json;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.JsonData
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public class ThreadInformation
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006D")]
		public string Name
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00002A5C File Offset: 0x00000C5C
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006E")]
		public bool Fault
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x75A6C0", Offset = "0x758CC0", VA = "0x18075A6C0")]
		public BacktraceJObject ToJson()
		{
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x75A940", Offset = "0x758F40", VA = "0x18075A940")]
		public ThreadInformation(string threadName, bool fault, IEnumerable<BacktraceStackFrame> stack)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x75AAF0", Offset = "0x7590F0", VA = "0x18075AAF0")]
		public ThreadInformation(Thread thread, IEnumerable<BacktraceStackFrame> stack, bool faultingThread = false)
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x75ACD0", Offset = "0x7592D0", VA = "0x18075ACD0")]
		private ThreadInformation()
		{
		}

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x20")]
		internal IEnumerable<BacktraceStackFrame> Stack;
	}
}
