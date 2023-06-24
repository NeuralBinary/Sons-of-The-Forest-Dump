using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	public interface ITileCenter : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000D3B RID: 3387
		[Token(Token = "0x6000D3B")]
		Vector3 CalcTileCenterPos();
	}
}
