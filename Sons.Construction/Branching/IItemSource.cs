using System;
using Il2CppDummyDll;
using Sons.Inventory;

namespace Sons.Construction.Branching
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public interface IItemSource
	{
		// Token: 0x06000060 RID: 96
		[Token(Token = "0x6000060")]
		ItemInstance GetCurrentItem();

		// Token: 0x06000061 RID: 97
		[Token(Token = "0x6000061")]
		bool TryRemove(ItemInstance item);

		// Token: 0x06000062 RID: 98
		[Token(Token = "0x6000062")]
		bool TryEquip(ItemInstance item);
	}
}
