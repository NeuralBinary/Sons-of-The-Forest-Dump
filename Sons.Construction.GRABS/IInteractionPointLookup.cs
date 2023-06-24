using System;
using Il2CppDummyDll;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public interface IInteractionPointLookup
	{
		// Token: 0x06000170 RID: 368
		[Token(Token = "0x6000170")]
		bool TryGetTargetInteractionPoint(out InteractionPoint targetIp);
	}
}
