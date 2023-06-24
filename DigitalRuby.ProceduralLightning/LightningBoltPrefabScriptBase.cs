using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public abstract class LightningBoltPrefabScriptBase : LightningBoltScript
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000020")]
		public System.Random RandomOverride
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xA3D160", Offset = "0xA3B760", VA = "0x180A3D160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xA3D170", Offset = "0xA3B770", VA = "0x180A3D170")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xA3D1D0", Offset = "0xA3B7D0", VA = "0x180A3D1D0")]
		public void SetTrunkWidth(float width)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xA3D1F0", Offset = "0xA3B7F0", VA = "0x180A3D1F0")]
		public void SetEndWidthMultiplier(float width)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xA3D200", Offset = "0xA3B800", VA = "0x180A3D200")]
		private void CalculateNextLightningTimestamp(float offset)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xA3D260", Offset = "0xA3B860", VA = "0x180A3D260")]
		private void CustomTransform(LightningCustomTransformStateInfo state)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xA3D2C0", Offset = "0xA3B8C0", VA = "0x180A3D2C0")]
		private void CallLightning()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xA3D2F0", Offset = "0xA3B8F0", VA = "0x180A3D2F0")]
		private void CallLightning(Vector3? start, Vector3? end)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA3D530", Offset = "0xA3BB30", VA = "0x180A3D530")]
		protected void CreateLightningBoltsNow()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA3D790", Offset = "0xA3BD90", VA = "0x180A3D790", Slot = "10")]
		protected override void PopulateParameters(LightningBoltParameters parameters)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xA3DA60", Offset = "0xA3C060", VA = "0x180A3DA60", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xA3DC00", Offset = "0xA3C200", VA = "0x180A3DC00", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA3DE00", Offset = "0xA3C400", VA = "0x180A3DE00", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters p)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA3D2C0", Offset = "0xA3B8C0", VA = "0x180A3D2C0")]
		public void Trigger()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA3DEA0", Offset = "0xA3C4A0", VA = "0x180A3DEA0")]
		public void Trigger(float seconds)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xA3DF00", Offset = "0xA3C500", VA = "0x180A3DF00")]
		public void Trigger(Vector3? start, Vector3? end)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xA3DF30", Offset = "0xA3C530", VA = "0x180A3DF30")]
		protected LightningBoltPrefabScriptBase()
		{
		}

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x138")]
		private readonly List<LightningBoltParameters> batchParameters;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x140")]
		private readonly System.Random random;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x148")]
		[Header("Lightning Spawn Properties")]
		[SingleLineClamp("How long to wait before creating another round of lightning bolts in seconds", 0.001, 1.7976931348623157E+308)]
		public RangeOfFloats IntervalRange;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x150")]
		[SingleLineClamp("How many lightning bolts to emit for each interval", 0.0, 100.0)]
		public RangeOfIntegers CountRange;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x158")]
		[Range(0f, 1f)]
		[Tooltip("Reduces the probability that additional bolts from CountRange will actually happen (0 - 1).")]
		public float CountProbabilityModifier;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x15C")]
		public RangeOfFloats DelayRange;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x164")]
		[SingleLineClamp("For each bolt emitted, how long should it stay in seconds", 0.01, 10.0)]
		public RangeOfFloats DurationRange;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x16C")]
		[SingleLineClamp("The trunk width range in unity units (x = min, y = max)", 0.0001, 100.0)]
		[Header("Lightning Appearance Properties")]
		public RangeOfFloats TrunkWidthRange;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x174")]
		[Tooltip("How long (in seconds) this game object should live before destroying itself. Leave as 0 for infinite.")]
		[Range(0f, 1000f)]
		public float LifeTime;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x178")]
		[Range(1f, 8f)]
		[Tooltip("Generations (1 - 8, higher makes more detailed but more expensive lightning)")]
		public int Generations;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x17C")]
		[Range(0f, 1f)]
		[Tooltip("The chaos factor that determines how far the lightning main trunk can spread out, higher numbers spread out more. 0 - 1.")]
		public float ChaosFactor;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x180")]
		[Tooltip("The chaos factor that determines how far the forks of the lightning can spread out, higher numbers spread out more. 0 - 1.")]
		[Range(0f, 1f)]
		public float ChaosFactorForks;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x184")]
		[Tooltip("Intensity of the lightning")]
		[Range(0f, 10f)]
		public float Intensity;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x188")]
		[Tooltip("The intensity of the glow")]
		[Range(0f, 10f)]
		public float GlowIntensity;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x18C")]
		[Tooltip("The width multiplier for the glow, 0 - 64")]
		[Range(0f, 64f)]
		public float GlowWidthMultiplier;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x190")]
		[Range(0f, 0.5f)]
		[Tooltip("What percent of time the lightning should fade in and out. For example, 0.15 fades in 15% of the time and fades out 15% of the time, with full visibility 70% of the time.")]
		public float FadePercent;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x194")]
		[Tooltip("Modify the duration of lightning fade in.")]
		[Range(0f, 1f)]
		public float FadeInMultiplier;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x198")]
		[Tooltip("Modify the duration of fully lit lightning.")]
		[Range(0f, 1f)]
		public float FadeFullyLitMultiplier;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x19C")]
		[Tooltip("Modify the duration of lightning fade out.")]
		[Range(0f, 1f)]
		public float FadeOutMultiplier;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x1A0")]
		[Tooltip("0 - 1, how slowly the lightning should grow. 0 for instant, 1 for slow.")]
		[Range(0f, 1f)]
		public float GrowthMultiplier;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x1A4")]
		[Tooltip("How much smaller the lightning should get as it goes towards the end of the bolt. For example, 0.5 will make the end 50% the width of the start.")]
		[Range(0f, 10f)]
		public float EndWidthMultiplier;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x1A8")]
		[Tooltip("How forked should the lightning be? (0 - 1, 0 for none, 1 for lots of forks)")]
		[Range(0f, 1f)]
		public float Forkedness;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x1AC")]
		[Range(0f, 10f)]
		[Tooltip("Minimum distance multiplier for forks")]
		public float ForkLengthMultiplier;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x1B0")]
		[Range(0f, 10f)]
		[Tooltip("Fork distance multiplier variance. Random range of 0 to n that is added to Fork Length Multiplier.")]
		public float ForkLengthVariance;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x1B4")]
		[Tooltip("Forks have their EndWidthMultiplier multiplied by this value")]
		[Range(0f, 10f)]
		public float ForkEndWidthMultiplier;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x1B8")]
		[Header("Lightning Light Properties")]
		[Tooltip("Light parameters")]
		public LightningLightParameters LightParameters;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x1C0")]
		[Range(0f, 64f)]
		[Tooltip("Maximum number of lights that can be created per batch of lightning")]
		public int MaximumLightsPerBatch;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x1C4")]
		[Tooltip("Manual or automatic mode. Manual requires that you call the Trigger method in script. Automatic uses the interval to create lightning continuously.")]
		[Header("Lightning Trigger Type")]
		public bool ManualMode;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x1C8")]
		[Tooltip("Turns lightning into automatic mode for this number of seconds, then puts it into manual mode.")]
		[Range(0f, 120f)]
		public float AutomaticModeSeconds;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x1CC")]
		public bool SoundMode;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x1D0")]
		public GameObject SoundPrefab;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x1D8")]
		[Header("Lightning custom transform handler")]
		[Tooltip("Custom handler to modify the transform of each lightning bolt, useful if it will be alive longer than a few frames and needs to scale and rotate based on the position of other objects.")]
		public LightningCustomTransformDelegate CustomTransformHandler;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x1E8")]
		private float nextLightningTimestamp;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x1EC")]
		private float lifeTimeRemaining;
	}
}
