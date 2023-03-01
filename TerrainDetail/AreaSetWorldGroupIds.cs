using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x020004FE RID: 1278
	[Token(Token = "0x20004FE")]
	[AddComponentMenu("Sons/Terrain/Area Set World Group Ids")]
	public class AreaSetWorldGroupIds : MonoBehaviour
	{
		// Token: 0x060020A3 RID: 8355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x2D262D0", Offset = "0x2D252D0", VA = "0x182D262D0")]
		public void Apply()
		{
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public AreaSetWorldGroupIds()
		{
		}

		// Token: 0x04001E68 RID: 7784
		[Token(Token = "0x4001E68")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _allGroups;

		// Token: 0x04001E69 RID: 7785
		[Token(Token = "0x4001E69")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<string> _activeGroups;
	}
}
