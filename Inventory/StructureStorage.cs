using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000622 RID: 1570
	[Token(Token = "0x2000622")]
	[RequireComponent(typeof(ItemInstanceManager))]
	[AddComponentMenu("Sons/Inventory/StructureStorage")]
	public class StructureStorage : MonoBehaviour
	{
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x0000BB80 File Offset: 0x00009D80
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054D")]
		public int StorageSlotIndex
		{
			[Token(Token = "0x600281D")]
			[Address(RVA = "0x5F1A10", Offset = "0x5F0A10", VA = "0x1805F1A10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600281E")]
			[Address(RVA = "0x7E13C0", Offset = "0x7E03C0", VA = "0x1807E13C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281F")]
		[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
		public void SetBoltEntityOwner(BoltEntity entity)
		{
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054E")]
		public ItemInstanceManager ItemInstanceManager
		{
			[Token(Token = "0x6002820")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x2DC4830", Offset = "0x2DC3830", VA = "0x182DC4830")]
		private void OnValidate()
		{
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002822")]
		[Address(RVA = "0x2DC4450", Offset = "0x2DC3450", VA = "0x182DC4450")]
		private void Awake()
		{
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x2DC4810", Offset = "0x2DC3810", VA = "0x182DC4810")]
		public ItemInstanceManager.ItemInstanceManagerSaveData GetSerializedItems()
		{
			return null;
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x2DC48C0", Offset = "0x2DC38C0", VA = "0x182DC48C0")]
		public void SetFromSerializedData(ItemInstanceManager.ItemInstanceManagerSaveData saveData)
		{
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x2A0D0C0", Offset = "0x2A0C0C0", VA = "0x182A0D0C0")]
		private void OnDeserializeCompletedInternal()
		{
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x2DC45B0", Offset = "0x2DC35B0", VA = "0x182DC45B0")]
		public void ClientRequestAddItems(int itemId, int count, ItemInstance itemInstance)
		{
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x2DC46E0", Offset = "0x2DC36E0", VA = "0x182DC46E0")]
		public void ClientRequestRemoveItems(int itemId, int count, ItemInstance itemInstance)
		{
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public StructureStorage()
		{
		}

		// Token: 0x040023ED RID: 9197
		[Token(Token = "0x40023ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemInstanceManager _itemInstanceManager;

		// Token: 0x040023EE RID: 9198
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BoltEntity _boltEntity;

		// Token: 0x040023EF RID: 9199
		[Token(Token = "0x40023EF")]
		[FieldOffset(Offset = "0x30")]
		public Action OnDeserializeCompleted;

		// Token: 0x040023F0 RID: 9200
		[Token(Token = "0x40023F0")]
		[FieldOffset(Offset = "0x38")]
		public Action<int> OnStorageContentsChanged;
	}
}
