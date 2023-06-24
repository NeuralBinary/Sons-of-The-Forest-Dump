using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[Serializable]
	public class IKEffector
	{
		// Token: 0x06000299 RID: 665 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2923DF0", Offset = "0x29223F0", VA = "0x182923DF0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000032E4 File Offset: 0x000014E4
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000036")]
		public bool isEndEffector
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2923E50", Offset = "0x2922450", VA = "0x182923E50")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2923FC0", Offset = "0x29225C0", VA = "0x182923FC0")]
		public IKEffector()
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x29242A0", Offset = "0x29228A0", VA = "0x1829242A0")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000032FC File Offset: 0x000014FC
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2924640", Offset = "0x2922C40", VA = "0x182924640")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2924C10", Offset = "0x2923210", VA = "0x182924C10")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x29251E0", Offset = "0x29237E0", VA = "0x1829251E0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x29253B0", Offset = "0x29239B0", VA = "0x1829253B0")]
		public void SetToTarget()
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2925550", Offset = "0x2923B50", VA = "0x182925550")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2925FB0", Offset = "0x29245B0", VA = "0x182925FB0")]
		public void OnPostWrite()
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00003314 File Offset: 0x00001514
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2926000", Offset = "0x2924600", VA = "0x182926000")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2926370", Offset = "0x2924970", VA = "0x182926370")]
		public void Update(IKSolverFullBody solver)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000332C File Offset: 0x0000152C
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2926810", Offset = "0x2924E10", VA = "0x182926810")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x10")]
		public Transform bone;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 position;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x88")]
		private float posW;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x8C")]
		private float rotW;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;
	}
}
