using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	public struct IOWriteResult
	{
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x000082F4 File Offset: 0x000064F4
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FC")]
		public IOCode code
		{
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
			[CompilerGenerated]
			readonly get
			{
				return IOCode.Ok;
			}
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FD")]
		public string message
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0xAB0970", Offset = "0xAAEF70", VA = "0x180AB0970")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x200B0E0", Offset = "0x20096E0", VA = "0x18200B0E0")]
		public IOWriteResult(IOCode r, string s)
		{
		}

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IOWriteResult Ok;
	}
}
