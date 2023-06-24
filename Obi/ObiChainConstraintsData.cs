using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	[Serializable]
	public class ObiChainConstraintsData : ObiConstraints<ObiChainConstraintsBatch>
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x27BEA90", Offset = "0x27BD090", VA = "0x1827BEA90", Slot = "14")]
		public override ObiChainConstraintsBatch CreateBatch([Optional] ObiChainConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x27BEAE0", Offset = "0x27BD0E0", VA = "0x1827BEAE0")]
		public ObiChainConstraintsData()
		{
		}
	}
}
