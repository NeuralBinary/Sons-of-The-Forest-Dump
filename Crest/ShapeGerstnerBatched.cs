using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[ExecuteAlways]
	public class ShapeGerstnerBatched : MonoBehaviour, ICollProvider, IFloatingOrigin
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x170000A3")]
		public Vector2 WindDir
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xA11BE0", Offset = "0xA101E0", VA = "0x180A11BE0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xA11C30", Offset = "0xA10230", VA = "0x180A11C30")]
		private void OnEnable()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xA11D80", Offset = "0xA10380", VA = "0x180A11D80")]
		private void InitPhases()
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xA11FA0", Offset = "0xA105A0", VA = "0x180A11FA0", Slot = "9")]
		public void SetOrigin(Vector3 newOrigin)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xA12180", Offset = "0xA10780", VA = "0x180A12180")]
		private void UpdateData()
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xA12380", Offset = "0xA10980", VA = "0x180A12380")]
		public void UpdateWaveData()
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA12650", Offset = "0xA10C50", VA = "0x180A12650")]
		private void UpdateAmplitudes()
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xA127C0", Offset = "0xA10DC0", VA = "0x180A127C0")]
		private void ReportMaxDisplacement()
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xA129D0", Offset = "0xA10FD0", VA = "0x180A129D0")]
		private void InitBatches()
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xA13040", Offset = "0xA11640", VA = "0x180A13040")]
		private void UpdateBatch(int lodIdx, int firstComponent, int lastComponentNonInc, ShapeGerstnerBatched.GerstnerBatch batch)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xA13C60", Offset = "0xA12260", VA = "0x180A13C60")]
		private void UpdateBatch(ShapeGerstnerBatched.GerstnerBatch batch, int batchIdx)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xA13ED0", Offset = "0xA124D0", VA = "0x180A13ED0")]
		private void OnDisable()
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xA14040", Offset = "0xA12640", VA = "0x180A14040")]
		private float ComputeWaveSpeed(float wavelength)
		{
			return 0f;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xA14070", Offset = "0xA12670", VA = "0x180A14070")]
		public bool GetSurfaceVelocity(ref Vector3 i_worldPos, float i_minSpatialLength, out Vector3 o_surfaceVel)
		{
			return default(bool);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xA144D0", Offset = "0xA12AD0", VA = "0x180A144D0")]
		public bool SampleHeight(ref Vector3 i_worldPos, float i_minSpatialLength, out float o_height)
		{
			return default(bool);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA14680", Offset = "0xA12C80", VA = "0x180A14680")]
		public bool ComputeUndisplacedPosition(ref Vector3 i_worldPos, float i_minSpatialLength, out Vector3 o_undisplacedWorldPos)
		{
			return default(bool);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xA14800", Offset = "0xA12E00", VA = "0x180A14800")]
		public bool SampleNormal(ref Vector3 i_undisplacedWorldPos, float i_minSpatialLength, out Vector3 o_normal)
		{
			return default(bool);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xA14DF0", Offset = "0xA133F0", VA = "0x180A14DF0")]
		public bool SampleDisplacement(ref Vector3 i_worldPos, float i_minSpatialLength, out Vector3 o_displacement)
		{
			return default(bool);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA15220", Offset = "0xA13820", VA = "0x180A15220", Slot = "5")]
		public int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, Vector3[] o_resultDisps, Vector3[] o_resultNorms, Vector3[] o_resultVels)
		{
			return 0;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA153C0", Offset = "0xA139C0", VA = "0x180A153C0", Slot = "4")]
		public int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, float[] o_resultHeights, Vector3[] o_resultNorms, Vector3[] o_resultVels)
		{
			return 0;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x9B12E0", Offset = "0x9AF8E0", VA = "0x1809B12E0", Slot = "6")]
		public bool RetrieveSucceeded(int queryStatus)
		{
			return default(bool);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public void UpdateQueries()
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public void CleanUp()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xA15720", Offset = "0xA13D20", VA = "0x180A15720")]
		public ShapeGerstnerBatched()
		{
		}

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("If set to 'Global', waves will render everywhere. If set to 'Geometry', the geometry on this GameObject will be rendered from a top down perspective to generate the waves. This allows having local wave conditions by placing Quad geometry where desired. The geometry must have one of the Gerstner shaders on it such as 'Crest/Inputs/Animated Waves/Gerstner Batch Geometry'.")]
		public ShapeGerstnerBatched.GerstnerMode _mode;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The spectrum that defines the ocean surface shape. Create asset of type Crest/Ocean Waves Spectrum.")]
		public OceanWaveSpectrum _spectrum;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x30")]
		[Range(-180f, 180f)]
		[Tooltip("Wind direction (angle from x axis in degrees)")]
		public float _windDirectionAngle;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x34")]
		public float _cullDistance;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x38")]
		public float _fadeRange;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x3C")]
		private float _cullDistanceSqr;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x40")]
		private float _oneOverFadeRangeSqr;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x48")]
		private Transform trans;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 pos;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x60")]
		private ShapeGerstnerBatched.GerstnerBatch[] _batches;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("How many wave components to generate in each octave.")]
		[Delayed]
		public int _componentsPerOctave;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float _weight;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x70")]
		public int _randomSeed;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x74")]
		[Header("Wave data (usually populated at runtime)")]
		public bool _evaluateSpectrumAtRuntime;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x78")]
		[PredicatedField("_evaluateSpectrumAtRuntime", true, 0)]
		public float[] _wavelengths;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x80")]
		[PredicatedField("_evaluateSpectrumAtRuntime", true, 0)]
		public float[] _amplitudes;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x88")]
		[PredicatedField("_evaluateSpectrumAtRuntime", true, 0)]
		public float[] _angleDegs;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x90")]
		[PredicatedField("_evaluateSpectrumAtRuntime", true, 0)]
		public float[] _phases;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Header("Direct towards point")]
		[Tooltip("Make waves converge towards a point. Must be set at edit time only, applied on startup.")]
		private bool _directTowardsPoint;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Tooltip("Target point XZ to converge to.")]
		private Vector2 _pointPositionXZ;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0xA4")]
		[Tooltip("Inner and outer radii. Influence at full strength at inner radius, fades off at outer radius.")]
		[SerializeField]
		private Vector2 _pointRadii;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		private const string DIRECT_TOWARDS_POINT_KEYWORD = "CREST_DIRECT_TOWARDS_POINT_INTERNAL";

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0xAC")]
		private readonly int sp_TwoPiOverWavelengths;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0xB0")]
		private readonly int sp_Amplitudes;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0xB4")]
		private readonly int sp_WaveDirX;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0xB8")]
		private readonly int sp_WaveDirZ;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0xBC")]
		private readonly int sp_Phases;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0xC0")]
		private readonly int sp_ChopAmps;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0xC4")]
		private readonly int sp_NumInBatch;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0xC8")]
		private readonly int sp_AttenuationInShallows;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0xCC")]
		private readonly int sp_NumWaveVecs;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0xD0")]
		private readonly int sp_TargetPointData;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		private const int BATCH_SIZE = 32;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0xD8")]
		private GameObject _renderProxy;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0xE0")]
		private int _lastFrameForUpdateData;

		// Token: 0x0200006C RID: 108
		[Token(Token = "0x200006C")]
		public enum GerstnerMode
		{
			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			Global,
			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			Geometry
		}

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		public class GerstnerBatch : ILodDataInput
		{
			// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0xA15BA0", Offset = "0xA141A0", VA = "0x180A15BA0")]
			public GerstnerBatch(ShapeGerstnerBatched gerstner, int batchIndex, MeshRenderer rend, bool directTowardsPoint)
			{
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x000020E2 File Offset: 0x000002E2
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xA16100", Offset = "0xA14700", VA = "0x180A16100")]
			public PropertyWrapperMaterial GetMaterial(int isTransition)
			{
				return null;
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060002B9 RID: 697 RVA: 0x00003288 File Offset: 0x00001488
			[Token(Token = "0x170000A4")]
			public float Wavelength
			{
				[Token(Token = "0x60002B9")]
				[Address(RVA = "0xA16130", Offset = "0xA14730", VA = "0x180A16130", Slot = "5")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060002BA RID: 698 RVA: 0x000032A0 File Offset: 0x000014A0
			// (set) Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A5")]
			public bool Enabled
			{
				[Token(Token = "0x60002BA")]
				[Address(RVA = "0x9DD210", Offset = "0x9DB810", VA = "0x1809DD210", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002BB")]
				[Address(RVA = "0x9DD220", Offset = "0x9DB820", VA = "0x1809DD220")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060002BC RID: 700 RVA: 0x000032B8 File Offset: 0x000014B8
			// (set) Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A6")]
			public bool HasWaves
			{
				[Token(Token = "0x60002BC")]
				[Address(RVA = "0xA161F0", Offset = "0xA147F0", VA = "0x180A161F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002BD")]
				[Address(RVA = "0xA16200", Offset = "0xA14800", VA = "0x180A16200")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xA16210", Offset = "0xA14810", VA = "0x180A16210", Slot = "4")]
			public void Draw(CommandBuffer buf, float weight, int isTransition, int lodIdx)
			{
			}

			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			[FieldOffset(Offset = "0x10")]
			private PropertyWrapperMaterial[] _materials;

			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			[FieldOffset(Offset = "0x18")]
			private MeshRenderer _rend;

			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			[FieldOffset(Offset = "0x20")]
			private ShapeGerstnerBatched _gerstner;

			// Token: 0x040002A6 RID: 678
			[Token(Token = "0x40002A6")]
			[FieldOffset(Offset = "0x28")]
			private int _batchIndex;
		}

		// Token: 0x0200006E RID: 110
		[Token(Token = "0x200006E")]
		private struct UpdateBatchScratchData
		{
			// Token: 0x040002A9 RID: 681
			[Token(Token = "0x40002A9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Vector4[] _twoPiOverWavelengthsBatch;

			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			[FieldOffset(Offset = "0x8")]
			public static readonly Vector4[] _ampsBatch;

			// Token: 0x040002AB RID: 683
			[Token(Token = "0x40002AB")]
			[FieldOffset(Offset = "0x10")]
			public static readonly Vector4[] _waveDirXBatch;

			// Token: 0x040002AC RID: 684
			[Token(Token = "0x40002AC")]
			[FieldOffset(Offset = "0x18")]
			public static readonly Vector4[] _waveDirZBatch;

			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			[FieldOffset(Offset = "0x20")]
			public static readonly Vector4[] _phasesBatch;

			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			[FieldOffset(Offset = "0x28")]
			public static readonly Vector4[] _chopAmpsBatch;
		}
	}
}
