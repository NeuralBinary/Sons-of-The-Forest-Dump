using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public static class TerrainUtils
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2F91540", Offset = "0x2F8FB40", VA = "0x182F91540")]
		public static void UpdateSnowHeight(Terrain terrain, ref float snowStartHeight)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2F917C0", Offset = "0x2F8FDC0", VA = "0x182F917C0")]
		public static void UpdateSnowDistances(Terrain terrain, ref float snowStartHeight, ref float snowFadeLength)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2F91B20", Offset = "0x2F90120", VA = "0x182F91B20")]
		public static int GetActiveTerrainType(Vector3 currentPosition)
		{
			return 0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2F91CF0", Offset = "0x2F902F0", VA = "0x182F91CF0")]
		public static int GetAudioTerrainIndex(Vector3 position)
		{
			return 0;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2F91DE0", Offset = "0x2F903E0", VA = "0x182F91DE0")]
		public static int ConvertToAudioTerrainIndex(int activeTerrainIndex)
		{
			return 0;
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int SnowStartHeightId;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int SnowFadeLengthId;

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		public enum AudioTextureType
		{
			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			Default,
			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			Grass,
			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			Leaves,
			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4000075")]
			Mud,
			// Token: 0x04000076 RID: 118
			[Token(Token = "0x4000076")]
			Rock,
			// Token: 0x04000077 RID: 119
			[Token(Token = "0x4000077")]
			Sand,
			// Token: 0x04000078 RID: 120
			[Token(Token = "0x4000078")]
			Snow,
			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000079")]
			Wood,
			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			Water
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		public enum TerrainTextureTypes
		{
			// Token: 0x0400007C RID: 124
			[Token(Token = "0x400007C")]
			SandA,
			// Token: 0x0400007D RID: 125
			[Token(Token = "0x400007D")]
			DirtA,
			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			SandB,
			// Token: 0x0400007F RID: 127
			[Token(Token = "0x400007F")]
			RockB,
			// Token: 0x04000080 RID: 128
			[Token(Token = "0x4000080")]
			GrassA,
			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000081")]
			ForestGround,
			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			Roots,
			// Token: 0x04000083 RID: 131
			[Token(Token = "0x4000083")]
			RiverBed,
			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			Moss,
			// Token: 0x04000085 RID: 133
			[Token(Token = "0x4000085")]
			Rocks,
			// Token: 0x04000086 RID: 134
			[Token(Token = "0x4000086")]
			GolfGrass,
			// Token: 0x04000087 RID: 135
			[Token(Token = "0x4000087")]
			BedRock,
			// Token: 0x04000088 RID: 136
			[Token(Token = "0x4000088")]
			Snow = 32
		}
	}
}
