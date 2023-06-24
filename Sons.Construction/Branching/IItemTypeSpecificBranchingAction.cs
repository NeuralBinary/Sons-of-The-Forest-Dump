using System;
using Construction;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace Sons.Construction.Branching
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public interface IItemTypeSpecificBranchingAction : IBranchingAction, IInputModeProvider, IStagedMessageOverrideProvider
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000032 RID: 50
		[Token(Token = "0x17000020")]
		Types ItemType { [Token(Token = "0x6000032")] get; }
	}
}
