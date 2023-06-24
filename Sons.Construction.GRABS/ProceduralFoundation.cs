using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	internal class ProceduralFoundation : ProceduralLogShape
	{
		// Token: 0x0600029B RID: 667 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2DB3970", Offset = "0x2DB1F70", VA = "0x182DB3970")]
		internal int Generate(Vector3 pos, float scale, Quaternion rotation, int addedVisuals)
		{
			return 0;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2DB39C0", Offset = "0x2DB1FC0", VA = "0x182DB39C0")]
		public void SpawnPilarAndBeams(FoundationArchetype foundationArchetype, Vector3Int tile, Vector3 tileWorldCenterPos, Vector3 xTileAxis, Vector3 yTileAxis, Corners allowedPilars, Sides allowedSides, ref int addedVisuals)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ProceduralFoundation()
		{
		}
	}
}
