using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	[AddComponentMenu("NGUI/Interaction/Table")]
	public class UITable : UIWidgetContainer
	{
		// Token: 0x1700017F RID: 383
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017F")]
		public bool repositionNow
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x26DDCD0", Offset = "0x26DC2D0", VA = "0x1826DDCD0")]
			set
			{
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x26DDD30", Offset = "0x26DC330", VA = "0x1826DDD30")]
		public List<Transform> GetChildList()
		{
			return null;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x26DE100", Offset = "0x26DC700", VA = "0x1826DE100", Slot = "4")]
		protected virtual void Sort(List<Transform> list)
		{
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x26DE190", Offset = "0x26DC790", VA = "0x1826DE190", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x26DE210", Offset = "0x26DC810", VA = "0x1826DE210", Slot = "6")]
		protected virtual void Init()
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x26DE310", Offset = "0x26DC910", VA = "0x1826DE310", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x26DE380", Offset = "0x26DC980", VA = "0x1826DE380")]
		private void OnValidate()
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x26DE450", Offset = "0x26DCA50", VA = "0x1826DE450")]
		protected void RepositionVariableSize(List<Transform> children)
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x26DF0F0", Offset = "0x26DD6F0", VA = "0x1826DF0F0", Slot = "8")]
		[ContextMenu("Execute")]
		public virtual void Reposition()
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x26DF3F0", Offset = "0x26DD9F0", VA = "0x1826DF3F0")]
		public UITable()
		{
		}

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x20")]
		public int columns;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x24")]
		public UITable.Direction direction;

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x28")]
		public UITable.Sorting sorting;

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x2C")]
		public UIWidget.Pivot pivot;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget.Pivot cellAlignment;

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x34")]
		public bool hideInactive;

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x35")]
		public bool keepWithinPanel;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 padding;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x40")]
		public UITable.OnReposition onReposition;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x48")]
		public Comparison<Transform> onCustomSort;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x50")]
		protected UIPanel mPanel;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x58")]
		protected bool mInitDone;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x59")]
		protected bool mReposition;

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x060007C0 RID: 1984
		[Token(Token = "0x20000DC")]
		public delegate void OnReposition();

		// Token: 0x020000DD RID: 221
		[Token(Token = "0x20000DD")]
		public enum Direction
		{
			// Token: 0x040005CE RID: 1486
			[Token(Token = "0x40005CE")]
			Down,
			// Token: 0x040005CF RID: 1487
			[Token(Token = "0x40005CF")]
			Up
		}

		// Token: 0x020000DE RID: 222
		[Token(Token = "0x20000DE")]
		public enum Sorting
		{
			// Token: 0x040005D1 RID: 1489
			[Token(Token = "0x40005D1")]
			None,
			// Token: 0x040005D2 RID: 1490
			[Token(Token = "0x40005D2")]
			Alphabetic,
			// Token: 0x040005D3 RID: 1491
			[Token(Token = "0x40005D3")]
			Horizontal,
			// Token: 0x040005D4 RID: 1492
			[Token(Token = "0x40005D4")]
			Vertical,
			// Token: 0x040005D5 RID: 1493
			[Token(Token = "0x40005D5")]
			Custom
		}
	}
}
