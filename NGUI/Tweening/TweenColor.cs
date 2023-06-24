using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[AddComponentMenu("NGUI/Tween/Tween Color")]
	public class TweenColor : UITweener
	{
		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2657C20", Offset = "0x2656220", VA = "0x182657C20")]
		private void Cache()
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00003120 File Offset: 0x00001320
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B2")]
		[Obsolete("Use 'value' instead")]
		public Color color
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x2658020", Offset = "0x2656620", VA = "0x182658020")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x2658050", Offset = "0x2656650", VA = "0x182658050")]
			set
			{
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00003138 File Offset: 0x00001338
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B3")]
		public Color value
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x2658070", Offset = "0x2656670", VA = "0x182658070")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x2658410", Offset = "0x2656A10", VA = "0x182658410")]
			set
			{
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2658800", Offset = "0x2656E00", VA = "0x182658800", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x26588D0", Offset = "0x2656ED0", VA = "0x1826588D0")]
		public static TweenColor Begin(GameObject go, float duration, Color color)
		{
			return null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x26589C0", Offset = "0x2656FC0", VA = "0x1826589C0", Slot = "7")]
		[ContextMenu("Set 'From' to current value")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x26589F0", Offset = "0x2656FF0", VA = "0x1826589F0", Slot = "8")]
		[ContextMenu("Set 'To' to current value")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2658A20", Offset = "0x2657020", VA = "0x182658A20")]
		[ContextMenu("Assume value of 'From'")]
		private void SetCurrentValueToStart()
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2658A50", Offset = "0x2657050", VA = "0x182658A50")]
		[ContextMenu("Assume value of 'To'")]
		private void SetCurrentValueToEnd()
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2658A80", Offset = "0x2657080", VA = "0x182658A80")]
		public TweenColor()
		{
		}

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x80")]
		public Color from;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x90")]
		public Color to;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0xA0")]
		private bool mCached;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0xA8")]
		private UIWidget mWidget;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0xB0")]
		private Material mMat;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0xB8")]
		private Light mLight;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0xC0")]
		private SpriteRenderer mSr;
	}
}
