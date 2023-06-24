using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	[AddComponentMenu("NGUI/Interaction/Forward Events (Legacy)")]
	public class UIForwardEvents : MonoBehaviour
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x26BD9D0", Offset = "0x26BBFD0", VA = "0x1826BD9D0")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x26BDB00", Offset = "0x26BC100", VA = "0x1826BDB00")]
		private void OnPress(bool pressed)
		{
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x26BDC30", Offset = "0x26BC230", VA = "0x1826BDC30")]
		private void OnClick()
		{
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x26BDD30", Offset = "0x26BC330", VA = "0x1826BDD30")]
		private void OnDoubleClick()
		{
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x26BDE30", Offset = "0x26BC430", VA = "0x1826BDE30")]
		private void OnSelect(bool selected)
		{
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x26BDF60", Offset = "0x26BC560", VA = "0x1826BDF60")]
		private void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x26BE0A0", Offset = "0x26BC6A0", VA = "0x1826BE0A0")]
		private void OnDrop(GameObject go)
		{
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x26BE1B0", Offset = "0x26BC7B0", VA = "0x1826BE1B0")]
		private void OnSubmit()
		{
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x26BE2B0", Offset = "0x26BC8B0", VA = "0x1826BE2B0")]
		private void OnScroll(float delta)
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIForwardEvents()
		{
		}

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x20")]
		public GameObject target;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x28")]
		public bool onHover;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x29")]
		public bool onPress;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x2A")]
		public bool onClick;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x2B")]
		public bool onDoubleClick;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x2C")]
		public bool onSelect;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x2D")]
		public bool onDrag;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x2E")]
		public bool onDrop;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x2F")]
		public bool onSubmit;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x30")]
		public bool onScroll;
	}
}
