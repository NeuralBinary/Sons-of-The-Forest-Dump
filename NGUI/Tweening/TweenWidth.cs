using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[RequireComponent(typeof(UIWidget))]
	[AddComponentMenu("NGUI/Tween/Tween Width")]
	public class TweenWidth : UITweener
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000CB")]
		public UIWidget cachedWidget
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x265DB40", Offset = "0x265C140", VA = "0x18265DB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000032D0 File Offset: 0x000014D0
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CC")]
		[Obsolete("Use 'value' instead")]
		public int width
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x265DC80", Offset = "0x265C280", VA = "0x18265DC80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x265DCB0", Offset = "0x265C2B0", VA = "0x18265DCB0")]
			set
			{
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000032E8 File Offset: 0x000014E8
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CD")]
		public int value
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x265DC80", Offset = "0x265C280", VA = "0x18265DC80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x265DCB0", Offset = "0x265C2B0", VA = "0x18265DCB0")]
			set
			{
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x265DCE0", Offset = "0x265C2E0", VA = "0x18265DCE0", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x265DFF0", Offset = "0x265C5F0", VA = "0x18265DFF0")]
		public static TweenWidth Begin(UIWidget widget, float duration, int width)
		{
			return null;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x265E120", Offset = "0x265C720", VA = "0x18265E120", Slot = "7")]
		[ContextMenu("Set 'From' to current value")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x265E150", Offset = "0x265C750", VA = "0x18265E150", Slot = "8")]
		[ContextMenu("Set 'To' to current value")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x265E180", Offset = "0x265C780", VA = "0x18265E180")]
		[ContextMenu("Assume value of 'From'")]
		private void SetCurrentValueToStart()
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x265E1B0", Offset = "0x265C7B0", VA = "0x18265E1B0")]
		[ContextMenu("Assume value of 'To'")]
		private void SetCurrentValueToEnd()
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x2659D60", Offset = "0x2658360", VA = "0x182659D60")]
		public TweenWidth()
		{
		}

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x80")]
		public int from;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x84")]
		public int to;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x88")]
		public bool updateTable;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x90")]
		private UIWidget mWidget;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x98")]
		private UITable mTable;
	}
}
