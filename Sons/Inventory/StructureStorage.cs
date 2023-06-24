using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000638 RID: 1592
	[Token(Token = "0x2000638")]
	[AddComponentMenu("Sons/Inventory/StructureStorage")]
	[RequireComponent(typeof(ItemInstanceManager))]
	public class StructureStorage : MonoBehaviour
	{
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x0000C330 File Offset: 0x0000A530
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000565")]
		public int StorageSlotIndex
		{
			[Token(Token = "0x6002945")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002946")]
			[Address(RVA = "0x9048C0", Offset = "0x902EC0", VA = "0x1809048C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002947")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetBoltEntityOwner(BoltEntity entity)
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000566")]
		public ItemInstanceManager ItemInstanceManager
		{
			[Token(Token = "0x6002948")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x33EA4C0", Offset = "0x33E8AC0", VA = "0x1833EA4C0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x33EA5C0", Offset = "0x33E8BC0", VA = "0x1833EA5C0")]
		private void Awake()
		{
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294B")]
		[Address(RVA = "0x33EA7F0", Offset = "0x33E8DF0", VA = "0x1833EA7F0")]
		public ItemInstanceManager.ItemInstanceManagerSaveData GetSerializedItems()
		{
			return null;
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x33EA810", Offset = "0x33E8E10", VA = "0x1833EA810")]
		public void SetFromSerializedData(ItemInstanceManager.ItemInstanceManagerSaveData saveData)
		{
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x2FF7330", Offset = "0x2FF5930", VA = "0x182FF7330")]
		private void OnDeserializeCompletedInternal()
		{
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x33EA830", Offset = "0x33E8E30", VA = "0x1833EA830")]
		public void ClientRequestAddItems(int itemId, int count, ItemInstance itemInstance)
		{
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294F")]
		[Address(RVA = "0x33EACF0", Offset = "0x33E92F0", VA = "0x1833EACF0")]
		public void ClientRequestRemoveItems(int itemId, int count, ItemInstance itemInstance)
		{
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002950")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public StructureStorage()
		{
		}

		// Token: 0x040024E3 RID: 9443
		[Token(Token = "0x40024E3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemInstanceManager _itemInstanceManager;

		// Token: 0x040024E4 RID: 9444
		[Token(Token = "0x40024E4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BoltEntity _boltEntity;

		// Token: 0x040024E5 RID: 9445
		[Token(Token = "0x40024E5")]
		[FieldOffset(Offset = "0x30")]
		public Action OnDeserializeCompleted;

		// Token: 0x040024E6 RID: 9446
		[Token(Token = "0x40024E6")]
		[FieldOffset(Offset = "0x38")]
		public Action<int> OnStorageContentsChanged;
	}
}
