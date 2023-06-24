using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[Serializable]
	internal class SnowProfile
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x1700003A")]
		public float SnowHeight
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000228 RID: 552 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x1700003B")]
		public float FadeRange
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x1700003C")]
		public float SnowAmount
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2D4BF20", Offset = "0x2D4A520", VA = "0x182D4BF20")]
		public SnowProfile()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2D4BF40", Offset = "0x2D4A540", VA = "0x182D4BF40")]
		public SnowProfile(SnowProfile defaultSnowProfile)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1FEFE20", Offset = "0x1FEE420", VA = "0x181FEFE20")]
		public SnowProfile(float height, float fadeRange, float snowAmount)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2D4BF80", Offset = "0x2D4A580", VA = "0x182D4BF80")]
		public static SnowProfile Lerp(SnowProfile profileA, SnowProfile profileB, float factor)
		{
			return null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2D4C010", Offset = "0x2D4A610", VA = "0x182D4C010")]
		public static void LerpNonAlloc(SnowProfile profileA, SnowProfile profileB, float factor, ref SnowProfile result)
		{
		}

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Range(0f, 1000f)]
		private float _snowHeight;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _fadeRange;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _snowAmount;
	}
}
