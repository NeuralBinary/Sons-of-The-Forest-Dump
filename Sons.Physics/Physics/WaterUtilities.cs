using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public static class WaterUtilities
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x310F9A0", Offset = "0x310DFA0", VA = "0x18310F9A0")]
		public static float GetSeaLevel()
		{
			return 0f;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x310F9B0", Offset = "0x310DFB0", VA = "0x18310F9B0")]
		public static float WorldPositionDepthInWater(Vector3 worldPosition, bool ignoreOcean = false)
		{
			return 0f;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x310FE00", Offset = "0x310E400", VA = "0x18310FE00")]
		public static bool IsPointInWaterZone(Vector3 point, float marginRadius = 0.01f, bool ignoreOcean = false)
		{
			return default(bool);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x3110060", Offset = "0x310E660", VA = "0x183110060")]
		public static float CastForWaterHeight(Vector3 worldPos, float fromHeight = 100f)
		{
			return 0f;
		}

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LayerMask WaterMask;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x8")]
		private static Collider[] _overlappingColliders;
	}
}
