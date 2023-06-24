using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[AddComponentMenu("NGUI/UI/Orthographic Camera")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class UIOrthoCamera : MonoBehaviour
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x26409A0", Offset = "0x263EFA0", VA = "0x1826409A0")]
		private void Start()
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2640B40", Offset = "0x263F140", VA = "0x182640B40")]
		private void Update()
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIOrthoCamera()
		{
		}

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x20")]
		private Camera mCam;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x28")]
		private Transform mTrans;
	}
}
