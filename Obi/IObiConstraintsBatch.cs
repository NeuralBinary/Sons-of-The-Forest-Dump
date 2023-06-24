using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	public interface IObiConstraintsBatch
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000546 RID: 1350
		[Token(Token = "0x1700009A")]
		int constraintCount { [Token(Token = "0x6000546")] get; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000547 RID: 1351
		// (set) Token: 0x06000548 RID: 1352
		[Token(Token = "0x1700009B")]
		int activeConstraintCount { [Token(Token = "0x6000547")] get; [Token(Token = "0x6000548")] set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000549 RID: 1353
		// (set) Token: 0x0600054A RID: 1354
		[Token(Token = "0x1700009C")]
		int initialActiveConstraintCount { [Token(Token = "0x6000549")] get; [Token(Token = "0x600054A")] set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600054B RID: 1355
		[Token(Token = "0x1700009D")]
		Oni.ConstraintType constraintType { [Token(Token = "0x600054B")] get; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600054C RID: 1356
		[Token(Token = "0x1700009E")]
		IConstraintsBatchImpl implementation { [Token(Token = "0x600054C")] get; }

		// Token: 0x0600054D RID: 1357
		[Token(Token = "0x600054D")]
		void AddToSolver(ObiSolver solver);

		// Token: 0x0600054E RID: 1358
		[Token(Token = "0x600054E")]
		void RemoveFromSolver(ObiSolver solver);

		// Token: 0x0600054F RID: 1359
		[Token(Token = "0x600054F")]
		void Merge(ObiActor actor, IObiConstraintsBatch other);

		// Token: 0x06000550 RID: 1360
		[Token(Token = "0x6000550")]
		bool DeactivateConstraint(int constraintIndex);

		// Token: 0x06000551 RID: 1361
		[Token(Token = "0x6000551")]
		bool ActivateConstraint(int constraintIndex);

		// Token: 0x06000552 RID: 1362
		[Token(Token = "0x6000552")]
		void DeactivateAllConstraints();

		// Token: 0x06000553 RID: 1363
		[Token(Token = "0x6000553")]
		void Clear();

		// Token: 0x06000554 RID: 1364
		[Token(Token = "0x6000554")]
		void GetParticlesInvolved(int index, List<int> particles);

		// Token: 0x06000555 RID: 1365
		[Token(Token = "0x6000555")]
		void ParticlesSwapped(int index, int newIndex);
	}
}
