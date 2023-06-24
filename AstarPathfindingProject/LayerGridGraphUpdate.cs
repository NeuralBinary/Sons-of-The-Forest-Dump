using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	public class LayerGridGraphUpdate : GraphUpdateObject
	{
		// Token: 0x060005CC RID: 1484 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x691300", Offset = "0x68F900", VA = "0x180691300")]
		public LayerGridGraphUpdate()
		{
		}

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x70")]
		public bool recalculateNodes;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x71")]
		public bool preserveExistingNodes;
	}
}
