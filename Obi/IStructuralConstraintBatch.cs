using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	public interface IStructuralConstraintBatch
	{
		// Token: 0x0600051B RID: 1307
		[Token(Token = "0x600051B")]
		float GetRestLength(int index);

		// Token: 0x0600051C RID: 1308
		[Token(Token = "0x600051C")]
		void SetRestLength(int index, float restLength);

		// Token: 0x0600051D RID: 1309
		[Token(Token = "0x600051D")]
		ParticlePair GetParticleIndices(int index);
	}
}
