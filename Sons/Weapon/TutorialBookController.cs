using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Crafting;
using Sons.Input;
using Sons.Inventory;
using Sons.Player;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace Sons.Weapon
{
	// Token: 0x020008EA RID: 2282
	[Token(Token = "0x20008EA")]
	[AddComponentMenu("Sons/Weapon/TutorialBookController")]
	public class TutorialBookController : HeldControllerBase
	{
		// Token: 0x06004139 RID: 16697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004139")]
		[Address(RVA = "0x360C2E0", Offset = "0x360A8E0", VA = "0x18360C2E0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413A")]
		[Address(RVA = "0x360CBF0", Offset = "0x360B1F0", VA = "0x18360CBF0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413B")]
		[Address(RVA = "0x360DFB0", Offset = "0x360C5B0", VA = "0x18360DFB0")]
		private void UpdateBaseColorMapTexture(Material targetMaterial)
		{
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413C")]
		[Address(RVA = "0x360E0C0", Offset = "0x360C6C0", VA = "0x18360E0C0")]
		private static void SetBaseColorMapTexture(Material targetMaterial, Texture2D targetTexture, List<TutorialBookController.TutorialPageData> otherPages)
		{
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413D")]
		[Address(RVA = "0x360E440", Offset = "0x360CA40", VA = "0x18360E440")]
		private void Update()
		{
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413E")]
		[Address(RVA = "0x360E890", Offset = "0x360CE90", VA = "0x18360E890")]
		private static void DelayClearRequestedMipmapLevel(IReadOnlyList<TutorialBookController.TutorialPageData> pages, int currentTextureIndex, ref float nextClearRequestedMipmapLevelTime)
		{
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413F")]
		[Address(RVA = "0x360EAC0", Offset = "0x360D0C0", VA = "0x18360EAC0")]
		private void OnCycleForward(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x06004140 RID: 16704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004140")]
		[Address(RVA = "0x360EB20", Offset = "0x360D120", VA = "0x18360EB20")]
		private IEnumerator FlipPageForward(int forcedPage = -1)
		{
			return null;
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004141")]
		[Address(RVA = "0x360EBE0", Offset = "0x360D1E0", VA = "0x18360EBE0")]
		private void OnCycleBackward(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004142")]
		[Address(RVA = "0x360ECB0", Offset = "0x360D2B0", VA = "0x18360ECB0")]
		private void OnCursorMoved(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004143")]
		[Address(RVA = "0x360EFE0", Offset = "0x360D5E0", VA = "0x18360EFE0")]
		private void OnActivateSCREW(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004144")]
		[Address(RVA = "0x360F0F0", Offset = "0x360D6F0", VA = "0x18360F0F0")]
		private IEnumerator FlipPageBackward()
		{
			return null;
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004145")]
		[Address(RVA = "0x360F180", Offset = "0x360D780", VA = "0x18360F180")]
		private void SwapPageTexture()
		{
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004146")]
		[Address(RVA = "0x360F260", Offset = "0x360D860", VA = "0x18360F260")]
		private void OnCycleForwardAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004147")]
		[Address(RVA = "0x360F300", Offset = "0x360D900", VA = "0x18360F300")]
		private void OnCycleBackwardAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x00013EF0 File Offset: 0x000120F0
		[Token(Token = "0x6004148")]
		[Address(RVA = "0x360F420", Offset = "0x360DA20", VA = "0x18360F420", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004149")]
		[Address(RVA = "0x360F540", Offset = "0x360DB40", VA = "0x18360F540")]
		private void UpdatePageLocalization()
		{
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414A")]
		[Address(RVA = "0x360F750", Offset = "0x360DD50", VA = "0x18360F750")]
		private static string GetTranslation(string translationKey)
		{
			return null;
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414B")]
		[Address(RVA = "0x360F940", Offset = "0x360DF40", VA = "0x18360F940")]
		private void OnInteractWithLayout(HeldBookInteraction heldBookInteraction)
		{
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414C")]
		[Address(RVA = "0x360FB20", Offset = "0x360E120", VA = "0x18360FB20")]
		private void JumpToCategory(int index)
		{
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414D")]
		[Address(RVA = "0x360FBE0", Offset = "0x360E1E0", VA = "0x18360FBE0")]
		public TutorialBookController()
		{
		}

		// Token: 0x040035FB RID: 13819
		[Token(Token = "0x40035FB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorMap;

		// Token: 0x040035FC RID: 13820
		[Token(Token = "0x40035FC")]
		private const string TutorialBookPageIndex = "TutorialBookPageIndex";

		// Token: 0x040035FD RID: 13821
		[Token(Token = "0x40035FD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _uiAnchor;

		// Token: 0x040035FE RID: 13822
		[Token(Token = "0x40035FE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040035FF RID: 13823
		[Token(Token = "0x40035FF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI _previousPageText;

		// Token: 0x04003600 RID: 13824
		[Token(Token = "0x4003600")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI _nextPageText;

		// Token: 0x04003601 RID: 13825
		[Token(Token = "0x4003601")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _pageRendererName;

		// Token: 0x04003602 RID: 13826
		[Token(Token = "0x4003602")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _padRendererName;

		// Token: 0x04003603 RID: 13827
		[Token(Token = "0x4003603")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<TutorialBookController.TutorialPageData> _pages;

		// Token: 0x04003604 RID: 13828
		[Token(Token = "0x4003604")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<HeldBookInteraction> _tabs;

		// Token: 0x04003605 RID: 13829
		[Token(Token = "0x4003605")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<int> _categoryStartingPage;

		// Token: 0x04003606 RID: 13830
		[Token(Token = "0x4003606")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private HeldBookInteraction _nextPage;

		// Token: 0x04003607 RID: 13831
		[Token(Token = "0x4003607")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private HeldBookInteraction _previousPage;

		// Token: 0x04003608 RID: 13832
		[Token(Token = "0x4003608")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _cursorMouseSpeed;

		// Token: 0x04003609 RID: 13833
		[Token(Token = "0x4003609")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float _cursorGamepadSpeed;

		// Token: 0x0400360A RID: 13834
		[Token(Token = "0x400360A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private VirtualMouseInput _virtualMouse;

		// Token: 0x0400360B RID: 13835
		[Token(Token = "0x400360B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private InputCursorState _inputCursorState;

		// Token: 0x0400360C RID: 13836
		[Token(Token = "0x400360C")]
		[FieldOffset(Offset = "0xD8")]
		private Vector2 _mouseScreenPosition;

		// Token: 0x0400360D RID: 13837
		[Token(Token = "0x400360D")]
		[FieldOffset(Offset = "0xE0")]
		private SonsInputMapping.StructureCraftingActions _inputMapping;

		// Token: 0x0400360E RID: 13838
		[Token(Token = "0x400360E")]
		[FieldOffset(Offset = "0xE8")]
		private int _currentPageIndex;

		// Token: 0x0400360F RID: 13839
		[Token(Token = "0x400360F")]
		[FieldOffset(Offset = "0xF0")]
		private Material _pageMaterial;

		// Token: 0x04003610 RID: 13840
		[Token(Token = "0x4003610")]
		[FieldOffset(Offset = "0xF8")]
		private Material _padMaterial;

		// Token: 0x04003611 RID: 13841
		[Token(Token = "0x4003611")]
		[FieldOffset(Offset = "0x100")]
		private bool _flippingForward;

		// Token: 0x04003612 RID: 13842
		[Token(Token = "0x4003612")]
		[FieldOffset(Offset = "0x108")]
		private PlayerState _playerData;

		// Token: 0x04003613 RID: 13843
		[Token(Token = "0x4003613")]
		[FieldOffset(Offset = "0x110")]
		private Transform _uiTransform;

		// Token: 0x04003614 RID: 13844
		[Token(Token = "0x4003614")]
		[FieldOffset(Offset = "0x118")]
		private float _nextClearRequestedMipmapLevelTime;

		// Token: 0x04003615 RID: 13845
		[Token(Token = "0x4003615")]
		internal const float DelayBeforeClearRequestedMipmapLevel = 0.4f;

		// Token: 0x04003616 RID: 13846
		[Token(Token = "0x4003616")]
		private const string ItemsTableReferenceKey = "Items";

		// Token: 0x020008EB RID: 2283
		[Token(Token = "0x20008EB")]
		[Serializable]
		private class TutorialPageData
		{
			// Token: 0x0600414F RID: 16719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600414F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public TutorialPageData()
			{
			}

			// Token: 0x04003617 RID: 13847
			[Token(Token = "0x4003617")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public Texture2D _texture;

			// Token: 0x04003618 RID: 13848
			[Token(Token = "0x4003618")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public string _pageTitleLocalizationId;
		}
	}
}
