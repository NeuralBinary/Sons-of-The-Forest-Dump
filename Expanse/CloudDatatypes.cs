using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\clouds\\CloudDatatypes.cs")]
	public class CloudDatatypes
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xAD3E90", Offset = "0xAD2490", VA = "0x180AD3E90")]
		public static int cloudNoiseLayerTypeToShaderID(CloudDatatypes.CloudNoiseLayer layerType, Datatypes.NoiseDimension dimension)
		{
			return 0;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xAD3F40", Offset = "0xAD2540", VA = "0x180AD3F40")]
		public static Datatypes.NoiseDimension cloudGeometryTypeToNoiseDimension(CloudDatatypes.CloudGeometryType t)
		{
			return Datatypes.NoiseDimension.TwoDimensional;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xAD3FC0", Offset = "0xAD25C0", VA = "0x180AD3FC0")]
		public static Vector2Int cloudShadowMapQualityToResolution(Datatypes.Quality quality)
		{
			return default(Vector2Int);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CloudDatatypes()
		{
		}

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		public const uint kMaxCloudLayers = 8U;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		public const uint kNumCloudNoiseLayers = 6U;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<CloudDatatypes.CloudNoiseLayer, int> cloudNoiseLayerToShaderVariable2D;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<CloudDatatypes.CloudNoiseLayer, int> cloudNoiseLayerToShaderVariable3D;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		public const uint kNumCloudGeometryTypes = 4U;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<CloudDatatypes.CloudGeometryType, Datatypes.NoiseDimension> cloudGeometryTypeToNoiseDimensionTable;

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\clouds\\CloudDatatypes.cs")]
		public enum CloudLayer
		{
			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			Layer0,
			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			Layer1,
			// Token: 0x040002BC RID: 700
			[Token(Token = "0x40002BC")]
			Layer2,
			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			Layer3,
			// Token: 0x040002BE RID: 702
			[Token(Token = "0x40002BE")]
			Layer4,
			// Token: 0x040002BF RID: 703
			[Token(Token = "0x40002BF")]
			Layer5,
			// Token: 0x040002C0 RID: 704
			[Token(Token = "0x40002C0")]
			Layer6,
			// Token: 0x040002C1 RID: 705
			[Token(Token = "0x40002C1")]
			Layer7
		}

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\clouds\\CloudDatatypes.cs")]
		public enum CloudNoiseLayer
		{
			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			Coverage,
			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			Base,
			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x40002C5")]
			Structure,
			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x40002C6")]
			Detail,
			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			BaseWarp,
			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x40002C8")]
			DetailWarp
		}

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\clouds\\CloudDatatypes.cs")]
		public enum CloudGeometryType
		{
			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			Plane,
			// Token: 0x040002CB RID: 715
			[Token(Token = "0x40002CB")]
			CurvedPlane,
			// Token: 0x040002CC RID: 716
			[Token(Token = "0x40002CC")]
			BoxVolume,
			// Token: 0x040002CD RID: 717
			[Token(Token = "0x40002CD")]
			CurvedBoxVolume
		}
	}
}
