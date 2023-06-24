using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public interface IStimuliSortAction
	{
		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000596 RID: 1430
		[Token(Token = "0x2000086")]
		public delegate float SortValueDelegate(VailActor actor, MonoBehaviourStimuli a);
	}
}
