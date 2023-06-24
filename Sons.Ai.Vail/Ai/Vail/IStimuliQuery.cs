using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	public interface IStimuliQuery
	{
		// Token: 0x06000593 RID: 1427
		[Token(Token = "0x6000593")]
		bool Evaluate(VailActor actor, out IStimuli result, float maxDistance = 0f);

		// Token: 0x06000594 RID: 1428
		[Token(Token = "0x6000594")]
		string GetName();
	}
}
