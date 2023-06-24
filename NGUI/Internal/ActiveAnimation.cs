using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[AddComponentMenu("NGUI/Internal/Active Animation")]
	public class ActiveAnimation : MonoBehaviour
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x170000D1")]
		private float playbackTime
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x265F400", Offset = "0x265DA00", VA = "0x18265F400")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x170000D2")]
		public bool isPlaying
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x265F4A0", Offset = "0x265DAA0", VA = "0x18265F4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x265F930", Offset = "0x265DF30", VA = "0x18265F930")]
		public void Finish()
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x265FD30", Offset = "0x265E330", VA = "0x18265FD30")]
		public void Reset()
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x26600F0", Offset = "0x265E6F0", VA = "0x1826600F0")]
		private void Start()
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x26602A0", Offset = "0x265E8A0", VA = "0x1826602A0")]
		private void Update()
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x2660A80", Offset = "0x265F080", VA = "0x182660A80")]
		private void Play(string clipName, Direction playDirection)
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2661200", Offset = "0x265F800", VA = "0x182661200")]
		public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
		{
			return null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x2661790", Offset = "0x265FD90", VA = "0x182661790")]
		public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
		{
			return null;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x26617B0", Offset = "0x265FDB0", VA = "0x1826617B0")]
		public static ActiveAnimation Play(Animation anim, Direction playDirection)
		{
			return null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x26617E0", Offset = "0x265FDE0", VA = "0x1826617E0")]
		public static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
		{
			return null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2661CE0", Offset = "0x26602E0", VA = "0x182661CE0")]
		public ActiveAnimation()
		{
		}

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x0")]
		public static ActiveAnimation current;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x20")]
		public List<EventDelegate> onFinished;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public GameObject eventReceiver;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public string callWhenFinished;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x38")]
		private Animation mAnim;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x40")]
		private Direction mLastDirection;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x44")]
		private Direction mDisableDirection;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x48")]
		private bool mNotify;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x50")]
		private Animator mAnimator;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x58")]
		private string mClip;
	}
}
