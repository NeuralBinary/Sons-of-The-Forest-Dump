using System;
using Construction;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace Sons.Construction.Branching
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public interface IItemSpecificBranchingAction : IBranchingAction, IInputModeProvider, IStagedMessageOverrideProvider
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000031 RID: 49
		[Token(Token = "0x1700001F")]
		ItemData ElementItemData { [Token(Token = "0x6000031")] get; }
	}
}
