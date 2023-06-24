using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	public abstract class ObiMeshBasedActorBlueprint : ObiActorBlueprint
	{
		// Token: 0x06000671 RID: 1649 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x2741FD0", Offset = "0x27405D0", VA = "0x182741FD0")]
		protected ObiMeshBasedActorBlueprint()
		{
		}

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x110")]
		public Mesh inputMesh;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x118")]
		public Vector3 scale;
	}
}
