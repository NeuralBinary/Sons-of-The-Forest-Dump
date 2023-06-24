using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[AddComponentMenu("NGUI/UI/Tooltip")]
	public class UITooltip : MonoBehaviour
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x170000AF")]
		public static bool isVisible
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x26536E0", Offset = "0x2651CE0", VA = "0x1826536E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x26537E0", Offset = "0x2651DE0", VA = "0x1826537E0")]
		private void Awake()
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2653870", Offset = "0x2651E70", VA = "0x182653870")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2653900", Offset = "0x2651F00", VA = "0x182653900", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2653C90", Offset = "0x2652290", VA = "0x182653C90", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x26541C0", Offset = "0x26527C0", VA = "0x1826541C0", Slot = "6")]
		protected virtual void SetAlpha(float val)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2654320", Offset = "0x2652920", VA = "0x182654320", Slot = "7")]
		protected virtual void SetText(string tooltipText)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2654CE0", Offset = "0x26532E0", VA = "0x182654CE0")]
		[Obsolete("Use UITooltip.Show instead")]
		public static void ShowText(string text)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2654DF0", Offset = "0x26533F0", VA = "0x182654DF0")]
		public static void Show(string text)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2654F00", Offset = "0x2653500", VA = "0x182654F00")]
		public static void Hide()
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2655050", Offset = "0x2653650", VA = "0x182655050")]
		public UITooltip()
		{
		}

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x0")]
		protected static UITooltip mInstance;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x20")]
		public Camera uiCamera;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel text;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x30")]
		public UISprite background;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x38")]
		public float appearSpeed;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x3C")]
		public bool scalingTransitions;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x40")]
		protected GameObject mTooltip;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x48")]
		protected Transform mTrans;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x50")]
		protected float mTarget;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x54")]
		protected float mCurrent;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x58")]
		protected Vector3 mPos;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x64")]
		protected Vector3 mSize;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x70")]
		protected UIWidget[] mWidgets;
	}
}
