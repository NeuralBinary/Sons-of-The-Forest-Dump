using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using PathCreation;
using PathCreation.Examples;
using Sons.Animation;
using Sons.Crafting.Structures;
using Sons.Gameplay.Cooking;
using Sons.Gameplay.Gardening;
using Sons.Input;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x0200084A RID: 2122
	[Token(Token = "0x200084A")]
	[AddComponentMenu("Sons/Gameplay/GrabBag/GrabBagController")]
	public class GrabBagController : HeldControllerBase
	{
		// Token: 0x06003C3C RID: 15420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3C")]
		[Address(RVA = "0x359CAD0", Offset = "0x359B0D0", VA = "0x18359CAD0")]
		public void OpenCooking()
		{
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3D")]
		[Address(RVA = "0x359CC50", Offset = "0x359B250", VA = "0x18359CC50")]
		public void UpdateCooking()
		{
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3E")]
		[Address(RVA = "0x359CF30", Offset = "0x359B530", VA = "0x18359CF30")]
		public void CloseCooking()
		{
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x00012528 File Offset: 0x00010728
		[Token(Token = "0x6003C3F")]
		[Address(RVA = "0x359D320", Offset = "0x359B920", VA = "0x18359D320")]
		private bool CanDoCookingInteraction(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x00012540 File Offset: 0x00010740
		[Token(Token = "0x6003C40")]
		[Address(RVA = "0x359D3F0", Offset = "0x359B9F0", VA = "0x18359D3F0")]
		private bool OnCookingItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return default(bool);
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x00012558 File Offset: 0x00010758
		[Token(Token = "0x170007C8")]
		private bool ReceiverIsValid
		{
			[Token(Token = "0x6003C41")]
			[Address(RVA = "0x359E0C0", Offset = "0x359C6C0", VA = "0x18359E0C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C42")]
		[Address(RVA = "0x359E220", Offset = "0x359C820", VA = "0x18359E220")]
		public IEnumerable<GrabBagLayoutItemGroup> GetActiveCategoryLayoutItemGroups()
		{
			return null;
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C43")]
		[Address(RVA = "0x359E390", Offset = "0x359C990", VA = "0x18359E390")]
		public void SetActiveCategory(GrabBagCategory category)
		{
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C44")]
		[Address(RVA = "0x359E930", Offset = "0x359CF30", VA = "0x18359E930")]
		private void Update()
		{
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C9")]
		private ILayerBehaviourActivator[] DisableSpineActivators
		{
			[Token(Token = "0x6003C45")]
			[Address(RVA = "0x359ECE0", Offset = "0x359D2E0", VA = "0x18359ECE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C46")]
		[Address(RVA = "0x359EE80", Offset = "0x359D480", VA = "0x18359EE80")]
		private void OnDisable()
		{
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C47")]
		[Address(RVA = "0x359F000", Offset = "0x359D600", VA = "0x18359F000")]
		private void RebuildCategoryGroups()
		{
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C48")]
		[Address(RVA = "0x359F340", Offset = "0x359D940", VA = "0x18359F340")]
		private void Open()
		{
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C49")]
		[Address(RVA = "0x359FBC0", Offset = "0x359E1C0", VA = "0x18359FBC0")]
		private void UpdateTossedItemPath()
		{
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4A")]
		[Address(RVA = "0x35A01A0", Offset = "0x359E7A0", VA = "0x1835A01A0")]
		private void OnChangeCategory(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4B")]
		[Address(RVA = "0x35A03C0", Offset = "0x359E9C0", VA = "0x1835A03C0")]
		private void OnClose(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4C")]
		[Address(RVA = "0x35A04E0", Offset = "0x359EAE0", VA = "0x1835A04E0")]
		public void PutAway()
		{
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4D")]
		[Address(RVA = "0x35A05B0", Offset = "0x359EBB0", VA = "0x1835A05B0")]
		private void Close()
		{
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4E")]
		[Address(RVA = "0x35A0D10", Offset = "0x359F310", VA = "0x1835A0D10")]
		private void OnCursorMoved(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4F")]
		[Address(RVA = "0x35A1060", Offset = "0x359F660", VA = "0x1835A1060", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x00012570 File Offset: 0x00010770
		[Token(Token = "0x6003C50")]
		[Address(RVA = "0x35A16B0", Offset = "0x359FCB0", VA = "0x1835A16B0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C51")]
		[Address(RVA = "0x35A17D0", Offset = "0x359FDD0", VA = "0x1835A17D0")]
		private void OnLayoutItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C52")]
		[Address(RVA = "0x35A18F0", Offset = "0x359FEF0", VA = "0x1835A18F0")]
		private IEnumerator DelayedOnLayoutItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return null;
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C53")]
		[Address(RVA = "0x35A1A00", Offset = "0x35A0000", VA = "0x1835A1A00")]
		public void OpenDryingRack()
		{
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C54")]
		[Address(RVA = "0x35A1AD0", Offset = "0x35A00D0", VA = "0x1835A1AD0")]
		public void UpdateDryingRack()
		{
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C55")]
		[Address(RVA = "0x35A1E80", Offset = "0x35A0480", VA = "0x1835A1E80")]
		public void CloseDryingRack()
		{
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x00012588 File Offset: 0x00010788
		[Token(Token = "0x6003C56")]
		[Address(RVA = "0x35A2100", Offset = "0x35A0700", VA = "0x1835A2100")]
		private bool CanDoDryingRackInteraction(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x000125A0 File Offset: 0x000107A0
		[Token(Token = "0x6003C57")]
		[Address(RVA = "0x35A21E0", Offset = "0x35A07E0", VA = "0x1835A21E0")]
		private bool OnDryingRackItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return default(bool);
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C58")]
		[Address(RVA = "0x35A2BB0", Offset = "0x35A11B0", VA = "0x1835A2BB0")]
		public void OpenGardening()
		{
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C59")]
		[Address(RVA = "0x35A2C80", Offset = "0x35A1280", VA = "0x1835A2C80")]
		public void UpdateGardening()
		{
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5A")]
		[Address(RVA = "0x35A2F80", Offset = "0x35A1580", VA = "0x1835A2F80")]
		public void CloseGardening()
		{
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x000125B8 File Offset: 0x000107B8
		[Token(Token = "0x6003C5B")]
		[Address(RVA = "0x35A3200", Offset = "0x35A1800", VA = "0x1835A3200")]
		private bool CanDoGardeningInteraction(ItemInstance _)
		{
			return default(bool);
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x000125D0 File Offset: 0x000107D0
		[Token(Token = "0x6003C5C")]
		[Address(RVA = "0x35A3290", Offset = "0x35A1890", VA = "0x1835A3290")]
		private bool OnGardeningItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return default(bool);
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5D")]
		[Address(RVA = "0x35A3C30", Offset = "0x35A2230", VA = "0x1835A3C30")]
		public void OpenGiveItem()
		{
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void UpdateGiveItem()
		{
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5F")]
		[Address(RVA = "0x35A3D40", Offset = "0x35A2340", VA = "0x1835A3D40")]
		public void CloseGiveItem()
		{
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x000125E8 File Offset: 0x000107E8
		[Token(Token = "0x6003C60")]
		[Address(RVA = "0x35A3FC0", Offset = "0x35A25C0", VA = "0x1835A3FC0")]
		private bool CanDoGiveInteraction(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x00012600 File Offset: 0x00010800
		[Token(Token = "0x6003C61")]
		[Address(RVA = "0x35A41B0", Offset = "0x35A27B0", VA = "0x1835A41B0")]
		private bool OnGiveItemItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return default(bool);
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C62")]
		[Address(RVA = "0x35A4BB0", Offset = "0x35A31B0", VA = "0x1835A4BB0")]
		public void RequestItemBack(int itemId)
		{
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C63")]
		[Address(RVA = "0x35A4CA0", Offset = "0x35A32A0", VA = "0x1835A4CA0")]
		public void OpenItemStorage()
		{
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C64")]
		[Address(RVA = "0x35A4DE0", Offset = "0x35A33E0", VA = "0x1835A4DE0")]
		public void UpdateItemStorage()
		{
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C65")]
		[Address(RVA = "0x35A4FE0", Offset = "0x35A35E0", VA = "0x1835A4FE0")]
		public void CloseItemStorage()
		{
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00012618 File Offset: 0x00010818
		[Token(Token = "0x6003C66")]
		[Address(RVA = "0x35A5260", Offset = "0x35A3860", VA = "0x1835A5260")]
		private bool CanDoItemStorageInteraction(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00012630 File Offset: 0x00010830
		[Token(Token = "0x6003C67")]
		[Address(RVA = "0x35A5330", Offset = "0x35A3930", VA = "0x1835A5330")]
		private bool OnItemStorageInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return default(bool);
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C68")]
		[Address(RVA = "0x35A5CF0", Offset = "0x35A42F0", VA = "0x1835A5CF0")]
		public GrabBagController()
		{
		}

		// Token: 0x040032FB RID: 13051
		[Token(Token = "0x40032FB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _arcHeightCookingOffset;

		// Token: 0x040032FC RID: 13052
		[Token(Token = "0x40032FC")]
		[FieldOffset(Offset = "0x70")]
		private CookingSurface _cookingSurface;

		// Token: 0x040032FD RID: 13053
		[Token(Token = "0x40032FD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<GrabBagController.GrabBagCategoryGroup> _categoryGroups;

		// Token: 0x040032FE RID: 13054
		[Token(Token = "0x40032FE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _cursorMouseSpeed;

		// Token: 0x040032FF RID: 13055
		[Token(Token = "0x40032FF")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _cursorGamepadSpeed;

		// Token: 0x04003300 RID: 13056
		[Token(Token = "0x4003300")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _layerDisableSpeed;

		// Token: 0x04003301 RID: 13057
		[Token(Token = "0x4003301")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _cursorThrottleSpeedWhenOverItem;

		// Token: 0x04003302 RID: 13058
		[Token(Token = "0x4003302")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _tossItemDelay;

		// Token: 0x04003303 RID: 13059
		[Token(Token = "0x4003303")]
		[FieldOffset(Offset = "0x98")]
		private GameObject _tossedItemObject;

		// Token: 0x04003304 RID: 13060
		[Token(Token = "0x4003304")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private PathCreator _pathCreator;

		// Token: 0x04003305 RID: 13061
		[Token(Token = "0x4003305")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private PathFollower _pathFollower;

		// Token: 0x04003306 RID: 13062
		[Token(Token = "0x4003306")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AnimationCurve _speedCurve;

		// Token: 0x04003307 RID: 13063
		[Token(Token = "0x4003307")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private VirtualMouseInput _virtualMouse;

		// Token: 0x04003308 RID: 13064
		[Token(Token = "0x4003308")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private InputCursorState _inputCursorState;

		// Token: 0x04003309 RID: 13065
		[Token(Token = "0x4003309")]
		[FieldOffset(Offset = "0xC8")]
		private ItemInstance _currentItemInstance;

		// Token: 0x0400330A RID: 13066
		[Token(Token = "0x400330A")]
		[FieldOffset(Offset = "0xD0")]
		private IGrabBagInteractionReceiver _grabBagInteractionReceiver;

		// Token: 0x0400330B RID: 13067
		[Token(Token = "0x400330B")]
		[FieldOffset(Offset = "0xD8")]
		private bool _isOverItem;

		// Token: 0x0400330C RID: 13068
		[Token(Token = "0x400330C")]
		[FieldOffset(Offset = "0xDC")]
		private Vector2 _mouseScreenPosition;

		// Token: 0x0400330D RID: 13069
		[Token(Token = "0x400330D")]
		[FieldOffset(Offset = "0xE4")]
		private GrabBagCategory _activeCategory;

		// Token: 0x0400330E RID: 13070
		[Token(Token = "0x400330E")]
		[FieldOffset(Offset = "0xE8")]
		private int _activeCategoryIndex;

		// Token: 0x0400330F RID: 13071
		[Token(Token = "0x400330F")]
		[FieldOffset(Offset = "0xF0")]
		private GrabBagController.GrabBagCategoryGroup _activeCategoryGroup;

		// Token: 0x04003310 RID: 13072
		[Token(Token = "0x4003310")]
		[FieldOffset(Offset = "0xF8")]
		private float _fullBodyWeight;

		// Token: 0x04003311 RID: 13073
		[Token(Token = "0x4003311")]
		[FieldOffset(Offset = "0xFC")]
		private float _spineWeight;

		// Token: 0x04003312 RID: 13074
		[Token(Token = "0x4003312")]
		[FieldOffset(Offset = "0x100")]
		private bool _isPuttingAway;

		// Token: 0x04003313 RID: 13075
		[Token(Token = "0x4003313")]
		[FieldOffset(Offset = "0x108")]
		private ILayerBehaviourActivator[] _cachedDisableSpineActivators;

		// Token: 0x04003314 RID: 13076
		[Token(Token = "0x4003314")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float _arcHeightOffsetDryingRack;

		// Token: 0x04003315 RID: 13077
		[Token(Token = "0x4003315")]
		[FieldOffset(Offset = "0x118")]
		private DryingRackScrewStructure _dryingRack;

		// Token: 0x04003316 RID: 13078
		[Token(Token = "0x4003316")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _arcHeightOffsetGardening;

		// Token: 0x04003317 RID: 13079
		[Token(Token = "0x4003317")]
		[FieldOffset(Offset = "0x128")]
		private GardenPlot _gardenPlot;

		// Token: 0x04003318 RID: 13080
		[Token(Token = "0x4003318")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private float _arcHeightOffsetGiveItem;

		// Token: 0x04003319 RID: 13081
		[Token(Token = "0x4003319")]
		[FieldOffset(Offset = "0x138")]
		private GiveItemsController _giveItemsController;

		// Token: 0x0400331A RID: 13082
		[Token(Token = "0x400331A")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float _arcHeightOffsetWeaponRack;

		// Token: 0x0400331B RID: 13083
		[Token(Token = "0x400331B")]
		[FieldOffset(Offset = "0x148")]
		private ItemStorageController _itemStorage;

		// Token: 0x0200084B RID: 2123
		[Token(Token = "0x200084B")]
		[Serializable]
		private class GrabBagCategoryGroup
		{
			// Token: 0x06003C6A RID: 15466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C6A")]
			[Address(RVA = "0x35A6010", Offset = "0x35A4610", VA = "0x1835A6010")]
			public GrabBagCategoryGroup()
			{
			}

			// Token: 0x0400331C RID: 13084
			[Token(Token = "0x400331C")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public GrabBagCategory _categoryType;

			// Token: 0x0400331D RID: 13085
			[Token(Token = "0x400331D")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public GameObject _layoutGroupRoot;

			// Token: 0x0400331E RID: 13086
			[Token(Token = "0x400331E")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public List<GrabBagLayoutItemGroup> _layoutItemGroups;
		}
	}
}
