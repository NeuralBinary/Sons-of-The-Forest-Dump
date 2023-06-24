using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	[Serializable]
	public class ObiAerodynamicConstraintsData : ObiConstraints<ObiAerodynamicConstraintsBatch>
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x27BE8E0", Offset = "0x27BCEE0", VA = "0x1827BE8E0", Slot = "14")]
		public override ObiAerodynamicConstraintsBatch CreateBatch([Optional] ObiAerodynamicConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x27BE930", Offset = "0x27BCF30", VA = "0x1827BE930")]
		public ObiAerodynamicConstraintsData()
		{
		}
	}
}
