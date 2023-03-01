using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000608 RID: 1544
	[Token(Token = "0x2000608")]
	[AddComponentMenu("Sons/Inventory/ItemInstanceManager")]
	public class ItemInstanceManager : MonoBehaviour
	{
		// Token: 0x06002781 RID: 10113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002781")]
		[Address(RVA = "0x2DBDF90", Offset = "0x2DBCF90", VA = "0x182DBDF90")]
		public void WriteContentsToLog()
		{
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x2DBDC00", Offset = "0x2DBCC00", VA = "0x182DBDC00")]
		public bool TryAddItems(int itemId, int count, bool suppressCallback = false)
		{
			return default(bool);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x2DBD8E0", Offset = "0x2DBC8E0", VA = "0x182DBD8E0")]
		public bool TryAddItem(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x2DBD900", Offset = "0x2DBC900", VA = "0x182DBD900")]
		public bool TryAddItem(ItemInstance item, bool suppressCallback = false)
		{
			return default(bool);
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x2DBD780", Offset = "0x2DBC780", VA = "0x182DBD780")]
		public int RemoveItems(int itemId, int count, bool suppressCallback = false)
		{
			return default(int);
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x2DBDE10", Offset = "0x2DBCE10", VA = "0x182DBDE10")]
		public bool TryRemoveItem(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x2DBD530", Offset = "0x2DBC530", VA = "0x182DBD530")]
		public void RemoveAll()
		{
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x2DBD680", Offset = "0x2DBC680", VA = "0x182DBD680")]
		public void RemoveAll(int itemId, bool suppressCallback = false)
		{
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x2DBCF10", Offset = "0x2DBBF10", VA = "0x182DBCF10")]
		public int GetItemCount(int itemId)
		{
			return default(int);
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
		public IReadOnlyDictionary<int, ItemInstanceManager.Items> GetAllItems()
		{
			return null;
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x600278B")]
		[Address(RVA = "0x2DBD510", Offset = "0x2DBC510", VA = "0x182DBD510")]
		public bool HaveAny(int itemId)
		{
			return default(bool);
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278C")]
		[Address(RVA = "0x2DBD400", Offset = "0x2DBC400", VA = "0x182DBD400")]
		public ItemInstance GetSingleInstance(int itemId)
		{
			return null;
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278D")]
		[Address(RVA = "0x2DBCD20", Offset = "0x2DBBD20", VA = "0x182DBCD20")]
		public List<ItemInstance> GetAllItemsOfType(int itemId)
		{
			return null;
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278E")]
		[Address(RVA = "0x2DBCFA0", Offset = "0x2DBBFA0", VA = "0x182DBCFA0")]
		public ItemInstanceManager.ItemInstanceManagerSaveData GetSerializedItems()
		{
			return null;
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278F")]
		[Address(RVA = "0x2DBC4D0", Offset = "0x2DBB4D0", VA = "0x182DBC4D0")]
		public void DeserializeItemsFromExternalData(ItemInstanceManager.ItemInstanceManagerSaveData saveData)
		{
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002790")]
		[Address(RVA = "0x2DBE1F0", Offset = "0x2DBD1F0", VA = "0x182DBE1F0")]
		public ItemInstanceManager()
		{
		}

		// Token: 0x04002399 RID: 9113
		[Token(Token = "0x4002399")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, ItemInstanceManager.Items> _itemsMap;

		// Token: 0x0400239A RID: 9114
		[Token(Token = "0x400239A")]
		[FieldOffset(Offset = "0x28")]
		public Action<int, int> ItemsAddedEvent;

		// Token: 0x0400239B RID: 9115
		[Token(Token = "0x400239B")]
		[FieldOffset(Offset = "0x30")]
		public Action<int, int> ItemsRemovedEvent;

		// Token: 0x0400239C RID: 9116
		[Token(Token = "0x400239C")]
		[FieldOffset(Offset = "0x38")]
		public Action OnDeserializeCompleted;

		// Token: 0x02000609 RID: 1545
		[Token(Token = "0x2000609")]
		[Serializable]
		public class Items
		{
			// Token: 0x06002791 RID: 10129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002791")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public Items()
			{
			}

			// Token: 0x0400239D RID: 9117
			[Token(Token = "0x400239D")]
			[FieldOffset(Offset = "0x10")]
			public int Count;

			// Token: 0x0400239E RID: 9118
			[Token(Token = "0x400239E")]
			[FieldOffset(Offset = "0x18")]
			public List<ItemInstance> UniqueInstances;
		}

		// Token: 0x0200060A RID: 1546
		[Token(Token = "0x200060A")]
		[Serializable]
		public class ItemInstanceManagerSaveData
		{
			// Token: 0x06002792 RID: 10130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002792")]
			[Address(RVA = "0x2DBC430", Offset = "0x2DBB430", VA = "0x182DBC430")]
			public ItemInstanceManagerSaveData()
			{
			}

			// Token: 0x0400239F RID: 9119
			[Token(Token = "0x400239F")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x040023A0 RID: 9120
			[Token(Token = "0x40023A0")]
			[FieldOffset(Offset = "0x18")]
			public List<ItemInstanceManager.ItemInstanceManagerSaveData.ItemBlock> ItemBlocks;

			// Token: 0x0200060B RID: 1547
			[Token(Token = "0x200060B")]
			[Serializable]
			public class ItemBlock
			{
				// Token: 0x06002793 RID: 10131 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002793")]
				[Address(RVA = "0x2DBB2B0", Offset = "0x2DBA2B0", VA = "0x182DBB2B0")]
				public ItemBlock()
				{
				}

				// Token: 0x040023A1 RID: 9121
				[Token(Token = "0x40023A1")]
				[FieldOffset(Offset = "0x10")]
				public int ItemId;

				// Token: 0x040023A2 RID: 9122
				[Token(Token = "0x40023A2")]
				[FieldOffset(Offset = "0x14")]
				public int TotalCount;

				// Token: 0x040023A3 RID: 9123
				[Token(Token = "0x40023A3")]
				[FieldOffset(Offset = "0x18")]
				public List<ItemInstanceManager.ItemInstanceManagerSaveData.UniqueItem> UniqueItems;
			}

			// Token: 0x0200060C RID: 1548
			[Token(Token = "0x200060C")]
			[Serializable]
			public class UniqueItem
			{
				// Token: 0x06002794 RID: 10132 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002794")]
				[Address(RVA = "0x2DC4E00", Offset = "0x2DC3E00", VA = "0x182DC4E00")]
				public UniqueItem()
				{
				}

				// Token: 0x040023A4 RID: 9124
				[Token(Token = "0x40023A4")]
				[FieldOffset(Offset = "0x10")]
				public List<ItemInstanceModule.SaveData> Modules;
			}
		}
	}
}
