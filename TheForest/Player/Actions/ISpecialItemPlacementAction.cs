using System;
using Il2CppDummyDll;
using Sons.Crafting.Structures;

namespace TheForest.Player.Actions
{
	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x2000491")]
	public interface ISpecialItemPlacementAction
	{
		// Token: 0x06001D8D RID: 7565
		[Token(Token = "0x6001D8D")]
		void Execute(int ingredientId, int itemCount, StructureCraftingNode structure);

		// Token: 0x06001D8E RID: 7566
		[Token(Token = "0x6001D8E")]
		void Cancel();
	}
}
