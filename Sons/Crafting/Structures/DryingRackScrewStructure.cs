using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.Inventory;
using Sons.Gameplay;
using Sons.Gameplay.GrabBag;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006F5 RID: 1781
	[Token(Token = "0x20006F5")]
	[AddComponentMenu("Sons/Gameplay/DryingRackScrewStructure")]
	public class DryingRackScrewStructure : ScrewStructure, IGrabBagInteractionReceiver, IVailDropTarget
	{
		// Token: 0x06002F15 RID: 12053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F15")]
		[Address(RVA = "0x34581D0", Offset = "0x34567D0", VA = "0x1834581D0", Slot = "32")]
		public List<GrabBagCategory> GetValidGrabBagCategories()
		{
			return null;
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F16")]
		[Address(RVA = "0x34582A0", Offset = "0x34568A0", VA = "0x1834582A0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F17")]
		[Address(RVA = "0x34583A0", Offset = "0x34569A0", VA = "0x1834583A0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x0000E058 File Offset: 0x0000C258
		[Token(Token = "0x6002F18")]
		[Address(RVA = "0x34585C0", Offset = "0x3456BC0", VA = "0x1834585C0", Slot = "31")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F19")]
		[Address(RVA = "0x34585F0", Offset = "0x3456BF0", VA = "0x1834585F0", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F1A")]
		[Address(RVA = "0x3458A40", Offset = "0x3457040", VA = "0x183458A40")]
		private void OnHookPointUsed(ItemHookPoint hookPoint)
		{
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F1B")]
		[Address(RVA = "0x3458C60", Offset = "0x3457260", VA = "0x183458C60")]
		private void OnHookPointCleared(ItemHookPoint hookPoint)
		{
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F1C")]
		[Address(RVA = "0x3459180", Offset = "0x3457780", VA = "0x183459180")]
		private void OnStorageDeserialized()
		{
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F1D")]
		[Address(RVA = "0x3459560", Offset = "0x3457B60", VA = "0x183459560")]
		public void InteractWithDryingRack()
		{
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0x3459740", Offset = "0x3457D40", VA = "0x183459740")]
		private void OnItemUnequipped(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x0000E070 File Offset: 0x0000C270
		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0x3459A70", Offset = "0x3458070", VA = "0x183459A70")]
		public bool HasAvailableHooks()
		{
			return default(bool);
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x0000E088 File Offset: 0x0000C288
		[Token(Token = "0x6002F20")]
		[Address(RVA = "0x3459BD0", Offset = "0x34581D0", VA = "0x183459BD0")]
		public bool TryGetAvailableHook(out DryingRackHookPoint hook, out int index)
		{
			return default(bool);
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		[Token(Token = "0x6002F21")]
		[Address(RVA = "0x3459DA0", Offset = "0x34583A0", VA = "0x183459DA0")]
		private bool TryAddItemToHook(ItemInstance itemInstance, int hookIndex)
		{
			return default(bool);
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Token(Token = "0x6002F22")]
		[Address(RVA = "0x3459E90", Offset = "0x3458490", VA = "0x183459E90", Slot = "30")]
		public bool TryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F23")]
		[Address(RVA = "0x345A050", Offset = "0x3458650", VA = "0x18345A050")]
		private void SpawnPickupAndAddToHook(ItemInstance itemInstance, ItemHookPoint hook)
		{
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x345A820", Offset = "0x3458E20", VA = "0x18345A820", Slot = "27")]
		public void OpenInteractionReceiver(GrabBagController grabBagController)
		{
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F25")]
		[Address(RVA = "0x345A970", Offset = "0x3458F70", VA = "0x18345A970", Slot = "28")]
		public void UpdateInteractionReceiver()
		{
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x345A990", Offset = "0x3458F90", VA = "0x18345A990", Slot = "29")]
		public void CloseInteractionReceiver()
		{
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x345A9B0", Offset = "0x3458FB0", VA = "0x18345A9B0", Slot = "25")]
		public override void ModifyItemCountFromClientRequest(ItemInstance itemInstance, int count, int storageIndex, BoltConnection sender)
		{
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F28")]
		[Address(RVA = "0x345ACD0", Offset = "0x34592D0", VA = "0x18345ACD0", Slot = "26")]
		protected override void OnSlotAvailabilityChangedMP()
		{
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[Token(Token = "0x6002F29")]
		[Address(RVA = "0x345AE60", Offset = "0x3459460", VA = "0x18345AE60", Slot = "34")]
		private int TryAddItem(int itemId, int itemCount)
		{
			return 0;
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		[Token(Token = "0x6002F2A")]
		[Address(RVA = "0x345AFA0", Offset = "0x34595A0", VA = "0x18345AFA0", Slot = "35")]
		private bool IsFull()
		{
			return default(bool);
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x0000E100 File Offset: 0x0000C300
		[Token(Token = "0x6002F2B")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
		private bool IsHolder()
		{
			return default(bool);
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2C")]
		[Address(RVA = "0x345AFC0", Offset = "0x34595C0", VA = "0x18345AFC0", Slot = "33")]
		private string GetItemType()
		{
			return null;
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F2D")]
		[Address(RVA = "0x345B030", Offset = "0x3459630", VA = "0x18345B030")]
		public DryingRackScrewStructure()
		{
		}

		// Token: 0x040028E0 RID: 10464
		[Token(Token = "0x40028E0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<DryingRackHookPoint> _hookPoints;

		// Token: 0x040028E1 RID: 10465
		[Token(Token = "0x40028E1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private StructureStorage _storage;

		// Token: 0x040028E2 RID: 10466
		[Token(Token = "0x40028E2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ItemAnchorLocalOffsetData _itemAnchorLocalOffsetData;

		// Token: 0x040028E3 RID: 10467
		[Token(Token = "0x40028E3")]
		[FieldOffset(Offset = "0x78")]
		private GrabBagController _grabBagController;

		// Token: 0x040028E4 RID: 10468
		[Token(Token = "0x40028E4")]
		[FieldOffset(Offset = "0x80")]
		private bool _isDeserializingOrStorageChanged;
	}
}
