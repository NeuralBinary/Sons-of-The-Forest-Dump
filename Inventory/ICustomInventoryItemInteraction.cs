using System;
using Il2CppDummyDll;

namespace Sons.Inventory
{
	// Token: 0x020005ED RID: 1517
	[Token(Token = "0x20005ED")]
	public interface ICustomInventoryItemInteraction
	{
		// Token: 0x060026D9 RID: 9945
		[Token(Token = "0x60026D9")]
		bool TryPerformAction(ItemInstance itemInstance, bool isUnique);
	}
}
