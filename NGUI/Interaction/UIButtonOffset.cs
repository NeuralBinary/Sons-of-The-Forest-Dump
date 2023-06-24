using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	[AddComponentMenu("NGUI/Interaction/Button Offset")]
	public class UIButtonOffset : MonoBehaviour
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x26AE060", Offset = "0x26AC660", VA = "0x1826AE060")]
		private void Start()
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x26AE240", Offset = "0x26AC840", VA = "0x1826AE240")]
		private void OnEnable()
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x26AE2F0", Offset = "0x26AC8F0", VA = "0x1826AE2F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x26AE4A0", Offset = "0x26ACAA0", VA = "0x1826AE4A0")]
		private void OnPress(bool isPressed)
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x26AE6F0", Offset = "0x26ACCF0", VA = "0x1826AE6F0")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x26AE860", Offset = "0x26ACE60", VA = "0x1826AE860")]
		private void OnDragOver()
		{
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x26AE960", Offset = "0x26ACF60", VA = "0x1826AE960")]
		private void OnDragOut()
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x26AEA10", Offset = "0x26AD010", VA = "0x1826AEA10")]
		private void OnSelect(bool isSelected)
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x26AEAC0", Offset = "0x26AD0C0", VA = "0x1826AEAC0")]
		public UIButtonOffset()
		{
		}

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x20")]
		public Transform tweenTarget;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 hover;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 pressed;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x40")]
		public float duration;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x44")]
		[NonSerialized]
		private Vector3 mPos;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private bool mStarted;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x51")]
		[NonSerialized]
		private bool mPressed;
	}
}
