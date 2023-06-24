using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("NGUI/Tween/Tween Field of View")]
	public class TweenFOV : UITweener
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000B5")]
		public Camera cachedCamera
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x26591D0", Offset = "0x26577D0", VA = "0x1826591D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00003168 File Offset: 0x00001368
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B6")]
		[Obsolete("Use 'value' instead")]
		public float fov
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x2659310", Offset = "0x2657910", VA = "0x182659310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x2659380", Offset = "0x2657980", VA = "0x182659380")]
			set
			{
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00003180 File Offset: 0x00001380
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B7")]
		public float value
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2659310", Offset = "0x2657910", VA = "0x182659310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x2659390", Offset = "0x2657990", VA = "0x182659390")]
			set
			{
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2659410", Offset = "0x2657A10", VA = "0x182659410", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2659440", Offset = "0x2657A40", VA = "0x182659440")]
		public static TweenFOV Begin(GameObject go, float duration, float to)
		{
			return null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2659580", Offset = "0x2657B80", VA = "0x182659580", Slot = "7")]
		[ContextMenu("Set 'From' to current value")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2659600", Offset = "0x2657C00", VA = "0x182659600", Slot = "8")]
		[ContextMenu("Set 'To' to current value")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2659680", Offset = "0x2657C80", VA = "0x182659680")]
		[ContextMenu("Assume value of 'From'")]
		private void SetCurrentValueToStart()
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2659690", Offset = "0x2657C90", VA = "0x182659690")]
		[ContextMenu("Assume value of 'To'")]
		private void SetCurrentValueToEnd()
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x26596A0", Offset = "0x2657CA0", VA = "0x1826596A0")]
		public TweenFOV()
		{
		}

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x80")]
		public float from;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x84")]
		public float to;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x88")]
		private Camera mCam;
	}
}
