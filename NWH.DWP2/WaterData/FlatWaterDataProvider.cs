using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.WaterData
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class FlatWaterDataProvider : WaterDataProvider
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
		public override bool SupportsWaterHeightQueries()
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
		public override bool SupportsWaterNormalQueries()
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
		public override bool SupportsWaterFlowQueries()
		{
			return default(bool);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x26FBB80", Offset = "0x26FA180", VA = "0x1826FBB80", Slot = "8")]
		public override void GetWaterHeights(ref Vector3[] points, ref float[] waterHeights)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0xAA91A0", Offset = "0xAA77A0", VA = "0x180AA91A0")]
		public FlatWaterDataProvider()
		{
		}
	}
}
