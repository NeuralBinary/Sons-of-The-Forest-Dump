using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	public class MudFloater : MonoBehaviour
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x24361F0", Offset = "0x24347F0", VA = "0x1824361F0")]
		private void Start()
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2436620", Offset = "0x2434C20", VA = "0x182436620")]
		private void OnEnable()
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x2436630", Offset = "0x2434C30", VA = "0x182436630")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2436D10", Offset = "0x2435310", VA = "0x182436D10")]
		public MudFloater()
		{
		}

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 10f)]
		public float Hover;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 10f)]
		public float Omega;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x28")]
		public bool UseLocalSpace;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_hoverCenter;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x38")]
		private Quaternion m_hoverRot;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x48")]
		private float m_hoverPhase;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x4C")]
		public MudFloater.RandomSeedEnum RandomSeed;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x50")]
		[ConditionalField("RandomSeed", 0, null, null, null, null, null, Label = "  Value")]
		public int CustomRandomSeed;

		// Token: 0x02000116 RID: 278
		[Token(Token = "0x2000116")]
		public enum RandomSeedEnum
		{
			// Token: 0x04000452 RID: 1106
			[Token(Token = "0x4000452")]
			Random,
			// Token: 0x04000453 RID: 1107
			[Token(Token = "0x4000453")]
			Position,
			// Token: 0x04000454 RID: 1108
			[Token(Token = "0x4000454")]
			Custom
		}
	}
}
