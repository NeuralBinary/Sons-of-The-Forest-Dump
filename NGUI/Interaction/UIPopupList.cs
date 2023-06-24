using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Interaction/Popup List")]
	public class UIPopupList : UIWidgetContainer
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000155")]
		public UnityEngine.Object ambigiousFont
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x26C7F90", Offset = "0x26C6590", VA = "0x1826C7F90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x26C8100", Offset = "0x26C6700", VA = "0x1826C8100")]
			set
			{
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000156")]
		[Obsolete("Use EventDelegate.Add(popup.onChange, YourCallback) instead, and UIPopupList.current.value to determine the state")]
		public UIPopupList.LegacyEvent onSelectionChange
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x1359C20", Offset = "0x1358220", VA = "0x181359C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x1359C30", Offset = "0x1358230", VA = "0x181359C30")]
			set
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x17000157")]
		public static bool isOpen
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x26C83A0", Offset = "0x26C69A0", VA = "0x1826C83A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000158")]
		public string value
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x26C8580", Offset = "0x26C6B80", VA = "0x1826C8580")]
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000159")]
		public object data
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x26C85F0", Offset = "0x26C6BF0", VA = "0x1826C85F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x1700015A")]
		public bool isColliderEnabled
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x26C86C0", Offset = "0x26C6CC0", VA = "0x1826C86C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015B")]
		[Obsolete("Use 'value' instead")]
		public string selection
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x26C88E0", Offset = "0x26C6EE0", VA = "0x1826C88E0")]
			set
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x1700015C")]
		private bool isValid
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x26C88F0", Offset = "0x26C6EF0", VA = "0x1826C88F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x1700015D")]
		private int activeFontSize
		{
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x26C8A50", Offset = "0x26C7050", VA = "0x1826C8A50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x1700015E")]
		private float activeFontScale
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x26C8BC0", Offset = "0x26C71C0", VA = "0x1826C8BC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x26C8D50", Offset = "0x26C7350", VA = "0x1826C8D50")]
		public void Clear()
		{
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x26C8DF0", Offset = "0x26C73F0", VA = "0x1826C8DF0")]
		public void AddItem(string text)
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x26C8EF0", Offset = "0x26C74F0", VA = "0x1826C8EF0")]
		public void AddItem(string text, object data)
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x26C9000", Offset = "0x26C7600", VA = "0x1826C9000")]
		public void RemoveItem(string text)
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x26C90D0", Offset = "0x26C76D0", VA = "0x1826C90D0")]
		public void RemoveItemByData(object data)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x26C91A0", Offset = "0x26C77A0", VA = "0x1826C91A0")]
		protected void TriggerCallbacks()
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x26C9450", Offset = "0x26C7A50", VA = "0x1826C9450")]
		private void OnEnable()
		{
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x26C99C0", Offset = "0x26C7FC0", VA = "0x1826C99C0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x26C9DA0", Offset = "0x26C83A0", VA = "0x1826C9DA0")]
		private void Start()
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x26CA080", Offset = "0x26C8680", VA = "0x1826CA080")]
		private void OnLocalize()
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x26CA0A0", Offset = "0x26C86A0", VA = "0x1826CA0A0")]
		protected void Highlight(UILabel lbl, bool instant)
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x26CA320", Offset = "0x26C8920", VA = "0x1826CA320", Slot = "4")]
		protected virtual Vector3 GetHighlightPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x26CA620", Offset = "0x26C8C20", VA = "0x1826CA620")]
		private IEnumerator UpdateTweenPosition()
		{
			return null;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x26CA6B0", Offset = "0x26C8CB0", VA = "0x1826CA6B0")]
		protected void OnItemHover(GameObject go, bool isOver)
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x26CA730", Offset = "0x26C8D30", VA = "0x1826CA730")]
		protected void OnItemPress(GameObject go, bool isPressed)
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x26CA8D0", Offset = "0x26C8ED0", VA = "0x1826CA8D0")]
		private void Select(UILabel lbl, bool instant)
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x26CA8E0", Offset = "0x26C8EE0", VA = "0x1826CA8E0")]
		private void OnNavigate(KeyCode key)
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x26CAB30", Offset = "0x26C9130", VA = "0x1826CAB30")]
		private void OnKey(KeyCode key)
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x26CAD30", Offset = "0x26C9330", VA = "0x1826CAD30")]
		private void OnDisable()
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x26CAD40", Offset = "0x26C9340", VA = "0x1826CAD40")]
		protected void OnSelect(bool isSelected)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x26CAD50", Offset = "0x26C9350", VA = "0x1826CAD50")]
		public static void Close()
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x26CAEB0", Offset = "0x26C94B0", VA = "0x1826CAEB0")]
		public void CloseSelf()
		{
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x26CB5D0", Offset = "0x26C9BD0", VA = "0x1826CB5D0")]
		protected void AnimateColor(UIWidget widget)
		{
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x26CB770", Offset = "0x26C9D70", VA = "0x1826CB770")]
		private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
		{
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x26CB930", Offset = "0x26C9F30", VA = "0x1826CB930")]
		protected void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
		{
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x26CBC10", Offset = "0x26CA210", VA = "0x1826CBC10")]
		protected void Animate(UIWidget widget, bool placeAbove, float bottom)
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x26CBDE0", Offset = "0x26CA3E0", VA = "0x1826CBDE0")]
		private void OnClick()
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x26CC1B0", Offset = "0x26CA7B0", VA = "0x1826CC1B0")]
		private void OnDoubleClick()
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x26CC1D0", Offset = "0x26CA7D0", VA = "0x1826CC1D0")]
		private IEnumerator CloseIfUnselected()
		{
			return null;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x26CC260", Offset = "0x26CA860", VA = "0x1826CC260", Slot = "5")]
		public virtual void Show()
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x26CE080", Offset = "0x26CC680", VA = "0x1826CE080")]
		public UIPopupList()
		{
		}

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x0")]
		public static UIPopupList current;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x8")]
		protected static GameObject mChild;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x10")]
		private static float mFadeOutComplete;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		private const float animSpeed = 0.15f;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x20")]
		public UIAtlas atlas;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x28")]
		public UIFont bitmapFont;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x30")]
		public Font trueTypeFont;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x38")]
		public int fontSize;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x3C")]
		public FontStyle fontStyle;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x40")]
		public string backgroundSprite;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x48")]
		public string highlightSprite;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x50")]
		public UIPopupList.Position position;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x54")]
		public NGUIText.Alignment alignment;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x58")]
		public List<string> items;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x60")]
		public List<object> itemData;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x68")]
		public Vector2 padding;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x70")]
		public Color textColor;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x80")]
		public Color backgroundColor;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x90")]
		public Color highlightColor;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0xA0")]
		public bool isAnimated;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0xA1")]
		public bool isLocalized;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0xA2")]
		public bool toUpper;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0xA4")]
		public UIPopupList.OpenOn openOn;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0xA8")]
		public List<EventDelegate> onChange;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		protected string mSelectedItem;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		protected UIPanel mPanel;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		protected UISprite mBackground;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		protected UISprite mHighlight;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		protected UILabel mHighlightedLabel;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[SerializeField]
		protected List<UILabel> mLabelList;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0xE0")]
		[HideInInspector]
		[SerializeField]
		protected float mBgBorder;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		protected GameObject mSelection;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		protected int mOpenFrame;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[HideInInspector]
		private GameObject eventReceiver;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[HideInInspector]
		private string functionName;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[HideInInspector]
		private float textScale;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[HideInInspector]
		private UIFont font;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private UILabel textLabel;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x120")]
		private UIPopupList.LegacyEvent mLegacyEvent;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x128")]
		[NonSerialized]
		private bool mExecuting;

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x129")]
		private bool mUseDynamicFont;

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x12A")]
		private bool mTweening;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x130")]
		public GameObject source;

		// Token: 0x020000C5 RID: 197
		[Token(Token = "0x20000C5")]
		public enum Position
		{
			// Token: 0x0400054E RID: 1358
			[Token(Token = "0x400054E")]
			Auto,
			// Token: 0x0400054F RID: 1359
			[Token(Token = "0x400054F")]
			Above,
			// Token: 0x04000550 RID: 1360
			[Token(Token = "0x4000550")]
			Below
		}

		// Token: 0x020000C6 RID: 198
		[Token(Token = "0x20000C6")]
		public enum OpenOn
		{
			// Token: 0x04000552 RID: 1362
			[Token(Token = "0x4000552")]
			ClickOrTap,
			// Token: 0x04000553 RID: 1363
			[Token(Token = "0x4000553")]
			RightClick,
			// Token: 0x04000554 RID: 1364
			[Token(Token = "0x4000554")]
			DoubleClick,
			// Token: 0x04000555 RID: 1365
			[Token(Token = "0x4000555")]
			Manual
		}

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x0600072D RID: 1837
		[Token(Token = "0x20000C7")]
		public delegate void LegacyEvent(string val);
	}
}
