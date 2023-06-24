using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	[AddComponentMenu("NGUI/Interaction/Button Scale")]
	public class UIButtonScale : MonoBehaviour
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x26AF630", Offset = "0x26ADC30", VA = "0x1826AF630")]
		private void Start()
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x26AF810", Offset = "0x26ADE10", VA = "0x1826AF810")]
		private void OnEnable()
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x26AF8C0", Offset = "0x26ADEC0", VA = "0x1826AF8C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x26AFA70", Offset = "0x26AE070", VA = "0x1826AFA70")]
		private void OnPress(bool isPressed)
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x26AFCC0", Offset = "0x26AE2C0", VA = "0x1826AFCC0")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x26AFE30", Offset = "0x26AE430", VA = "0x1826AFE30")]
		private void OnSelect(bool isSelected)
		{
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x26AFEE0", Offset = "0x26AE4E0", VA = "0x1826AFEE0")]
		public UIButtonScale()
		{
		}

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x20")]
		public Transform tweenTarget;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 hover;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 pressed;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x40")]
		public float duration;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 mScale;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x50")]
		private bool mStarted;
	}
}
