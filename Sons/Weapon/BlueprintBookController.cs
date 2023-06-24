using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Crafting;
using Sons.Input;
using Sons.Inventory;
using Sons.Player;
using TheForest.Items.Inventory;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace Sons.Weapon
{
	// Token: 0x0200089E RID: 2206
	[Token(Token = "0x200089E")]
	[AddComponentMenu("Sons/Items/BlueprintBookController")]
	public class BlueprintBookController : HeldControllerBase
	{
		// Token: 0x06003ED3 RID: 16083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED3")]
		[Address(RVA = "0x35D78A0", Offset = "0x35D5EA0", VA = "0x1835D78A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED4")]
		[Address(RVA = "0x35D8100", Offset = "0x35D6700", VA = "0x1835D8100", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED5")]
		[Address(RVA = "0x35D8650", Offset = "0x35D6C50", VA = "0x1835D8650")]
		private void Update()
		{
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x000131E8 File Offset: 0x000113E8
		[Token(Token = "0x6003ED6")]
		[Address(RVA = "0x35D8C90", Offset = "0x35D7290", VA = "0x1835D8C90", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED7")]
		[Address(RVA = "0x35D8DB0", Offset = "0x35D73B0", VA = "0x1835D8DB0")]
		private void StartBlueprintSelectionMode()
		{
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED8")]
		[Address(RVA = "0x35DA0C0", Offset = "0x35D86C0", VA = "0x1835DA0C0")]
		private void OnActivateTutorials(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED9")]
		[Address(RVA = "0x35DA1F0", Offset = "0x35D87F0", VA = "0x1835DA1F0")]
		private void OnCycleForward(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDA")]
		[Address(RVA = "0x35DA250", Offset = "0x35D8850", VA = "0x1835DA250")]
		private IEnumerator FlipPageForward(int forcedPage = -1)
		{
			return null;
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDB")]
		[Address(RVA = "0x35DA310", Offset = "0x35D8910", VA = "0x1835DA310")]
		private void OnCycleBackward(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDC")]
		[Address(RVA = "0x35DA3E0", Offset = "0x35D89E0", VA = "0x1835DA3E0")]
		private IEnumerator FlipPageBackward()
		{
			return null;
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x35DA470", Offset = "0x35D8A70", VA = "0x1835DA470")]
		private void JumpToCategory(int index)
		{
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDE")]
		[Address(RVA = "0x35DA530", Offset = "0x35D8B30", VA = "0x1835DA530")]
		private void UpdateBaseColorMapTexture(Material targetMaterial)
		{
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EDF")]
		[Address(RVA = "0x35DA650", Offset = "0x35D8C50", VA = "0x1835DA650")]
		private static void SetBaseColorMapTexture(Material targetMaterial, Texture2D targetTexture, List<BlueprintBookPageData> allPages)
		{
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE0")]
		[Address(RVA = "0x35DA9D0", Offset = "0x35D8FD0", VA = "0x1835DA9D0")]
		private void OnInteractWithLayout(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE1")]
		[Address(RVA = "0x35DAF30", Offset = "0x35D9530", VA = "0x1835DAF30")]
		private void OnCursorMoved(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE2")]
		[Address(RVA = "0x35DB260", Offset = "0x35D9860", VA = "0x1835DB260")]
		private void SwapPageTexture()
		{
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x35DB340", Offset = "0x35D9940", VA = "0x1835DB340")]
		private void OnCycleForwardAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0x35DB3E0", Offset = "0x35D99E0", VA = "0x1835DB3E0")]
		private void OnCycleBackwardAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x35DB4F0", Offset = "0x35D9AF0", VA = "0x1835DB4F0")]
		private static void DelayClearRequestedMipmapLevel(List<BlueprintBookPageData> pages, int currentTextureIndex, ref float nextClearRequestedMipmapLevelTime)
		{
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x35DB690", Offset = "0x35D9C90", VA = "0x1835DB690")]
		private void UpdatePageLocalization()
		{
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x35DBCB0", Offset = "0x35DA2B0", VA = "0x1835DBCB0")]
		private static string GetTranslation(string translationKey)
		{
			return null;
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x35DBEA0", Offset = "0x35DA4A0", VA = "0x1835DBEA0")]
		public BlueprintBookController()
		{
		}

		// Token: 0x04003483 RID: 13443
		[Token(Token = "0x4003483")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _uiAnchor;

		// Token: 0x04003484 RID: 13444
		[Token(Token = "0x4003484")]
		[FieldOffset(Offset = "0x70")]
		private bool _enteringPlacementMode;

		// Token: 0x04003485 RID: 13445
		[Token(Token = "0x4003485")]
		[FieldOffset(Offset = "0x78")]
		private SonsInputMapping.StructureCraftingActions _inputMapping;

		// Token: 0x04003486 RID: 13446
		[Token(Token = "0x4003486")]
		[FieldOffset(Offset = "0x80")]
		private PlayerInventory _inventory;

		// Token: 0x04003487 RID: 13447
		[Token(Token = "0x4003487")]
		[FieldOffset(Offset = "0x88")]
		private AnimatorLayersController _layersController;

		// Token: 0x04003488 RID: 13448
		[Token(Token = "0x4003488")]
		[FieldOffset(Offset = "0x90")]
		private LayerBehaviourActivator _leftArmLayerBehaviourActivator;

		// Token: 0x04003489 RID: 13449
		[Token(Token = "0x4003489")]
		[FieldOffset(Offset = "0x98")]
		private Transform _uiTransform;

		// Token: 0x0400348A RID: 13450
		[Token(Token = "0x400348A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorMap;

		// Token: 0x0400348B RID: 13451
		[Token(Token = "0x400348B")]
		private const string BlueprintBookPageIndex = "BlueprintBookPageIndex";

		// Token: 0x0400348C RID: 13452
		[Token(Token = "0x400348C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400348D RID: 13453
		[Token(Token = "0x400348D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TextMeshProUGUI _previousPageText;

		// Token: 0x0400348E RID: 13454
		[Token(Token = "0x400348E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private TextMeshProUGUI _nextPageText;

		// Token: 0x0400348F RID: 13455
		[Token(Token = "0x400348F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private TextMeshProUGUI _topBlueprintName;

		// Token: 0x04003490 RID: 13456
		[Token(Token = "0x4003490")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private TextMeshProUGUI _bottomBlueprintName;

		// Token: 0x04003491 RID: 13457
		[Token(Token = "0x4003491")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private string _pageRendererName;

		// Token: 0x04003492 RID: 13458
		[Token(Token = "0x4003492")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private string _padRendererName;

		// Token: 0x04003493 RID: 13459
		[Token(Token = "0x4003493")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private BlueprintBookPages _pages;

		// Token: 0x04003494 RID: 13460
		[Token(Token = "0x4003494")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private List<HeldBookInteraction> _tabs;

		// Token: 0x04003495 RID: 13461
		[Token(Token = "0x4003495")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private List<int> _categoryStartingPage;

		// Token: 0x04003496 RID: 13462
		[Token(Token = "0x4003496")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private List<HeldBookInteraction> _blueprintBookLayoutItems;

		// Token: 0x04003497 RID: 13463
		[Token(Token = "0x4003497")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private HeldBookInteraction _nextPage;

		// Token: 0x04003498 RID: 13464
		[Token(Token = "0x4003498")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private HeldBookInteraction _previousPage;

		// Token: 0x04003499 RID: 13465
		[Token(Token = "0x4003499")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float _cursorMouseSpeed;

		// Token: 0x0400349A RID: 13466
		[Token(Token = "0x400349A")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private float _cursorGamepadSpeed;

		// Token: 0x0400349B RID: 13467
		[Token(Token = "0x400349B")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private VirtualMouseInput _virtualMouse;

		// Token: 0x0400349C RID: 13468
		[Token(Token = "0x400349C")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private InputCursorState _inputCursorState;

		// Token: 0x0400349D RID: 13469
		[Token(Token = "0x400349D")]
		[FieldOffset(Offset = "0x120")]
		private int _currentPageIndex;

		// Token: 0x0400349E RID: 13470
		[Token(Token = "0x400349E")]
		[FieldOffset(Offset = "0x124")]
		private bool _flippingForward;

		// Token: 0x0400349F RID: 13471
		[Token(Token = "0x400349F")]
		[FieldOffset(Offset = "0x128")]
		private Vector2 _mouseScreenPosition;

		// Token: 0x040034A0 RID: 13472
		[Token(Token = "0x40034A0")]
		[FieldOffset(Offset = "0x130")]
		private Material _padMaterial;

		// Token: 0x040034A1 RID: 13473
		[Token(Token = "0x40034A1")]
		[FieldOffset(Offset = "0x138")]
		private Material _pageMaterial;

		// Token: 0x040034A2 RID: 13474
		[Token(Token = "0x40034A2")]
		[FieldOffset(Offset = "0x140")]
		private PlayerState _playerData;

		// Token: 0x040034A3 RID: 13475
		[Token(Token = "0x40034A3")]
		[FieldOffset(Offset = "0x148")]
		private float _nextClearRequestedMipmapLevelTime;

		// Token: 0x040034A4 RID: 13476
		[Token(Token = "0x40034A4")]
		private const string ItemsTableReferenceKey = "Items";
	}
}
