using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace TheForest.TaskSystem
{
	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	[Serializable]
	public class ItemIdList
	{
		// Token: 0x06001BFE RID: 7166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ItemIdList()
		{
		}

		// Token: 0x04001AF5 RID: 6901
		[Token(Token = "0x4001AF5")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker]
		public int[] _itemIds;

		// Token: 0x04001AF6 RID: 6902
		[Token(Token = "0x4001AF6")]
		[FieldOffset(Offset = "0x18")]
		public bool _done;
	}
}
