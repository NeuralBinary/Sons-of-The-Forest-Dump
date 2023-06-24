using System;
using Il2CppDummyDll;
using NGUI.Internal;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Interaction/Drag Object")]
	public class UIDragObject : MonoBehaviour
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00004560 File Offset: 0x00002760
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014D")]
		public Vector3 dragMovement
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x620480", Offset = "0x61EA80", VA = "0x180620480")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x6204A0", Offset = "0x61EAA0", VA = "0x1806204A0")]
			set
			{
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x26B7810", Offset = "0x26B5E10", VA = "0x1826B7810")]
		private void OnEnable()
		{
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x26B7C20", Offset = "0x26B6220", VA = "0x1826B7C20")]
		private void OnDisable()
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x26B7C30", Offset = "0x26B6230", VA = "0x1826B7C30")]
		private void FindPanel()
		{
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x26B7EE0", Offset = "0x26B64E0", VA = "0x1826B7EE0")]
		private void UpdateBounds()
		{
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x26B84A0", Offset = "0x26B6AA0", VA = "0x1826B84A0")]
		private void OnPress(bool pressed)
		{
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x26B8A90", Offset = "0x26B7090", VA = "0x1826B8A90")]
		private void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x26B9200", Offset = "0x26B7800", VA = "0x1826B9200")]
		private void Move(Vector3 worldDelta)
		{
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x26B9AC0", Offset = "0x26B80C0", VA = "0x1826B9AC0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x26B9F60", Offset = "0x26B8560", VA = "0x1826B9F60")]
		public void CancelMovement()
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x26BA310", Offset = "0x26B8910", VA = "0x1826BA310")]
		public void CancelSpring()
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x26BA440", Offset = "0x26B8A40", VA = "0x1826BA440")]
		private void OnScroll(float delta)
		{
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x26BA5B0", Offset = "0x26B8BB0", VA = "0x1826BA5B0")]
		public UIDragObject()
		{
		}

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x20")]
		public Transform target;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel panelRegion;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 scrollMomentum;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x3C")]
		public bool restrictWithinPanel;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x40")]
		public UIRect contentRect;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x48")]
		public UIDragObject.DragEffect dragEffect;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x4C")]
		public float momentumAmount;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Vector3 scale;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		[SerializeField]
		private float scrollWheelFactor;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x60")]
		private Plane mPlane;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 mTargetPos;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 mLastPos;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 mMomentum;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 mScroll;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0xA0")]
		private Bounds mBounds;

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0xB8")]
		private int mTouchID;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0xBC")]
		private bool mStarted;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0xBD")]
		private bool mPressed;

		// Token: 0x020000B1 RID: 177
		[Token(Token = "0x20000B1")]
		public enum DragEffect
		{
			// Token: 0x04000484 RID: 1156
			[Token(Token = "0x4000484")]
			None,
			// Token: 0x04000485 RID: 1157
			[Token(Token = "0x4000485")]
			Momentum,
			// Token: 0x04000486 RID: 1158
			[Token(Token = "0x4000486")]
			MomentumAndSpring
		}
	}
}
