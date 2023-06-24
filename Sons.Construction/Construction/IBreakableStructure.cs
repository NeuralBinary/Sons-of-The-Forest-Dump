using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	public interface IBreakableStructure : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000708 RID: 1800
		[Token(Token = "0x17000238")]
		bool IsReinforced { [Token(Token = "0x6000708")] get; }

		// Token: 0x06000709 RID: 1801
		[Token(Token = "0x6000709")]
		bool IsBreakable();

		// Token: 0x0600070A RID: 1802
		[Token(Token = "0x600070A")]
		float CalcBreakForce();
	}
}
