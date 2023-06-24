using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public static class LightProbeUtilities
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void GenerateLightProbes(Terrain terrainComponent, LightProbeGroup lightProbeGroup, float density, LayerMask snapLayerMask)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0xA62F10", Offset = "0xA61510", VA = "0x180A62F10")]
		private static void GenerateProbeLayout(Terrain terrainComponent, Vector3 baseOffset, Vector3 size, Vector3 step, float terrainHeightOffset, List<Vector3> positions)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0xA63140", Offset = "0xA61740", VA = "0x180A63140")]
		private static void GenerateProbeLayout(Terrain terrainComponent, Vector3 baseOffset, Vector3 size, Vector3 step, float terrainHeightOffset, List<Vector3> positions, LayerMask snapLayerMask)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000051")]
		[Address(RVA = "0xA63300", Offset = "0xA61900", VA = "0x180A63300")]
		private static float GetHeight(Terrain terrainComponent, LayerMask snapLayerMask, float xFactor, float zFactor, float x, float z)
		{
			return 0f;
		}
	}
}
