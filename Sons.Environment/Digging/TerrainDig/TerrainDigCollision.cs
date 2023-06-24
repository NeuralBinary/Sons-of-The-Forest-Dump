using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[AddComponentMenu("Sons/Environment/Digging/TerrainDigCollision")]
	public class TerrainDigCollision : MonoBehaviour
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public TerrainCollider GetTerrainCollider()
		{
			return null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetTerrainCollider(TerrainCollider terrainCollider)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TerrainDigCollision()
		{
		}

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x20")]
		private TerrainCollider _terrainCollider;
	}
}
