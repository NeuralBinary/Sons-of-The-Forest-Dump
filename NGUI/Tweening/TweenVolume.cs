using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[AddComponentMenu("NGUI/Tween/Tween Volume")]
	[RequireComponent(typeof(AudioSource))]
	public class TweenVolume : UITweener
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C8")]
		public AudioSource audioSource
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x265D370", Offset = "0x265B970", VA = "0x18265D370")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000302 RID: 770 RVA: 0x000032A0 File Offset: 0x000014A0
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C9")]
		[Obsolete("Use 'value' instead")]
		public float volume
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x265D690", Offset = "0x265BC90", VA = "0x18265D690")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x265D6A0", Offset = "0x265BCA0", VA = "0x18265D6A0")]
			set
			{
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000304 RID: 772 RVA: 0x000032B8 File Offset: 0x000014B8
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CA")]
		public float value
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x265D6B0", Offset = "0x265BCB0", VA = "0x18265D6B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x265D7E0", Offset = "0x265BDE0", VA = "0x18265D7E0")]
			set
			{
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x265D8D0", Offset = "0x265BED0", VA = "0x18265D8D0", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x265D9C0", Offset = "0x265BFC0", VA = "0x18265D9C0")]
		public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
		{
			return null;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x265DB00", Offset = "0x265C100", VA = "0x18265DB00", Slot = "7")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x265DB20", Offset = "0x265C120", VA = "0x18265DB20", Slot = "8")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2657C00", Offset = "0x2656200", VA = "0x182657C00")]
		public TweenVolume()
		{
		}

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float from;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float to;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x88")]
		private AudioSource mSource;
	}
}
