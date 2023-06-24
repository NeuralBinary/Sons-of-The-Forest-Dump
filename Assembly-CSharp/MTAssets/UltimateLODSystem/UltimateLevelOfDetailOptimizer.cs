using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[AddComponentMenu("MT Assets/Ultimate LOD System/Ultimate Level Of Detail Optimizer")]
	public class UltimateLevelOfDetailOptimizer : MonoBehaviour
	{
		// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x5F6E10", Offset = "0x5F5410", VA = "0x1805F6E10")]
		public void Awake()
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x5F6EB0", Offset = "0x5F54B0", VA = "0x1805F6EB0")]
		private bool isThisUlodPresentOnUlodsToBeIgnored(UltimateLevelOfDetail ulod)
		{
			return default(bool);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x5F70F0", Offset = "0x5F56F0", VA = "0x1805F70F0")]
		private IEnumerator UlodOptimizationLoop()
		{
			return null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x5F7180", Offset = "0x5F5780", VA = "0x1805F7180")]
		public UltimateLevelOfDetailOptimizer()
		{
		}

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x20")]
		private WaitForSecondsRealtime DELAY_BETWEEN_OPTIMIZATION_UPDATES;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x28")]
		private WaitForSecondsRealtime DELAY_BETWEEN_GAMEOBJECTS_STATE_CHANGE;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x30")]
		private float ADITIONAL_CULLING_DISTANCE_OFFSET;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x38")]
		private RuntimeInstancesDetector runtimeInstancesDetector;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x40")]
		private int[] instructionsToMakeOnUlods;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public bool enableOptimizationTasks;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public List<UltimateLevelOfDetail> ulodsToBeIgnored;
	}
}
