using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	[Serializable]
	public class ItemCondition : ACondition
	{
		// Token: 0x06001C52 RID: 7250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x32C24C0", Offset = "0x32C0AC0", VA = "0x1832C24C0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C53")]
		[Address(RVA = "0x32C2530", Offset = "0x32C0B30", VA = "0x1832C2530")]
		public void OnItemAdded(object o)
		{
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C54")]
		[Address(RVA = "0x32C26C0", Offset = "0x32C0CC0", VA = "0x1832C26C0")]
		public void OnItemAdded(int itemId)
		{
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C55")]
		[Address(RVA = "0x32C2800", Offset = "0x32C0E00", VA = "0x1832C2800", Slot = "8")]
		public override void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C56")]
		[Address(RVA = "0x32C28D0", Offset = "0x32C0ED0", VA = "0x1832C28D0", Slot = "9")]
		public override void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C57")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public ItemCondition()
		{
		}

		// Token: 0x04001B10 RID: 6928
		[Token(Token = "0x4001B10")]
		[FieldOffset(Offset = "0x20")]
		public ItemIdList[] _items;
	}
}
