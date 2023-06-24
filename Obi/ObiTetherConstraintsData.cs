using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	[Serializable]
	public class ObiTetherConstraintsData : ObiConstraints<ObiTetherConstraintsBatch>
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x27BEDF0", Offset = "0x27BD3F0", VA = "0x1827BEDF0", Slot = "14")]
		public override ObiTetherConstraintsBatch CreateBatch([Optional] ObiTetherConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x27BEE40", Offset = "0x27BD440", VA = "0x1827BEE40")]
		public ObiTetherConstraintsData()
		{
		}
	}
}
