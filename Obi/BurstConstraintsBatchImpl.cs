using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public abstract class BurstConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x1700006C")]
		public Oni.ConstraintType constraintType
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "4")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00002E7C File Offset: 0x0000107C
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700006D")]
		public bool enabled
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x150B770", Offset = "0x1509D70", VA = "0x18150B770", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x2777200", Offset = "0x2775800", VA = "0x182777200", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700006E")]
		public IConstraints constraints
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700006F")]
		public ObiSolver solverAbstraction
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x2777210", Offset = "0x2775810", VA = "0x182777210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000070")]
		public BurstSolverImpl solverImplementation
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x27772B0", Offset = "0x27758B0", VA = "0x1827772B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2777350", Offset = "0x2775950", VA = "0x182777350", Slot = "11")]
		public virtual JobHandle Initialize(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x060002CC RID: 716
		[Token(Token = "0x60002CC")]
		public abstract JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps);

		// Token: 0x060002CD RID: 717
		[Token(Token = "0x60002CD")]
		public abstract JobHandle Apply(JobHandle inputDeps, float substepTime);

		// Token: 0x060002CE RID: 718 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		public virtual void Destroy()
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590", Slot = "9")]
		public void SetConstraintCount(int constraintCount)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "10")]
		public int GetConstraintCount()
		{
			return 0;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x27773E0", Offset = "0x27759E0", VA = "0x1827773E0")]
		public static void ApplyPositionDelta(int particleIndex, float sorFactor, ref NativeArray<float4> positions, ref NativeArray<float4> deltas, ref NativeArray<int> counts)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2777520", Offset = "0x2775B20", VA = "0x182777520")]
		public static void ApplyOrientationDelta(int particleIndex, float sorFactor, ref NativeArray<quaternion> orientations, ref NativeArray<quaternion> deltas, ref NativeArray<int> counts)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x27776C0", Offset = "0x2775CC0", VA = "0x1827776C0")]
		protected BurstConstraintsBatchImpl()
		{
		}

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x10")]
		protected IBurstConstraintsImpl m_Constraints;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x18")]
		protected Oni.ConstraintType m_ConstraintType;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x1C")]
		protected bool m_Enabled;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x20")]
		protected int m_ConstraintCount;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x28")]
		protected NativeArray<int> particleIndices;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x38")]
		protected NativeArray<float> lambdas;
	}
}
