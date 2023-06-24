using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Jobs;

namespace Obi
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public abstract class BurstConstraintsImpl<T> : IBurstConstraintsImpl, IConstraints where T : BurstConstraintsBatchImpl
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x17000071")]
		public Oni.ConstraintType constraintType
		{
			[Token(Token = "0x60002D9")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000072")]
		public ISolverImpl solver
		{
			[Token(Token = "0x60002DA")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002DB")]
		public BurstConstraintsImpl(BurstSolverImpl solver, Oni.ConstraintType constraintType)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002DC")]
		public virtual void Dispose()
		{
		}

		// Token: 0x060002DD RID: 733
		[Token(Token = "0x60002DD")]
		public abstract IConstraintsBatchImpl CreateConstraintsBatch();

		// Token: 0x060002DE RID: 734
		[Token(Token = "0x60002DE")]
		public abstract void RemoveBatch(IConstraintsBatchImpl batch);

		// Token: 0x060002DF RID: 735 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x60002DF")]
		public virtual int GetConstraintCount()
		{
			return 0;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x60002E0")]
		public JobHandle Initialize(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x60002E1")]
		public JobHandle Project(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x60002E2")]
		protected virtual JobHandle EvaluateSequential(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x60002E3")]
		protected virtual JobHandle EvaluateParallel(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x0")]
		protected BurstSolverImpl m_Solver;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x0")]
		public List<T> batches;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x0")]
		protected Oni.ConstraintType m_ConstraintType;
	}
}
