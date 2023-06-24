using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace TheForest.Items.Inventory
{
	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	[Serializable]
	public class InventoryItem
	{
		// Token: 0x06001EC4 RID: 7876 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x32F6500", Offset = "0x32F4B00", VA = "0x1832F6500")]
		public int Add(int amount)
		{
			return 0;
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0x32F6530", Offset = "0x32F4B30", VA = "0x1832F6530")]
		public int RemoveOverflow(int amount)
		{
			return 0;
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0x32F6550", Offset = "0x32F4B50", VA = "0x1832F6550")]
		public bool Remove(int amount)
		{
			return default(bool);
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
		public void SetAmount(int amount)
		{
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x17000442")]
		public int Amount
		{
			[Token(Token = "0x6001EC8")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x17000443")]
		public int MaxAmount
		{
			[Token(Token = "0x6001EC9")]
			[Address(RVA = "0x32F6560", Offset = "0x32F4B60", VA = "0x1832F6560")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public InventoryItem()
		{
		}

		// Token: 0x04001CAF RID: 7343
		[Token(Token = "0x4001CAF")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker(true)]
		public int _itemId;

		// Token: 0x04001CB0 RID: 7344
		[Token(Token = "0x4001CB0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _amount;

		// Token: 0x04001CB1 RID: 7345
		[Token(Token = "0x4001CB1")]
		[FieldOffset(Offset = "0x18")]
		public int _maxAmount;

		// Token: 0x04001CB2 RID: 7346
		[Token(Token = "0x4001CB2")]
		[FieldOffset(Offset = "0x1C")]
		public int _maxAmountBonus;
	}
}
