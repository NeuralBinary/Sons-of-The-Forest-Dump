using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000254 RID: 596
	[Token(Token = "0x2000254")]
	public interface IMeshComponentManager
	{
		// Token: 0x0600152B RID: 5419
		[Token(Token = "0x600152B")]
		void AddComponent(MeshDecomposition.Component C);

		// Token: 0x0600152C RID: 5420
		[Token(Token = "0x600152C")]
		void ClearAllComponents();
	}
}
