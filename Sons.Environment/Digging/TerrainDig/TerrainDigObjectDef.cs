using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[Serializable]
	public class TerrainDigObjectDef
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2FC6C70", Offset = "0x2FC5270", VA = "0x182FC6C70")]
		public bool Matches(int terrainLayerId)
		{
			return default(bool);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public GameObject GetDigAttachPrefab()
		{
			return null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		public GameObject GetDigNodePrefab()
		{
			return null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
		public GameObject GetNetworkDigNodePrefab()
		{
			return null;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2FC6E40", Offset = "0x2FC5440", VA = "0x182FC6E40")]
		public void OnValidate()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TerrainDigObjectDef()
		{
		}

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		private int _terrainLayerId;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<int> _terrainLayerIds;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _digAttachPrefab;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _digNodePrefab;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _networkDigNodePrefab;
	}
}
