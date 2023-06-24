using System;
using Il2CppDummyDll;

namespace Sons.Environment
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public interface IEnvironmentWetnessAndRainReceiver
	{
		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		void UpdateWetnessAndRain(float wetnessCurrent, float rainFactor);
	}
}
