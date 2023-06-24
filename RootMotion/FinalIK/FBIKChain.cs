using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[Serializable]
	public class FBIKChain
	{
		// Token: 0x06000271 RID: 625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x291D150", Offset = "0x291B750", VA = "0x18291D150")]
		public FBIKChain()
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x291D390", Offset = "0x291B990", VA = "0x18291D390")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x291D670", Offset = "0x291BC70", VA = "0x18291D670")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x291D930", Offset = "0x291BF30", VA = "0x18291D930")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return 0;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x291DAC0", Offset = "0x291C0C0", VA = "0x18291DAC0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x291DC70", Offset = "0x291C270", VA = "0x18291DC70")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x291DF00", Offset = "0x291C500", VA = "0x18291DF00")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x291E5B0", Offset = "0x291CBB0", VA = "0x18291E5B0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x291EC80", Offset = "0x291D280", VA = "0x18291EC80")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000031F4 File Offset: 0x000013F4
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x291F090", Offset = "0x291D690", VA = "0x18291F090")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x291F4C0", Offset = "0x291DAC0", VA = "0x18291F4C0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x291F880", Offset = "0x291DE80", VA = "0x18291F880")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x291FD30", Offset = "0x291E330", VA = "0x18291FD30")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2920000", Offset = "0x291E600", VA = "0x182920000")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000320C File Offset: 0x0000140C
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2920300", Offset = "0x291E900", VA = "0x182920300")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00003224 File Offset: 0x00001424
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2920470", Offset = "0x291EA70", VA = "0x182920470")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2920700", Offset = "0x291ED00", VA = "0x182920700")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2920AB0", Offset = "0x291F0B0", VA = "0x182920AB0")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2920C80", Offset = "0x291F280", VA = "0x182920C80")]
		public void ForwardReach(Vector3 position)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2920DD0", Offset = "0x291F3D0", VA = "0x182920DD0")]
		private void BackwardReach(Vector3 position)
		{
		}

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x24")]
		public FBIKChain.Smoothing reachSmoothing;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x28")]
		public FBIKChain.Smoothing pushSmoothing;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x38")]
		public int[] children;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x40")]
		public FBIKChain.ChildConstraint[] childConstraints;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x50")]
		private float rootLength;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x54")]
		private bool initiated;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x58")]
		private float length;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x5C")]
		private float distance;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x68")]
		private float reachForce;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		private const float maxLimbLength = 0.99999f;

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		[Serializable]
		public class ChildConstraint
		{
			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000285 RID: 645 RVA: 0x0000323C File Offset: 0x0000143C
			// (set) Token: 0x06000286 RID: 646 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000033")]
			public float nominalDistance
			{
				[Token(Token = "0x6000285")]
				[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000286")]
				[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000287 RID: 647 RVA: 0x00003254 File Offset: 0x00001454
			// (set) Token: 0x06000288 RID: 648 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x6000287")]
				[Address(RVA = "0x9DD210", Offset = "0x9DB810", VA = "0x1809DD210")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000288")]
				[Address(RVA = "0x9DD220", Offset = "0x9DB820", VA = "0x1809DD220")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000289 RID: 649 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x2920F90", Offset = "0x291F590", VA = "0x182920F90")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			// Token: 0x0600028A RID: 650 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x2921060", Offset = "0x291F660", VA = "0x182921060")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			// Token: 0x0600028B RID: 651 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x29210C0", Offset = "0x291F6C0", VA = "0x1829210C0")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			// Token: 0x0600028C RID: 652 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x29213A0", Offset = "0x291F9A0", VA = "0x1829213A0")]
			public void Solve(IKSolverFullBody solver)
			{
			}

			// Token: 0x04000220 RID: 544
			[Token(Token = "0x4000220")]
			[FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			// Token: 0x04000221 RID: 545
			[Token(Token = "0x4000221")]
			[FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			// Token: 0x04000222 RID: 546
			[Token(Token = "0x4000222")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			// Token: 0x04000223 RID: 547
			[Token(Token = "0x4000223")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			// Token: 0x04000226 RID: 550
			[Token(Token = "0x4000226")]
			[FieldOffset(Offset = "0x30")]
			private float crossFade;

			// Token: 0x04000227 RID: 551
			[Token(Token = "0x4000227")]
			[FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			[FieldOffset(Offset = "0x38")]
			private int chain1Index;

			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			[FieldOffset(Offset = "0x3C")]
			private int chain2Index;
		}

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		[Serializable]
		public enum Smoothing
		{
			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			None,
			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			Exponential,
			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			Cubic
		}
	}
}
