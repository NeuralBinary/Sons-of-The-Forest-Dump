using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Gameplay.GrabBag;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007E8 RID: 2024
	[Token(Token = "0x20007E8")]
	[AddComponentMenu("Sons/Gameplay/DryingRackScrewStructure")]
	public class DryingRackScrewStructure : ScrewStructure, IGrabBagInteractionReceiver
	{
		// Token: 0x0600357A RID: 13690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357A")]
		[Address(RVA = "0x2E911D0", Offset = "0x2E901D0", VA = "0x182E911D0", Slot = "32")]
		public List<GrabBagCategory> GetValidGrabBagCategories()
		{
			return null;
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357B")]
		[Address(RVA = "0x2E924B0", Offset = "0x2E914B0", VA = "0x182E924B0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357C")]
		[Address(RVA = "0x2E90C60", Offset = "0x2E8FC60", VA = "0x182E90C60", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x0000F618 File Offset: 0x0000D818
		[Token(Token = "0x600357D")]
		[Address(RVA = "0x2E91630", Offset = "0x2E90630", VA = "0x182E91630", Slot = "31")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357E")]
		[Address(RVA = "0x2E90E50", Offset = "0x2E8FE50", VA = "0x182E90E50", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357F")]
		[Address(RVA = "0x2E91E00", Offset = "0x2E90E00", VA = "0x182E91E00")]
		private void OnHookPointUsed(ItemHookPoint hookPoint)
		{
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003580")]
		[Address(RVA = "0x2E919A0", Offset = "0x2E909A0", VA = "0x182E919A0")]
		private void OnHookPointCleared(ItemHookPoint hookPoint)
		{
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003581")]
		[Address(RVA = "0x2E92100", Offset = "0x2E91100", VA = "0x182E92100")]
		private void OnStorageDeserialized()
		{
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003582")]
		[Address(RVA = "0x2E913D0", Offset = "0x2E903D0", VA = "0x182E913D0")]
		public void InteractWithDryingRack()
		{
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x0000F630 File Offset: 0x0000D830
		[Token(Token = "0x6003583")]
		[Address(RVA = "0x2E912A0", Offset = "0x2E902A0", VA = "0x182E912A0")]
		public bool HasAvailableHooks()
		{
			return default(bool);
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x0000F648 File Offset: 0x0000D848
		[Token(Token = "0x6003584")]
		[Address(RVA = "0x2E92D50", Offset = "0x2E91D50", VA = "0x182E92D50")]
		public bool TryGetAvailableHook(out DryingRackHookPoint hook, out int index)
		{
			return default(bool);
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x0000F660 File Offset: 0x0000D860
		[Token(Token = "0x6003585")]
		[Address(RVA = "0x2E92A00", Offset = "0x2E91A00", VA = "0x182E92A00")]
		private bool TryAddItemToHook(ItemInstance itemInstance, int hookIndex)
		{
			return default(bool);
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x0000F678 File Offset: 0x0000D878
		[Token(Token = "0x6003586")]
		[Address(RVA = "0x2E92AD0", Offset = "0x2E91AD0", VA = "0x182E92AD0", Slot = "30")]
		public bool TryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003587")]
		[Address(RVA = "0x2E92570", Offset = "0x2E91570", VA = "0x182E92570")]
		private void SpawnPickupAndAddToHook(ItemInstance itemInstance, ItemHookPoint hook)
		{
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003588")]
		[Address(RVA = "0x2E92540", Offset = "0x2E91540", VA = "0x182E92540", Slot = "27")]
		public void OpenInteractionReceiver(GrabBagController grabBagController)
		{
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003589")]
		[Address(RVA = "0x2E92E50", Offset = "0x2E91E50", VA = "0x182E92E50", Slot = "28")]
		public void UpdateInteractionReceiver()
		{
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358A")]
		[Address(RVA = "0x2E911B0", Offset = "0x2E901B0", VA = "0x182E911B0", Slot = "29")]
		public void CloseInteractionReceiver()
		{
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358B")]
		[Address(RVA = "0x2E91720", Offset = "0x2E90720", VA = "0x182E91720", Slot = "25")]
		public override void ModifyItemCountFromClientRequest(ItemInstance itemInstance, int count, int storageIndex, BoltConnection sender)
		{
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x2E91FA0", Offset = "0x2E90FA0", VA = "0x182E91FA0", Slot = "26")]
		protected override void OnSlotAvailabilityChangedMP()
		{
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x2E92E70", Offset = "0x2E91E70", VA = "0x182E92E70")]
		public DryingRackScrewStructure()
		{
		}

		// Token: 0x04002DF4 RID: 11764
		[Token(Token = "0x4002DF4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<DryingRackHookPoint> _hookPoints;

		// Token: 0x04002DF5 RID: 11765
		[Token(Token = "0x4002DF5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StructureStorage _storage;

		// Token: 0x04002DF6 RID: 11766
		[Token(Token = "0x4002DF6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ItemAnchorLocalOffsetData _itemAnchorLocalOffsetData;

		// Token: 0x04002DF7 RID: 11767
		[Token(Token = "0x4002DF7")]
		[FieldOffset(Offset = "0x58")]
		private GrabBagController _grabBagController;

		// Token: 0x04002DF8 RID: 11768
		[Token(Token = "0x4002DF8")]
		[FieldOffset(Offset = "0x60")]
		private bool _isDeserializingOrStorageChanged;
	}
}
