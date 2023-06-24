using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using NGUI.Tweening;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Interaction/Play Tween")]
	public class UIPlayTween : MonoBehaviour
	{
		// Token: 0x060006EF RID: 1775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x26C66B0", Offset = "0x26C4CB0", VA = "0x1826C66B0")]
		private void Awake()
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x26C6860", Offset = "0x26C4E60", VA = "0x1826C6860")]
		private void Start()
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x26C69C0", Offset = "0x26C4FC0", VA = "0x1826C69C0")]
		private void OnEnable()
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x26C6ED0", Offset = "0x26C54D0", VA = "0x1826C6ED0")]
		private void OnDisable()
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x26C7020", Offset = "0x26C5620", VA = "0x1826C7020")]
		private void OnDragOver()
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x26C70A0", Offset = "0x26C56A0", VA = "0x1826C70A0")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x26C7140", Offset = "0x26C5740", VA = "0x1826C7140")]
		private void OnDragOut()
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x26C71B0", Offset = "0x26C57B0", VA = "0x1826C71B0")]
		private void OnPress(bool isPressed)
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x26C7250", Offset = "0x26C5850", VA = "0x1826C7250")]
		private void OnClick()
		{
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x26C72C0", Offset = "0x26C58C0", VA = "0x1826C72C0")]
		private void OnDoubleClick()
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x26C7330", Offset = "0x26C5930", VA = "0x1826C7330")]
		private void OnSelect(bool isSelected)
		{
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x26C73D0", Offset = "0x26C59D0", VA = "0x1826C73D0")]
		private void OnToggle()
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x26C7600", Offset = "0x26C5C00", VA = "0x1826C7600")]
		private void Update()
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x26C7730", Offset = "0x26C5D30", VA = "0x1826C7730")]
		public void Play(bool forward)
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x26C7B90", Offset = "0x26C6190", VA = "0x1826C7B90")]
		private void OnFinished()
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x26C7EB0", Offset = "0x26C64B0", VA = "0x1826C7EB0")]
		public UIPlayTween()
		{
		}

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x0")]
		public static UIPlayTween current;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x20")]
		public GameObject tweenTarget;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x28")]
		public int tweenGroup;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x2C")]
		public Trigger trigger;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x30")]
		public Direction playDirection;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x34")]
		public bool resetOnPlay;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x35")]
		public bool resetIfDisabled;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x38")]
		public EnableCondition ifDisabledOnPlay;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x3C")]
		public DisableCondition disableWhenFinished;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x40")]
		public bool includeChildren;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x48")]
		public List<EventDelegate> onFinished;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private GameObject eventReceiver;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private string callWhenFinished;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x60")]
		private UITweener[] mTweens;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x68")]
		private bool mStarted;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x6C")]
		private int mActive;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x70")]
		private bool mActivated;
	}
}
