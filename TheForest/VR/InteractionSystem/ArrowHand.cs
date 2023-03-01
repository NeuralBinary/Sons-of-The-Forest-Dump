using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace TheForest.VR.InteractionSystem
{
	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	public class ArrowHand : MonoBehaviour
	{
		// Token: 0x0600189B RID: 6299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x2CC14F0", Offset = "0x2CC04F0", VA = "0x182CC14F0")]
		private void Awake()
		{
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x2CC22E0", Offset = "0x2CC12E0", VA = "0x182CC22E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x2CC2200", Offset = "0x2CC1200", VA = "0x182CC2200")]
		private void OnAttachedToHand(Hand attachedHand)
		{
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x2CC1F60", Offset = "0x2CC0F60", VA = "0x182CC1F60")]
		private GameObject InstantiateArrow()
		{
			return null;
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x2CC15E0", Offset = "0x2CC05E0", VA = "0x182CC15E0")]
		private void HandAttachedUpdate(Hand hand)
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x2CC2370", Offset = "0x2CC1370", VA = "0x182CC2370")]
		public void ReleaseNock()
		{
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x2CC2280", Offset = "0x2CC1280", VA = "0x182CC2280")]
		private void OnDetachedFromHand(Hand hand)
		{
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void FireArrow()
		{
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x2CC1560", Offset = "0x2CC0560", VA = "0x182CC1560")]
		private void EnableArrowSpawn()
		{
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x2CC1480", Offset = "0x2CC0480", VA = "0x182CC1480")]
		private IEnumerator ArrowReleaseHaptics()
		{
			return null;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x921FE0", Offset = "0x920FE0", VA = "0x180921FE0")]
		private void OnHandFocusLost(Hand hand)
		{
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x2CC2340", Offset = "0x2CC1340", VA = "0x182CC2340")]
		private void OnHandFocusAcquired(Hand hand)
		{
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x2CC1570", Offset = "0x2CC0570", VA = "0x182CC1570")]
		private void FindBow(Hand hand)
		{
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x2CC2690", Offset = "0x2CC1690", VA = "0x182CC2690")]
		public ArrowHand()
		{
		}

		// Token: 0x04001834 RID: 6196
		[Token(Token = "0x4001834")]
		[FieldOffset(Offset = "0x20")]
		private Hand hand;

		// Token: 0x04001835 RID: 6197
		[Token(Token = "0x4001835")]
		[FieldOffset(Offset = "0x28")]
		private Longbow bow;

		// Token: 0x04001836 RID: 6198
		[Token(Token = "0x4001836")]
		[FieldOffset(Offset = "0x30")]
		public GameObject currentArrow;

		// Token: 0x04001837 RID: 6199
		[Token(Token = "0x4001837")]
		[FieldOffset(Offset = "0x38")]
		public GameObject arrowPrefab;

		// Token: 0x04001838 RID: 6200
		[Token(Token = "0x4001838")]
		[FieldOffset(Offset = "0x40")]
		public Transform arrowNockTransform;

		// Token: 0x04001839 RID: 6201
		[Token(Token = "0x4001839")]
		[FieldOffset(Offset = "0x48")]
		public Transform arrowFollowTransform;

		// Token: 0x0400183A RID: 6202
		[Token(Token = "0x400183A")]
		[FieldOffset(Offset = "0x50")]
		public Transform nockPositionTransform;

		// Token: 0x0400183B RID: 6203
		[Token(Token = "0x400183B")]
		[FieldOffset(Offset = "0x58")]
		public float nockDistance;

		// Token: 0x0400183C RID: 6204
		[Token(Token = "0x400183C")]
		[FieldOffset(Offset = "0x5C")]
		public float lerpCompleteDistance;

		// Token: 0x0400183D RID: 6205
		[Token(Token = "0x400183D")]
		[FieldOffset(Offset = "0x60")]
		public float rotationLerpThreshold;

		// Token: 0x0400183E RID: 6206
		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x64")]
		public float positionLerpThreshold;

		// Token: 0x0400183F RID: 6207
		[Token(Token = "0x400183F")]
		[FieldOffset(Offset = "0x68")]
		private bool allowArrowSpawn;

		// Token: 0x04001840 RID: 6208
		[Token(Token = "0x4001840")]
		[FieldOffset(Offset = "0x69")]
		private bool nocked;

		// Token: 0x04001841 RID: 6209
		[Token(Token = "0x4001841")]
		[FieldOffset(Offset = "0x6A")]
		private bool inNockRange;

		// Token: 0x04001842 RID: 6210
		[Token(Token = "0x4001842")]
		[FieldOffset(Offset = "0x6B")]
		private bool arrowLerpComplete;

		// Token: 0x04001843 RID: 6211
		[Token(Token = "0x4001843")]
		[FieldOffset(Offset = "0x70")]
		public SoundPlayOneshot arrowSpawnSound;

		// Token: 0x04001844 RID: 6212
		[Token(Token = "0x4001844")]
		[FieldOffset(Offset = "0x78")]
		public int maxArrowCount;

		// Token: 0x04001845 RID: 6213
		[Token(Token = "0x4001845")]
		[FieldOffset(Offset = "0x80")]
		private List<GameObject> arrowList;

		// Token: 0x04001846 RID: 6214
		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0x88")]
		public bool useCustomScale;
	}
}
