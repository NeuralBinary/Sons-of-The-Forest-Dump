using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x0200061B RID: 1563
	[Token(Token = "0x200061B")]
	[AddComponentMenu("Sons/Inventory/ItemInstanceManager")]
	public class ItemInstanceManager : MonoBehaviour
	{
		// Token: 0x06002898 RID: 10392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002898")]
		[Address(RVA = "0x33E0EA0", Offset = "0x33DF4A0", VA = "0x1833E0EA0")]
		public void WriteContentsToLog()
		{
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002899")]
		[Address(RVA = "0x33E1140", Offset = "0x33DF740", VA = "0x1833E1140")]
		public void SetItemMaxCount(int itemId, int maxCount)
		{
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x600289A")]
		[Address(RVA = "0x33E1320", Offset = "0x33DF920", VA = "0x1833E1320")]
		public bool TryAddItems(int itemId, int count, bool suppressCallback = false)
		{
			return default(bool);
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x600289B")]
		[Address(RVA = "0x33E1540", Offset = "0x33DFB40", VA = "0x1833E1540")]
		public bool TryAddItem(int itemId)
		{
			return default(bool);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x600289C")]
		[Address(RVA = "0x33E1560", Offset = "0x33DFB60", VA = "0x1833E1560")]
		public bool TryAddItem(ItemInstance item, bool suppressCallback = false)
		{
			return default(bool);
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[Token(Token = "0x600289D")]
		[Address(RVA = "0x33E1920", Offset = "0x33DFF20", VA = "0x1833E1920")]
		public int RemoveItems(int itemId, int count, bool suppressCallback = false)
		{
			return 0;
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[Token(Token = "0x600289E")]
		[Address(RVA = "0x33E1A70", Offset = "0x33E0070", VA = "0x1833E1A70")]
		public bool TryRemoveItem(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289F")]
		[Address(RVA = "0x33E1C30", Offset = "0x33E0230", VA = "0x1833E1C30")]
		public void RemoveAll()
		{
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A0")]
		[Address(RVA = "0x33E1E10", Offset = "0x33E0410", VA = "0x1833E1E10")]
		public void RemoveAll(int itemId, bool suppressCallback = false)
		{
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x0000C000 File Offset: 0x0000A200
		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x33E1F10", Offset = "0x33E0510", VA = "0x1833E1F10")]
		public int GetItemCount(int itemId)
		{
			return 0;
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public IReadOnlyDictionary<int, ItemInstanceManager.Items> GetAllItems()
		{
			return null;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x0000C018 File Offset: 0x0000A218
		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x33E1FC0", Offset = "0x33E05C0", VA = "0x1833E1FC0")]
		public bool HaveAny(int itemId)
		{
			return default(bool);
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x0000C030 File Offset: 0x0000A230
		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x33E1FE0", Offset = "0x33E05E0", VA = "0x1833E1FE0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x33E21F0", Offset = "0x33E07F0", VA = "0x1833E21F0")]
		public ItemInstance GetSingleInstance(int itemId)
		{
			return null;
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x33E2350", Offset = "0x33E0950", VA = "0x1833E2350")]
		public List<ItemInstance> GetAllItemsOfType(int itemId)
		{
			return null;
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x33E2520", Offset = "0x33E0B20", VA = "0x1833E2520")]
		public ItemInstanceManager.ItemInstanceManagerSaveData GetSerializedItems()
		{
			return null;
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x33E2920", Offset = "0x33E0F20", VA = "0x1833E2920")]
		public void DeserializeItemsFromExternalData(ItemInstanceManager.ItemInstanceManagerSaveData saveData)
		{
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x33E3230", Offset = "0x33E1830", VA = "0x1833E3230")]
		public ItemInstanceManager()
		{
		}

		// Token: 0x04002488 RID: 9352
		[Token(Token = "0x4002488")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, ItemInstanceManager.Items> _itemsMap;

		// Token: 0x04002489 RID: 9353
		[Token(Token = "0x4002489")]
		[FieldOffset(Offset = "0x28")]
		public Action<int, int> ItemsAddedEvent;

		// Token: 0x0400248A RID: 9354
		[Token(Token = "0x400248A")]
		[FieldOffset(Offset = "0x30")]
		public Action<int, int> ItemsRemovedEvent;

		// Token: 0x0400248B RID: 9355
		[Token(Token = "0x400248B")]
		[FieldOffset(Offset = "0x38")]
		public Action OnDeserializeCompleted;

		// Token: 0x0200061C RID: 1564
		[Token(Token = "0x200061C")]
		[Serializable]
		public class Items
		{
			// Token: 0x060028AA RID: 10410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60028AA")]
			[Address(RVA = "0x168A190", Offset = "0x1688790", VA = "0x18168A190")]
			public Items()
			{
			}

			// Token: 0x0400248C RID: 9356
			[Token(Token = "0x400248C")]
			[FieldOffset(Offset = "0x10")]
			public int Count;

			// Token: 0x0400248D RID: 9357
			[Token(Token = "0x400248D")]
			[FieldOffset(Offset = "0x14")]
			public int MaxCount;

			// Token: 0x0400248E RID: 9358
			[Token(Token = "0x400248E")]
			[FieldOffset(Offset = "0x18")]
			public List<ItemInstance> UniqueInstances;
		}

		// Token: 0x0200061D RID: 1565
		[Token(Token = "0x200061D")]
		[Serializable]
		public class ItemInstanceManagerSaveData
		{
			// Token: 0x060028AB RID: 10411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60028AB")]
			[Address(RVA = "0x33E3310", Offset = "0x33E1910", VA = "0x1833E3310")]
			public ItemInstanceManagerSaveData()
			{
			}

			// Token: 0x0400248F RID: 9359
			[Token(Token = "0x400248F")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04002490 RID: 9360
			[Token(Token = "0x4002490")]
			[FieldOffset(Offset = "0x18")]
			public List<ItemInstanceManager.ItemInstanceManagerSaveData.ItemBlock> ItemBlocks;

			// Token: 0x0200061E RID: 1566
			[Token(Token = "0x200061E")]
			[Serializable]
			public class ItemBlock
			{
				// Token: 0x060028AC RID: 10412 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60028AC")]
				[Address(RVA = "0x33E3440", Offset = "0x33E1A40", VA = "0x1833E3440")]
				public ItemBlock()
				{
				}

				// Token: 0x04002491 RID: 9361
				[Token(Token = "0x4002491")]
				[FieldOffset(Offset = "0x10")]
				public int ItemId;

				// Token: 0x04002492 RID: 9362
				[Token(Token = "0x4002492")]
				[FieldOffset(Offset = "0x14")]
				public int TotalCount;

				// Token: 0x04002493 RID: 9363
				[Token(Token = "0x4002493")]
				[FieldOffset(Offset = "0x18")]
				public List<ItemInstanceManager.ItemInstanceManagerSaveData.UniqueItem> UniqueItems;
			}

			// Token: 0x0200061F RID: 1567
			[Token(Token = "0x200061F")]
			[Serializable]
			public class UniqueItem
			{
				// Token: 0x060028AD RID: 10413 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60028AD")]
				[Address(RVA = "0x33E34F0", Offset = "0x33E1AF0", VA = "0x1833E34F0")]
				public UniqueItem()
				{
				}

				// Token: 0x04002494 RID: 9364
				[Token(Token = "0x4002494")]
				[FieldOffset(Offset = "0x10")]
				public List<ItemInstanceModule.SaveData> Modules;
			}
		}
	}
}
