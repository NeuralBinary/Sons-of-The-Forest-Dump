using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Utilities
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[AddComponentMenu("Sons/Utilities/OnGrabberProxy")]
	public class OnGrabberProxy : MonoBehaviour
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x282D840", Offset = "0x282BE40", VA = "0x18282D840")]
		public void GrabEnter()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2FF7310", Offset = "0x2FF5910", VA = "0x182FF7310")]
		public void GrabExit()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2FF7330", Offset = "0x2FF5930", VA = "0x182FF7330")]
		public void GrabStay()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OnGrabberProxy()
		{
		}

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x20")]
		public Action OnGrabberEnterProxy;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x28")]
		public Action OnGrabberExitProxy;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x30")]
		public Action OnGrabberStayProxy;
	}
}
