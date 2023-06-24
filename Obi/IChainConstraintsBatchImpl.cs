using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	public interface IChainConstraintsBatchImpl : IConstraintsBatchImpl
	{
		// Token: 0x0600044E RID: 1102
		[Token(Token = "0x600044E")]
		void SetChainConstraints(ObiNativeIntList particleIndices, ObiNativeVector2List restLengths, ObiNativeIntList firstIndex, ObiNativeIntList numIndex, int count);
	}
}
