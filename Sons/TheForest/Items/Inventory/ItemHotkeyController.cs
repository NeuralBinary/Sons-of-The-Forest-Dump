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
	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	public class ItemHotkeyController : SingletonBehaviour<ItemHotkeyController>, ISaveGameSerializer<HotkeySaveData>
	{
		// Token: 0x06001ECB RID: 7883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECB")]
		[Address(RVA = "0x32F6570", Offset = "0x32F4B70", VA = "0x1832F6570")]
		private void OnEnable()
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0x32F71D0", Offset = "0x32F57D0", VA = "0x1832F71D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECD")]
		[Address(RVA = "0x32F7DB0", Offset = "0x32F63B0", VA = "0x1832F7DB0")]
		private void OnHotkey0Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x32F7DC0", Offset = "0x32F63C0", VA = "0x1832F7DC0")]
		private void OnHotkey1Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x32F7DD0", Offset = "0x32F63D0", VA = "0x1832F7DD0")]
		private void OnHotkey2Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x32F7DE0", Offset = "0x32F63E0", VA = "0x1832F7DE0")]
		private void OnHotkey3Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x32F7DF0", Offset = "0x32F63F0", VA = "0x1832F7DF0")]
		private void OnHotkey4Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x32F7E00", Offset = "0x32F6400", VA = "0x1832F7E00")]
		private void OnHotkey5Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x32F7E10", Offset = "0x32F6410", VA = "0x1832F7E10")]
		private void OnHotkey6Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0x32F7E20", Offset = "0x32F6420", VA = "0x1832F7E20")]
		private void OnHotkey7Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0x32F7E30", Offset = "0x32F6430", VA = "0x1832F7E30")]
		private void OnHotkey8Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x32F7E40", Offset = "0x32F6440", VA = "0x1832F7E40")]
		private void OnHotkey9Triggered(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x32F7E50", Offset = "0x32F6450", VA = "0x1832F7E50")]
		private void SetItemHotkeyFromInventory(int index, bool exclusive = true)
		{
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x32F8110", Offset = "0x32F6710", VA = "0x1832F8110")]
		private void ClearHotkey(int itemId)
		{
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00008CE8 File Offset: 0x00006EE8
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x32F82A0", Offset = "0x32F68A0", VA = "0x1832F82A0")]
		private int ValidateOtherHand(int itemId, int currentValue, EquipmentSlot hand)
		{
			return 0;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x32F8360", Offset = "0x32F6960", VA = "0x1832F8360")]
		private void TriggerItemHotkey(int index)
		{
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x32F8490", Offset = "0x32F6A90", VA = "0x1832F8490")]
		private void TriggerItemHotkey(int index, int itemId, bool rightHand = false, bool leftHand = false)
		{
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x32F8770", Offset = "0x32F6D70", VA = "0x1832F8770")]
		private void TriggerItemHotkeyFromInventory(int index, int itemId)
		{
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x32F87D0", Offset = "0x32F6DD0", VA = "0x1832F87D0")]
		private void DoConsumedItemHotkey(int index, int itemId)
		{
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x32F8B20", Offset = "0x32F7120", VA = "0x1832F8B20")]
		private ItemInstance GetBestItemInstance(List<ItemInstance> itemInstances)
		{
			return null;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x32F8D20", Offset = "0x32F7320", VA = "0x1832F8D20")]
		private bool IsBetterPerishable(PerishableItemInstanceModule dataA, PerishableItemInstanceModule dataB)
		{
			return default(bool);
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0x32F8DF0", Offset = "0x32F73F0", VA = "0x1832F8DF0")]
		private void RemoveConsumedItem(ItemInstance itemInstance)
		{
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00008D18 File Offset: 0x00006F18
		[Token(Token = "0x6001EE1")]
		[Address(RVA = "0x32F8E90", Offset = "0x32F7490", VA = "0x1832F8E90")]
		public static int GetHotkeyIndex(ItemInstance itemInstance)
		{
			return 0;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x6001EE2")]
		[Address(RVA = "0x32F9030", Offset = "0x32F7630", VA = "0x1832F9030")]
		private int GetHotkeyIndexInternal(ItemInstance itemInstance)
		{
			return 0;
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000444")]
		public string SerializedName
		{
			[Token(Token = "0x6001EE3")]
			[Address(RVA = "0x32F9170", Offset = "0x32F7770", VA = "0x1832F9170", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE4")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "11")]
		public HotkeySaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE5")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0", Slot = "12")]
		public void OnDeserialize(HotkeySaveData data)
		{
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x17000445")]
		public bool UniqueFile
		{
			[Token(Token = "0x6001EE6")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x17000446")]
		public bool ShouldSerialize
		{
			[Token(Token = "0x6001EE7")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x17000447")]
		public bool IncludeInPlayerSave
		{
			[Token(Token = "0x6001EE8")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE9")]
		[Address(RVA = "0x32F91A0", Offset = "0x32F77A0", VA = "0x1832F91A0")]
		public ItemHotkeyController()
		{
		}

		// Token: 0x04001CB3 RID: 7347
		[Token(Token = "0x4001CB3")]
		[FieldOffset(Offset = "0x28")]
		private HotkeySaveData _hotkeySaveData;

		// Token: 0x04001CB4 RID: 7348
		[Token(Token = "0x4001CB4")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<PerishableItemData.State, int> _perishableStateRanks;
	}
}
