using System;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public interface IFalloffFunction
	{
		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		double FalloffT(double t);

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		IFalloffFunction Duplicate();
	}
}
