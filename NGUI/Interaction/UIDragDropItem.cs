using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	[AddComponentMenu("NGUI/Interaction/Drag and Drop Item")]
	public class UIDragDropItem : MonoBehaviour
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x26B2E20", Offset = "0x26B1420", VA = "0x1826B2E20", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x26B3060", Offset = "0x26B1660", VA = "0x1826B3060", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x26B30E0", Offset = "0x26B16E0", VA = "0x1826B30E0", Slot = "7")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x26B31F0", Offset = "0x26B17F0", VA = "0x1826B31F0", Slot = "8")]
		protected virtual void OnPress(bool isPressed)
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x26B3360", Offset = "0x26B1960", VA = "0x1826B3360", Slot = "9")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x26B33C0", Offset = "0x26B19C0", VA = "0x1826B33C0", Slot = "10")]
		protected virtual void OnDragStart()
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x26B3510", Offset = "0x26B1B10", VA = "0x1826B3510", Slot = "11")]
		public virtual void StartDragging()
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x26B3E10", Offset = "0x26B2410", VA = "0x1826B3E10", Slot = "12")]
		protected virtual void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x26B3F40", Offset = "0x26B2540", VA = "0x1826B3F40", Slot = "13")]
		protected virtual void OnDragEnd()
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x26B4040", Offset = "0x26B2640", VA = "0x1826B4040")]
		public void StopDragging(GameObject go)
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x26B4070", Offset = "0x26B2670", VA = "0x1826B4070", Slot = "14")]
		protected virtual void OnDragDropStart()
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x26B4C70", Offset = "0x26B3270", VA = "0x1826B4C70", Slot = "15")]
		protected virtual void OnDragDropMove(Vector2 delta)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x26B4D70", Offset = "0x26B3370", VA = "0x1826B4D70", Slot = "16")]
		protected virtual void OnDragDropRelease(GameObject surface)
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x26B5820", Offset = "0x26B3E20", VA = "0x1826B5820", Slot = "17")]
		protected virtual void OnDragDropEnd()
		{
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x26B58A0", Offset = "0x26B3EA0", VA = "0x1826B58A0")]
		protected IEnumerator EnableDragScrollView()
		{
			return null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x26B5930", Offset = "0x26B3F30", VA = "0x1826B5930")]
		public UIDragDropItem()
		{
		}

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x20")]
		public UIDragDropItem.Restriction restriction;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x24")]
		public bool cloneOnDrag;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float pressAndHoldDelay;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x2C")]
		public bool interactable;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		protected Transform mTrans;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		protected Transform mParent;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		protected Collider mCollider;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		protected Collider2D mCollider2D;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		protected UIButton mButton;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		protected UIRoot mRoot;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		protected UIGrid mGrid;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		protected UITable mTable;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		protected float mDragStartTime;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		protected UIDragScrollView mDragScrollView;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		protected bool mPressed;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x81")]
		[NonSerialized]
		protected bool mDragging;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		protected UICamera.MouseOrTouch mTouch;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x0")]
		public static List<UIDragDropItem> draggedItems;

		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000AC")]
		public enum Restriction
		{
			// Token: 0x0400045B RID: 1115
			[Token(Token = "0x400045B")]
			None,
			// Token: 0x0400045C RID: 1116
			[Token(Token = "0x400045C")]
			Horizontal,
			// Token: 0x0400045D RID: 1117
			[Token(Token = "0x400045D")]
			Vertical,
			// Token: 0x0400045E RID: 1118
			[Token(Token = "0x400045E")]
			PressAndHold
		}
	}
}
