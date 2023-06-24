using System;
using System.Runtime.CompilerServices;
using Crest.Spline;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[ExecuteAlways]
	public class ShapeGerstner : MonoBehaviour, IFloatingOrigin, LodDataMgrAnimWaves.IShapeUpdatable, ISplinePointCustomDataSetup
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x170000A0")]
		public Vector2 PrimaryWaveDirection
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0xA0C920", Offset = "0xA0AF20", VA = "0x180A0C920")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0xA0C970", Offset = "0xA0AF70", VA = "0x180A0C970")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0xA0CA10", Offset = "0xA0B010", VA = "0x180A0CA10")]
		private void InitData()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x600028A")]
		[Address(RVA = "0xA0D020", Offset = "0xA0B620", VA = "0x180A0D020")]
		public float MinWavelength(int cascadeIdx)
		{
			return 0f;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028B")]
		[Address(RVA = "0xA0D050", Offset = "0xA0B650", VA = "0x180A0D050", Slot = "5")]
		public void CrestUpdate(CommandBuffer buf)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0xA0D660", Offset = "0xA0BC60", VA = "0x180A0D660")]
		private void SliceUpWaves(float windSpeed)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0xA0E900", Offset = "0xA0CF00", VA = "0x180A0E900")]
		private void UpdateGenerateWaves(CommandBuffer buf)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0xA0ECA0", Offset = "0xA0D2A0", VA = "0x180A0ECA0", Slot = "4")]
		public void SetOrigin(Vector3 newOrigin)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0xA0EEE0", Offset = "0xA0D4E0", VA = "0x180A0EEE0")]
		public void UpdateWaveData(float windSpeed)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0xA0F070", Offset = "0xA0D670", VA = "0x180A0F070")]
		private void UpdateAmplitudes()
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0xA0F4D0", Offset = "0xA0DAD0", VA = "0x180A0F4D0")]
		private void InitPhases()
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000292")]
		[Address(RVA = "0xA0F7D0", Offset = "0xA0DDD0", VA = "0x180A0F7D0")]
		private void ReportMaxDisplacement()
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0xA0F9F0", Offset = "0xA0DFF0", VA = "0x180A0F9F0")]
		private void InitBatches()
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0xA102B0", Offset = "0xA0E8B0", VA = "0x180A102B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0xA107D0", Offset = "0xA0EDD0", VA = "0x180A107D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x6000296")]
		[Address(RVA = "0xA10E00", Offset = "0xA0F400", VA = "0x180A10E00", Slot = "6")]
		public bool AttachDataToSplinePoint(GameObject splinePoint)
		{
			return default(bool);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA10E80", Offset = "0xA0F480", VA = "0x180A10E80")]
		public ShapeGerstner()
		{
		}

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private int _version;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x24")]
		[Header("Culling")]
		public float _cullDistance;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x28")]
		public float _fadeRange;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x2C")]
		private float _cullDistanceSqr;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x30")]
		private float _oneOverFadeRangeSqr;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x38")]
		private Transform trans;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 pos;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The spectrum that defines the ocean surface shape. Assign asset of type Crest/Ocean Waves Spectrum.")]
		[Header("Waves")]
		public OceanWaveSpectrum _spectrum;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x58")]
		private OceanWaveSpectrum _activeSpectrum;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("When true, the wave spectrum is evaluated once on startup in editor play mode and standalone builds, rather than every frame. This is less flexible but reduces the performance cost significantly.")]
		private bool _spectrumFixedAtRuntime;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("Primary wave direction heading (deg). This is the angle from x axis in degrees that the waves are oriented towards. If a spline is being used to place the waves, this angle is relative ot the spline.")]
		[Range(-180f, 180f)]
		public float _waveDirectionHeadingAngle;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("When true, uses the wind speed on this component rather than the wind speed from the Ocean Renderer component.")]
		public bool _overrideGlobalWindSpeed;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("Wind speed in km/h. Controls wave conditions.")]
		[Range(0f, 150f)]
		public float _windSpeed;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Multiplier for these waves to scale up/down.")]
		[Range(0f, 1f)]
		public float _weight;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Tooltip("How much these waves respect the shallow water attenuation setting in the Animated Waves Settings. Set to 0 to ignore shallow water.")]
		[Range(0f, 1f)]
		private float _respectShallowWaterAttenuation;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x78")]
		[Delayed]
		[Tooltip("How many wave components to generate in each octave.")]
		[Header("Generation Settings")]
		public int _componentsPerOctave;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("Change to get a different set of waves.")]
		public int _randomSeed;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Resolution to use for wave generation buffers. Low resolutions are more efficient but can result in noticeable patterns in the shape.")]
		[Delayed]
		public int _resolution;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x84")]
		[Tooltip("In Editor, shows the wave generation buffers on screen.")]
		[SerializeField]
		private bool _debugDrawSlicesInEditor;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		[Header("Spline settings")]
		private bool _overrideSplineSettings;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _radius;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private int _subdivisions;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private int _smoothingIterations;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _featherWaveStart;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x98")]
		private Mesh _meshForDrawingWaves;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0xA0")]
		private float _windSpeedWhenGenerated;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		private const int CASCADE_COUNT = 16;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		private const int MAX_WAVE_COMPONENTS = 1024;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0xA8")]
		private ShapeGerstner.GerstnerBatch[] _batches;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0xB0")]
		private float[] _wavelengths;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0xB8")]
		private float[] _amplitudes;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0xC0")]
		private float[] _amplitudes2;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0xC8")]
		private float[] _powers;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0xD0")]
		private float[] _angleDegs;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0xD8")]
		private float[] _phases;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0xE0")]
		private float[] _phases2;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		public RenderTexture _waveBuffers;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0xF0")]
		private ComputeBuffer _bufCascadeParams;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0xF8")]
		private ShapeGerstner.GerstnerCascadeParams[] _cascadeParams;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x100")]
		private int _firstCascade;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x104")]
		private int _lastCascade;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x108")]
		private bool _firstUpdate;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x110")]
		private ComputeBuffer _bufWaveData;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x118")]
		private ShapeGerstner.GerstnerWaveComponent4[] _waveData;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x120")]
		private ComputeShader _shaderGerstner;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x128")]
		private int _krnlGerstner;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x130")]
		private Material _matGenerateWaves;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x138")]
		private readonly int sp_FirstCascadeIndex;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x13C")]
		private readonly int sp_TextureRes;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x140")]
		private readonly int sp_CascadeParams;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x144")]
		private readonly int sp_GerstnerWaveData;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int sp_WaveBuffer;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int sp_WaveBufferSliceIndex;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int sp_AverageWavelength;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int sp_RespectShallowWaterAttenuation;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int sp_FeatherWaveStart;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x148")]
		private readonly int sp_AxisX;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x14C")]
		private readonly float _twoPi;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x150")]
		private readonly float _recipTwoPi;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly CrestSortedList<int, ShapeGerstner> Instances;

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		public class GerstnerBatch : ILodDataInput
		{
			// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000299")]
			[Address(RVA = "0xA11520", Offset = "0xA0FB20", VA = "0x180A11520")]
			public GerstnerBatch(ShapeGerstner gerstner, float wavelength, int waveBufferSliceIndex, Material material, Mesh mesh)
			{
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600029A RID: 666 RVA: 0x00003168 File Offset: 0x00001368
			// (set) Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A1")]
			public float Wavelength
			{
				[Token(Token = "0x600029A")]
				[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600029B")]
				[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600029C RID: 668 RVA: 0x00003180 File Offset: 0x00001380
			// (set) Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A2")]
			public bool Enabled
			{
				[Token(Token = "0x600029C")]
				[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600029D")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				set
				{
				}
			}

			// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600029E")]
			[Address(RVA = "0xA11630", Offset = "0xA0FC30", VA = "0x180A11630", Slot = "4")]
			public void Draw(CommandBuffer buf, float weight, int isTransition, int lodIdx)
			{
			}

			// Token: 0x0400026C RID: 620
			[Token(Token = "0x400026C")]
			[FieldOffset(Offset = "0x10")]
			private ShapeGerstner _gerstner;

			// Token: 0x0400026D RID: 621
			[Token(Token = "0x400026D")]
			[FieldOffset(Offset = "0x18")]
			private Material _material;

			// Token: 0x0400026E RID: 622
			[Token(Token = "0x400026E")]
			[FieldOffset(Offset = "0x20")]
			private Mesh _mesh;

			// Token: 0x0400026F RID: 623
			[Token(Token = "0x400026F")]
			[FieldOffset(Offset = "0x28")]
			private int _waveBufferSliceIndex;
		}

		// Token: 0x02000069 RID: 105
		[Token(Token = "0x2000069")]
		private struct GerstnerCascadeParams
		{
			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			[FieldOffset(Offset = "0x0")]
			public int _startIndex;

			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			[FieldOffset(Offset = "0x4")]
			public float _cumulativeVariance;
		}

		// Token: 0x0200006A RID: 106
		[Token(Token = "0x200006A")]
		private struct GerstnerWaveComponent4
		{
			// Token: 0x04000273 RID: 627
			[Token(Token = "0x4000273")]
			[FieldOffset(Offset = "0x0")]
			public Vector4 _twoPiOverWavelength;

			// Token: 0x04000274 RID: 628
			[Token(Token = "0x4000274")]
			[FieldOffset(Offset = "0x10")]
			public Vector4 _amp;

			// Token: 0x04000275 RID: 629
			[Token(Token = "0x4000275")]
			[FieldOffset(Offset = "0x20")]
			public Vector4 _waveDirX;

			// Token: 0x04000276 RID: 630
			[Token(Token = "0x4000276")]
			[FieldOffset(Offset = "0x30")]
			public Vector4 _waveDirZ;

			// Token: 0x04000277 RID: 631
			[Token(Token = "0x4000277")]
			[FieldOffset(Offset = "0x40")]
			public Vector4 _omega;

			// Token: 0x04000278 RID: 632
			[Token(Token = "0x4000278")]
			[FieldOffset(Offset = "0x50")]
			public Vector4 _phase;

			// Token: 0x04000279 RID: 633
			[Token(Token = "0x4000279")]
			[FieldOffset(Offset = "0x60")]
			public Vector4 _chopAmp;

			// Token: 0x0400027A RID: 634
			[Token(Token = "0x400027A")]
			[FieldOffset(Offset = "0x70")]
			public Vector4 _amp2;

			// Token: 0x0400027B RID: 635
			[Token(Token = "0x400027B")]
			[FieldOffset(Offset = "0x80")]
			public Vector4 _chopAmp2;

			// Token: 0x0400027C RID: 636
			[Token(Token = "0x400027C")]
			[FieldOffset(Offset = "0x90")]
			public Vector4 _phase2;
		}
	}
}
