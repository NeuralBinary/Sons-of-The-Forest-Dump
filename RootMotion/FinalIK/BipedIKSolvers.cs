using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[Serializable]
	public class BipedIKSolvers
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000010")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x28F7930", Offset = "0x28F5F30", VA = "0x1828F7930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000129 RID: 297 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x28F7B00", Offset = "0x28F6100", VA = "0x1828F7B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x28F7D90", Offset = "0x28F6390", VA = "0x1828F7D90")]
		public void AssignReferences(BipedReferences references)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x28F8000", Offset = "0x28F6600", VA = "0x1828F8000")]
		public BipedIKSolvers()
		{
		}

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;
	}
}
