using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[Serializable]
	public sealed class LightningBoltParameters
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA2F8D0", Offset = "0xA2DED0", VA = "0x180A2F8D0")]
		public LightningBoltParameters()
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000020CC File Offset: 0x000002CC
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public int Generations
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0xA2FB30", Offset = "0xA2E130", VA = "0x180A2FB30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0xA2FB40", Offset = "0xA2E140", VA = "0x180A2FB40")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000005")]
		public System.Random Random
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xA2FD50", Offset = "0xA2E350", VA = "0x180A2FD50")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000006")]
		public System.Random RandomOverride
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xA2FE40", Offset = "0xA2E440", VA = "0x180A2FE40")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000020E4 File Offset: 0x000002E4
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000007")]
		public float GrowthMultiplier
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xA2FF10", Offset = "0xA2E510", VA = "0x180A2FF10")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000008")]
		public List<Vector3> Points
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x691530", Offset = "0x68FB30", VA = "0x180691530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xA2FF40", Offset = "0xA2E540", VA = "0x180A2FF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600005D")]
		[Address(RVA = "0xA2FFA0", Offset = "0xA2E5A0", VA = "0x180A2FFA0")]
		public float ForkMultiplier()
		{
			return 0f;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x600005E")]
		[Address(RVA = "0xA2FFF0", Offset = "0xA2E5F0", VA = "0x180A2FFF0")]
		public Vector3 ApplyVariance(Vector3 pos, Vector3 variance)
		{
			return default(Vector3);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0xA30110", Offset = "0xA2E710", VA = "0x180A30110")]
		public void Reset()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000060")]
		[Address(RVA = "0xA30260", Offset = "0xA2E860", VA = "0x180A30260")]
		public static LightningBoltParameters GetOrCreateParameters()
		{
			return null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000061")]
		[Address(RVA = "0xA30380", Offset = "0xA2E980", VA = "0x180A30380")]
		public static void ReturnParametersToCache(LightningBoltParameters p)
		{
		}

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x0")]
		private static int randomSeed;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<LightningBoltParameters> cache;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x10")]
		internal int generationWhereForksStop;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x14")]
		internal int forkednessCalculated;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x18")]
		internal LightningBoltQualitySetting quality;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x1C")]
		internal float delaySeconds;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		internal int maxLights;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x10")]
		public static float Scale;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Dictionary<int, LightningQualityMaximum> QualityMaximums;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x28")]
		public LightningGenerator Generator;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 Start;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 End;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 StartVariance;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 EndVariance;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x60")]
		public Action<LightningCustomTransformStateInfo> CustomTransform;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x68")]
		private int generations;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x6C")]
		public float LifeTime;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x70")]
		public float Delay;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x74")]
		public RangeOfFloats DelayRange;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x7C")]
		public float ChaosFactor;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x80")]
		public float ChaosFactorForks;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x84")]
		public float TrunkWidth;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x88")]
		public float EndWidthMultiplier;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x8C")]
		public float Intensity;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x90")]
		public float GlowIntensity;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x94")]
		public float GlowWidthMultiplier;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x98")]
		public float Forkedness;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x9C")]
		public int GenerationWhereForksStopSubtractor;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xA0")]
		public Color32 Color;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xA4")]
		public Color32 MainTrunkTintColor;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0xA8")]
		private System.Random random;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0xB0")]
		private System.Random currentRandom;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0xB8")]
		private System.Random randomOverride;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0xC0")]
		public float FadePercent;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0xC4")]
		public float FadeInMultiplier;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0xC8")]
		public float FadeFullyLitMultiplier;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0xCC")]
		public float FadeOutMultiplier;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0xD0")]
		private float growthMultiplier;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0xD4")]
		public float ForkLengthMultiplier;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0xD8")]
		public float ForkLengthVariance;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0xDC")]
		public float ForkEndWidthMultiplier;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0xE0")]
		public LightningLightParameters LightParameters;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0xF0")]
		public int SmoothingFactor;
	}
}
