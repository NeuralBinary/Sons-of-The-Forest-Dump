using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedTerrainGrass
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class SwitchGrassSettings : MonoBehaviour
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x59F450", Offset = "0x59DA50", VA = "0x18059F450")]
		private void Start()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x59F680", Offset = "0x59DC80", VA = "0x18059F680")]
		private void Update()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SwitchGrassSettings()
		{
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		public List<GrassManager> GrassManagers;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		public int ActiveGrassManagers;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		public Terrain[] ters;
	}
}
