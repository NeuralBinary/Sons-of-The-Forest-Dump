using System;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class WyvillFalloff : IFalloffFunction
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1DF2BC0", Offset = "0x1DF11C0", VA = "0x181DF2BC0", Slot = "4")]
		public double FalloffT(double t)
		{
			return 0.0;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1DF2D80", Offset = "0x1DF1380", VA = "0x181DF2D80", Slot = "5")]
		public IFalloffFunction Duplicate()
		{
			return null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public WyvillFalloff()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		public double ConstantRange;
	}
}
