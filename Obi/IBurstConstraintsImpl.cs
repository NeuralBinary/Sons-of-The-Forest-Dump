using System;
using Il2CppDummyDll;
using Unity.Jobs;

namespace Obi
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public interface IBurstConstraintsImpl : IConstraints
	{
		// Token: 0x060002D4 RID: 724
		[Token(Token = "0x60002D4")]
		JobHandle Initialize(JobHandle inputDeps, float substepTime);

		// Token: 0x060002D5 RID: 725
		[Token(Token = "0x60002D5")]
		JobHandle Project(JobHandle inputDeps, float stepTime, float substepTime, int substeps);

		// Token: 0x060002D6 RID: 726
		[Token(Token = "0x60002D6")]
		void Dispose();

		// Token: 0x060002D7 RID: 727
		[Token(Token = "0x60002D7")]
		IConstraintsBatchImpl CreateConstraintsBatch();

		// Token: 0x060002D8 RID: 728
		[Token(Token = "0x60002D8")]
		void RemoveBatch(IConstraintsBatchImpl batch);
	}
}
