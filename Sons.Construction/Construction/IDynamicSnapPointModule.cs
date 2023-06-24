using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	public interface IDynamicSnapPointModule : IConstructionModule
	{
		// Token: 0x06000698 RID: 1688
		[Token(Token = "0x6000698")]
		bool TryStage(ModuleState state);
	}
}
