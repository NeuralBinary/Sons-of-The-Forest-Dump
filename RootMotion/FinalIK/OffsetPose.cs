using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	public class OffsetPose : MonoBehaviour
	{
		// Token: 0x0600063F RID: 1599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2996C70", Offset = "0x2995270", VA = "0x182996C70")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2996DB0", Offset = "0x29953B0", VA = "0x182996DB0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x2996E70", Offset = "0x2995470", VA = "0x182996E70")]
		public OffsetPose()
		{
		}

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x20")]
		public OffsetPose.EffectorLink[] effectorLinks;

		// Token: 0x020000C3 RID: 195
		[Token(Token = "0x20000C3")]
		[Serializable]
		public class EffectorLink
		{
			// Token: 0x06000642 RID: 1602 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x2996F30", Offset = "0x2995530", VA = "0x182996F30")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			// Token: 0x06000643 RID: 1603 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public EffectorLink()
			{
			}

			// Token: 0x040005A7 RID: 1447
			[Token(Token = "0x40005A7")]
			[FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			// Token: 0x040005A8 RID: 1448
			[Token(Token = "0x40005A8")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			// Token: 0x040005A9 RID: 1449
			[Token(Token = "0x40005A9")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			// Token: 0x040005AA RID: 1450
			[Token(Token = "0x40005AA")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;
		}
	}
}
