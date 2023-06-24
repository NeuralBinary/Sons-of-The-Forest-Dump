using System;
using Il2CppDummyDll;

namespace Sons.Inventory
{
	// Token: 0x020005FF RID: 1535
	[Token(Token = "0x20005FF")]
	public interface ICustomInventoryItemInteraction
	{
		// Token: 0x060027E3 RID: 10211
		[Token(Token = "0x60027E3")]
		bool TryPerformAction(ItemInstance itemInstance, bool isUnique);
	}
}
