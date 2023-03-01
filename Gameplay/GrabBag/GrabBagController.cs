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
	// Token: 0x020006FC RID: 1788
	[Token(Token = "0x20006FC")]
	[AddComponentMenu("Sons/Gameplay/GrabBag/GrabBagController")]
	public class GrabBagController : HeldControllerBase
	{
		// Token: 0x06002E45 RID: 11845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E45")]
		[Address(RVA = "0x2E0CAE0", Offset = "0x2E0BAE0", VA = "0x182E0CAE0")]
		public void OpenCooking()
		{
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x2E0E100", Offset = "0x2E0D100", VA = "0x182E0E100")]
		public void UpdateCooking()
		{
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E47")]
		[Address(RVA = "0x2E08C60", Offset = "0x2E07C60", VA = "0x182E08C60")]
		public void CloseCooking()
		{
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x0000D278 File Offset: 0x0000B478
		[Token(Token = "0x6002E48")]
		[Address(RVA = "0x2E089B0", Offset = "0x2E079B0", VA = "0x182E089B0")]
		private bool CanDoCookingInteraction(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x0000D290 File Offset: 0x0000B490
		[Token(Token = "0x6002E49")]
		[Address(RVA = "0x2E0A720", Offset = "0x2E09720", VA = "0x182E0A720")]
		private bool OnCookingItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return default(bool);
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		[Token(Token = "0x170005C5")]
		private bool ReceiverIsValid
		{
			[Token(Token = "0x6002E4A")]
			[Address(RVA = "0x2E0F530", Offset = "0x2E0E530", VA = "0x182E0F530")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E4B")]
		[Address(RVA = "0x2E09F60", Offset = "0x2E08F60", VA = "0x182E09F60")]
		public IEnumerable<GrabBagLayoutItemGroup> GetActiveCategoryLayoutItemGroups()
		{
			return null;
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4C")]
		[Address(RVA = "0x2E0DC40", Offset = "0x2E0CC40", VA = "0x182E0DC40")]
		public void SetActiveCategory(GrabBagCategory category)
		{
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4D")]
		[Address(RVA = "0x2E0EF60", Offset = "0x2E0DF60", VA = "0x182E0EF60")]
		private void Update()
		{
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C6")]
		private ILayerBehaviourActivator[] DisableSpineActivators
		{
			[Token(Token = "0x6002E4E")]
			[Address(RVA = "0x2E0F420", Offset = "0x2E0E420", VA = "0x182E0F420")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4F")]
		[Address(RVA = "0x2E0B070", Offset = "0x2E0A070", VA = "0x182E0B070")]
		private void OnDisable()
		{
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E50")]
		[Address(RVA = "0x2E0D7F0", Offset = "0x2E0C7F0", VA = "0x182E0D7F0")]
		private void RebuildCategoryGroups()
		{
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E51")]
		[Address(RVA = "0x2E0CFF0", Offset = "0x2E0BFF0", VA = "0x182E0CFF0")]
		private void Open()
		{
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E52")]
		[Address(RVA = "0x2E0EB90", Offset = "0x2E0DB90", VA = "0x182E0EB90")]
		private void UpdateTossedItemPath()
		{
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E53")]
		[Address(RVA = "0x2E0A4A0", Offset = "0x2E094A0", VA = "0x182E0A4A0")]
		private void OnChangeCategory(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E54")]
		[Address(RVA = "0x2E0A690", Offset = "0x2E09690", VA = "0x182E0A690")]
		private void OnClose(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E55")]
		[Address(RVA = "0x2E0D740", Offset = "0x2E0C740", VA = "0x182E0D740")]
		public void PutAway()
		{
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E56")]
		[Address(RVA = "0x2E097A0", Offset = "0x2E087A0", VA = "0x182E097A0")]
		private void Close()
		{
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E57")]
		[Address(RVA = "0x2E0AE40", Offset = "0x2E09E40", VA = "0x182E0AE40")]
		private void OnCursorMoved(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E58")]
		[Address(RVA = "0x2E0A070", Offset = "0x2E09070", VA = "0x182E0A070", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		[Token(Token = "0x6002E59")]
		[Address(RVA = "0x2E0A420", Offset = "0x2E09420", VA = "0x182E0A420", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E5A")]
		[Address(RVA = "0x2E0CA40", Offset = "0x2E0BA40", VA = "0x182E0CA40")]
		private void OnLayoutItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E5B")]
		[Address(RVA = "0x2E09EC0", Offset = "0x2E08EC0", VA = "0x182E09EC0")]
		private IEnumerator DelayedOnLayoutItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return null;
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E5C")]
		[Address(RVA = "0x2E0CBC0", Offset = "0x2E0BBC0", VA = "0x182E0CBC0")]
		public void OpenDryingRack()
		{
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E5D")]
		[Address(RVA = "0x2E0E340", Offset = "0x2E0D340", VA = "0x182E0E340")]
		public void UpdateDryingRack()
		{
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E5E")]
		[Address(RVA = "0x2E08EA0", Offset = "0x2E07EA0", VA = "0x182E08EA0")]
		public void CloseDryingRack()
		{
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		[Token(Token = "0x6002E5F")]
		[Address(RVA = "0x2E08A20", Offset = "0x2E07A20", VA = "0x182E08A20")]
		private bool CanDoDryingRackInteraction(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[Token(Token = "0x6002E60")]
		[Address(RVA = "0x2E0B190", Offset = "0x2E0A190", VA = "0x182E0B190")]
		private bool OnDryingRackItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return default(bool);
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E61")]
		[Address(RVA = "0x2E0CCA0", Offset = "0x2E0BCA0", VA = "0x182E0CCA0")]
		public void OpenGardening()
		{
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E62")]
		[Address(RVA = "0x2E0E6B0", Offset = "0x2E0D6B0", VA = "0x182E0E6B0")]
		public void UpdateGardening()
		{
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E63")]
		[Address(RVA = "0x2E090E0", Offset = "0x2E080E0", VA = "0x182E090E0")]
		public void CloseGardening()
		{
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x6002E64")]
		[Address(RVA = "0x2E08AB0", Offset = "0x2E07AB0", VA = "0x182E08AB0")]
		private bool CanDoGardeningInteraction(ItemInstance _)
		{
			return default(bool);
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x0000D320 File Offset: 0x0000B520
		[Token(Token = "0x6002E65")]
		[Address(RVA = "0x2E0B7D0", Offset = "0x2E0A7D0", VA = "0x182E0B7D0")]
		private bool OnGardeningItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return default(bool);
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E66")]
		[Address(RVA = "0x2E0CD80", Offset = "0x2E0BD80", VA = "0x182E0CD80")]
		public void OpenGiveItem()
		{
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E67")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void UpdateGiveItem()
		{
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E68")]
		[Address(RVA = "0x2E09320", Offset = "0x2E08320", VA = "0x182E09320")]
		public void CloseGiveItem()
		{
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x0000D338 File Offset: 0x0000B538
		[Token(Token = "0x6002E69")]
		[Address(RVA = "0x2E08B00", Offset = "0x2E07B00", VA = "0x182E08B00")]
		private bool CanDoGiveInteraction(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x0000D350 File Offset: 0x0000B550
		[Token(Token = "0x6002E6A")]
		[Address(RVA = "0x2E0BE30", Offset = "0x2E0AE30", VA = "0x182E0BE30")]
		private bool OnGiveItemItemInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return default(bool);
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6B")]
		[Address(RVA = "0x2E0DA50", Offset = "0x2E0CA50", VA = "0x182E0DA50")]
		public void RequestItemBack(int itemId)
		{
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6C")]
		[Address(RVA = "0x2E0CEB0", Offset = "0x2E0BEB0", VA = "0x182E0CEB0")]
		public void OpenItemStorage()
		{
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6D")]
		[Address(RVA = "0x2E0E970", Offset = "0x2E0D970", VA = "0x182E0E970")]
		public void UpdateItemStorage()
		{
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6E")]
		[Address(RVA = "0x2E09560", Offset = "0x2E08560", VA = "0x182E09560")]
		public void CloseItemStorage()
		{
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x0000D368 File Offset: 0x0000B568
		[Token(Token = "0x6002E6F")]
		[Address(RVA = "0x2E08BD0", Offset = "0x2E07BD0", VA = "0x182E08BD0")]
		private bool CanDoItemStorageInteraction(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x0000D380 File Offset: 0x0000B580
		[Token(Token = "0x6002E70")]
		[Address(RVA = "0x2E0C410", Offset = "0x2E0B410", VA = "0x182E0C410")]
		private bool OnItemStorageInteraction(ItemInstance itemInstance, bool isUniqueCollection)
		{
			return default(bool);
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E71")]
		[Address(RVA = "0x2E0F210", Offset = "0x2E0E210", VA = "0x182E0F210")]
		public GrabBagController()
		{
		}

		// Token: 0x04002915 RID: 10517
		[Token(Token = "0x4002915")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _arcHeightCookingOffset;

		// Token: 0x04002916 RID: 10518
		[Token(Token = "0x4002916")]
		[FieldOffset(Offset = "0x78")]
		private CookingSurface _cookingSurface;

		// Token: 0x04002917 RID: 10519
		[Token(Token = "0x4002917")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<GrabBagController.GrabBagCategoryGroup> _categoryGroups;

		// Token: 0x04002918 RID: 10520
		[Token(Token = "0x4002918")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _cursorMouseSpeed;

		// Token: 0x04002919 RID: 10521
		[Token(Token = "0x4002919")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _cursorGamepadSpeed;

		// Token: 0x0400291A RID: 10522
		[Token(Token = "0x400291A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _layerDisableSpeed;

		// Token: 0x0400291B RID: 10523
		[Token(Token = "0x400291B")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _cursorThrottleSpeedWhenOverItem;

		// Token: 0x0400291C RID: 10524
		[Token(Token = "0x400291C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _tossItemDelay;

		// Token: 0x0400291D RID: 10525
		[Token(Token = "0x400291D")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject _tossedItemObject;

		// Token: 0x0400291E RID: 10526
		[Token(Token = "0x400291E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private PathCreator _pathCreator;

		// Token: 0x0400291F RID: 10527
		[Token(Token = "0x400291F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private PathFollower _pathFollower;

		// Token: 0x04002920 RID: 10528
		[Token(Token = "0x4002920")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AnimationCurve _speedCurve;

		// Token: 0x04002921 RID: 10529
		[Token(Token = "0x4002921")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private VirtualMouseInput _virtualMouse;

		// Token: 0x04002922 RID: 10530
		[Token(Token = "0x4002922")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private InputCursorState _inputCursorState;

		// Token: 0x04002923 RID: 10531
		[Token(Token = "0x4002923")]
		[FieldOffset(Offset = "0xD0")]
		private ItemInstance _currentItemInstance;

		// Token: 0x04002924 RID: 10532
		[Token(Token = "0x4002924")]
		[FieldOffset(Offset = "0xD8")]
		private IGrabBagInteractionReceiver _grabBagInteractionReceiver;

		// Token: 0x04002925 RID: 10533
		[Token(Token = "0x4002925")]
		[FieldOffset(Offset = "0xE0")]
		private bool _isOverItem;

		// Token: 0x04002926 RID: 10534
		[Token(Token = "0x4002926")]
		[FieldOffset(Offset = "0xE4")]
		private Vector2 _mouseScreenPosition;

		// Token: 0x04002927 RID: 10535
		[Token(Token = "0x4002927")]
		[FieldOffset(Offset = "0xEC")]
		private GrabBagCategory _activeCategory;

		// Token: 0x04002928 RID: 10536
		[Token(Token = "0x4002928")]
		[FieldOffset(Offset = "0xF0")]
		private int _activeCategoryIndex;

		// Token: 0x04002929 RID: 10537
		[Token(Token = "0x4002929")]
		[FieldOffset(Offset = "0xF8")]
		private GrabBagController.GrabBagCategoryGroup _activeCategoryGroup;

		// Token: 0x0400292A RID: 10538
		[Token(Token = "0x400292A")]
		[FieldOffset(Offset = "0x100")]
		private float _fullBodyWeight;

		// Token: 0x0400292B RID: 10539
		[Token(Token = "0x400292B")]
		[FieldOffset(Offset = "0x104")]
		private float _spineWeight;

		// Token: 0x0400292C RID: 10540
		[Token(Token = "0x400292C")]
		[FieldOffset(Offset = "0x108")]
		private ILayerBehaviourActivator[] _cachedDisableSpineActivators;

		// Token: 0x0400292D RID: 10541
		[Token(Token = "0x400292D")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float _arcHeightOffsetDryingRack;

		// Token: 0x0400292E RID: 10542
		[Token(Token = "0x400292E")]
		[FieldOffset(Offset = "0x118")]
		private DryingRackScrewStructure _dryingRack;

		// Token: 0x0400292F RID: 10543
		[Token(Token = "0x400292F")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _arcHeightOffsetGardening;

		// Token: 0x04002930 RID: 10544
		[Token(Token = "0x4002930")]
		[FieldOffset(Offset = "0x128")]
		private GardenPlot _gardenPlot;

		// Token: 0x04002931 RID: 10545
		[Token(Token = "0x4002931")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private float _arcHeightOffsetGiveItem;

		// Token: 0x04002932 RID: 10546
		[Token(Token = "0x4002932")]
		[FieldOffset(Offset = "0x138")]
		private GiveItemsController _giveItemsController;

		// Token: 0x04002933 RID: 10547
		[Token(Token = "0x4002933")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float _arcHeightOffsetWeaponRack;

		// Token: 0x04002934 RID: 10548
		[Token(Token = "0x4002934")]
		[FieldOffset(Offset = "0x148")]
		private ItemStorageController _itemStorage;

		// Token: 0x020006FD RID: 1789
		[Token(Token = "0x20006FD")]
		[Serializable]
		private class GrabBagCategoryGroup
		{
			// Token: 0x06002E73 RID: 11891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002E73")]
			[Address(RVA = "0x2E08930", Offset = "0x2E07930", VA = "0x182E08930")]
			public GrabBagCategoryGroup()
			{
			}

			// Token: 0x04002935 RID: 10549
			[Token(Token = "0x4002935")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public GrabBagCategory _categoryType;

			// Token: 0x04002936 RID: 10550
			[Token(Token = "0x4002936")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public GameObject _layoutGroupRoot;

			// Token: 0x04002937 RID: 10551
			[Token(Token = "0x4002937")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public List<GrabBagLayoutItemGroup> _layoutItemGroups;
		}
	}
}
