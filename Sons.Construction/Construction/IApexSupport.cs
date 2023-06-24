using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	public interface IApexSupport : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000CCF RID: 3279
		[Token(Token = "0x6000CCF")]
		bool CanHostNewApex();

		// Token: 0x06000CD0 RID: 3280
		[Token(Token = "0x6000CD0")]
		void SetApex(ApexStructure apex);

		// Token: 0x06000CD1 RID: 3281
		[Token(Token = "0x6000CD1")]
		bool TryGetApex(out ApexStructure apex);

		// Token: 0x06000CD2 RID: 3282
		[Token(Token = "0x6000CD2")]
		Vector3 GetApexSnapPos(StructureElement apexPrefab);
	}
}
