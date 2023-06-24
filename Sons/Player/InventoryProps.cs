using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.Items.Core;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Player
{
	// Token: 0x02000658 RID: 1624
	[Token(Token = "0x2000658")]
	[AddComponentMenu("Sons/Player/InventoryProps")]
	public class InventoryProps : MonoBehaviour
	{
		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06002A1F RID: 10783 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002A20 RID: 10784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001C")]
		private event Action<GameObject, InventoryProps.PropDefinition, ItemInstance> OnHeldItemInitialized
		{
			[Token(Token = "0x6002A1F")]
			[Address(RVA = "0x33F6BD0", Offset = "0x33F51D0", VA = "0x1833F6BD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002A20")]
			[Address(RVA = "0x33F6D40", Offset = "0x33F5340", VA = "0x1833F6D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06002A21 RID: 10785 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002A22 RID: 10786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001D")]
		private event Action<int, bool> OnHeldItemRemoved
		{
			[Token(Token = "0x6002A21")]
			[Address(RVA = "0x33F6EB0", Offset = "0x33F54B0", VA = "0x1833F6EB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002A22")]
			[Address(RVA = "0x33F7020", Offset = "0x33F5620", VA = "0x1833F7020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x33F6BD0", Offset = "0x33F51D0", VA = "0x1833F6BD0")]
		public void RegisterOnHeldItemInitialized(Action<GameObject, InventoryProps.PropDefinition, ItemInstance> regFunc)
		{
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A24")]
		[Address(RVA = "0x33F6D40", Offset = "0x33F5340", VA = "0x1833F6D40")]
		public void UnregisterOnHeldItemInitialized(Action<GameObject, InventoryProps.PropDefinition, ItemInstance> regFunc)
		{
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x33F6EB0", Offset = "0x33F54B0", VA = "0x1833F6EB0")]
		public void RegisterOnHeldItemRemoved(Action<int, bool> regFunc)
		{
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x33F7020", Offset = "0x33F5620", VA = "0x1833F7020")]
		public void UnregisterOnHeldItemRemoved(Action<int, bool> regFunc)
		{
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x33F7190", Offset = "0x33F5790", VA = "0x1833F7190")]
		public void MpRemoveItem(int itemId)
		{
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x0000C618 File Offset: 0x0000A818
		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x33F71B0", Offset = "0x33F57B0", VA = "0x1833F71B0")]
		public bool TryCreateHeldInstance(InventoryProps.PropDefinition propDefinition, ItemInstance itemInstance, out GameObject outObjectInstance, [Optional] EquipmentSlot? forceSlot, bool dummyProp = false)
		{
			return default(bool);
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x0000C630 File Offset: 0x0000A830
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x33F7680", Offset = "0x33F5C80", VA = "0x1833F7680")]
		public bool TryTransferItemToSlot(int itemId, EquipmentSlot slot)
		{
			return default(bool);
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x0000C648 File Offset: 0x0000A848
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x33F7AD0", Offset = "0x33F60D0", VA = "0x1833F7AD0")]
		public bool TryTransferItemToSlot(ItemInstance itemInstance, EquipmentSlot slot)
		{
			return default(bool);
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x33F7E60", Offset = "0x33F6460", VA = "0x1833F7E60")]
		private Transform GetHeldLocatorParent(InventoryProps.PropDefinition propDefinition, EquipmentSlot? forceSlot)
		{
			return null;
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0x33F8060", Offset = "0x33F6660", VA = "0x1833F8060")]
		private void SetupInitializeCallback(GameObject newObjectInstance, InventoryProps.PropDefinition propDefinition, ItemInstance itemInstance, bool dummyProp = false)
		{
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x33F8370", Offset = "0x33F6970", VA = "0x1833F8370")]
		private void InitializeCallback(GameObject newObjectInstance, InventoryProps.PropDefinition propDefinition, ItemInstance itemInstance, bool dummyProp = false)
		{
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x33F8410", Offset = "0x33F6A10", VA = "0x1833F8410")]
		private void InitializeHeldItem(GameObject newInstance, ItemInstance itemInstance)
		{
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x33F8760", Offset = "0x33F6D60", VA = "0x1833F8760")]
		private void InitializeWeaponInfo(GameObject newInstance)
		{
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A30")]
		[Address(RVA = "0x33F8A50", Offset = "0x33F7050", VA = "0x1833F8A50")]
		private static void MatchLocalTransforms(Transform applyToTransform, Transform queryFromTransform)
		{
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x33F8DA0", Offset = "0x33F73A0", VA = "0x1833F8DA0")]
		private void SetupWeaponInfo(weaponInfo weaponInfo)
		{
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x33F8FA0", Offset = "0x33F75A0", VA = "0x1833F8FA0")]
		public InventoryProps.PropDefinition GetPropDefinitionForItem(int itemId, [Optional] EquipmentSlot? slot)
		{
			return null;
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0000C660 File Offset: 0x0000A860
		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x33F92A0", Offset = "0x33F78A0", VA = "0x1833F92A0")]
		public bool TryRemoveHeldInstance(int itemId, Animator playerAnimator, bool instantDestroy = false, bool skipDestroyItemObject = false, bool mpIgnoreCallback = false, [Optional] EquipmentSlot? slotOverride)
		{
			return default(bool);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A34")]
		[Address(RVA = "0x33F9560", Offset = "0x33F7B60", VA = "0x1833F9560")]
		private static IEnumerator DestroyHeldItemOncePlayerIsIdle(EquipmentSlot equipmentSlot, GameObject heldItemInstance, Animator playerAnimator)
		{
			return null;
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x33F9670", Offset = "0x33F7C70", VA = "0x1833F9670")]
		private IEnumerator ApplyAnimVarsOncePlayerIsIdle(ItemData itemData, Animator playerAnimator)
		{
			return null;
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A36")]
		[Address(RVA = "0x33F9770", Offset = "0x33F7D70", VA = "0x1833F9770")]
		public InventoryProps()
		{
		}

		// Token: 0x04002575 RID: 9589
		[Token(Token = "0x4002575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<InventoryProps.PropDefinition> _propDefinitions;

		// Token: 0x04002576 RID: 9590
		[Token(Token = "0x4002576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<InventoryProps.PropDefinitionOverride> _propDefinitionsOverrides;

		// Token: 0x04002577 RID: 9591
		[Token(Token = "0x4002577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("General Hookups")]
		public Transform _leftHeldParent;

		// Token: 0x04002578 RID: 9592
		[Token(Token = "0x4002578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("_heldParent")]
		public Transform _rightHeldParent;

		// Token: 0x04002579 RID: 9593
		[Token(Token = "0x4002579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _weaponHeldRoot;

		// Token: 0x0400257A RID: 9594
		[Token(Token = "0x400257A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _playerTransform;

		// Token: 0x0400257B RID: 9595
		[Token(Token = "0x400257B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _playerBase;

		// Token: 0x0400257C RID: 9596
		[Token(Token = "0x400257C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Animator _playerAnimator;

		// Token: 0x0400257D RID: 9597
		[Token(Token = "0x400257D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PlayerAnimatorControl _playerAnimatorControl;

		// Token: 0x0400257E RID: 9598
		[Token(Token = "0x400257E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationEventReceiver _playerAnimEventReceiver;

		// Token: 0x0400257F RID: 9599
		[Token(Token = "0x400257F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PlayerInventory _playerInventory;

		// Token: 0x04002580 RID: 9600
		[Token(Token = "0x4002580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<int, GameObject> _gameObjectInstances;

		// Token: 0x02000659 RID: 1625
		[Token(Token = "0x2000659")]
		[Serializable]
		public class PropDefinition
		{
			// Token: 0x06002A37 RID: 10807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002A37")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PropDefinition()
			{
			}

			// Token: 0x04002583 RID: 9603
			[Token(Token = "0x4002583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform _heldLocator;

			// Token: 0x04002584 RID: 9604
			[Token(Token = "0x4002584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[ItemIdPicker(true)]
			public int _itemId;
		}

		// Token: 0x0200065A RID: 1626
		[Token(Token = "0x200065A")]
		[Serializable]
		public class PropDefinitionOverride
		{
			// Token: 0x06002A38 RID: 10808 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002A38")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			public InventoryProps.PropDefinition GetPropDefinition()
			{
				return null;
			}

			// Token: 0x06002A39 RID: 10809 RVA: 0x0000C678 File Offset: 0x0000A878
			[Token(Token = "0x6002A39")]
			[Address(RVA = "0x33F9850", Offset = "0x33F7E50", VA = "0x1833F9850")]
			public bool Matches(int itemId)
			{
				return default(bool);
			}

			// Token: 0x06002A3A RID: 10810 RVA: 0x0000C690 File Offset: 0x0000A890
			[Token(Token = "0x6002A3A")]
			[Address(RVA = "0x33A51F0", Offset = "0x33A37F0", VA = "0x1833A51F0")]
			public bool Matches(EquipmentSlot slot)
			{
				return default(bool);
			}

			// Token: 0x06002A3B RID: 10811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002A3B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PropDefinitionOverride()
			{
			}

			// Token: 0x04002585 RID: 9605
			[Token(Token = "0x4002585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EquipmentSlot _slot;

			// Token: 0x04002586 RID: 9606
			[Token(Token = "0x4002586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InventoryProps.PropDefinition _propDefinition;
		}
	}
}
