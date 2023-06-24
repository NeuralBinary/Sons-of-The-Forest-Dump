using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[AddComponentMenu("NGUI/UI/Viewport Camera")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class UIViewport : MonoBehaviour
	{
		// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x26550E0", Offset = "0x26536E0", VA = "0x1826550E0")]
		private void Start()
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x26552A0", Offset = "0x26538A0", VA = "0x1826552A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2655880", Offset = "0x2653E80", VA = "0x182655880")]
		public UIViewport()
		{
		}

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x20")]
		public Camera sourceCamera;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x28")]
		public Transform topLeft;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x30")]
		public Transform bottomRight;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x38")]
		public float fullSize;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x40")]
		private Camera mCam;
	}
}
