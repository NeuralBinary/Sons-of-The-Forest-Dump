using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	public interface ITargetablePlacement
	{
		// Token: 0x06000D39 RID: 3385
		[Token(Token = "0x6000D39")]
		StructureElement AddElement(StructureElement elementPrefab, Vector3 worldPos);

		// Token: 0x06000D3A RID: 3386
		[Token(Token = "0x6000D3A")]
		void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 position, out Quaternion rotation, out float lengthScale);
	}
}
