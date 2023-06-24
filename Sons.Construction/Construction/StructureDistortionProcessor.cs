using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	public class StructureDistortionProcessor : IStructureImpactProcessor
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public StructureDistortionProcessor(HashSet<Structure> distortedStructures)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000374C File Offset: 0x0000194C
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2DC1470", Offset = "0x2DBFA70", VA = "0x182DC1470", Slot = "4")]
		public bool Process(StructureImpactProcessingData processingData)
		{
			return default(bool);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x2DC2030", Offset = "0x2DC0630", VA = "0x182DC2030")]
		private static void DistortElementFromHit(StructureImpactProcessingData processingData, Vector3 hitPosition, StructureElement element, float forceMultiplier)
		{
		}

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<Structure> _distortedStructures;
	}
}
