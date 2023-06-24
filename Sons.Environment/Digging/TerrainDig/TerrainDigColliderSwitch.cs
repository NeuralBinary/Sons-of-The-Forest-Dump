using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public class TerrainDigColliderSwitch : MonoBehaviour
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2FBB9A0", Offset = "0x2FB9FA0", VA = "0x182FBB9A0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2FBB9E0", Offset = "0x2FB9FE0", VA = "0x182FBB9E0")]
		private bool MatchesMask(Collider other)
		{
			return default(bool);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2FBBAB0", Offset = "0x2FBA0B0", VA = "0x182FBBAB0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2FBBAF0", Offset = "0x2FBA0F0", VA = "0x182FBBAF0")]
		private void IgnoreTerrainCollision(Collider other, bool ignore)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TerrainDigColliderSwitch()
		{
		}

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask _layerFilter;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x28")]
		private List<Collider> _terrainCollision;
	}
}
