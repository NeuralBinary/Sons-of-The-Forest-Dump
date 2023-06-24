using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[AddComponentMenu("")]
	public class RuntimeInstancesDetector : MonoBehaviour
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x5EE120", Offset = "0x5EC720", VA = "0x1805EE120")]
		public void RegisterNewUlodOptimizerInThisScene(UltimateLevelOfDetailOptimizer optimizer)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x5EE210", Offset = "0x5EC810", VA = "0x1805EE210")]
		public RuntimeInstancesDetector()
		{
		}

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public List<UltimateLevelOfDetail> instancesOfUlodInThisScene;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public List<UltimateLevelOfDetailOptimizer> instancesOfUlodOptimizerInThisScene;
	}
}
