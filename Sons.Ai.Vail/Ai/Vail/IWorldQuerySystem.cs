using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public interface IWorldQuerySystem
	{
		// Token: 0x060005A1 RID: 1441
		[Token(Token = "0x60005A1")]
		bool GetClosestBush(Vector3 position, float radius, bool includeSmallBush, out Vector3 closestPos);

		// Token: 0x060005A2 RID: 1442
		[Token(Token = "0x60005A2")]
		bool GetClosestTree(Vector3 position, float radius, out Vector3 closestPos);

		// Token: 0x060005A3 RID: 1443
		[Token(Token = "0x60005A3")]
		int GetTreeCount(Vector3 position, float radius);
	}
}
