using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	[Serializable]
	public class ObiShapeMatchingConstraintsData : ObiConstraints<ObiShapeMatchingConstraintsBatch>
	{
		// Token: 0x060005FE RID: 1534 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x27BEC40", Offset = "0x27BD240", VA = "0x1827BEC40", Slot = "14")]
		public override ObiShapeMatchingConstraintsBatch CreateBatch([Optional] ObiShapeMatchingConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x27BEC90", Offset = "0x27BD290", VA = "0x1827BEC90")]
		public ObiShapeMatchingConstraintsData()
		{
		}
	}
}
