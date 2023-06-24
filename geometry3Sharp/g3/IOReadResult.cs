using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	public struct IOReadResult
	{
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000082DC File Offset: 0x000064DC
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FA")]
		public IOCode code
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
			[CompilerGenerated]
			readonly get
			{
				return IOCode.Ok;
			}
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FB")]
		public string message
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xAB0970", Offset = "0xAAEF70", VA = "0x180AB0970")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x200AED0", Offset = "0x20094D0", VA = "0x18200AED0")]
		public IOReadResult(IOCode r, string s)
		{
		}

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IOReadResult Ok;
	}
}
