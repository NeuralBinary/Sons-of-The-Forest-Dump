using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	[AddComponentMenu("NGUI/Interaction/Button Color")]
	[ExecuteInEditMode]
	public class UIButtonColor : UIWidgetContainer
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x000044B8 File Offset: 0x000026B8
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000146")]
		public UIButtonColor.State state
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xAFF2D0", Offset = "0xAFD8D0", VA = "0x180AFF2D0")]
			get
			{
				return UIButtonColor.State.Normal;
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x26AB5A0", Offset = "0x26A9BA0", VA = "0x1826AB5A0")]
			set
			{
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000044D0 File Offset: 0x000026D0
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000147")]
		public Color defaultColor
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x26AB5C0", Offset = "0x26A9BC0", VA = "0x1826AB5C0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x26AB600", Offset = "0x26A9C00", VA = "0x1826AB600")]
			set
			{
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000044E8 File Offset: 0x000026E8
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000148")]
		public virtual bool isEnabled
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x2612650", Offset = "0x2610C50", VA = "0x182612650", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x26AB660", Offset = "0x26A9C60", VA = "0x1826AB660", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x26AB6C0", Offset = "0x26A9CC0", VA = "0x1826AB6C0")]
		public void ResetDefaultColor()
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x26AB720", Offset = "0x26A9D20", VA = "0x1826AB720")]
		public void CacheDefaultColor()
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x26AB740", Offset = "0x26A9D40", VA = "0x1826AB740")]
		private void Start()
		{
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x26AB7A0", Offset = "0x26A9DA0", VA = "0x1826AB7A0", Slot = "6")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x26ABD80", Offset = "0x26AA380", VA = "0x1826ABD80", Slot = "7")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x26AC160", Offset = "0x26AA760", VA = "0x1826AC160", Slot = "8")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x26AC320", Offset = "0x26AA920", VA = "0x1826AC320", Slot = "9")]
		protected virtual void OnHover(bool isOver)
		{
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x26AC440", Offset = "0x26AAA40", VA = "0x1826AC440", Slot = "10")]
		protected virtual void OnPress(bool isPressed)
		{
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x26AC810", Offset = "0x26AAE10", VA = "0x1826AC810", Slot = "11")]
		protected virtual void OnDragOver()
		{
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x26AC920", Offset = "0x26AAF20", VA = "0x1826AC920", Slot = "12")]
		protected virtual void OnDragOut()
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x26ACA30", Offset = "0x26AB030", VA = "0x1826ACA30", Slot = "13")]
		public virtual void SetState(UIButtonColor.State state, bool instant)
		{
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x26ACA90", Offset = "0x26AB090", VA = "0x1826ACA90")]
		public void UpdateColor(bool instant)
		{
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x26ACC70", Offset = "0x26AB270", VA = "0x1826ACC70")]
		public UIButtonColor()
		{
		}

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject tweenTarget;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x28")]
		public Color hover;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x38")]
		public Color pressed;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x48")]
		public Color disabledColor;

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x58")]
		public float duration;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x5C")]
		[NonSerialized]
		protected Color mStartingColor;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x6C")]
		[NonSerialized]
		protected Color mDefaultColor;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x7C")]
		[NonSerialized]
		protected bool mInitDone;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		protected UIWidget mWidget;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		protected UIButtonColor.State mState;

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x200009F")]
		public enum State
		{
			// Token: 0x04000418 RID: 1048
			[Token(Token = "0x4000418")]
			Normal,
			// Token: 0x04000419 RID: 1049
			[Token(Token = "0x4000419")]
			Hover,
			// Token: 0x0400041A RID: 1050
			[Token(Token = "0x400041A")]
			Pressed,
			// Token: 0x0400041B RID: 1051
			[Token(Token = "0x400041B")]
			Disabled
		}
	}
}
