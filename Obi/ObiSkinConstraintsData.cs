using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	[Serializable]
	public class ObiSkinConstraintsData : ObiConstraints<ObiSkinConstraintsBatch>
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x27BECD0", Offset = "0x27BD2D0", VA = "0x1827BECD0", Slot = "14")]
		public override ObiSkinConstraintsBatch CreateBatch([Optional] ObiSkinConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x27BED20", Offset = "0x27BD320", VA = "0x1827BED20")]
		public ObiSkinConstraintsData()
		{
		}
	}
}
