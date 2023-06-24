using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public class StructureCollapsedProcessor : IStructureImpactProcessor
	{
		// Token: 0x06000349 RID: 841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2DC0210", Offset = "0x2DBE810", VA = "0x182DC0210")]
		public StructureCollapsedProcessor(float explosionForce, float collapseDelayPerElement, ConstructionManager manager)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000036D4 File Offset: 0x000018D4
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x2DC0270", Offset = "0x2DBE870", VA = "0x182DC0270", Slot = "4")]
		public bool Process(StructureImpactProcessingData processingData)
		{
			return default(bool);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x2DC0410", Offset = "0x2DBEA10", VA = "0x182DC0410")]
		private void SpawnDestroyedPrefabs(Structure structure, Vector3 attackSourcePos, bool isExplosion, out float timeToFinalize)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2DC0B90", Offset = "0x2DBF190", VA = "0x182DC0B90")]
		private IEnumerator FinalizeDestructionAfterDelay(Structure structure, float delay)
		{
			return null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2DC0C50", Offset = "0x2DBF250", VA = "0x182DC0C50")]
		private static IEnumerator DelayedDestroyElementFromHit(StructureElement element, Vector3 hitPosition, float explosionForce, float delay = 0f)
		{
			return null;
		}

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x10")]
		private float _explosionForce;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x14")]
		private float _collapseDelayPerElement;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x18")]
		private ConstructionManager _manager;
	}
}
