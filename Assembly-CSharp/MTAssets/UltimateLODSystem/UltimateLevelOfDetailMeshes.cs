using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[AddComponentMenu("")]
	public class UltimateLevelOfDetailMeshes : MonoBehaviour
	{
		// Token: 0x0600016C RID: 364 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public UltimateLevelOfDetail GetResponsibleUlodComponent()
		{
			return null;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x5F68B0", Offset = "0x5F4EB0", VA = "0x1805F68B0")]
		public int GetQuantityOfLods()
		{
			return 0;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x5F68D0", Offset = "0x5F4ED0", VA = "0x1805F68D0")]
		public void SetMeshOfThisLodGroup(int level, Mesh newMesh)
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x5F69E0", Offset = "0x5F4FE0", VA = "0x1805F69E0")]
		public Mesh GetMeshOfThisLodGroup(int level)
		{
			return null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x5F6AD0", Offset = "0x5F50D0", VA = "0x1805F6AD0")]
		public bool isMaterialChangesEnabledForThisMesh()
		{
			return default(bool);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x5F6B00", Offset = "0x5F5100", VA = "0x1805F6B00")]
		public void SetMaterialArrayOfThisLodGroup(int level, Material[] newMaterialArray)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x5F6C70", Offset = "0x5F5270", VA = "0x1805F6C70")]
		public Material[] GetMaterialArrayOfThisLodGroup(int level)
		{
			return null;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x5F6DC0", Offset = "0x5F53C0", VA = "0x1805F6DC0")]
		public UltimateLevelOfDetailMeshes()
		{
		}

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public UltimateLevelOfDetail responsibleUlod;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public int idOfOriginalMeshItemOfThisInResponsibleUlod;
	}
}
