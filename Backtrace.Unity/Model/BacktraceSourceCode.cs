using System;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Json;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class BacktraceSourceCode
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004D")]
		public string Text
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x74F5E0", Offset = "0x74DBE0", VA = "0x18074F5E0")]
		internal BacktraceJObject ToJson()
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x74F880", Offset = "0x74DE80", VA = "0x18074F880")]
		public BacktraceSourceCode()
		{
		}

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x0")]
		internal static string SOURCE_CODE_PROPERTY;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x10")]
		public readonly string Type;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x18")]
		public readonly string Title;
	}
}
