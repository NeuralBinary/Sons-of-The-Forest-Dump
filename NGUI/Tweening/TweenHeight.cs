using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[RequireComponent(typeof(UIWidget))]
	[AddComponentMenu("NGUI/Tween/Tween Height")]
	public class TweenHeight : UITweener
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000B8")]
		public UIWidget cachedWidget
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x26596C0", Offset = "0x2657CC0", VA = "0x1826596C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00003198 File Offset: 0x00001398
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B9")]
		[Obsolete("Use 'value' instead")]
		public int height
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x2659800", Offset = "0x2657E00", VA = "0x182659800")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x2659830", Offset = "0x2657E30", VA = "0x182659830")]
			set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000031B0 File Offset: 0x000013B0
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BA")]
		public int value
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x2659800", Offset = "0x2657E00", VA = "0x182659800")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x2659830", Offset = "0x2657E30", VA = "0x182659830")]
			set
			{
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2659860", Offset = "0x2657E60", VA = "0x182659860", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2659B70", Offset = "0x2658170", VA = "0x182659B70")]
		public static TweenHeight Begin(UIWidget widget, float duration, int height)
		{
			return null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x2659CA0", Offset = "0x26582A0", VA = "0x182659CA0", Slot = "7")]
		[ContextMenu("Set 'From' to current value")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2659CD0", Offset = "0x26582D0", VA = "0x182659CD0", Slot = "8")]
		[ContextMenu("Set 'To' to current value")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2659D00", Offset = "0x2658300", VA = "0x182659D00")]
		[ContextMenu("Assume value of 'From'")]
		private void SetCurrentValueToStart()
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2659D30", Offset = "0x2658330", VA = "0x182659D30")]
		[ContextMenu("Assume value of 'To'")]
		private void SetCurrentValueToEnd()
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2659D60", Offset = "0x2658360", VA = "0x182659D60")]
		public TweenHeight()
		{
		}

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x80")]
		public int from;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x84")]
		public int to;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x88")]
		public bool updateTable;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x90")]
		private UIWidget mWidget;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x98")]
		private UITable mTable;
	}
}
