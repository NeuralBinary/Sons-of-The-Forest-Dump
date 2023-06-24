using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public interface IVailActorInteract
	{
		// Token: 0x06000692 RID: 1682
		[Token(Token = "0x6000692")]
		void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback);

		// Token: 0x06000693 RID: 1683
		[Token(Token = "0x6000693")]
		void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback);

		// Token: 0x06000694 RID: 1684
		[Token(Token = "0x6000694")]
		void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback);
	}
}
