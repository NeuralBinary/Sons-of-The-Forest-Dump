using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public abstract class OptionsGui : MonoBehaviour
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event Action OnCachedChangesEvent
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x3046D50", Offset = "0x3045350", VA = "0x183046D50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x3046E40", Offset = "0x3045440", VA = "0x183046E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x3046F30", Offset = "0x3045530", VA = "0x183046F30")]
		private void RefreshFirstSelected()
		{
		}

		// Token: 0x06000191 RID: 401
		[Token(Token = "0x6000191")]
		public abstract MenuOptionGui[] GetMenuOptionsOrder();

		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x30472B0", Offset = "0x30458B0", VA = "0x1830472B0")]
		public void AddDynamicMenuOption(MenuOptionGui menuOption)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x3047350", Offset = "0x3045950", VA = "0x183047350")]
		private void OnEnable()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x30476B0", Offset = "0x3045CB0", VA = "0x1830476B0")]
		public void OnCachedChanges()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x30476D0", Offset = "0x3045CD0", VA = "0x1830476D0")]
		private void OnChangedAudioEvent(string eventPath)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		internal virtual void OnPreEnable()
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x6000197")]
		internal bool TryGet<T>(out T outVal) where T : MenuOptionGui
		{
			return default(bool);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000198")]
		internal T Get<T>() where T : MenuOptionGui
		{
			return null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		internal virtual void OnPostEnable()
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		internal virtual void OnPreDisable()
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x3047720", Offset = "0x3045D20", VA = "0x183047720")]
		private void OnDisable()
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		internal virtual void OnPostDisable()
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x3047930", Offset = "0x3045F30", VA = "0x183047930")]
		private void Update()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		internal virtual void OnPostUpdate()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x3047A80", Offset = "0x3046080", VA = "0x183047A80")]
		public void ApplyCachedChanged()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x3047BE0", Offset = "0x30461E0", VA = "0x183047BE0")]
		public bool HasCachedChanges()
		{
			return default(bool);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x3047D40", Offset = "0x3046340", VA = "0x183047D40")]
		public void RevertCachedChanges()
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x3047E90", Offset = "0x3046490", VA = "0x183047E90")]
		private void UpdateLastSelected(GameObject currentSelected)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x3048040", Offset = "0x3046640", VA = "0x183048040")]
		private void RefreshToolTip(List<GameObject> potentialMatches)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x3048440", Offset = "0x3046A40", VA = "0x183048440")]
		private void GetTooltipPotentialMatches(ref List<GameObject> potentialMatches)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x3048750", Offset = "0x3046D50", VA = "0x183048750")]
		private void GetHoveredUiObjects(List<GameObject> hoveredObjects)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x3048A90", Offset = "0x3047090", VA = "0x183048A90")]
		public void SetActive(bool value)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x3048C50", Offset = "0x3047250", VA = "0x183048C50")]
		private void DoFirstSelection()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x3048E00", Offset = "0x3047400", VA = "0x183048E00")]
		private GameObject GetFirstSelectGameObject()
		{
			return null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x3049010", Offset = "0x3047610", VA = "0x183049010")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x3049110", Offset = "0x3047710", VA = "0x183049110")]
		public void SetSelectedAudioEvent(FmodEmitterBuffer selectedAudioEvent)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x3049270", Offset = "0x3047870", VA = "0x183049270")]
		public void FindAllDefaultValues(Dictionary<string, object> defaults)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x30496A0", Offset = "0x3047CA0", VA = "0x1830496A0")]
		protected OptionsGui()
		{
		}

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GraphicRaycaster _graphicsRaycaster;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_Text _groupLabel;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private OptionGuiTooltipController _tooltipController;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _groupButton;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _groupParent;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _firstSelected;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent<string> _changedAudioEventCallback;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeReference]
		private List<MenuOptionGui> _menuOptions;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _lastSelected;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> _currentTooltipPotentialMatches;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x70")]
		private List<RaycastResult> _raycastResults;
	}
}
