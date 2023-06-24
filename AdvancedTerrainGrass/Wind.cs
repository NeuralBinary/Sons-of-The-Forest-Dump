using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedTerrainGrass
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WindZone))]
	public class Wind : MonoBehaviour
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x5AD9A0", Offset = "0x5ABFA0", VA = "0x1805AD9A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x5ADE30", Offset = "0x5AC430", VA = "0x1805ADE30")]
		private void OnDisable()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x5AE170", Offset = "0x5AC770", VA = "0x1805AE170")]
		private void SetupRT()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x5AE680", Offset = "0x5ACC80", VA = "0x1805AE680")]
		private void OnValidate()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x5AEB90", Offset = "0x5AD190", VA = "0x1805AEB90")]
		private void Update()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x5B0050", Offset = "0x5AE650", VA = "0x1805B0050")]
		public Wind()
		{
		}

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x20")]
		[Space(4f)]
		public bool UpdateInEditMode;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x24")]
		[Header("Tree Wind Settings")]
		public float WindMultiplierTrees;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.1f, 1f)]
		public float WindToFrequencyChange;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x2C")]
		public float BaseTurbulence;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve WindToTurbulence;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x38")]
		[Header("Grass Render Texture Settings")]
		public RTSize Resolution;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Size of the Wind RenderTexture in World Space")]
		public float SizeInWorldSpace;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x40")]
		[Space(5f)]
		public Texture WindBaseTex;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x48")]
		public Shader WindCompositeShader;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x50")]
		[Header("Grass Wind Multipliers")]
		public AnimationCurve WindToGrasswind;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve WindToGrassspeed;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Must be in a 0 - 1 range.")]
		public AnimationCurve WindToGrassGust;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x68")]
		public float Grass;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x6C")]
		public float Foliage;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x70")]
		[Header("Grass Wind Speed and Size")]
		[Tooltip("Base Wind Speed in km/h at Main = 1 (WindZone)")]
		public float BaseWindSpeed;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x74")]
		[Space(5f)]
		public float speedLayer0;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x78")]
		public float speedLayer1;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x7C")]
		public float speedLayer2;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x80")]
		[Header("Grass Noise")]
		public int GrassGustTiling;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x84")]
		public float GrassGustSpeed;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x88")]
		public GustMixLayer LayerToMixWith;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x90")]
		private RenderTexture WindRenderTextureA;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x98")]
		private RenderTexture WindRenderTextureB;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xA0")]
		private bool renderIntoA;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0xA4")]
		private int previousRTSize;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0xA8")]
		private Material m_material;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0xB0")]
		private Vector2 uvs;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 uvs1;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xC0")]
		private Vector2 uvs2;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xC8")]
		private Vector2 uvs3;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0xD0")]
		private Transform trans;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0xD8")]
		private WindZone windZone;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0xE0")]
		private float mainWind;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xE4")]
		private float turbulence;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xE8")]
		private float windpulseMagnitude;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0xEC")]
		private float windPulseFrequency;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int AtgWindDirSizePID;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int AtgWindStrengthMultipliersPID;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int AtgSinTimePID;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int AtgGustPID;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int AtgGustMixLayerPID;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int AtgWindUVsPID;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int AtgWindUVs1PID;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int AtgWindUVs2PID;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int AtgWindUVs3PID;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x28")]
		private static Vector3[] MixLayers;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int GlobalWindPID;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0xF0")]
		private Vector3 WindDirection;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0xFC")]
		private float WindStrength;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x100")]
		private float WindStrength_LastFrame;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x104")]
		private float WindTurbulence;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int TreeWindPID;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int TreeTurbulencePID;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly int BendFrequencyPID;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x40")]
		private static readonly int BendFrequencyLastTimePID;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x108")]
		private double domainTime_Wind;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x110")]
		private double domainTime_Wind_LastFrame;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x118")]
		private float temp_WindFrequency;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x11C")]
		private float freqSpeed;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x120")]
		private Vector4 WindDirectionSize;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 lastPosition;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x140")]
		private double lastTimeStamp;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x148")]
		[Header("Fog Volume Wind")]
		public float FogNoiseTiling;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x150")]
		public AnimationCurve WindToFogWind;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x158")]
		private float _fogWind;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x44")]
		private static readonly int _Sons_FogNoiseTiling;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x48")]
		private static readonly int _Sons_FogWind;
	}
}
