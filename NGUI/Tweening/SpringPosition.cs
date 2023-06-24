using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[AddComponentMenu("NGUI/Tween/Spring Position")]
	public class SpringPosition : MonoBehaviour
	{
		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x26562B0", Offset = "0x26548B0", VA = "0x1826562B0")]
		private void Start()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2656480", Offset = "0x2654A80", VA = "0x182656480")]
		private void Update()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2656C30", Offset = "0x2655230", VA = "0x182656C30")]
		private void NotifyListeners()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2656E30", Offset = "0x2655430", VA = "0x182656E30")]
		public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
		{
			return null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2657040", Offset = "0x2655640", VA = "0x182657040")]
		public SpringPosition()
		{
		}

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x0")]
		public static SpringPosition current;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 target;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x2C")]
		public float strength;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x30")]
		public bool worldSpace;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x31")]
		public bool ignoreTimeScale;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x32")]
		public bool updateScrollView;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x38")]
		public SpringPosition.OnFinished onFinished;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		private GameObject eventReceiver;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public string callWhenFinished;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x50")]
		private Transform mTrans;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x58")]
		private float mThreshold;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x60")]
		private UIScrollView mSv;

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600028E RID: 654
		[Token(Token = "0x200004A")]
		public delegate void OnFinished();
	}
}
