using System;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F6 RID: 1526
	[Token(Token = "0x20005F6")]
	public class QuickSlotHookPoint : MonoBehaviour
	{
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x0000BC40 File Offset: 0x00009E40
		[Token(Token = "0x17000540")]
		public ItemData.QuickSelectSlotTypes SlotType
		{
			[Token(Token = "0x60027BC")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return ItemData.QuickSelectSlotTypes.Small;
			}
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x33CD2B0", Offset = "0x33CB8B0", VA = "0x1833CD2B0")]
		public void Clear()
		{
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x0000BC58 File Offset: 0x00009E58
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0x33CD460", Offset = "0x33CBA60", VA = "0x1833CD460")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x33CD520", Offset = "0x33CBB20", VA = "0x1833CD520")]
		public void Set(QuickSelectLayoutItem layoutItem)
		{
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public QuickSlotHookPoint()
		{
		}

		// Token: 0x04002403 RID: 9219
		[Token(Token = "0x4002403")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemData.QuickSelectSlotTypes _slotType;

		// Token: 0x04002404 RID: 9220
		[Token(Token = "0x4002404")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ItemAnchorLocalOffsetData _itemAnchorLocalOffsetData;

		// Token: 0x04002405 RID: 9221
		[Token(Token = "0x4002405")]
		[FieldOffset(Offset = "0x30")]
		private QuickSelectLayoutItem _layoutItem;
	}
}
