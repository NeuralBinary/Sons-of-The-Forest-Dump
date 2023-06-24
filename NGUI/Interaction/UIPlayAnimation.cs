using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Interaction/Play Animation")]
	public class UIPlayAnimation : MonoBehaviour
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x17000153")]
		private bool dualState
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x26C3C30", Offset = "0x26C2230", VA = "0x1826C3C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x26C3C50", Offset = "0x26C2250", VA = "0x1826C3C50")]
		private void Awake()
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x26C3EB0", Offset = "0x26C24B0", VA = "0x1826C3EB0")]
		private void Start()
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x26C4360", Offset = "0x26C2960", VA = "0x1826C4360")]
		private void OnEnable()
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x26C48F0", Offset = "0x26C2EF0", VA = "0x1826C48F0")]
		private void OnDisable()
		{
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x26C4A40", Offset = "0x26C3040", VA = "0x1826C4A40")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x26C4AE0", Offset = "0x26C30E0", VA = "0x1826C4AE0")]
		private void OnPress(bool isPressed)
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x26C4BE0", Offset = "0x26C31E0", VA = "0x1826C4BE0")]
		private void OnClick()
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x26C4CB0", Offset = "0x26C32B0", VA = "0x1826C4CB0")]
		private void OnDoubleClick()
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x26C4D80", Offset = "0x26C3380", VA = "0x1826C4D80")]
		private void OnSelect(bool isSelected)
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x26C4E20", Offset = "0x26C3420", VA = "0x1826C4E20")]
		private void OnToggle()
		{
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x26C5060", Offset = "0x26C3660", VA = "0x1826C5060")]
		private void OnDragOver()
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x26C5280", Offset = "0x26C3880", VA = "0x1826C5280")]
		private void OnDragOut()
		{
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x26C5470", Offset = "0x26C3A70", VA = "0x1826C5470")]
		private void OnDrop(GameObject go)
		{
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x26C5670", Offset = "0x26C3C70", VA = "0x1826C5670")]
		public void Play(bool forward)
		{
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x26C5680", Offset = "0x26C3C80", VA = "0x1826C5680")]
		public void Play(bool forward, bool onlyIfDifferent)
		{
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x26C5C20", Offset = "0x26C4220", VA = "0x1826C5C20")]
		public void PlayForward()
		{
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x26C5C30", Offset = "0x26C4230", VA = "0x1826C5C30")]
		public void PlayReverse()
		{
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x26C5C40", Offset = "0x26C4240", VA = "0x1826C5C40")]
		private void OnFinished()
		{
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x26C5F60", Offset = "0x26C4560", VA = "0x1826C5F60")]
		public UIPlayAnimation()
		{
		}

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x0")]
		public static UIPlayAnimation current;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x20")]
		public Animation target;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x28")]
		public Animator animator;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x30")]
		public string clipName;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x38")]
		public Trigger trigger;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x3C")]
		public Direction playDirection;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x40")]
		public bool resetOnPlay;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x41")]
		public bool clearSelection;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x44")]
		public EnableCondition ifDisabledOnPlay;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x48")]
		public DisableCondition disableWhenFinished;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x50")]
		public List<EventDelegate> onFinished;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		private GameObject eventReceiver;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		private string callWhenFinished;

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x68")]
		private bool mStarted;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x69")]
		private bool mActivated;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x6A")]
		private bool dragHighlight;
	}
}
