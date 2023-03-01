using System;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005E5 RID: 1509
	[Token(Token = "0x20005E5")]
	public class QuickSlotHookPoint : MonoBehaviour
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x1700052B")]
		public ItemData.QuickSelectSlotTypes SlotType
		{
			[Token(Token = "0x60026B3")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return default(ItemData.QuickSelectSlotTypes);
			}
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B4")]
		[Address(RVA = "0x2DAB060", Offset = "0x2DAA060", VA = "0x182DAB060")]
		public void Clear()
		{
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x2DAB100", Offset = "0x2DAA100", VA = "0x182DAB100")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B6")]
		[Address(RVA = "0x2DAB150", Offset = "0x2DAA150", VA = "0x182DAB150")]
		public void Set(QuickSelectLayoutItem layoutItem)
		{
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B7")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public QuickSlotHookPoint()
		{
		}

		// Token: 0x04002325 RID: 8997
		[Token(Token = "0x4002325")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemData.QuickSelectSlotTypes _slotType;

		// Token: 0x04002326 RID: 8998
		[Token(Token = "0x4002326")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ItemAnchorLocalOffsetData _itemAnchorLocalOffsetData;

		// Token: 0x04002327 RID: 8999
		[Token(Token = "0x4002327")]
		[FieldOffset(Offset = "0x30")]
		private QuickSelectLayoutItem _layoutItem;
	}
}
