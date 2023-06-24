using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	[Serializable]
	public class ObiBendTwistConstraintsData : ObiConstraints<ObiBendTwistConstraintsBatch>
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x27BEA00", Offset = "0x27BD000", VA = "0x1827BEA00", Slot = "14")]
		public override ObiBendTwistConstraintsBatch CreateBatch([Optional] ObiBendTwistConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x27BEA50", Offset = "0x27BD050", VA = "0x1827BEA50")]
		public ObiBendTwistConstraintsData()
		{
		}
	}
}
