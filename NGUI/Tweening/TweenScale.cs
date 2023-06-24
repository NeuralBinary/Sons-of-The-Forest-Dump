using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[AddComponentMenu("NGUI/Tween/Tween Scale")]
	public class TweenScale : UITweener
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C4")]
		public Transform cachedTransform
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x265B720", Offset = "0x2659D20", VA = "0x18265B720")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00003258 File Offset: 0x00001458
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C5")]
		public Vector3 value
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x265B880", Offset = "0x2659E80", VA = "0x18265B880")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x265B920", Offset = "0x2659F20", VA = "0x18265B920")]
			set
			{
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00003270 File Offset: 0x00001470
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C6")]
		[Obsolete("Use 'value' instead")]
		public Vector3 scale
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x265B880", Offset = "0x2659E80", VA = "0x18265B880")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x265B920", Offset = "0x2659F20", VA = "0x18265B920")]
			set
			{
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x265B9B0", Offset = "0x2659FB0", VA = "0x18265B9B0", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x265BD70", Offset = "0x265A370", VA = "0x18265BD70")]
		public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
		{
			return null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x265BEE0", Offset = "0x265A4E0", VA = "0x18265BEE0", Slot = "7")]
		[ContextMenu("Set 'From' to current value")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x265BF80", Offset = "0x265A580", VA = "0x18265BF80", Slot = "8")]
		[ContextMenu("Set 'To' to current value")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x265C020", Offset = "0x265A620", VA = "0x18265C020")]
		[ContextMenu("Assume value of 'From'")]
		private void SetCurrentValueToStart()
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x265C0C0", Offset = "0x265A6C0", VA = "0x18265C0C0")]
		[ContextMenu("Assume value of 'To'")]
		private void SetCurrentValueToEnd()
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x265C160", Offset = "0x265A760", VA = "0x18265C160")]
		public TweenScale()
		{
		}

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x80")]
		public Vector3 from;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x8C")]
		public Vector3 to;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x98")]
		public bool updateTable;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0xA0")]
		private Transform mTrans;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0xA8")]
		private UITable mTable;
	}
}
