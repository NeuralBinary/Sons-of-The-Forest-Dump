using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Serializable]
	public class BipedLimbOrientations
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x150CC50", Offset = "0x150B250", VA = "0x18150CC50")]
		public BipedLimbOrientations(BipedLimbOrientations.LimbOrientation leftArm, BipedLimbOrientations.LimbOrientation rightArm, BipedLimbOrientations.LimbOrientation leftLeg, BipedLimbOrientations.LimbOrientation rightLeg)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x28E4A00", Offset = "0x28E3000", VA = "0x1828E4A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x28E4E30", Offset = "0x28E3430", VA = "0x1828E4E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x10")]
		public BipedLimbOrientations.LimbOrientation leftArm;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x18")]
		public BipedLimbOrientations.LimbOrientation rightArm;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x20")]
		public BipedLimbOrientations.LimbOrientation leftLeg;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x28")]
		public BipedLimbOrientations.LimbOrientation rightLeg;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		[Serializable]
		public class LimbOrientation
		{
			// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x28E5260", Offset = "0x28E3860", VA = "0x1828E5260")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}

			// Token: 0x0400008C RID: 140
			[Token(Token = "0x400008C")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			// Token: 0x0400008D RID: 141
			[Token(Token = "0x400008D")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			// Token: 0x0400008E RID: 142
			[Token(Token = "0x400008E")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;
		}
	}
}
