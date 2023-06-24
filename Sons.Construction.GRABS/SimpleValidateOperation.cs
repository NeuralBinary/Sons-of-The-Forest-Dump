using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public class SimpleValidateOperation : Operation
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2DA6530", Offset = "0x2DA4B30", VA = "0x182DA6530")]
		public void Init(VisualModes mode, InteractionPoint fromIp, BlueprintFace face, Transform aimTransform)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2DA02E0", Offset = "0x2D9E8E0", VA = "0x182DA02E0", Slot = "4")]
		public override bool Update(Transform aimTransform, out bool modifiedFace)
		{
			return default(bool);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2DA6870", Offset = "0x2DA4E70", VA = "0x182DA6870", Slot = "5")]
		public override void Validate()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2DA6B40", Offset = "0x2DA5140", VA = "0x182DA6B40", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2DA6D00", Offset = "0x2DA5300", VA = "0x182DA6D00")]
		public SimpleValidateOperation()
		{
		}

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x28")]
		private float MaxSnapDistance;
	}
}
