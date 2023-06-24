using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("NGUI/Tween/Tween Orthographic Size")]
	public class TweenOrthoSize : UITweener
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000BB")]
		public Camera cachedCamera
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x2659D80", Offset = "0x2658380", VA = "0x182659D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002CA RID: 714 RVA: 0x000031C8 File Offset: 0x000013C8
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BC")]
		[Obsolete("Use 'value' instead")]
		public float orthoSize
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x2659EC0", Offset = "0x26584C0", VA = "0x182659EC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x2659F30", Offset = "0x2658530", VA = "0x182659F30")]
			set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002CC RID: 716 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BD")]
		public float value
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x2659EC0", Offset = "0x26584C0", VA = "0x182659EC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x2659F40", Offset = "0x2658540", VA = "0x182659F40")]
			set
			{
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2659FC0", Offset = "0x26585C0", VA = "0x182659FC0", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2659FF0", Offset = "0x26585F0", VA = "0x182659FF0")]
		public static TweenOrthoSize Begin(GameObject go, float duration, float to)
		{
			return null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x265A130", Offset = "0x2658730", VA = "0x18265A130", Slot = "7")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x265A1B0", Offset = "0x26587B0", VA = "0x18265A1B0", Slot = "8")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2657C00", Offset = "0x2656200", VA = "0x182657C00")]
		public TweenOrthoSize()
		{
		}

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x80")]
		public float from;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x84")]
		public float to;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x88")]
		private Camera mCam;
	}
}
