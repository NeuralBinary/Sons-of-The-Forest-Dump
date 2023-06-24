using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	[AddComponentMenu("NGUI/Interaction/Button Message (Legacy)")]
	public class UIButtonMessage : MonoBehaviour
	{
		// Token: 0x06000609 RID: 1545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x26AD970", Offset = "0x26ABF70", VA = "0x1826AD970")]
		private void Start()
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x26AD980", Offset = "0x26ABF80", VA = "0x1826AD980")]
		private void OnEnable()
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x26ADA30", Offset = "0x26AC030", VA = "0x1826ADA30")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x26ADAC0", Offset = "0x26AC0C0", VA = "0x1826ADAC0")]
		private void OnPress(bool isPressed)
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x26ADB50", Offset = "0x26AC150", VA = "0x1826ADB50")]
		private void OnSelect(bool isSelected)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x26ADC00", Offset = "0x26AC200", VA = "0x1826ADC00")]
		private void OnClick()
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x26ADC70", Offset = "0x26AC270", VA = "0x1826ADC70")]
		private void OnDoubleClick()
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x26ADCE0", Offset = "0x26AC2E0", VA = "0x1826ADCE0")]
		private void Send()
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIButtonMessage()
		{
		}

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x20")]
		public GameObject target;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x28")]
		public string functionName;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x30")]
		public UIButtonMessage.Trigger trigger;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x34")]
		public bool includeChildren;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x35")]
		private bool mStarted;

		// Token: 0x020000A2 RID: 162
		[Token(Token = "0x20000A2")]
		public enum Trigger
		{
			// Token: 0x04000427 RID: 1063
			[Token(Token = "0x4000427")]
			OnClick,
			// Token: 0x04000428 RID: 1064
			[Token(Token = "0x4000428")]
			OnMouseOver,
			// Token: 0x04000429 RID: 1065
			[Token(Token = "0x4000429")]
			OnMouseOut,
			// Token: 0x0400042A RID: 1066
			[Token(Token = "0x400042A")]
			OnPress,
			// Token: 0x0400042B RID: 1067
			[Token(Token = "0x400042B")]
			OnRelease,
			// Token: 0x0400042C RID: 1068
			[Token(Token = "0x400042C")]
			OnDoubleClick
		}
	}
}
