using System;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class LinearFalloff : IFalloffFunction
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1DF2AD0", Offset = "0x1DF10D0", VA = "0x181DF2AD0", Slot = "4")]
		public double FalloffT(double t)
		{
			return 0.0;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1DF2B70", Offset = "0x1DF1170", VA = "0x181DF2B70", Slot = "5")]
		public IFalloffFunction Duplicate()
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LinearFalloff()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		public double ConstantRange;
	}
}
