using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[AddComponentMenu("MT Assets/Ultimate LOD System/Ultimate Level Of Detail Pivot")]
	public class UltimateLevelOfDetailPivot : MonoBehaviour
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UltimateLevelOfDetailPivot()
		{
		}

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public UltimateLevelOfDetail targetUlodToChangePivot;
	}
}
