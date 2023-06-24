using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[AddComponentMenu("NGUI/Tween/Tween Fill")]
	[RequireComponent(typeof(UIBasicSprite))]
	public class TweenFill : UITweener
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2658C60", Offset = "0x2657260", VA = "0x182658C60")]
		private void Cache()
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00003150 File Offset: 0x00001350
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B4")]
		public float value
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x2658D00", Offset = "0x2657300", VA = "0x182658D00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x2658E00", Offset = "0x2657400", VA = "0x182658E00")]
			set
			{
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2658F30", Offset = "0x2657530", VA = "0x182658F30", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x26590A0", Offset = "0x26576A0", VA = "0x1826590A0")]
		public static TweenFill Begin(GameObject go, float duration, float fill)
		{
			return null;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2659190", Offset = "0x2657790", VA = "0x182659190", Slot = "7")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x26591B0", Offset = "0x26577B0", VA = "0x1826591B0", Slot = "8")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2657C00", Offset = "0x2656200", VA = "0x182657C00")]
		public TweenFill()
		{
		}

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float from;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float to;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x88")]
		private bool mCached;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x90")]
		private UIBasicSprite mSprite;
	}
}
