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
	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x200074E")]
	[AddComponentMenu("Sons/Player/InventoryProps")]
	public class InventoryProps : MonoBehaviour
	{
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060030B5 RID: 12469 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060030B6 RID: 12470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000023")]
		private event Action<GameObject, InventoryProps.PropDefinition, ItemInstance> OnHeldItemInitialized
		{
			[Token(Token = "0x60030B5")]
			[Address(RVA = "0x2E49C20", Offset = "0x2E48C20", VA = "0x182E49C20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60030B6")]
			[Address(RVA = "0x2E4A750", Offset = "0x2E49750", VA = "0x182E4A750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060030B7 RID: 12471 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060030B8 RID: 12472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000024")]
		private event Action<int> OnHeldItemRemoved
		{
			[Token(Token = "0x60030B7")]
			[Address(RVA = "0x2E49CD0", Offset = "0x2E48CD0", VA = "0x182E49CD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60030B8")]
			[Address(RVA = "0x2E4A800", Offset = "0x2E49800", VA = "0x182E4A800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B9")]
		[Address(RVA = "0x2E49C20", Offset = "0x2E48C20", VA = "0x182E49C20")]
		public void RegisterOnHeldItemInitialized(Action<GameObject, InventoryProps.PropDefinition, ItemInstance> regFunc)
		{
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BA")]
		[Address(RVA = "0x2E4A750", Offset = "0x2E49750", VA = "0x182E4A750")]
		public void UnregisterOnHeldItemInitialized(Action<GameObject, InventoryProps.PropDefinition, ItemInstance> regFunc)
		{
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BB")]
		[Address(RVA = "0x2E49CD0", Offset = "0x2E48CD0", VA = "0x182E49CD0")]
		public void RegisterOnHeldItemRemoved(Action<int> regFunc)
		{
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BC")]
		[Address(RVA = "0x2E4A800", Offset = "0x2E49800", VA = "0x182E4A800")]
		public void UnregisterOnHeldItemRemoved(Action<int> regFunc)
		{
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		[Token(Token = "0x60030BD")]
		[Address(RVA = "0x2E4A050", Offset = "0x2E49050", VA = "0x182E4A050")]
		public bool TryCreateHeldInstance(InventoryProps.PropDefinition propDefinition, ItemInstance itemInstance, out GameObject outObjectInstance, [Optional] EquipmentSlot? forceSlot, bool dummyProp = false)
		{
			return default(bool);
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BE")]
		[Address(RVA = "0x2E492C0", Offset = "0x2E482C0", VA = "0x182E492C0")]
		private Transform GetHeldLocatorParent(InventoryProps.PropDefinition propDefinition, EquipmentSlot? forceSlot)
		{
			return null;
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BF")]
		[Address(RVA = "0x2E49D80", Offset = "0x2E48D80", VA = "0x182E49D80")]
		private void SetupInitializeCallback(GameObject newObjectInstance, InventoryProps.PropDefinition propDefinition, ItemInstance itemInstance, bool dummyProp = false)
		{
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C0")]
		[Address(RVA = "0x2E49520", Offset = "0x2E48520", VA = "0x182E49520")]
		private void InitializeCallback(GameObject newObjectInstance, InventoryProps.PropDefinition propDefinition, ItemInstance itemInstance, bool dummyProp = false)
		{
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C1")]
		[Address(RVA = "0x2E495D0", Offset = "0x2E485D0", VA = "0x182E495D0")]
		private void InitializeHeldItem(GameObject newInstance, ItemData itemData)
		{
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C2")]
		[Address(RVA = "0x2E497F0", Offset = "0x2E487F0", VA = "0x182E497F0")]
		private void InitializeWeaponInfo(GameObject newInstance)
		{
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C3")]
		[Address(RVA = "0x2E49A60", Offset = "0x2E48A60", VA = "0x182E49A60")]
		private static void MatchLocalTransforms(Transform applyToTransform, Transform queryFromTransform)
		{
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C4")]
		[Address(RVA = "0x2E49F70", Offset = "0x2E48F70", VA = "0x182E49F70")]
		private void SetupWeaponInfo(weaponInfo weaponInfo)
		{
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C5")]
		[Address(RVA = "0x2E493E0", Offset = "0x2E483E0", VA = "0x182E493E0")]
		public InventoryProps.PropDefinition GetPropDefinitionForItem(int itemId)
		{
			return null;
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		[Token(Token = "0x60030C6")]
		[Address(RVA = "0x2E4A560", Offset = "0x2E49560", VA = "0x182E4A560")]
		public bool TryRemoveHeldInstance(int itemId, Animator playerAnimator, bool instantDestroy = false)
		{
			return default(bool);
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C7")]
		[Address(RVA = "0x2E49220", Offset = "0x2E48220", VA = "0x182E49220")]
		private static IEnumerator DestroyHeldItemOncePlayerIsIdle(EquipmentSlot equipmentSlot, GameObject heldItemInstance, Animator playerAnimator)
		{
			return null;
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C8")]
		[Address(RVA = "0x2E49190", Offset = "0x2E48190", VA = "0x182E49190")]
		private IEnumerator ApplyAnimVarsOncePlayerIsIdle(ItemData itemData, Animator playerAnimator)
		{
			return null;
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C9")]
		[Address(RVA = "0x2E4A8B0", Offset = "0x2E498B0", VA = "0x182E4A8B0")]
		public InventoryProps()
		{
		}

		// Token: 0x04002AA8 RID: 10920
		[Token(Token = "0x4002AA8")]
		[FieldOffset(Offset = "0x20")]
		public List<InventoryProps.PropDefinition> _propDefinitions;

		// Token: 0x04002AA9 RID: 10921
		[Token(Token = "0x4002AA9")]
		[FieldOffset(Offset = "0x28")]
		[Header("General Hookups")]
		public Transform _leftHeldParent;

		// Token: 0x04002AAA RID: 10922
		[Token(Token = "0x4002AAA")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("_heldParent")]
		public Transform _rightHeldParent;

		// Token: 0x04002AAB RID: 10923
		[Token(Token = "0x4002AAB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _weaponHeldRoot;

		// Token: 0x04002AAC RID: 10924
		[Token(Token = "0x4002AAC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _playerTransform;

		// Token: 0x04002AAD RID: 10925
		[Token(Token = "0x4002AAD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _playerBase;

		// Token: 0x04002AAE RID: 10926
		[Token(Token = "0x4002AAE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Animator _playerAnimator;

		// Token: 0x04002AAF RID: 10927
		[Token(Token = "0x4002AAF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private PlayerAnimatorControl _playerAnimatorControl;

		// Token: 0x04002AB0 RID: 10928
		[Token(Token = "0x4002AB0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationEventReceiver _playerAnimEventReceiver;

		// Token: 0x04002AB1 RID: 10929
		[Token(Token = "0x4002AB1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private PlayerInventory _playerInventory;

		// Token: 0x04002AB2 RID: 10930
		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<int, GameObject> _gameObjectInstances;

		// Token: 0x0200074F RID: 1871
		[Token(Token = "0x200074F")]
		[Serializable]
		public class PropDefinition
		{
			// Token: 0x060030CA RID: 12490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030CA")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public PropDefinition()
			{
			}

			// Token: 0x04002AB5 RID: 10933
			[Token(Token = "0x4002AB5")]
			[FieldOffset(Offset = "0x10")]
			public Transform _heldLocator;

			// Token: 0x04002AB6 RID: 10934
			[Token(Token = "0x4002AB6")]
			[FieldOffset(Offset = "0x18")]
			[ItemIdPicker(true)]
			public int _itemId;
		}
	}
}
