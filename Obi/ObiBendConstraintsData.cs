using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	[Serializable]
	public class ObiBendConstraintsData : ObiConstraints<ObiBendConstraintsBatch>
	{
		// Token: 0x060005D0 RID: 1488 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x27BE970", Offset = "0x27BCF70", VA = "0x1827BE970", Slot = "14")]
		public override ObiBendConstraintsBatch CreateBatch([Optional] ObiBendConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x27BE9C0", Offset = "0x27BCFC0", VA = "0x1827BE9C0")]
		public ObiBendConstraintsData()
		{
		}
	}
}
