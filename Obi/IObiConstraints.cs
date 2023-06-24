using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	public interface IObiConstraints
	{
		// Token: 0x0600061C RID: 1564
		[Token(Token = "0x600061C")]
		Oni.ConstraintType? GetConstraintType();

		// Token: 0x0600061D RID: 1565
		[Token(Token = "0x600061D")]
		IObiConstraintsBatch GetBatch(int i);

		// Token: 0x0600061E RID: 1566
		[Token(Token = "0x600061E")]
		int GetBatchCount();

		// Token: 0x0600061F RID: 1567
		[Token(Token = "0x600061F")]
		void Clear();

		// Token: 0x06000620 RID: 1568
		[Token(Token = "0x6000620")]
		bool AddToSolver(ObiSolver solver);

		// Token: 0x06000621 RID: 1569
		[Token(Token = "0x6000621")]
		bool RemoveFromSolver();

		// Token: 0x06000622 RID: 1570
		[Token(Token = "0x6000622")]
		int GetConstraintCount();

		// Token: 0x06000623 RID: 1571
		[Token(Token = "0x6000623")]
		int GetActiveConstraintCount();

		// Token: 0x06000624 RID: 1572
		[Token(Token = "0x6000624")]
		void DeactivateAllConstraints();

		// Token: 0x06000625 RID: 1573
		[Token(Token = "0x6000625")]
		void Merge(ObiActor actor, IObiConstraints other);
	}
}
