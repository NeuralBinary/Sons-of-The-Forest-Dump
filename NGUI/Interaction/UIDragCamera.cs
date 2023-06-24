using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	[AddComponentMenu("NGUI/Interaction/Drag Camera")]
	[ExecuteInEditMode]
	public class UIDragCamera : MonoBehaviour
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x26B2500", Offset = "0x26B0B00", VA = "0x1826B2500")]
		private void Awake()
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x26B26A0", Offset = "0x26B0CA0", VA = "0x1826B26A0")]
		private void OnPress(bool isPressed)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x26B2850", Offset = "0x26B0E50", VA = "0x1826B2850")]
		private void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x26B2A00", Offset = "0x26B1000", VA = "0x1826B2A00")]
		private void OnScroll(float delta)
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIDragCamera()
		{
		}

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x20")]
		public UIDraggableCamera draggableCamera;
	}
}
