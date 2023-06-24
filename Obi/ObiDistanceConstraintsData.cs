using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	[Serializable]
	public class ObiDistanceConstraintsData : ObiConstraints<ObiDistanceConstraintsBatch>
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x27BEB20", Offset = "0x27BD120", VA = "0x1827BEB20", Slot = "14")]
		public override ObiDistanceConstraintsBatch CreateBatch([Optional] ObiDistanceConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x27BEB70", Offset = "0x27BD170", VA = "0x1827BEB70")]
		public ObiDistanceConstraintsData()
		{
		}
	}
}
