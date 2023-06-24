using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x0200043F RID: 1087
	[Token(Token = "0x200043F")]
	[Serializable]
	public class ItemIdList : ACondition
	{
		// Token: 0x06001C58 RID: 7256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C58")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public ItemIdList()
		{
		}

		// Token: 0x04001B11 RID: 6929
		[Token(Token = "0x4001B11")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker]
		public int[] _itemIds;
	}
}
