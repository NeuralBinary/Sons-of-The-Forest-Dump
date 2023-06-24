using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	[AddComponentMenu("NGUI/Interaction/Grid")]
	public class UIGrid : UIWidgetContainer
	{
		// Token: 0x1700014F RID: 335
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014F")]
		public bool repositionNow
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x26BE3F0", Offset = "0x26BC9F0", VA = "0x1826BE3F0")]
			set
			{
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x26BE450", Offset = "0x26BCA50", VA = "0x1826BE450")]
		public List<Transform> GetChildList()
		{
			return null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x26BE820", Offset = "0x26BCE20", VA = "0x1826BE820")]
		public Transform GetChild(int index)
		{
			return null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x26BE8B0", Offset = "0x26BCEB0", VA = "0x1826BE8B0")]
		public int GetIndex(Transform trans)
		{
			return 0;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x26BE930", Offset = "0x26BCF30", VA = "0x1826BE930")]
		public void AddChild(Transform trans)
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x26BE930", Offset = "0x26BCF30", VA = "0x1826BE930")]
		public void AddChild(Transform trans, bool sort)
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x26BEA60", Offset = "0x26BD060", VA = "0x1826BEA60")]
		public bool RemoveChild(Transform t)
		{
			return default(bool);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x26BEB00", Offset = "0x26BD100", VA = "0x1826BEB00", Slot = "4")]
		protected virtual void Init()
		{
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x26BEC00", Offset = "0x26BD200", VA = "0x1826BEC00", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x26BEC90", Offset = "0x26BD290", VA = "0x1826BEC90", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x26BED00", Offset = "0x26BD300", VA = "0x1826BED00")]
		private void OnValidate()
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x26BEDD0", Offset = "0x26BD3D0", VA = "0x1826BEDD0")]
		public static int SortByName(Transform a, Transform b)
		{
			return 0;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x26BEEE0", Offset = "0x26BD4E0", VA = "0x1826BEEE0")]
		public static int SortHorizontal(Transform a, Transform b)
		{
			return 0;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x26BF040", Offset = "0x26BD640", VA = "0x1826BF040")]
		public static int SortVertical(Transform a, Transform b)
		{
			return 0;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		protected virtual void Sort(List<Transform> list)
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x26BF1A0", Offset = "0x26BD7A0", VA = "0x1826BF1A0", Slot = "8")]
		[ContextMenu("Execute")]
		public virtual void Reposition()
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x26BF340", Offset = "0x26BD940", VA = "0x1826BF340")]
		public void ConstrainWithinPanel()
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x26BF530", Offset = "0x26BDB30", VA = "0x1826BF530", Slot = "9")]
		protected virtual void ResetPosition(List<Transform> list)
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x26BFCC0", Offset = "0x26BE2C0", VA = "0x1826BFCC0")]
		public UIGrid()
		{
		}

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid.Arrangement arrangement;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x24")]
		public UIGrid.Sorting sorting;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget.Pivot pivot;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x2C")]
		public int maxPerLine;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x30")]
		public float cellWidth;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x34")]
		public float cellHeight;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x38")]
		public bool animateSmoothly;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x39")]
		public bool hideInactive;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x3A")]
		public bool keepWithinPanel;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid.OnReposition onReposition;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x48")]
		public Comparison<Transform> onCustomSort;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		private bool sorted;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x51")]
		protected bool mReposition;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x58")]
		protected UIPanel mPanel;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x60")]
		protected bool mInitDone;

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x060006A9 RID: 1705
		[Token(Token = "0x20000B7")]
		public delegate void OnReposition();

		// Token: 0x020000B8 RID: 184
		[Token(Token = "0x20000B8")]
		public enum Arrangement
		{
			// Token: 0x040004C2 RID: 1218
			[Token(Token = "0x40004C2")]
			Horizontal,
			// Token: 0x040004C3 RID: 1219
			[Token(Token = "0x40004C3")]
			Vertical,
			// Token: 0x040004C4 RID: 1220
			[Token(Token = "0x40004C4")]
			CellSnap
		}

		// Token: 0x020000B9 RID: 185
		[Token(Token = "0x20000B9")]
		public enum Sorting
		{
			// Token: 0x040004C6 RID: 1222
			[Token(Token = "0x40004C6")]
			None,
			// Token: 0x040004C7 RID: 1223
			[Token(Token = "0x40004C7")]
			Alphabetic,
			// Token: 0x040004C8 RID: 1224
			[Token(Token = "0x40004C8")]
			Horizontal,
			// Token: 0x040004C9 RID: 1225
			[Token(Token = "0x40004C9")]
			Vertical,
			// Token: 0x040004CA RID: 1226
			[Token(Token = "0x40004CA")]
			Custom
		}
	}
}
