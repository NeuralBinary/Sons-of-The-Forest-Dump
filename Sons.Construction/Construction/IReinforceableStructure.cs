using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	public interface IReinforceableStructure : IStructure, IMonoBehaviour, ISuperStructureNode, ITargetablePlacement
	{
		// Token: 0x0600070E RID: 1806
		[Token(Token = "0x600070E")]
		PresetElementsTemplate GetReinforcementTemplate();
	}
}
