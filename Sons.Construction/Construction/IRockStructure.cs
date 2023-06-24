using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000251 RID: 593
	[Token(Token = "0x2000251")]
	public interface IRockStructure : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x060011FF RID: 4607
		[Token(Token = "0x60011FF")]
		StructureElement GetElementPlacementInfo(StructureElement linePrefab, int lineNum, out Vector3 worldPos, out Quaternion worldRot, out float zScale, [Optional] Vector3 nearPos);

		// Token: 0x06001200 RID: 4608
		[Token(Token = "0x6001200")]
		Vector3 CalcTemplateOffset(StructureElement elementPrefab);
	}
}
