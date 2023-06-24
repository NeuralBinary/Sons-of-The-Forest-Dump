using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public class FBBIKArmBending : MonoBehaviour
	{
		// Token: 0x0600025B RID: 603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x29158A0", Offset = "0x2913EA0", VA = "0x1829158A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2916400", Offset = "0x2914A00", VA = "0x182916400")]
		private void OnPostFBBIK()
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2916880", Offset = "0x2914E80", VA = "0x182916880")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FBBIKArmBending()
		{
		}

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK ik;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 bendDirectionOffsetLeft;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 bendDirectionOffsetRight;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 characterSpaceBendOffsetLeft;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 characterSpaceBendOffsetRight;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion leftHandTargetRotation;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x68")]
		private Quaternion rightHandTargetRotation;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x78")]
		private bool initiated;
	}
}
