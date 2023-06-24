using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000500 RID: 1280
	[Token(Token = "0x2000500")]
	[AddComponentMenu("Sons/Terrain/Area Set World Group Ids")]
	public class AreaSetWorldGroupIds : MonoBehaviour
	{
		// Token: 0x06002166 RID: 8550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002166")]
		[Address(RVA = "0x3328AA0", Offset = "0x33270A0", VA = "0x183328AA0")]
		public void Apply()
		{
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002167")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AreaSetWorldGroupIds()
		{
		}

		// Token: 0x04001F00 RID: 7936
		[Token(Token = "0x4001F00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _allGroups;

		// Token: 0x04001F01 RID: 7937
		[Token(Token = "0x4001F01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<string> _activeGroups;
	}
}
