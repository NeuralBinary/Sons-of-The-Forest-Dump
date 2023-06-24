using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Endnight.Utilities
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public class MouseEventsProxy : MonoBehaviour
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA875A0", Offset = "0xA85BA0", VA = "0x180A875A0")]
		private void OnMouseEnterCollider()
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA875C0", Offset = "0xA85BC0", VA = "0x180A875C0")]
		private void OnMouseExitCollider()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA875E0", Offset = "0xA85BE0", VA = "0x180A875E0")]
		private void OnMouseOverCollider()
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xA87600", Offset = "0xA85C00", VA = "0x180A87600")]
		public MouseEventsProxy()
		{
		}

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent _mouseEnterEvent;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent _mouseExitEvent;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent _mouseOverEvent;
	}
}
