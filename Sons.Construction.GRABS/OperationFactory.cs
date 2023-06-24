using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public abstract class OperationFactory : ScriptableObject
	{
		// Token: 0x060001CB RID: 459
		[Token(Token = "0x60001CB")]
		public abstract Operation GetOperation(InteractionPoint ip, GrabsController controller);

		// Token: 0x060001CC RID: 460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		protected OperationFactory()
		{
		}
	}
}
