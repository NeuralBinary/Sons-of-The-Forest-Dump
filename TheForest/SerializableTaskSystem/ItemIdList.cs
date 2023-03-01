using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x0200044D RID: 1101
	[Token(Token = "0x200044D")]
	[Serializable]
	public class ItemIdList : ACondition
	{
		// Token: 0x06001C1A RID: 7194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public ItemIdList()
		{
		}

		// Token: 0x04001AED RID: 6893
		[Token(Token = "0x4001AED")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker]
		public int[] _itemIds;
	}
}
