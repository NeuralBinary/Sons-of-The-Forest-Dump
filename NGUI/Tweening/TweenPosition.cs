using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[AddComponentMenu("NGUI/Tween/Tween Position")]
	public class TweenPosition : UITweener
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000BE")]
		public Transform cachedTransform
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x265A230", Offset = "0x2658830", VA = "0x18265A230")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000031F8 File Offset: 0x000013F8
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BF")]
		[Obsolete("Use 'value' instead")]
		public Vector3 position
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x265A390", Offset = "0x2658990", VA = "0x18265A390")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x265A3C0", Offset = "0x26589C0", VA = "0x18265A3C0")]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00003210 File Offset: 0x00001410
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C0")]
		public Vector3 value
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x265A3F0", Offset = "0x26589F0", VA = "0x18265A3F0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x265A4F0", Offset = "0x2658AF0", VA = "0x18265A4F0")]
			set
			{
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x265A7A0", Offset = "0x2658DA0", VA = "0x18265A7A0")]
		private void Awake()
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x265A830", Offset = "0x2658E30", VA = "0x18265A830", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x265A8F0", Offset = "0x2658EF0", VA = "0x18265A8F0")]
		public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
		{
			return null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x265AA00", Offset = "0x2659000", VA = "0x18265AA00")]
		public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
		{
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x265AB20", Offset = "0x2659120", VA = "0x18265AB20", Slot = "7")]
		[ContextMenu("Set 'From' to current value")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x265AB60", Offset = "0x2659160", VA = "0x18265AB60", Slot = "8")]
		[ContextMenu("Set 'To' to current value")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x265ABA0", Offset = "0x26591A0", VA = "0x18265ABA0")]
		[ContextMenu("Assume value of 'From'")]
		private void SetCurrentValueToStart()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x265ABD0", Offset = "0x26591D0", VA = "0x18265ABD0")]
		[ContextMenu("Assume value of 'To'")]
		private void SetCurrentValueToEnd()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x265AC00", Offset = "0x2659200", VA = "0x18265AC00")]
		public TweenPosition()
		{
		}

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x80")]
		public Vector3 from;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x8C")]
		public Vector3 to;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool worldSpace;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0xA0")]
		private Transform mTrans;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0xA8")]
		private UIRect mRect;
	}
}
