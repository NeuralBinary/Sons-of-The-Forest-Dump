using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	public interface IEffigySupport : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000AC3 RID: 2755
		[Token(Token = "0x6000AC3")]
		bool CanHostNewEffigy();

		// Token: 0x06000AC4 RID: 2756
		[Token(Token = "0x6000AC4")]
		void SetEffigy(EffigyStructure effigy);
	}
}
