using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	public interface ISuperStructureNode
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060003EE RID: 1006
		[Token(Token = "0x17000163")]
		SuperStructure SuperStructure { [Token(Token = "0x60003EE")] get; }

		// Token: 0x060003EF RID: 1007
		[Token(Token = "0x60003EF")]
		void SetSuperStructure(SuperStructure superStructure);
	}
}
