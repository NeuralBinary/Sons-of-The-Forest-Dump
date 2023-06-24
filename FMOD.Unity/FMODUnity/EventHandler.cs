using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FMODUnity
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	public abstract class EventHandler : MonoBehaviour
	{
		// Token: 0x0600065E RID: 1630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065E")]
		[Address(RVA = "0xB50930", Offset = "0xB4EF30", VA = "0x180B50930", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065F")]
		[Address(RVA = "0xB50950", Offset = "0xB4EF50", VA = "0x180B50950", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000660")]
		[Address(RVA = "0xB50970", Offset = "0xB4EF70", VA = "0x180B50970", Slot = "6")]
		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000661")]
		[Address(RVA = "0xB509D0", Offset = "0xB4EFD0", VA = "0x180B509D0", Slot = "7")]
		protected virtual void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000662")]
		[Address(RVA = "0xB50A30", Offset = "0xB4F030", VA = "0x180B50A30", Slot = "8")]
		protected virtual void OnTriggerEnter2D(Collider2D other)
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000663")]
		[Address(RVA = "0xB50A90", Offset = "0xB4F090", VA = "0x180B50A90", Slot = "9")]
		protected virtual void OnTriggerExit2D(Collider2D other)
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000664")]
		[Address(RVA = "0xB50AF0", Offset = "0xB4F0F0", VA = "0x180B50AF0", Slot = "10")]
		protected virtual void OnCollisionEnter()
		{
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000665")]
		[Address(RVA = "0xB50B10", Offset = "0xB4F110", VA = "0x180B50B10", Slot = "11")]
		protected virtual void OnCollisionExit()
		{
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000666")]
		[Address(RVA = "0xB50B30", Offset = "0xB4F130", VA = "0x180B50B30", Slot = "12")]
		protected virtual void OnCollisionEnter2D()
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000667")]
		[Address(RVA = "0xB50B50", Offset = "0xB4F150", VA = "0x180B50B50", Slot = "13")]
		protected virtual void OnCollisionExit2D()
		{
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000668")]
		[Address(RVA = "0xB50B70", Offset = "0xB4F170", VA = "0x180B50B70", Slot = "14")]
		protected virtual void OnMouseEnter()
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000669")]
		[Address(RVA = "0xB50B90", Offset = "0xB4F190", VA = "0x180B50B90", Slot = "15")]
		protected virtual void OnMouseExit()
		{
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066A")]
		[Address(RVA = "0xB50BB0", Offset = "0xB4F1B0", VA = "0x180B50BB0", Slot = "16")]
		protected virtual void OnMouseDown()
		{
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066B")]
		[Address(RVA = "0xB50BD0", Offset = "0xB4F1D0", VA = "0x180B50BD0", Slot = "17")]
		protected virtual void OnMouseUp()
		{
		}

		// Token: 0x0600066C RID: 1644
		[Token(Token = "0x600066C")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		// Token: 0x0600066D RID: 1645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066D")]
		[Address(RVA = "0xB50BF0", Offset = "0xB4F1F0", VA = "0x180B50BF0")]
		protected EventHandler()
		{
		}

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x20")]
		public string CollisionTag;
	}
}
