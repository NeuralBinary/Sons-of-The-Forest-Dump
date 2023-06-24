using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace TheForest.VR.InteractionSystem
{
	// Token: 0x0200039D RID: 925
	[Token(Token = "0x200039D")]
	public class ArrowHand : MonoBehaviour
	{
		// Token: 0x060018D6 RID: 6358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x3289100", Offset = "0x3287700", VA = "0x183289100")]
		private void Awake()
		{
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x32891B0", Offset = "0x32877B0", VA = "0x1832891B0")]
		private void OnEnable()
		{
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x3289290", Offset = "0x3287890", VA = "0x183289290")]
		private void OnAttachedToHand(Hand attachedHand)
		{
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x32892F0", Offset = "0x32878F0", VA = "0x1832892F0")]
		private GameObject InstantiateArrow()
		{
			return null;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x3289730", Offset = "0x3287D30", VA = "0x183289730")]
		private void HandAttachedUpdate(Hand hand)
		{
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x328A420", Offset = "0x3288A20", VA = "0x18328A420")]
		public void ReleaseNock()
		{
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x328A9B0", Offset = "0x3288FB0", VA = "0x18328A9B0")]
		private void OnDetachedFromHand(Hand hand)
		{
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void FireArrow()
		{
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x328AA40", Offset = "0x3289040", VA = "0x18328AA40")]
		private void EnableArrowSpawn()
		{
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x328AA50", Offset = "0x3289050", VA = "0x18328AA50")]
		private IEnumerator ArrowReleaseHaptics()
		{
			return null;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0xA71C70", Offset = "0xA70270", VA = "0x180A71C70")]
		private void OnHandFocusLost(Hand hand)
		{
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x328AAE0", Offset = "0x32890E0", VA = "0x18328AAE0")]
		private void OnHandFocusAcquired(Hand hand)
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x328AB80", Offset = "0x3289180", VA = "0x18328AB80")]
		private void FindBow(Hand hand)
		{
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x328AC30", Offset = "0x3289230", VA = "0x18328AC30")]
		public ArrowHand()
		{
		}

		// Token: 0x04001853 RID: 6227
		[Token(Token = "0x4001853")]
		[FieldOffset(Offset = "0x20")]
		private Hand hand;

		// Token: 0x04001854 RID: 6228
		[Token(Token = "0x4001854")]
		[FieldOffset(Offset = "0x28")]
		private Longbow bow;

		// Token: 0x04001855 RID: 6229
		[Token(Token = "0x4001855")]
		[FieldOffset(Offset = "0x30")]
		public GameObject currentArrow;

		// Token: 0x04001856 RID: 6230
		[Token(Token = "0x4001856")]
		[FieldOffset(Offset = "0x38")]
		public GameObject arrowPrefab;

		// Token: 0x04001857 RID: 6231
		[Token(Token = "0x4001857")]
		[FieldOffset(Offset = "0x40")]
		public Transform arrowNockTransform;

		// Token: 0x04001858 RID: 6232
		[Token(Token = "0x4001858")]
		[FieldOffset(Offset = "0x48")]
		public Transform arrowFollowTransform;

		// Token: 0x04001859 RID: 6233
		[Token(Token = "0x4001859")]
		[FieldOffset(Offset = "0x50")]
		public Transform nockPositionTransform;

		// Token: 0x0400185A RID: 6234
		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x58")]
		public float nockDistance;

		// Token: 0x0400185B RID: 6235
		[Token(Token = "0x400185B")]
		[FieldOffset(Offset = "0x5C")]
		public float lerpCompleteDistance;

		// Token: 0x0400185C RID: 6236
		[Token(Token = "0x400185C")]
		[FieldOffset(Offset = "0x60")]
		public float rotationLerpThreshold;

		// Token: 0x0400185D RID: 6237
		[Token(Token = "0x400185D")]
		[FieldOffset(Offset = "0x64")]
		public float positionLerpThreshold;

		// Token: 0x0400185E RID: 6238
		[Token(Token = "0x400185E")]
		[FieldOffset(Offset = "0x68")]
		private bool allowArrowSpawn;

		// Token: 0x0400185F RID: 6239
		[Token(Token = "0x400185F")]
		[FieldOffset(Offset = "0x69")]
		private bool nocked;

		// Token: 0x04001860 RID: 6240
		[Token(Token = "0x4001860")]
		[FieldOffset(Offset = "0x6A")]
		private bool inNockRange;

		// Token: 0x04001861 RID: 6241
		[Token(Token = "0x4001861")]
		[FieldOffset(Offset = "0x6B")]
		private bool arrowLerpComplete;

		// Token: 0x04001862 RID: 6242
		[Token(Token = "0x4001862")]
		[FieldOffset(Offset = "0x70")]
		public SoundPlayOneshot arrowSpawnSound;

		// Token: 0x04001863 RID: 6243
		[Token(Token = "0x4001863")]
		[FieldOffset(Offset = "0x78")]
		public int maxArrowCount;

		// Token: 0x04001864 RID: 6244
		[Token(Token = "0x4001864")]
		[FieldOffset(Offset = "0x80")]
		private List<GameObject> arrowList;

		// Token: 0x04001865 RID: 6245
		[Token(Token = "0x4001865")]
		[FieldOffset(Offset = "0x88")]
		public bool useCustomScale;
	}
}
