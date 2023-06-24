using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.MeshDecimation
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class Vert
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2728A80", Offset = "0x2727080", VA = "0x182728A80")]
		public Vert(Vector3 position, int id, bool selected)
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2728C60", Offset = "0x2727260", VA = "0x182728C60")]
		public void RemoveVert()
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2728E90", Offset = "0x2727490", VA = "0x182728E90")]
		public bool IsBorder()
		{
			return default(bool);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2728FF0", Offset = "0x27275F0", VA = "0x182728FF0")]
		public void AddFace(Tri f)
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2729090", Offset = "0x2727690", VA = "0x182729090")]
		public void RemoveFace(Tri f)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x27290F0", Offset = "0x27276F0", VA = "0x1827290F0")]
		public void AddNeighbor(Vert v)
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x27291F0", Offset = "0x27277F0", VA = "0x1827291F0")]
		public void RemoveIfNonNeighbor(Vert v)
		{
		}

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x20")]
		public List<Tri> face;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x28")]
		public List<Vert> neighbor;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x30")]
		public int id;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x34")]
		public float cost;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x38")]
		public Vert collapse;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x40")]
		public bool selected;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x41")]
		public bool deleted;
	}
}
