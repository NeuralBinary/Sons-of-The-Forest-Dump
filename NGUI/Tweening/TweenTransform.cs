using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[AddComponentMenu("NGUI/Tween/Tween Transform")]
	public class TweenTransform : UITweener
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00003288 File Offset: 0x00001488
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		public static int ActiveTransformTweener
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x265C200", Offset = "0x265A800", VA = "0x18265C200")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x265C240", Offset = "0x265A840", VA = "0x18265C240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x265C280", Offset = "0x265A880", VA = "0x18265C280")]
		protected void OnEnable()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x265C2F0", Offset = "0x265A8F0", VA = "0x18265C2F0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x265C370", Offset = "0x265A970", VA = "0x18265C370", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x265D060", Offset = "0x265B660", VA = "0x18265D060")]
		public static TweenTransform Begin(GameObject go, float duration, Transform to)
		{
			return null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x265D1E0", Offset = "0x265B7E0", VA = "0x18265D1E0")]
		public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to)
		{
			return null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x265AC00", Offset = "0x2659200", VA = "0x18265AC00")]
		public TweenTransform()
		{
		}

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x80")]
		public Transform from;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x88")]
		public Transform to;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x90")]
		public bool parentWhenFinished;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x98")]
		private Transform mTrans;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 mPos;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0xAC")]
		private Quaternion mRot;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0xBC")]
		private Vector3 mScale;
	}
}
