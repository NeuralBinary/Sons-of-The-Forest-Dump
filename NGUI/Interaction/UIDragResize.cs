using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	[AddComponentMenu("NGUI/Interaction/Drag-Resize Widget")]
	public class UIDragResize : MonoBehaviour
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x26BA6E0", Offset = "0x26B8CE0", VA = "0x1826BA6E0")]
		private void OnDragStart()
		{
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x26BA9C0", Offset = "0x26B8FC0", VA = "0x1826BA9C0")]
		private void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x73CD40", Offset = "0x73B340", VA = "0x18073CD40")]
		private void OnDragEnd()
		{
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x26BAF50", Offset = "0x26B9550", VA = "0x1826BAF50")]
		public UIDragResize()
		{
		}

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget target;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget.Pivot pivot;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x2C")]
		public int minWidth;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x30")]
		public int minHeight;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x34")]
		public int maxWidth;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x38")]
		public int maxHeight;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x3C")]
		public bool updateAnchors;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x40")]
		private Plane mPlane;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 mRayPos;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 mLocalPos;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x68")]
		private int mWidth;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x6C")]
		private int mHeight;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x70")]
		private bool mDragging;
	}
}
