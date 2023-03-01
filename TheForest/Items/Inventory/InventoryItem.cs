using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace TheForest.Items.Inventory
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	[Serializable]
	public class InventoryItem
	{
		// Token: 0x06001E70 RID: 7792 RVA: 0x00008970 File Offset: 0x00006B70
		[Token(Token = "0x6001E70")]
		[Address(RVA = "0x2D0EFA0", Offset = "0x2D0DFA0", VA = "0x182D0EFA0")]
		public int Add(int amount)
		{
			return default(int);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00008988 File Offset: 0x00006B88
		[Token(Token = "0x6001E71")]
		[Address(RVA = "0x2D0EFD0", Offset = "0x2D0DFD0", VA = "0x182D0EFD0")]
		public int RemoveOverflow(int amount)
		{
			return default(int);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x6001E72")]
		[Address(RVA = "0x2D0EFF0", Offset = "0x2D0DFF0", VA = "0x182D0EFF0")]
		public bool Remove(int amount)
		{
			return default(bool);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E73")]
		[Address(RVA = "0x5D9550", Offset = "0x5D8550", VA = "0x1805D9550")]
		public void SetAmount(int amount)
		{
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x000089B8 File Offset: 0x00006BB8
		[Token(Token = "0x17000438")]
		public int Amount
		{
			[Token(Token = "0x6001E74")]
			[Address(RVA = "0x5D9490", Offset = "0x5D8490", VA = "0x1805D9490")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x000089D0 File Offset: 0x00006BD0
		[Token(Token = "0x17000439")]
		public int MaxAmount
		{
			[Token(Token = "0x6001E75")]
			[Address(RVA = "0x2D0F000", Offset = "0x2D0E000", VA = "0x182D0F000")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E76")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public InventoryItem()
		{
		}

		// Token: 0x04001C79 RID: 7289
		[Token(Token = "0x4001C79")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker(true)]
		public int _itemId;

		// Token: 0x04001C7A RID: 7290
		[Token(Token = "0x4001C7A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _amount;

		// Token: 0x04001C7B RID: 7291
		[Token(Token = "0x4001C7B")]
		[FieldOffset(Offset = "0x18")]
		public int _maxAmount;

		// Token: 0x04001C7C RID: 7292
		[Token(Token = "0x4001C7C")]
		[FieldOffset(Offset = "0x1C")]
		public int _maxAmountBonus;
	}
}
