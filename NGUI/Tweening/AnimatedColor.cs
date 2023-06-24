using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[RequireComponent(typeof(UIWidget))]
	[ExecuteInEditMode]
	public class AnimatedColor : MonoBehaviour
	{
		// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2655D50", Offset = "0x2654350", VA = "0x182655D50")]
		private void OnEnable()
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2655ED0", Offset = "0x26544D0", VA = "0x182655ED0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2655FD0", Offset = "0x26545D0", VA = "0x182655FD0")]
		public AnimatedColor()
		{
		}

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x20")]
		public Color color;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x30")]
		private UIWidget mWidget;
	}
}
