using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[Serializable]
	public class IKConstraintBend
	{
		// Token: 0x0600028D RID: 653 RVA: 0x0000326C File Offset: 0x0000146C
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x29216C0", Offset = "0x291FCC0", VA = "0x1829216C0")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00003284 File Offset: 0x00001484
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x2921A20", Offset = "0x2920020", VA = "0x182921A20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x2921A30", Offset = "0x2920030", VA = "0x182921A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2921A40", Offset = "0x2920040", VA = "0x182921A40")]
		public IKConstraintBend()
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2921A90", Offset = "0x2920090", VA = "0x182921A90")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x612090", Offset = "0x610690", VA = "0x180612090")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2921B30", Offset = "0x2920130", VA = "0x182921B30")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2922360", Offset = "0x2920960", VA = "0x182922360")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2922620", Offset = "0x2920C20", VA = "0x182922620")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000329C File Offset: 0x0000149C
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2922F60", Offset = "0x2921560", VA = "0x182922F60")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000032B4 File Offset: 0x000014B4
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2923AF0", Offset = "0x29220F0", VA = "0x182923AF0")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000032CC File Offset: 0x000014CC
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2923C70", Offset = "0x2922270", VA = "0x182923C70")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x10")]
		public Transform bone1;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x18")]
		public Transform bone2;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x20")]
		public Transform bone3;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public float clampF;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;
	}
}
