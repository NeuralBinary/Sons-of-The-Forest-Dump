using System;
using Il2CppDummyDll;
using NGUI.Internal;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	public class AnimatedAlpha : MonoBehaviour
	{
		// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x26558D0", Offset = "0x2653ED0", VA = "0x1826558D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2655B70", Offset = "0x2654170", VA = "0x182655B70")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
		public AnimatedAlpha()
		{
		}

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float alpha;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x28")]
		private UIWidget mWidget;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x30")]
		private UIPanel mPanel;
	}
}
