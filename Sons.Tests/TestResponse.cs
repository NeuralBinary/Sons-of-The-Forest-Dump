using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sons.Tests
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public class TestResponse
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003E")]
		public string Message
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TestResponse()
		{
		}

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x18")]
		public bool Passed;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TestResponse PassedResponse;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x8")]
		public static readonly TestResponse FailedResponse;
	}
}
