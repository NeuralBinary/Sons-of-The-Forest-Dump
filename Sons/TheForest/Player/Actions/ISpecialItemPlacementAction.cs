using System;
using Il2CppDummyDll;
using Sons.Crafting.Structures;

namespace TheForest.Player.Actions
{
	// Token: 0x02000483 RID: 1155
	[Token(Token = "0x2000483")]
	public interface ISpecialItemPlacementAction
	{
		// Token: 0x06001DD1 RID: 7633
		[Token(Token = "0x6001DD1")]
		void Execute(int ingredientId, int itemCount, StructureCraftingNode structure);

		// Token: 0x06001DD2 RID: 7634
		[Token(Token = "0x6001DD2")]
		void Cancel();
	}
}
