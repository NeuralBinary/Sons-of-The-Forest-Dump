using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F5 RID: 1525
	[Token(Token = "0x20005F5")]
	public class QuickSelectLayoutItem : LayoutItem
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x0000BC10 File Offset: 0x00009E10
		[Token(Token = "0x1700053E")]
		public int ItemId
		{
			[Token(Token = "0x60027B5")]
			[Address(RVA = "0xA2FB30", Offset = "0xA2E130", VA = "0x180A2FB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x1700053F")]
		public ItemData.QuickSelectSlotTypes SlotType
		{
			[Token(Token = "0x60027B6")]
			[Address(RVA = "0x671130", Offset = "0x66F730", VA = "0x180671130")]
			get
			{
				return ItemData.QuickSelectSlotTypes.Small;
			}
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0x33CD010", Offset = "0x33CB610", VA = "0x1833CD010")]
		public void Set(int itemId, ItemData.QuickSelectSlotTypes slot)
		{
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0x33CD020", Offset = "0x33CB620", VA = "0x1833CD020", Slot = "8")]
		protected override void OnMouseEnter()
		{
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B9")]
		[Address(RVA = "0x33CD090", Offset = "0x33CB690", VA = "0x1833CD090")]
		public void PlayAudio()
		{
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BA")]
		[Address(RVA = "0x33CD130", Offset = "0x33CB730", VA = "0x1833CD130", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BB")]
		[Address(RVA = "0x33CD260", Offset = "0x33CB860", VA = "0x1833CD260")]
		public QuickSelectLayoutItem()
		{
		}

		// Token: 0x04002400 RID: 9216
		[Token(Token = "0x4002400")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _itemId;

		// Token: 0x04002401 RID: 9217
		[Token(Token = "0x4002401")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private ItemData.QuickSelectSlotTypes _slotType;

		// Token: 0x04002402 RID: 9218
		[Token(Token = "0x4002402")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[EventRef]
		private string _onInteractAudioEvent;
	}
}
