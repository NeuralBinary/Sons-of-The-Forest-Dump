using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	public abstract class OniConstraintsImpl : IOniConstraintsImpl, IConstraints
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700008E")]
		public ISolverImpl solver
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[Token(Token = "0x1700008F")]
		public Oni.ConstraintType constraintType
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "6")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x27ABD70", Offset = "0x27AA370", VA = "0x1827ABD70")]
		public OniConstraintsImpl(OniSolverImpl solver, Oni.ConstraintType constraintType)
		{
		}

		// Token: 0x060004C4 RID: 1220
		[Token(Token = "0x60004C4")]
		public abstract IConstraintsBatchImpl CreateConstraintsBatch();

		// Token: 0x060004C5 RID: 1221
		[Token(Token = "0x60004C5")]
		public abstract void RemoveBatch(IConstraintsBatchImpl batch);

		// Token: 0x060004C6 RID: 1222 RVA: 0x00003CBC File Offset: 0x00001EBC
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x27ABDD0", Offset = "0x27AA3D0", VA = "0x1827ABDD0", Slot = "8")]
		public int GetConstraintCount()
		{
			return 0;
		}

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x10")]
		protected OniSolverImpl m_Solver;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x18")]
		protected Oni.ConstraintType m_ConstraintType;
	}
}
