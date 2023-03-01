using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Crafting;
using Sons.Input;
using Sons.Player;
using TheForest.Items.Inventory;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace Sons.Weapon
{
	// Token: 0x0200082E RID: 2094
	[Token(Token = "0x200082E")]
	[AddComponentMenu("Sons/Items/BlueprintBookController")]
	public class BlueprintBookController : HeldControllerBase
	{
		// Token: 0x060037C3 RID: 14275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C3")]
		[Address(RVA = "0x2EAC580", Offset = "0x2EAB580", VA = "0x182EAC580")]
		private void OnDisable()
		{
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C4")]
		[Address(RVA = "0x2EABB60", Offset = "0x2EAAB60", VA = "0x182EABB60", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C5")]
		[Address(RVA = "0x2EAE050", Offset = "0x2EAD050", VA = "0x182EAE050")]
		private void Update()
		{
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00010488 File Offset: 0x0000E688
		[Token(Token = "0x60037C6")]
		[Address(RVA = "0x2EABE60", Offset = "0x2EAAE60", VA = "0x182EABE60", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C7")]
		[Address(RVA = "0x2EACF90", Offset = "0x2EABF90", VA = "0x182EACF90")]
		private void StartBlueprintSelectionMode()
		{
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C8")]
		[Address(RVA = "0x2EABFD0", Offset = "0x2EAAFD0", VA = "0x182EABFD0")]
		private void OnActivateTutorials(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C9")]
		[Address(RVA = "0x2EAC520", Offset = "0x2EAB520", VA = "0x182EAC520")]
		private void OnCycleForward(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037CA")]
		[Address(RVA = "0x2EAB990", Offset = "0x2EAA990", VA = "0x182EAB990")]
		private IEnumerator FlipPageForward(int forcedPage = -1)
		{
			return null;
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CB")]
		[Address(RVA = "0x2EAC3E0", Offset = "0x2EAB3E0", VA = "0x182EAC3E0")]
		private void OnCycleBackward(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037CC")]
		[Address(RVA = "0x2EAB920", Offset = "0x2EAA920", VA = "0x182EAB920")]
		private IEnumerator FlipPageBackward()
		{
			return null;
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CD")]
		[Address(RVA = "0x2EABF30", Offset = "0x2EAAF30", VA = "0x182EABF30")]
		private void JumpToCategory(int index)
		{
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CE")]
		[Address(RVA = "0x2EADBA0", Offset = "0x2EACBA0", VA = "0x182EADBA0")]
		private void UpdateBaseColorMapTexture(Material targetMaterial)
		{
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CF")]
		[Address(RVA = "0x2EACD90", Offset = "0x2EABD90", VA = "0x182EACD90")]
		private static void SetBaseColorMapTexture(Material targetMaterial, Texture2D targetTexture, List<BlueprintBookPageData> allPages)
		{
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D0")]
		[Address(RVA = "0x2EACA60", Offset = "0x2EABA60", VA = "0x182EACA60")]
		private void OnInteractWithLayout(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D1")]
		[Address(RVA = "0x2EAC100", Offset = "0x2EAB100", VA = "0x182EAC100")]
		private void OnCursorMoved(InputAction.CallbackContext context)
		{
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D2")]
		[Address(RVA = "0x2EADB10", Offset = "0x2EACB10", VA = "0x182EADB10")]
		private void SwapPageTexture()
		{
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x2EAC480", Offset = "0x2EAB480", VA = "0x182EAC480")]
		private void OnCycleForwardAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D4")]
		[Address(RVA = "0x2EAC300", Offset = "0x2EAB300", VA = "0x182EAC300")]
		private void OnCycleBackwardAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D5")]
		[Address(RVA = "0x2EAB820", Offset = "0x2EAA820", VA = "0x182EAB820")]
		private static void DelayClearRequestedMipmapLevel(List<BlueprintBookPageData> pages, int currentTextureIndex, ref float nextClearRequestedMipmapLevelTime)
		{
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D6")]
		[Address(RVA = "0x2EADC70", Offset = "0x2EACC70", VA = "0x182EADC70")]
		private void UpdatePageLocalization()
		{
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037D7")]
		[Address(RVA = "0x2EABA10", Offset = "0x2EAAA10", VA = "0x182EABA10")]
		private static string GetTranslation(string translationKey)
		{
			return null;
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D8")]
		[Address(RVA = "0x2EAE440", Offset = "0x2EAD440", VA = "0x182EAE440")]
		public BlueprintBookController()
		{
		}

		// Token: 0x04002FBD RID: 12221
		[Token(Token = "0x4002FBD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _uiAnchor;

		// Token: 0x04002FBE RID: 12222
		[Token(Token = "0x4002FBE")]
		[FieldOffset(Offset = "0x78")]
		private bool _enteringPlacementMode;

		// Token: 0x04002FBF RID: 12223
		[Token(Token = "0x4002FBF")]
		[FieldOffset(Offset = "0x80")]
		private SonsInputMapping.StructureCraftingActions _inputMapping;

		// Token: 0x04002FC0 RID: 12224
		[Token(Token = "0x4002FC0")]
		[FieldOffset(Offset = "0x88")]
		private PlayerInventory _inventory;

		// Token: 0x04002FC1 RID: 12225
		[Token(Token = "0x4002FC1")]
		[FieldOffset(Offset = "0x90")]
		private AnimatorLayersController _layersController;

		// Token: 0x04002FC2 RID: 12226
		[Token(Token = "0x4002FC2")]
		[FieldOffset(Offset = "0x98")]
		private LayerBehaviourActivator _leftArmLayerBehaviourActivator;

		// Token: 0x04002FC3 RID: 12227
		[Token(Token = "0x4002FC3")]
		[FieldOffset(Offset = "0xA0")]
		private Transform _uiTransform;

		// Token: 0x04002FC4 RID: 12228
		[Token(Token = "0x4002FC4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorMap;

		// Token: 0x04002FC5 RID: 12229
		[Token(Token = "0x4002FC5")]
		private const string BlueprintBookPageIndex = "BlueprintBookPageIndex";

		// Token: 0x04002FC6 RID: 12230
		[Token(Token = "0x4002FC6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002FC7 RID: 12231
		[Token(Token = "0x4002FC7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private TextMeshProUGUI _previousPageText;

		// Token: 0x04002FC8 RID: 12232
		[Token(Token = "0x4002FC8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private TextMeshProUGUI _nextPageText;

		// Token: 0x04002FC9 RID: 12233
		[Token(Token = "0x4002FC9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private TextMeshProUGUI _topBlueprintName;

		// Token: 0x04002FCA RID: 12234
		[Token(Token = "0x4002FCA")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private TextMeshProUGUI _bottomBlueprintName;

		// Token: 0x04002FCB RID: 12235
		[Token(Token = "0x4002FCB")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private string _pageRendererName;

		// Token: 0x04002FCC RID: 12236
		[Token(Token = "0x4002FCC")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private string _padRendererName;

		// Token: 0x04002FCD RID: 12237
		[Token(Token = "0x4002FCD")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private BlueprintBookPages _pages;

		// Token: 0x04002FCE RID: 12238
		[Token(Token = "0x4002FCE")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private List<HeldBookInteraction> _tabs;

		// Token: 0x04002FCF RID: 12239
		[Token(Token = "0x4002FCF")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private List<int> _categoryStartingPage;

		// Token: 0x04002FD0 RID: 12240
		[Token(Token = "0x4002FD0")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private List<HeldBookInteraction> _blueprintBookLayoutItems;

		// Token: 0x04002FD1 RID: 12241
		[Token(Token = "0x4002FD1")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private HeldBookInteraction _nextPage;

		// Token: 0x04002FD2 RID: 12242
		[Token(Token = "0x4002FD2")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private HeldBookInteraction _previousPage;

		// Token: 0x04002FD3 RID: 12243
		[Token(Token = "0x4002FD3")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float _cursorMouseSpeed;

		// Token: 0x04002FD4 RID: 12244
		[Token(Token = "0x4002FD4")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private float _cursorGamepadSpeed;

		// Token: 0x04002FD5 RID: 12245
		[Token(Token = "0x4002FD5")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private VirtualMouseInput _virtualMouse;

		// Token: 0x04002FD6 RID: 12246
		[Token(Token = "0x4002FD6")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private InputCursorState _inputCursorState;

		// Token: 0x04002FD7 RID: 12247
		[Token(Token = "0x4002FD7")]
		[FieldOffset(Offset = "0x128")]
		private int _currentPageIndex;

		// Token: 0x04002FD8 RID: 12248
		[Token(Token = "0x4002FD8")]
		[FieldOffset(Offset = "0x12C")]
		private bool _flippingForward;

		// Token: 0x04002FD9 RID: 12249
		[Token(Token = "0x4002FD9")]
		[FieldOffset(Offset = "0x130")]
		private Vector2 _mouseScreenPosition;

		// Token: 0x04002FDA RID: 12250
		[Token(Token = "0x4002FDA")]
		[FieldOffset(Offset = "0x138")]
		private Material _padMaterial;

		// Token: 0x04002FDB RID: 12251
		[Token(Token = "0x4002FDB")]
		[FieldOffset(Offset = "0x140")]
		private Material _pageMaterial;

		// Token: 0x04002FDC RID: 12252
		[Token(Token = "0x4002FDC")]
		[FieldOffset(Offset = "0x148")]
		private PlayerState _playerData;

		// Token: 0x04002FDD RID: 12253
		[Token(Token = "0x4002FDD")]
		[FieldOffset(Offset = "0x150")]
		private float _nextClearRequestedMipmapLevelTime;

		// Token: 0x04002FDE RID: 12254
		[Token(Token = "0x4002FDE")]
		private const string ItemsTableReferenceKey = "Items";
	}
}
