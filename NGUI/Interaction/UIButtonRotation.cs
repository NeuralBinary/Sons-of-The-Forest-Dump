using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	[AddComponentMenu("NGUI/Interaction/Button Rotation")]
	public class UIButtonRotation : MonoBehaviour
	{
		// Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x26AEB70", Offset = "0x26AD170", VA = "0x1826AEB70")]
		private void Start()
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x26AED40", Offset = "0x26AD340", VA = "0x1826AED40")]
		private void OnEnable()
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x26AEDF0", Offset = "0x26AD3F0", VA = "0x1826AEDF0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x26AEFF0", Offset = "0x26AD5F0", VA = "0x1826AEFF0")]
		private void OnPress(bool isPressed)
		{
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x26AF2B0", Offset = "0x26AD8B0", VA = "0x1826AF2B0")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x26AF4B0", Offset = "0x26ADAB0", VA = "0x1826AF4B0")]
		private void OnSelect(bool isSelected)
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x26AF560", Offset = "0x26ADB60", VA = "0x1826AF560")]
		public UIButtonRotation()
		{
		}

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x20")]
		public Transform tweenTarget;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 hover;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 pressed;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x40")]
		public float duration;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x44")]
		private Quaternion mRot;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x54")]
		private bool mStarted;
	}
}
