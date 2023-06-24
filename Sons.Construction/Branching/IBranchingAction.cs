using System;
using Construction;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.Branching
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public interface IBranchingAction : IInputModeProvider, IStagedMessageOverrideProvider
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000057 RID: 87
		[Token(Token = "0x1700002B")]
		string DisplayName { [Token(Token = "0x6000057")] get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000058 RID: 88
		[Token(Token = "0x1700002C")]
		BranchingActionPreviewTypes PreviewType { [Token(Token = "0x6000058")] get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000059 RID: 89
		[Token(Token = "0x1700002D")]
		Vector3 RelativePos { [Token(Token = "0x6000059")] get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600005A RID: 90
		[Token(Token = "0x1700002E")]
		Vector3 RelativeLookAxis { [Token(Token = "0x600005A")] get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600005B RID: 91
		[Token(Token = "0x1700002F")]
		Vector3 PreviewSize { [Token(Token = "0x600005B")] get; }

		// Token: 0x0600005C RID: 92
		[Token(Token = "0x600005C")]
		Vector3 GetWorldPosFor(StructureElement element);

		// Token: 0x0600005D RID: 93
		[Token(Token = "0x600005D")]
		bool TryExecute(IItemSource itemSource, ILoadItemReceiver itemLoader);

		// Token: 0x0600005E RID: 94
		[Token(Token = "0x600005E")]
		bool TryExecute(IItemSource itemSource, StructureElement element);

		// Token: 0x0600005F RID: 95
		[Token(Token = "0x600005F")]
		bool CheckIsValid(IItemSource itemSource, StructureElement element);
	}
}
