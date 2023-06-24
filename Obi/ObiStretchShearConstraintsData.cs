using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	[Serializable]
	public class ObiStretchShearConstraintsData : ObiConstraints<ObiStretchShearConstraintsBatch>
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x27BED60", Offset = "0x27BD360", VA = "0x1827BED60", Slot = "14")]
		public override ObiStretchShearConstraintsBatch CreateBatch([Optional] ObiStretchShearConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x27BEDB0", Offset = "0x27BD3B0", VA = "0x1827BEDB0")]
		public ObiStretchShearConstraintsData()
		{
		}
	}
}
