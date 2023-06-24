using System;
using System.Collections.Generic;
using Construction;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class GrabsStructureGeneratorProcessor : MonoBehaviour, IGrabsStructureGeneratedProcessor
	{
		// Token: 0x06000106 RID: 262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2D92890", Offset = "0x2D90E90", VA = "0x182D92890")]
		private void Awake()
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2D929D0", Offset = "0x2D90FD0", VA = "0x182D929D0", Slot = "4")]
		public void OnGeneratedStructures(List<Structure> structureList)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2D92A70", Offset = "0x2D91070", VA = "0x182D92A70")]
		private Structure[][] SortStructurePerTypeInArrays(List<Structure> structureList)
		{
			return null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GrabsStructureGeneratorProcessor()
		{
		}

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _freeFormGhostPrefab;
	}
}
