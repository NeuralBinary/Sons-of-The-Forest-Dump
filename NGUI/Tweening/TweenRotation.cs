using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Tweening
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[AddComponentMenu("NGUI/Tween/Tween Rotation")]
	public class TweenRotation : UITweener
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C1")]
		public Transform cachedTransform
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x265AC10", Offset = "0x2659210", VA = "0x18265AC10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00003228 File Offset: 0x00001428
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C2")]
		[Obsolete("Use 'value' instead")]
		public Quaternion rotation
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x265AD70", Offset = "0x2659370", VA = "0x18265AD70")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x265AE00", Offset = "0x2659400", VA = "0x18265AE00")]
			set
			{
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00003240 File Offset: 0x00001440
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C3")]
		public Quaternion value
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x265AD70", Offset = "0x2659370", VA = "0x18265AD70")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x265AE00", Offset = "0x2659400", VA = "0x18265AE00")]
			set
			{
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x265AE80", Offset = "0x2659480", VA = "0x18265AE80", Slot = "6")]
		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x265B1F0", Offset = "0x26597F0", VA = "0x18265B1F0")]
		public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
		{
			return null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x265B380", Offset = "0x2659980", VA = "0x18265B380", Slot = "7")]
		[ContextMenu("Set 'From' to current value")]
		public override void SetStartToCurrentValue()
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x265B430", Offset = "0x2659A30", VA = "0x18265B430", Slot = "8")]
		[ContextMenu("Set 'To' to current value")]
		public override void SetEndToCurrentValue()
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x265B4E0", Offset = "0x2659AE0", VA = "0x18265B4E0")]
		[ContextMenu("Assume value of 'From'")]
		private void SetCurrentValueToStart()
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x265B600", Offset = "0x2659C00", VA = "0x18265B600")]
		[ContextMenu("Assume value of 'To'")]
		private void SetCurrentValueToEnd()
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x265AC00", Offset = "0x2659200", VA = "0x18265AC00")]
		public TweenRotation()
		{
		}

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x80")]
		public Vector3 from;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x8C")]
		public Vector3 to;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x98")]
		public bool quaternionLerp;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0xA0")]
		private Transform mTrans;
	}
}
