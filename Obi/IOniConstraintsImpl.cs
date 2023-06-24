using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	public interface IOniConstraintsImpl : IConstraints
	{
		// Token: 0x060004BF RID: 1215
		[Token(Token = "0x60004BF")]
		IConstraintsBatchImpl CreateConstraintsBatch();

		// Token: 0x060004C0 RID: 1216
		[Token(Token = "0x60004C0")]
		void RemoveBatch(IConstraintsBatchImpl batch);
	}
}
