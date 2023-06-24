using System;
using Construction;
using Il2CppDummyDll;
using Sons.Inventory;

namespace Sons.Construction.Branching
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public interface ILoadItemReceiver
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000063 RID: 99
		[Token(Token = "0x17000030")]
		bool IsBusy { [Token(Token = "0x6000063")] get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000064 RID: 100
		[Token(Token = "0x17000031")]
		bool IsLoaded { [Token(Token = "0x6000064")] get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000065 RID: 101
		[Token(Token = "0x17000032")]
		ItemInstance LoadedItem { [Token(Token = "0x6000065")] get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000066 RID: 102
		[Token(Token = "0x17000033")]
		StructureElement LoadedElement { [Token(Token = "0x6000066")] get; }

		// Token: 0x06000067 RID: 103
		[Token(Token = "0x6000067")]
		bool TryLoad(ItemInstance itemInstance);

		// Token: 0x06000068 RID: 104
		[Token(Token = "0x6000068")]
		bool TryLoad(BranchingElementData elementData, ItemInstance itemInstance);

		// Token: 0x06000069 RID: 105
		[Token(Token = "0x6000069")]
		bool TryUnLoadItem(out ItemInstance itemInstance);

		// Token: 0x0600006A RID: 106
		[Token(Token = "0x600006A")]
		bool Accepts(ItemInstance itemInstance);
	}
}
