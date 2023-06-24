using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	public interface ITileEdge : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000D3C RID: 3388
		[Token(Token = "0x6000D3C")]
		void SetAboveTileEdge(Directions dir, ITileEdge tileEdge);

		// Token: 0x06000D3D RID: 3389
		[Token(Token = "0x6000D3D")]
		void GetBottomExtremities(out Vector3 backPos, out Vector3 forwardPos);

		// Token: 0x06000D3E RID: 3390
		[Token(Token = "0x6000D3E")]
		void GetTopExtremities(out Vector3 backPos, out Vector3 forwardPos);
	}
}
