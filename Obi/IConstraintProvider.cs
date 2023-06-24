using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public interface IConstraintProvider
	{
		// Token: 0x060003DF RID: 991
		[Token(Token = "0x60003DF")]
		int GetConstraintCount();

		// Token: 0x060003E0 RID: 992
		[Token(Token = "0x60003E0")]
		int GetParticleCount(int constraintIndex);

		// Token: 0x060003E1 RID: 993
		[Token(Token = "0x60003E1")]
		int GetParticle(int constraintIndex, int index);

		// Token: 0x060003E2 RID: 994
		[Token(Token = "0x60003E2")]
		void WriteSortedConstraint(int constraintIndex, int sortedIndex);
	}
}
