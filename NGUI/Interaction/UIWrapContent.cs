using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	[AddComponentMenu("NGUI/Interaction/Wrap Content")]
	public class UIWrapContent : MonoBehaviour
	{
		// Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x26E16E0", Offset = "0x26DFCE0", VA = "0x1826E16E0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x26E1890", Offset = "0x26DFE90", VA = "0x1826E1890", Slot = "5")]
		protected virtual void OnMove(UIPanel panel)
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x26E18B0", Offset = "0x26DFEB0", VA = "0x1826E18B0", Slot = "6")]
		[ContextMenu("Sort Based on Scroll Movement")]
		public virtual void SortBasedOnScrollMovement()
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x26E1B90", Offset = "0x26E0190", VA = "0x1826E1B90", Slot = "7")]
		[ContextMenu("Sort Alphabetically")]
		public virtual void SortAlphabetically()
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x26E1E50", Offset = "0x26E0450", VA = "0x1826E1E50")]
		protected bool CacheScrollView()
		{
			return default(bool);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x26E2140", Offset = "0x26E0740", VA = "0x1826E2140", Slot = "8")]
		protected virtual void ResetChildPositions()
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x26E22C0", Offset = "0x26E08C0", VA = "0x1826E22C0", Slot = "9")]
		public virtual void WrapContent()
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x26E2E00", Offset = "0x26E1400", VA = "0x1826E2E00")]
		private void OnValidate()
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x26E2E20", Offset = "0x26E1420", VA = "0x1826E2E20", Slot = "10")]
		protected virtual void UpdateItem(Transform item, int index)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x26E2FB0", Offset = "0x26E15B0", VA = "0x1826E2FB0")]
		public UIWrapContent()
		{
		}

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x20")]
		public int itemSize;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x24")]
		public bool cullContent;

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x28")]
		public int minIndex;

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x2C")]
		public int maxIndex;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x30")]
		public UIWrapContent.OnInitializeItem onInitializeItem;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x38")]
		protected Transform mTrans;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x40")]
		protected UIPanel mPanel;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x48")]
		protected UIScrollView mScroll;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x50")]
		protected bool mHorizontal;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x51")]
		protected bool mFirstTime;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x58")]
		protected List<Transform> mChildren;

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x060007E7 RID: 2023
		[Token(Token = "0x20000E5")]
		public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);
	}
}
