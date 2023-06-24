using System;
using Il2CppDummyDll;

namespace Sons.Gui.Input
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public interface IHeldInputProgressReceiver
	{
		// Token: 0x06000282 RID: 642
		[Token(Token = "0x6000282")]
		void Started();

		// Token: 0x06000283 RID: 643
		[Token(Token = "0x6000283")]
		void Stopped();

		// Token: 0x06000284 RID: 644
		[Token(Token = "0x6000284")]
		void UpdateProgress(float progress);
	}
}
