using System;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("NGUI/Interaction/Draggable Camera")]
	public class UIDraggableCamera : MonoBehaviour
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00004518 File Offset: 0x00002718
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014C")]
		public Vector2 currentMomentum
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x26B5EB0", Offset = "0x26B44B0", VA = "0x1826B5EB0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x26B5ED0", Offset = "0x26B44D0", VA = "0x1826B5ED0")]
			set
			{
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x26B5EE0", Offset = "0x26B44E0", VA = "0x1826B5EE0")]
		private void Start()
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x26B62A0", Offset = "0x26B48A0", VA = "0x1826B62A0")]
		private Vector3 CalculateConstrainOffset()
		{
			return default(Vector3);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x26B68E0", Offset = "0x26B4EE0", VA = "0x1826B68E0")]
		public bool ConstrainToBounds(bool immediate)
		{
			return default(bool);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x26B6C80", Offset = "0x26B5280", VA = "0x1826B6C80")]
		public void Press(bool isPressed)
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x26B6E90", Offset = "0x26B5490", VA = "0x1826B6E90")]
		public void Drag(Vector2 delta)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x26B71E0", Offset = "0x26B57E0", VA = "0x1826B71E0")]
		public void Scroll(float delta)
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x26B7330", Offset = "0x26B5930", VA = "0x1826B7330")]
		private void Update()
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x26B7730", Offset = "0x26B5D30", VA = "0x1826B7730")]
		public UIDraggableCamera()
		{
		}

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x20")]
		public Transform rootForBounds;

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 scale;

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x30")]
		public float scrollWheelFactor;

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x34")]
		public UIDragObject.DragEffect dragEffect;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x38")]
		public bool smoothDragStart;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x3C")]
		public float momentumAmount;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x40")]
		private Camera mCam;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x48")]
		private Transform mTrans;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x50")]
		private bool mPressed;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x54")]
		private Vector2 mMomentum;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x5C")]
		private Bounds mBounds;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x74")]
		private float mScroll;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x78")]
		private UIRoot mRoot;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x80")]
		private bool mDragStarted;
	}
}
