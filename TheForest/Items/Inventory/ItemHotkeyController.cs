using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using Sons.Save;
using UnityEngine.InputSystem;

namespace TheForest.Items.Inventory
{
	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	public class ItemHotkeyController : SingletonBehaviour<ItemHotkeyController>, ISaveGameSerializer<HotkeySaveData>
	{
		// Token: 0x06001E77 RID: 7799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E77")]
		[Address(RVA = "0x2D100B0", Offset = "0x2D0F0B0", VA = "0x182D100B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E78")]
		[Address(RVA = "0x2D0F920", Offset = "0x2D0E920", VA = "0x182D0F920")]
		private void OnDisable()
		{
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x2D108A0", Offset = "0x2D0F8A0", VA = "0x182D108A0")]
		private void OnHotkey0Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0x2D108B0", Offset = "0x2D0F8B0", VA = "0x182D108B0")]
		private void OnHotkey1Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x2D108C0", Offset = "0x2D0F8C0", VA = "0x182D108C0")]
		private void OnHotkey2Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0x2D108D0", Offset = "0x2D0F8D0", VA = "0x182D108D0")]
		private void OnHotkey3Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0x2D108E0", Offset = "0x2D0F8E0", VA = "0x182D108E0")]
		private void OnHotkey4Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0x2D108F0", Offset = "0x2D0F8F0", VA = "0x182D108F0")]
		private void OnHotkey5Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7F")]
		[Address(RVA = "0x2D10900", Offset = "0x2D0F900", VA = "0x182D10900")]
		private void OnHotkey6Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E80")]
		[Address(RVA = "0x2D10910", Offset = "0x2D0F910", VA = "0x182D10910")]
		private void OnHotkey7Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E81")]
		[Address(RVA = "0x2D10920", Offset = "0x2D0F920", VA = "0x182D10920")]
		private void OnHotkey8Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0x2D10930", Offset = "0x2D0F930", VA = "0x182D10930")]
		private void OnHotkey9Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E83")]
		[Address(RVA = "0x2D109E0", Offset = "0x2D0F9E0", VA = "0x182D109E0")]
		private void SetItemHotkeyFromInventory(int index, bool exclusive = true)
		{
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E84")]
		[Address(RVA = "0x2D0F020", Offset = "0x2D0E020", VA = "0x182D0F020")]
		private void ClearHotkey(int itemId)
		{
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x000089E8 File Offset: 0x00006BE8
		[Token(Token = "0x6001E85")]
		[Address(RVA = "0x2D110D0", Offset = "0x2D100D0", VA = "0x182D110D0")]
		private int ValidateOtherHand(int itemId, int currentValue, EquipmentSlot hand)
		{
			return default(int);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E86")]
		[Address(RVA = "0x2D10FB0", Offset = "0x2D0FFB0", VA = "0x182D10FB0")]
		private void TriggerItemHotkey(int index)
		{
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E87")]
		[Address(RVA = "0x2D10DF0", Offset = "0x2D0FDF0", VA = "0x182D10DF0")]
		private void TriggerItemHotkey(int index, int itemId)
		{
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E88")]
		[Address(RVA = "0x2D10D90", Offset = "0x2D0FD90", VA = "0x182D10D90")]
		private void TriggerItemHotkeyFromInventory(int index, int itemId)
		{
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E89")]
		[Address(RVA = "0x2D0F1B0", Offset = "0x2D0E1B0", VA = "0x182D0F1B0")]
		private void DoConsumedItemHotkey(int index, int itemId)
		{
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8A")]
		[Address(RVA = "0x2D0F460", Offset = "0x2D0E460", VA = "0x182D0F460")]
		private ItemInstance GetBestItemInstance(List<ItemInstance> itemInstances)
		{
			return null;
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0x2D0F850", Offset = "0x2D0E850", VA = "0x182D0F850")]
		private bool IsBetterPerishable(PerishableItemInstanceModule dataA, PerishableItemInstanceModule dataB)
		{
			return default(bool);
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8C")]
		[Address(RVA = "0x2D10940", Offset = "0x2D0F940", VA = "0x182D10940")]
		private void RemoveConsumedItem(ItemInstance itemInstance)
		{
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0x2D0F710", Offset = "0x2D0E710", VA = "0x182D0F710")]
		public static int GetHotkeyIndex(ItemInstance itemInstance)
		{
			return default(int);
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00008A30 File Offset: 0x00006C30
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x2D0F630", Offset = "0x2D0E630", VA = "0x182D0F630")]
		private int GetHotkeyIndexInternal(ItemInstance itemInstance)
		{
			return default(int);
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700043A")]
		public string SerializedName
		{
			[Token(Token = "0x6001E8F")]
			[Address(RVA = "0x2D112F0", Offset = "0x2D102F0", VA = "0x182D112F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230", Slot = "11")]
		public HotkeySaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E91")]
		[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270", Slot = "12")]
		public void OnDeserialize(HotkeySaveData data)
		{
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x00008A48 File Offset: 0x00006C48
		[Token(Token = "0x1700043B")]
		public bool UniqueFile
		{
			[Token(Token = "0x6001E92")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x00008A60 File Offset: 0x00006C60
		[Token(Token = "0x1700043C")]
		public bool ShouldSerialize
		{
			[Token(Token = "0x6001E93")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x00008A78 File Offset: 0x00006C78
		[Token(Token = "0x1700043D")]
		public bool IncludeInPlayerSave
		{
			[Token(Token = "0x6001E94")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E95")]
		[Address(RVA = "0x2D11190", Offset = "0x2D10190", VA = "0x182D11190")]
		public ItemHotkeyController()
		{
		}

		// Token: 0x04001C7D RID: 7293
		[Token(Token = "0x4001C7D")]
		[FieldOffset(Offset = "0x28")]
		private HotkeySaveData _hotkeySaveData;

		// Token: 0x04001C7E RID: 7294
		[Token(Token = "0x4001C7E")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<PerishableItemData.State, int> _perishableStateRanks;
	}
}
