using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Crafting;
using Sons.Input;
using Sons.Player;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace Sons.Weapon
{
	// Token: 0x02000878 RID: 2168
	[Token(Token = "0x2000878")]
	[AddComponentMenu("Sons/Weapon/TutorialBookController")]
	public class TutorialBookController : HeldControllerBase
	{
		// Token: 0x06003A11 RID: 14865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A11")]
		[Address(RVA = "0x2F0ADF0", Offset = "0x2F09DF0", VA = "0x182F0ADF0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A12")]
		[Address(RVA = "0x2F09B00", Offset = "0x2F08B00", VA = "0x182F09B00", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A13")]
		[Address(RVA = "0x2F0B6F0", Offset = "0x2F0A6F0", VA = "0x182F0B6F0")]
		private void UpdateBaseColorMapTexture(Material targetMaterial)
		{
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A14")]
		[Address(RVA = "0x2F0B460", Offset = "0x2F0A460", VA = "0x182F0B460")]
		private static void SetBaseColorMapTexture(Material targetMaterial, Texture2D targetTexture, List<TutorialBookController.TutorialPageData> otherPages)
		{
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A15")]
		[Address(RVA = "0x2F0B960", Offset = "0x2F0A960", VA = "0x182F0B960")]
		private void Update()
		{
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A16")]
		[Address(RVA = "0x2F096D0", Offset = "0x2F086D0", VA = "0x182F096D0")]
		private static void DelayClearRequestedMipmapLevel(IReadOnlyList<TutorialBookController.TutorialPageData> pages, int currentTextureIndex, ref float nextClearRequestedMipmapLevelTime)
		{
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A17")]
		[Address(RVA = "0x2F0AD90", Offset = "0x2F09D90", VA = "0x182F0AD90")]
		private void OnCycleForward(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A18")]
		[Address(RVA = "0x2F098E0", Offset = "0x2F088E0", VA = "0x182F098E0")]
		private IEnumerator FlipPageForward(int forcedPage = -1)
		{
			return null;
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A19")]
		[Address(RVA = "0x2F0AC50", Offset = "0x2F09C50", VA = "0x182F0AC50")]
		private void OnCycleBackward(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1A")]
		[Address(RVA = "0x2F0A960", Offset = "0x2F09960", VA = "0x182F0A960")]
		private void OnCursorMoved(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1B")]
		[Address(RVA = "0x2F0A810", Offset = "0x2F09810", VA = "0x182F0A810")]
		private void OnActivateSCREW(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1C")]
		[Address(RVA = "0x2F09870", Offset = "0x2F08870", VA = "0x182F09870")]
		private IEnumerator FlipPageBackward()
		{
			return null;
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1D")]
		[Address(RVA = "0x2F0B660", Offset = "0x2F0A660", VA = "0x182F0B660")]
		private void SwapPageTexture()
		{
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1E")]
		[Address(RVA = "0x2F0ACF0", Offset = "0x2F09CF0", VA = "0x182F0ACF0")]
		private void OnCycleForwardAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1F")]
		[Address(RVA = "0x2F0AB60", Offset = "0x2F09B60", VA = "0x182F0AB60")]
		private void OnCycleBackwardAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00011058 File Offset: 0x0000F258
		[Token(Token = "0x6003A20")]
		[Address(RVA = "0x2F0A6F0", Offset = "0x2F096F0", VA = "0x182F0A6F0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A21")]
		[Address(RVA = "0x2F0B7B0", Offset = "0x2F0A7B0", VA = "0x182F0B7B0")]
		private void UpdatePageLocalization()
		{
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A22")]
		[Address(RVA = "0x2F09960", Offset = "0x2F08960", VA = "0x182F09960")]
		private static string GetTranslation(string translationKey)
		{
			return null;
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A23")]
		[Address(RVA = "0x2F0B2D0", Offset = "0x2F0A2D0", VA = "0x182F0B2D0")]
		private void OnInteractWithLayout(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A24")]
		[Address(RVA = "0x2F0A770", Offset = "0x2F09770", VA = "0x182F0A770")]
		private void JumpToCategory(int index)
		{
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A25")]
		[Address(RVA = "0x2F0BD10", Offset = "0x2F0AD10", VA = "0x182F0BD10")]
		public TutorialBookController()
		{
		}

		// Token: 0x04003131 RID: 12593
		[Token(Token = "0x4003131")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorMap;

		// Token: 0x04003132 RID: 12594
		[Token(Token = "0x4003132")]
		private const string TutorialBookPageIndex = "TutorialBookPageIndex";

		// Token: 0x04003133 RID: 12595
		[Token(Token = "0x4003133")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _uiAnchor;

		// Token: 0x04003134 RID: 12596
		[Token(Token = "0x4003134")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04003135 RID: 12597
		[Token(Token = "0x4003135")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI _previousPageText;

		// Token: 0x04003136 RID: 12598
		[Token(Token = "0x4003136")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TextMeshProUGUI _nextPageText;

		// Token: 0x04003137 RID: 12599
		[Token(Token = "0x4003137")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _pageRendererName;

		// Token: 0x04003138 RID: 12600
		[Token(Token = "0x4003138")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _padRendererName;

		// Token: 0x04003139 RID: 12601
		[Token(Token = "0x4003139")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<TutorialBookController.TutorialPageData> _pages;

		// Token: 0x0400313A RID: 12602
		[Token(Token = "0x400313A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<HeldBookInteraction> _tabs;

		// Token: 0x0400313B RID: 12603
		[Token(Token = "0x400313B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<int> _categoryStartingPage;

		// Token: 0x0400313C RID: 12604
		[Token(Token = "0x400313C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private HeldBookInteraction _nextPage;

		// Token: 0x0400313D RID: 12605
		[Token(Token = "0x400313D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private HeldBookInteraction _previousPage;

		// Token: 0x0400313E RID: 12606
		[Token(Token = "0x400313E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _cursorMouseSpeed;

		// Token: 0x0400313F RID: 12607
		[Token(Token = "0x400313F")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float _cursorGamepadSpeed;

		// Token: 0x04003140 RID: 12608
		[Token(Token = "0x4003140")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private VirtualMouseInput _virtualMouse;

		// Token: 0x04003141 RID: 12609
		[Token(Token = "0x4003141")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private InputCursorState _inputCursorState;

		// Token: 0x04003142 RID: 12610
		[Token(Token = "0x4003142")]
		[FieldOffset(Offset = "0xE0")]
		private Vector2 _mouseScreenPosition;

		// Token: 0x04003143 RID: 12611
		[Token(Token = "0x4003143")]
		[FieldOffset(Offset = "0xE8")]
		private SonsInputMapping.StructureCraftingActions _inputMapping;

		// Token: 0x04003144 RID: 12612
		[Token(Token = "0x4003144")]
		[FieldOffset(Offset = "0xF0")]
		private int _currentPageIndex;

		// Token: 0x04003145 RID: 12613
		[Token(Token = "0x4003145")]
		[FieldOffset(Offset = "0xF8")]
		private Material _pageMaterial;

		// Token: 0x04003146 RID: 12614
		[Token(Token = "0x4003146")]
		[FieldOffset(Offset = "0x100")]
		private Material _padMaterial;

		// Token: 0x04003147 RID: 12615
		[Token(Token = "0x4003147")]
		[FieldOffset(Offset = "0x108")]
		private bool _flippingForward;

		// Token: 0x04003148 RID: 12616
		[Token(Token = "0x4003148")]
		[FieldOffset(Offset = "0x110")]
		private PlayerState _playerData;

		// Token: 0x04003149 RID: 12617
		[Token(Token = "0x4003149")]
		[FieldOffset(Offset = "0x118")]
		private Transform _uiTransform;

		// Token: 0x0400314A RID: 12618
		[Token(Token = "0x400314A")]
		[FieldOffset(Offset = "0x120")]
		private float _nextClearRequestedMipmapLevelTime;

		// Token: 0x0400314B RID: 12619
		[Token(Token = "0x400314B")]
		internal const float DelayBeforeClearRequestedMipmapLevel = 0.4f;

		// Token: 0x0400314C RID: 12620
		[Token(Token = "0x400314C")]
		private const string ItemsTableReferenceKey = "Items";

		// Token: 0x02000879 RID: 2169
		[Token(Token = "0x2000879")]
		[Serializable]
		private class TutorialPageData
		{
			// Token: 0x06003A27 RID: 14887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A27")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public TutorialPageData()
			{
			}

			// Token: 0x0400314D RID: 12621
			[Token(Token = "0x400314D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public Texture2D _texture;

			// Token: 0x0400314E RID: 12622
			[Token(Token = "0x400314E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public string _pageTitleLocalizationId;
		}
	}
}
