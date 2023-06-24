using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	[Serializable]
	public class ObiVolumeConstraintsData : ObiConstraints<ObiVolumeConstraintsBatch>
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x27BEE80", Offset = "0x27BD480", VA = "0x1827BEE80", Slot = "14")]
		public override ObiVolumeConstraintsBatch CreateBatch([Optional] ObiVolumeConstraintsBatch source)
		{
			return null;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x27BEED0", Offset = "0x27BD4D0", VA = "0x1827BEED0")]
		public ObiVolumeConstraintsData()
		{
		}
	}
}
