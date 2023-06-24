using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	[AddComponentMenu("NGUI/Interaction/Drag Scroll View")]
	public class UIDragScrollView : MonoBehaviour
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x26BAFC0", Offset = "0x26B95C0", VA = "0x1826BAFC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x26BB310", Offset = "0x26B9910", VA = "0x1826BB310")]
		private void Start()
		{
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x26BB320", Offset = "0x26B9920", VA = "0x1826BB320")]
		private void FindScrollView()
		{
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x26BB6C0", Offset = "0x26B9CC0", VA = "0x1826BB6C0")]
		private void OnPress(bool pressed)
		{
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x26BBA10", Offset = "0x26BA010", VA = "0x1826BBA10")]
		private void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x26BBB10", Offset = "0x26BA110", VA = "0x1826BBB10")]
		private void OnScroll(float delta)
		{
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x26BBC30", Offset = "0x26BA230", VA = "0x1826BBC30")]
		public void OnPan(Vector2 delta)
		{
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIDragScrollView()
		{
		}

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView scrollView;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private UIScrollView draggablePanel;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x30")]
		private Transform mTrans;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x38")]
		private UIScrollView mScroll;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x40")]
		private bool mAutoFind;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x41")]
		private bool mStarted;
	}
}
