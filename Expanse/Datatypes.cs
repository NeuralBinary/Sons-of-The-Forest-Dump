using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\common\\Datatypes.cs")]
	public class Datatypes
	{
		// Token: 0x06000316 RID: 790 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000316")]
		[Address(RVA = "0xAE4600", Offset = "0xAE2C00", VA = "0x180AE4600")]
		public static string noiseTypeToKernelName(Datatypes.NoiseType type)
		{
			return null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Datatypes()
		{
		}

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		public const uint kMaxQuality = 6U;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		public const uint kNumNoiseTypes = 8U;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Datatypes.NoiseType, string> cloudNoiseTypeToKernelName;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		public const uint kNumNoiseDimensions = 2U;

		// Token: 0x02000047 RID: 71
		[Token(Token = "0x2000047")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\common\\Datatypes.cs")]
		public enum Quality
		{
			// Token: 0x040003C7 RID: 967
			[Token(Token = "0x40003C7")]
			Potato,
			// Token: 0x040003C8 RID: 968
			[Token(Token = "0x40003C8")]
			Low,
			// Token: 0x040003C9 RID: 969
			[Token(Token = "0x40003C9")]
			Medium,
			// Token: 0x040003CA RID: 970
			[Token(Token = "0x40003CA")]
			High,
			// Token: 0x040003CB RID: 971
			[Token(Token = "0x40003CB")]
			Ultra,
			// Token: 0x040003CC RID: 972
			[Token(Token = "0x40003CC")]
			RippingThroughTheMetaverse
		}

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\common\\Datatypes.cs")]
		public enum NoiseType
		{
			// Token: 0x040003CE RID: 974
			[Token(Token = "0x40003CE")]
			Constant,
			// Token: 0x040003CF RID: 975
			[Token(Token = "0x40003CF")]
			Value,
			// Token: 0x040003D0 RID: 976
			[Token(Token = "0x40003D0")]
			Perlin,
			// Token: 0x040003D1 RID: 977
			[Token(Token = "0x40003D1")]
			Worley,
			// Token: 0x040003D2 RID: 978
			[Token(Token = "0x40003D2")]
			InverseWorley,
			// Token: 0x040003D3 RID: 979
			[Token(Token = "0x40003D3")]
			PerlinWorley,
			// Token: 0x040003D4 RID: 980
			[Token(Token = "0x40003D4")]
			PerlinWorley2,
			// Token: 0x040003D5 RID: 981
			[Token(Token = "0x40003D5")]
			Curl
		}

		// Token: 0x02000049 RID: 73
		[Token(Token = "0x2000049")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\common\\Datatypes.cs")]
		public enum NoiseDimension
		{
			// Token: 0x040003D7 RID: 983
			[Token(Token = "0x40003D7")]
			TwoDimensional,
			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x40003D8")]
			ThreeDimensional
		}
	}
}
