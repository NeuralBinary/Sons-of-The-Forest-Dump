using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x0200044C RID: 1100
	[Token(Token = "0x200044C")]
	[Serializable]
	public class ItemCondition : ACondition
	{
		// Token: 0x06001C14 RID: 7188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x2CF4AF0", Offset = "0x2CF3AF0", VA = "0x182CF4AF0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x2CF4C30", Offset = "0x2CF3C30", VA = "0x182CF4C30")]
		public void OnItemAdded(object o)
		{
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C16")]
		[Address(RVA = "0x2CF4DC0", Offset = "0x2CF3DC0", VA = "0x182CF4DC0")]
		public void OnItemAdded(int itemId)
		{
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x2CF4F00", Offset = "0x2CF3F00", VA = "0x182CF4F00", Slot = "8")]
		public override void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C18")]
		[Address(RVA = "0x2CF4B60", Offset = "0x2CF3B60", VA = "0x182CF4B60", Slot = "9")]
		public override void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public ItemCondition()
		{
		}

		// Token: 0x04001AEC RID: 6892
		[Token(Token = "0x4001AEC")]
		[FieldOffset(Offset = "0x20")]
		public ItemIdList[] _items;
	}
}
