using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Input;
using TMPro;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public class RobbyWorldUi : MonoBehaviour
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x300DBC0", Offset = "0x300C1C0", VA = "0x18300DBC0")]
		private void Awake()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x300DDC0", Offset = "0x300C3C0", VA = "0x18300DDC0")]
		public void DisableUI()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x300DF20", Offset = "0x300C520", VA = "0x18300DF20")]
		private void AddCarouselMenu(int menuId)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x300E230", Offset = "0x300C830", VA = "0x18300E230")]
		private void OnValidate()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
		public Animator GetAnimator()
		{
			return null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x300E320", Offset = "0x300C920", VA = "0x18300E320")]
		public void Show(bool show)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
		public void SetOrderFinishedAction(Action finishedAction)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
		public void SetOrderCanceledAction(Action canceledAction)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x300E6C0", Offset = "0x300CCC0", VA = "0x18300E6C0")]
		public void ClearMenu()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x300E920", Offset = "0x300CF20", VA = "0x18300E920")]
		public void ClearSubMenu(int carouselId)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x300E9E0", Offset = "0x300CFE0", VA = "0x18300E9E0")]
		private int GetPreviousMenu(int menuId)
		{
			return 0;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x300EC00", Offset = "0x300D200", VA = "0x18300EC00")]
		private int GetPlacement(int menuId)
		{
			return 0;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x300EC50", Offset = "0x300D250", VA = "0x18300EC50")]
		public void SetAndText(string text)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x300EC80", Offset = "0x300D280", VA = "0x18300EC80")]
		public void AddMenuItem(int carouselId, int optionId, string itemName, int nextId = -1)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x300EDF0", Offset = "0x300D3F0", VA = "0x18300EDF0")]
		public int GetSelection(int carouselId)
		{
			return 0;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x300EE90", Offset = "0x300D490", VA = "0x18300EE90")]
		private void SetSelectedCarousel(int newSelected)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x300EED0", Offset = "0x300D4D0", VA = "0x18300EED0")]
		private void UpdateVisuals()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x300F670", Offset = "0x300DC70", VA = "0x18300F670")]
		private void ShowGuiPrompts()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x300F720", Offset = "0x300DD20", VA = "0x18300F720")]
		private void HideGuiPrompts()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x300F850", Offset = "0x300DE50", VA = "0x18300F850")]
		public TextCarousel SelectedCarousel()
		{
			return null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x300F8B0", Offset = "0x300DEB0", VA = "0x18300F8B0")]
		private bool IsSelectedOrPrevious(int testCarousel)
		{
			return default(bool);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x300F960", Offset = "0x300DF60", VA = "0x18300F960")]
		public bool SelectNextCarousel()
		{
			return default(bool);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x300FA80", Offset = "0x300E080", VA = "0x18300FA80")]
		public void SelectPreviousCarousel()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x300FB60", Offset = "0x300E160", VA = "0x18300FB60")]
		public void HandlePlayerInput()
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x3010130", Offset = "0x300E730", VA = "0x183010130")]
		public void Update()
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x3010150", Offset = "0x300E750", VA = "0x183010150")]
		private void OnStartClose()
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x30102A0", Offset = "0x300E8A0", VA = "0x1830102A0")]
		public void OnOrderFinished()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x30102D0", Offset = "0x300E8D0", VA = "0x1830102D0")]
		public void OnOrderCanceled()
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x3010300", Offset = "0x300E900", VA = "0x183010300")]
		public RobbyWorldUi()
		{
		}

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextCarousel _carouselTemplate1;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextCarousel _carouselTemplate2;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextCarousel _carouselTemplate3;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_Text _andText;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RobbyGuiPrompts _guiPrompts;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _showPromptsDelay;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _screenButtonsId;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _holdAxisCooldown;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x70")]
		private Action _onOrderFinished;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x78")]
		private Action _onOrderCanceled;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x80")]
		private float _lastNextPressTime;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x84")]
		private bool _initialConfirmHold;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x85")]
		private bool _closing;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x88")]
		private InputSystem.Action _backAction;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x98")]
		private InputSystem.Action _confirmAction;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xA8")]
		public Action<int> PreShowCarousel;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<int> _previousMenus;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0xB8")]
		private readonly Dictionary<int, RobbyWorldUi.MenuInfo> _carouselMenus;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0xC0")]
		private int _selectedCarousel;

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		private struct MenuInfo
		{
			// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x3010660", Offset = "0x300EC60", VA = "0x183010660")]
			public MenuInfo(TextCarousel carousel)
			{
			}

			// Token: 0x06000131 RID: 305 RVA: 0x00002340 File Offset: 0x00000540
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x3010780", Offset = "0x300ED80", VA = "0x183010780")]
			public int GetNextMenu()
			{
				return 0;
			}

			// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x3010850", Offset = "0x300EE50", VA = "0x183010850")]
			public void Clear()
			{
			}

			// Token: 0x04000136 RID: 310
			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x0")]
			public TextCarousel _carousel;

			// Token: 0x04000137 RID: 311
			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x8")]
			public List<int> _nextMenus;
		}
	}
}
