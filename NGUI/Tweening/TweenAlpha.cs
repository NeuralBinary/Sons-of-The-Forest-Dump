using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;
using UnityEngine.UI;

namespace NGUI.Tweening
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[AddComponentMenu("NGUI/Tween/Tween Alpha")]
	public class TweenAlpha : UITweener
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000030F0 File Offset: 0x000012F0
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B0")]
		[Obsolete("Use 'value' instead")]
		public float alpha
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x26570D0", Offset = "0x26556D0", VA = "0x1826570D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x26570E0", Offset = "0x26556E0", VA = "0x1826570E0")]
			set
			{
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x26570F0", Offset = "0x26556F0", VA = "0x1826570F0")]
		private void Cache()
		{
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00003108 File Offset: 0x00001308
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B1")]
		public float value
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x26574C0", Offset = "0x2655AC0", VA = "0x1826574C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x2657750", Offset = "0x2655D50", VA = "0x182657750")]
			set
			{
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2657A80", Offset = "0x2656080", VA = "0x182657A80", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2657AD0", Offset = "0x26560D0", VA = "0x182657AD0")]
		public static TweenAlpha Begin(GameObject go, float duration, float alpha)
		{
			return null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2657BC0", Offset = "0x26561C0", VA = "0x182657BC0", Slot = "7")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2657BE0", Offset = "0x26561E0", VA = "0x182657BE0", Slot = "8")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2657C00", Offset = "0x2656200", VA = "0x182657C00")]
		public TweenAlpha()
		{
		}

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float from;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float to;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x88")]
		private bool mCached;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x90")]
		private UIRect mRect;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x98")]
		private Material mMat;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0xA0")]
		private Image mSr;
	}
}
