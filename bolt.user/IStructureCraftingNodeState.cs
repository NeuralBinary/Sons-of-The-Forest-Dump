using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000018 RID: 24
[Token(Token = "0x2000018")]
public interface IStructureCraftingNodeState : IState, IDisposable
{
	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000085 RID: 133
	// (set) Token: 0x06000086 RID: 134
	[Token(Token = "0x17000034")]
	int AddedIngredients { [Token(Token = "0x6000085")] get; [Token(Token = "0x6000086")] set; }
}
