using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	public interface ObiInterpolator<T>
	{
		// Token: 0x06000A23 RID: 2595
		[Token(Token = "0x6000A23")]
		T Evaluate(T v0, T v1, T v2, T v3, float mu);

		// Token: 0x06000A24 RID: 2596
		[Token(Token = "0x6000A24")]
		T EvaluateFirstDerivative(T v0, T v1, T v2, T v3, float mu);

		// Token: 0x06000A25 RID: 2597
		[Token(Token = "0x6000A25")]
		T EvaluateSecondDerivative(T v0, T v1, T v2, T v3, float mu);
	}
}
