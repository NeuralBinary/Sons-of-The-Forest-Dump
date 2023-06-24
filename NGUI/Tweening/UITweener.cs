using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public abstract class UITweener : MonoBehaviour
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x170000CE")]
		public float amountPerDelta
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x265E1E0", Offset = "0x265C7E0", VA = "0x18265E1E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00003318 File Offset: 0x00001518
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CF")]
		public float tweenFactor
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x23C2610", Offset = "0x23C0C10", VA = "0x1823C2610")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x265E250", Offset = "0x265C850", VA = "0x18265E250")]
			set
			{
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x170000D0")]
		public Direction direction
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x265E280", Offset = "0x265C880", VA = "0x18265E280")]
			get
			{
				return Direction.Toggle;
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x265E2F0", Offset = "0x265C8F0", VA = "0x18265E2F0")]
		private void Reset()
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x265E330", Offset = "0x265C930", VA = "0x18265E330", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x265E340", Offset = "0x265C940", VA = "0x18265E340")]
		private void Update()
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x265E9E0", Offset = "0x265CFE0", VA = "0x18265E9E0")]
		public void SetOnFinished(EventDelegate.Callback del)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x265EAC0", Offset = "0x265D0C0", VA = "0x18265EAC0")]
		public void SetOnFinished(EventDelegate del)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x265EB70", Offset = "0x265D170", VA = "0x18265EB70")]
		public void AddOnFinished(EventDelegate.Callback del)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x265EC10", Offset = "0x265D210", VA = "0x18265EC10")]
		public void AddOnFinished(EventDelegate del)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x265ECC0", Offset = "0x265D2C0", VA = "0x18265ECC0")]
		public void RemoveOnFinished(EventDelegate del)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x265ED30", Offset = "0x265D330", VA = "0x18265ED30", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x265ED40", Offset = "0x265D340", VA = "0x18265ED40")]
		public void Sample(float factor, bool isFinished)
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x265EF00", Offset = "0x265D500", VA = "0x18265EF00")]
		private float BounceLogic(float val)
		{
			return 0f;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x265EFA0", Offset = "0x265D5A0", VA = "0x18265EFA0")]
		[Obsolete("Use PlayForward() instead")]
		public void Play()
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x265EFA0", Offset = "0x265D5A0", VA = "0x18265EFA0")]
		public void PlayForward()
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x265EFB0", Offset = "0x265D5B0", VA = "0x18265EFB0")]
		public void PlayReverse()
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x265EFC0", Offset = "0x265D5C0", VA = "0x18265EFC0")]
		public void Play(bool forward)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x265F0A0", Offset = "0x265D6A0", VA = "0x18265F0A0")]
		public void ResetToBeginning()
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x265F120", Offset = "0x265D720", VA = "0x18265F120")]
		public void Toggle()
		{
		}

		// Token: 0x0600032C RID: 812
		[Token(Token = "0x600032C")]
		protected abstract void OnUpdate(float factor, bool isFinished);

		// Token: 0x0600032D RID: 813 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600032D")]
		public static T Begin<T>(GameObject go, float duration) where T : UITweener
		{
			return null;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public virtual void SetStartToCurrentValue()
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public virtual void SetEndToCurrentValue()
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x265F1A0", Offset = "0x265D7A0", VA = "0x18265F1A0")]
		protected UITweener()
		{
		}

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x0")]
		public static UITweener current;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public UITweener.Method method;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public UITweener.Style style;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public AnimationCurve animationCurve;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public bool ignoreTimeScale;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public float delay;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public float duration;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		public bool steeperCurves;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public int tweenGroup;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public List<EventDelegate> onFinished;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public GameObject eventReceiver;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public string callWhenFinished;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x60")]
		private bool mStarted;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x64")]
		private float mStartTime;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x68")]
		private float mDuration;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x6C")]
		private float mAmountPerDelta;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x70")]
		private float mFactor;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x78")]
		private List<EventDelegate> mTemp;

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		public enum Method
		{
			// Token: 0x04000264 RID: 612
			[Token(Token = "0x4000264")]
			Linear,
			// Token: 0x04000265 RID: 613
			[Token(Token = "0x4000265")]
			EaseIn,
			// Token: 0x04000266 RID: 614
			[Token(Token = "0x4000266")]
			EaseOut,
			// Token: 0x04000267 RID: 615
			[Token(Token = "0x4000267")]
			EaseInOut,
			// Token: 0x04000268 RID: 616
			[Token(Token = "0x4000268")]
			BounceIn,
			// Token: 0x04000269 RID: 617
			[Token(Token = "0x4000269")]
			BounceOut
		}

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		public enum Style
		{
			// Token: 0x0400026B RID: 619
			[Token(Token = "0x400026B")]
			Once,
			// Token: 0x0400026C RID: 620
			[Token(Token = "0x400026C")]
			Loop,
			// Token: 0x0400026D RID: 621
			[Token(Token = "0x400026D")]
			PingPong
		}
	}
}
