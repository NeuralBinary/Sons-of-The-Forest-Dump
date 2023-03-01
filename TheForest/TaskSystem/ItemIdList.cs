using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace TheForest.TaskSystem
{
	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x200043A")]
	[Serializable]
	public class ItemIdList
	{
		// Token: 0x06001BC0 RID: 7104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public ItemIdList()
		{
		}

		// Token: 0x04001AD1 RID: 6865
		[Token(Token = "0x4001AD1")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker]
		public int[] _itemIds;

		// Token: 0x04001AD2 RID: 6866
		[Token(Token = "0x4001AD2")]
		[FieldOffset(Offset = "0x18")]
		public bool _done;
	}
}
