using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Endnight.Physics
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public class OnTriggerEvents : MonoBehaviour
	{
		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0xA9A9D0", Offset = "0xA98FD0", VA = "0x180A9A9D0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0xA9AA30", Offset = "0xA99030", VA = "0x180A9AA30")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0xA9AA90", Offset = "0xA99090", VA = "0x180A9AA90")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0xA9AAF0", Offset = "0xA990F0", VA = "0x180A9AAF0")]
		public OnTriggerEvents()
		{
		}

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<Collider> OnTriggerEnterEvent;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<Collider> OnTriggerExitEvent;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent<Collider> OnTriggerStayEvent;
	}
}
