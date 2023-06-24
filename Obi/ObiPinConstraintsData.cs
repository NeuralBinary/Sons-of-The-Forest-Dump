using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	[Serializable]
	public class ObiPinConstraintsData : ObiConstraints<ObiPinConstraintsBatch>
	{
		// Token: 0x060005F0 RID: 1520 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x27BEBB0", Offset = "0x27BD1B0", VA = "0x1827BEBB0", Slot = "14")]
		public override ObiPinConstraintsBatch CreateBatch([Optional] ObiPinConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x27BEC00", Offset = "0x27BD200", VA = "0x1827BEC00")]
		public ObiPinConstraintsData()
		{
		}
	}
}
