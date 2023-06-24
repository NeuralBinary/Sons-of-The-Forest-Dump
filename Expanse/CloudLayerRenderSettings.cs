using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\clouds\\CloudLayerRenderSettings.cs", needAccessors = false)]
	public struct CloudLayerRenderSettings
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xAD7C70", Offset = "0xAD6270", VA = "0x180AD7C70")]
		public static void register(BaseCloudLayerBlock b)
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xAD7DB0", Offset = "0xAD63B0", VA = "0x180AD7DB0")]
		public static void deregister(BaseCloudLayerBlock b)
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xAD7E30", Offset = "0xAD6430", VA = "0x180AD7E30")]
		public static int GetLayerCount()
		{
			return 0;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xAD7EA0", Offset = "0xAD64A0", VA = "0x180AD7EA0")]
		public static int GetShadowLayerCount()
		{
			return 0;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xAD7F10", Offset = "0xAD6510", VA = "0x180AD7F10")]
		public static int GetShadowLayerIndex(int i)
		{
			return 0;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xAD7FB0", Offset = "0xAD65B0", VA = "0x180AD7FB0")]
		public static UniversalCloudLayer GetLayer(int i)
		{
			return null;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xAD8060", Offset = "0xAD6660", VA = "0x180AD8060")]
		public static void SetShaderGlobals(ExpanseSettings settings, CommandBuffer cmd)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xAD8A20", Offset = "0xAD7020", VA = "0x180AD8A20")]
		public static void build()
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xAD8DF0", Offset = "0xAD73F0", VA = "0x180AD8DF0")]
		public static void cleanup()
		{
		}

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x0")]
		private static List<BaseCloudLayerBlock> kLayers;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x8")]
		private static List<int> kShadowLayers;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x10")]
		private static ComputeBuffer kLayerComputeBuffer;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x18")]
		private static ComputeBuffer kNoiseComputeBuffer;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x20")]
		private static UniversalCloudLayer.UniversalCloudLayerRenderSettings[] kLayerArray;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x28")]
		private static UniversalCloudLayer.UniversalCloudNoiseLayer.UniversalCloudNoiseLayerRenderSettings[] kNoiseArray;
	}
}
