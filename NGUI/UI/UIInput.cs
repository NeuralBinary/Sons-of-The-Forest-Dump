using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[AddComponentMenu("NGUI/UI/Input Field")]
	public class UIInput : MonoBehaviour
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public string defaultText
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x26316C0", Offset = "0x262FCC0", VA = "0x1826316C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x2631700", Offset = "0x262FD00", VA = "0x182631700")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x1700003F")]
		public bool inputShouldBeHidden
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x2631790", Offset = "0x262FD90", VA = "0x182631790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		[Obsolete("Use UIInput.value instead")]
		public string text
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2631890", Offset = "0x262FE90", VA = "0x182631890")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x26318D0", Offset = "0x262FED0", VA = "0x1826318D0")]
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public string value
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x2631890", Offset = "0x262FE90", VA = "0x182631890")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x26318E0", Offset = "0x262FEE0", VA = "0x1826318E0")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		[Obsolete("Use UIInput.isSelected instead")]
		public bool selected
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x2631B60", Offset = "0x2630160", VA = "0x182631B60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x2631B70", Offset = "0x2630170", VA = "0x182631B70")]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public bool isSelected
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x2631B80", Offset = "0x2630180", VA = "0x182631B80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2631CE0", Offset = "0x26302E0", VA = "0x182631CE0")]
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002688 File Offset: 0x00000888
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public int cursorPosition
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x2631DC0", Offset = "0x26303C0", VA = "0x182631DC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x2631E10", Offset = "0x2630410", VA = "0x182631E10")]
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000026A0 File Offset: 0x000008A0
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public int selectionStart
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x2631E50", Offset = "0x2630450", VA = "0x182631E50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x2631EA0", Offset = "0x26304A0", VA = "0x182631EA0")]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public int selectionEnd
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x2631DC0", Offset = "0x26303C0", VA = "0x182631DC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x2631E10", Offset = "0x2630410", VA = "0x182631E10")]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000047")]
		public UITexture caret
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2631EE0", Offset = "0x26304E0", VA = "0x182631EE0")]
		public string Validate(string val)
		{
			return null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x26320F0", Offset = "0x26306F0", VA = "0x1826320F0")]
		private void Start()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2632560", Offset = "0x2630B60", VA = "0x182632560")]
		protected void Init()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x26327D0", Offset = "0x2630DD0", VA = "0x1826327D0")]
		protected void SaveToPlayerPrefs(string val)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2632850", Offset = "0x2630E50", VA = "0x182632850", Slot = "4")]
		protected virtual void OnSelect(bool isSelected)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2632B20", Offset = "0x2631120", VA = "0x182632B20")]
		protected void OnSelectEvent()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2632D40", Offset = "0x2631340", VA = "0x182632D40")]
		protected void OnDeselectEvent()
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2633020", Offset = "0x2631620", VA = "0x182633020", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2633DC0", Offset = "0x26323C0", VA = "0x182633DC0")]
		private void OnKey(KeyCode key)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x26340F0", Offset = "0x26326F0", VA = "0x1826340F0")]
		protected void DoBackspace()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2634170", Offset = "0x2632770", VA = "0x182634170", Slot = "6")]
		public virtual bool ProcessEvent(Event ev)
		{
			return default(bool);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2634B30", Offset = "0x2633130", VA = "0x182634B30", Slot = "7")]
		protected virtual void Insert(string text)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2634F70", Offset = "0x2633570", VA = "0x182634F70")]
		protected string GetLeftText()
		{
			return null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2634FE0", Offset = "0x26335E0", VA = "0x182634FE0")]
		protected string GetRightText()
		{
			return null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2635050", Offset = "0x2633650", VA = "0x182635050")]
		protected string GetSelection()
		{
			return null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x26350C0", Offset = "0x26336C0", VA = "0x1826350C0")]
		protected int GetCharUnderMouse()
		{
			return 0;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x26352E0", Offset = "0x26338E0", VA = "0x1826352E0", Slot = "8")]
		protected virtual void OnPress(bool isPressed)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2635480", Offset = "0x2633A80", VA = "0x182635480", Slot = "9")]
		protected virtual void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0xA508B0", Offset = "0xA4EEB0", VA = "0x180A508B0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x26355C0", Offset = "0x2633BC0", VA = "0x1826355C0", Slot = "10")]
		protected virtual void Cleanup()
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x26358C0", Offset = "0x2633EC0", VA = "0x1826358C0")]
		public void Submit()
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2635C00", Offset = "0x2634200", VA = "0x182635C00")]
		public void UpdateLabel()
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2636D70", Offset = "0x2635370", VA = "0x182636D70")]
		protected void SetPivotToLeft()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2636DD0", Offset = "0x26353D0", VA = "0x182636DD0")]
		protected void SetPivotToRight()
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2636E40", Offset = "0x2635440", VA = "0x182636E40")]
		protected void RestoreLabelPivot()
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2636F20", Offset = "0x2635520", VA = "0x182636F20")]
		protected char Validate(string text, int pos, char ch)
		{
			return '\0';
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2637250", Offset = "0x2635850", VA = "0x182637250")]
		protected void ExecuteOnChange()
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x26374A0", Offset = "0x2635AA0", VA = "0x1826374A0")]
		public void RemoveFocus()
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2637500", Offset = "0x2635B00", VA = "0x182637500")]
		public void SaveValue()
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2637580", Offset = "0x2635B80", VA = "0x182637580")]
		public void LoadValue()
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x26376D0", Offset = "0x2635CD0", VA = "0x1826376D0")]
		public UIInput()
		{
		}

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x0")]
		public static UIInput current;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x8")]
		public static UIInput selection;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x20")]
		public UILabel label;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x28")]
		public UIInput.InputType inputType;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x2C")]
		public UIInput.OnReturnKey onReturnKey;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x30")]
		public UIInput.KeyboardType keyboardType;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x34")]
		public bool hideInput;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x35")]
		[NonSerialized]
		public bool selectAllTextOnFocus;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x38")]
		public UIInput.Validation validation;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x3C")]
		public int characterLimit;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x40")]
		public string savedAs;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		private GameObject selectOnTab;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x50")]
		public Color activeTextColor;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x60")]
		public Color caretColor;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x70")]
		public Color selectionColor;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x80")]
		public List<EventDelegate> onSubmit;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x88")]
		public List<EventDelegate> onChange;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x90")]
		public UIInput.OnValidate onValidate;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		protected string mValue;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		protected string mDefaultText;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		protected Color mDefaultColor;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		protected float mPosition;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0xBC")]
		[NonSerialized]
		protected bool mDoInit;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		protected UIWidget.Pivot mPivot;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xC4")]
		[NonSerialized]
		protected bool mLoadSavedValue;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x10")]
		protected static int mDrawStart;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x18")]
		protected static string mLastIME;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		protected int mSelectionStart;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xCC")]
		[NonSerialized]
		protected int mSelectionEnd;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		protected UITexture mHighlight;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		protected UITexture mCaret;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xE0")]
		[NonSerialized]
		protected Texture2D mBlankTex;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		protected float mNextBlink;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xEC")]
		[NonSerialized]
		protected float mLastAlpha;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		protected string mCached;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0xF8")]
		[NonSerialized]
		protected int mSelectMe;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0xFC")]
		[NonSerialized]
		protected int mSelectTime;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x100")]
		[NonSerialized]
		private UIInputOnGUI mOnGUI;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x108")]
		[NonSerialized]
		private UICamera mCam;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x20")]
		private static int mIgnoreKey;

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		public enum InputType
		{
			// Token: 0x04000110 RID: 272
			[Token(Token = "0x4000110")]
			Standard,
			// Token: 0x04000111 RID: 273
			[Token(Token = "0x4000111")]
			AutoCorrect,
			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			Password
		}

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		public enum Validation
		{
			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			None,
			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			Integer,
			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			Float,
			// Token: 0x04000117 RID: 279
			[Token(Token = "0x4000117")]
			Alphanumeric,
			// Token: 0x04000118 RID: 280
			[Token(Token = "0x4000118")]
			Username,
			// Token: 0x04000119 RID: 281
			[Token(Token = "0x4000119")]
			Name,
			// Token: 0x0400011A RID: 282
			[Token(Token = "0x400011A")]
			Filename
		}

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		public enum KeyboardType
		{
			// Token: 0x0400011C RID: 284
			[Token(Token = "0x400011C")]
			Default,
			// Token: 0x0400011D RID: 285
			[Token(Token = "0x400011D")]
			ASCIICapable,
			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			NumbersAndPunctuation,
			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			URL,
			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			NumberPad,
			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			PhonePad,
			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			NamePhonePad,
			// Token: 0x04000123 RID: 291
			[Token(Token = "0x4000123")]
			EmailAddress
		}

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		public enum OnReturnKey
		{
			// Token: 0x04000125 RID: 293
			[Token(Token = "0x4000125")]
			Default,
			// Token: 0x04000126 RID: 294
			[Token(Token = "0x4000126")]
			Submit,
			// Token: 0x04000127 RID: 295
			[Token(Token = "0x4000127")]
			NewLine
		}

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000138 RID: 312
		[Token(Token = "0x200002C")]
		public delegate char OnValidate(string text, int charIndex, char addedChar);
	}
}
