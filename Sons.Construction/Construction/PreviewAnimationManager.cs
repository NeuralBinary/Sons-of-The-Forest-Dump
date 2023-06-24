using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	[AddComponentMenu("Sons/Construction/PreviewAnimationManager")]
	public class PreviewAnimationManager : MonoBehaviour
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000243")]
		public Transform TargetTr
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x2E3C470", Offset = "0x2E3AA70", VA = "0x182E3C470")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x2E3C5A0", Offset = "0x2E3ABA0", VA = "0x182E3C5A0")]
		private void Awake()
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x2E3C970", Offset = "0x2E3AF70", VA = "0x182E3C970")]
		private void Update()
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x2E3CBF0", Offset = "0x2E3B1F0", VA = "0x182E3CBF0")]
		internal void Play(ClipTypes clipType, TweenTypes tweenType, Transform target)
		{
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x2E3CC50", Offset = "0x2E3B250", VA = "0x182E3CC50")]
		internal void Stop()
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x2E3CD10", Offset = "0x2E3B310", VA = "0x182E3CD10")]
		private void SetActiveTarget(Transform targetTr, Tweener tweener, AnimationClip clip)
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PreviewAnimationManager()
		{
		}

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Tweener[] _tweeners;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationClip[] _clips;

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x30")]
		private Transform _animationShell;

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x38")]
		private Transform _animationRenderableShell;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x40")]
		private GameObject _activeTarget;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x48")]
		private Tweener _activeTweener;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x50")]
		private AnimationClip _activeClip;
	}
}
