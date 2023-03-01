using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;

// Token: 0x020002CD RID: 717
[Token(Token = "0x20002CD")]
public class WaterOnTerrainSFX : MonoBehaviour, IEnvironmentWetnessReceiver
{
	// Token: 0x06001246 RID: 4678 RVA: 0x00006330 File Offset: 0x00004530
	[Token(Token = "0x6001246")]
	[Address(RVA = "0x2B91F50", Offset = "0x2B90F50", VA = "0x182B91F50")]
	private float GradientForLocalPosition(WaterOnTerrainSFX.IntVector v)
	{
		return default(float);
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x00006348 File Offset: 0x00004548
	[Token(Token = "0x6001247")]
	[Address(RVA = "0x2B91E50", Offset = "0x2B90E50", VA = "0x182B91E50")]
	private Vector3 EventPositionForLocalPosition(WaterOnTerrainSFX.IntVector v)
	{
		return default(Vector3);
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x00006360 File Offset: 0x00004560
	[Token(Token = "0x6001248")]
	[Address(RVA = "0x2B92620", Offset = "0x2B91620", VA = "0x182B92620")]
	private WaterOnTerrainSFX.IntVector SampleGridToWorldGrid(WaterOnTerrainSFX.IntVector v)
	{
		return default(WaterOnTerrainSFX.IntVector);
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x00006378 File Offset: 0x00004578
	[Token(Token = "0x6001249")]
	[Address(RVA = "0x2B91FA0", Offset = "0x2B90FA0", VA = "0x182B91FA0")]
	private Vector3 GridCellCentre(WaterOnTerrainSFX.IntVector v)
	{
		return default(Vector3);
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x00006390 File Offset: 0x00004590
	[Token(Token = "0x600124A")]
	[Address(RVA = "0x2B91FF0", Offset = "0x2B90FF0", VA = "0x182B91FF0")]
	private Rect GridCellRect(WaterOnTerrainSFX.IntVector v)
	{
		return default(Rect);
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124B")]
	[Address(RVA = "0x2B939B0", Offset = "0x2B929B0", VA = "0x182B939B0")]
	private void Update()
	{
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124C")]
	[Address(RVA = "0x2B92540", Offset = "0x2B91540", VA = "0x182B92540")]
	private void OnDisable()
	{
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124D")]
	[Address(RVA = "0x2B90B90", Offset = "0x2B8FB90", VA = "0x182B90B90")]
	private void CheckWeatherSystemRegister()
	{
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124E")]
	[Address(RVA = "0x2B92050", Offset = "0x2B91050", VA = "0x182B92050")]
	private void Initialize()
	{
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124F")]
	[Address(RVA = "0x2B93330", Offset = "0x2B92330", VA = "0x182B93330")]
	private void UpdateSources()
	{
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001250")]
	[Address(RVA = "0x2B924F0", Offset = "0x2B914F0", VA = "0x182B924F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001251")]
	[Address(RVA = "0x2B90C70", Offset = "0x2B8FC70", VA = "0x182B90C70")]
	private void ClearPool()
	{
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001252")]
	[Address(RVA = "0x2B92910", Offset = "0x2B91910", VA = "0x182B92910")]
	private void StopAllSources()
	{
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001253")]
	[Address(RVA = "0x2B92A60", Offset = "0x2B91A60", VA = "0x182B92A60")]
	private void StopSource(int index)
	{
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x000063A8 File Offset: 0x000045A8
	[Token(Token = "0x6001254")]
	[Address(RVA = "0x2B92390", Offset = "0x2B91390", VA = "0x182B92390")]
	private static bool IsWithinSampleGrid(WaterOnTerrainSFX.IntVector v)
	{
		return default(bool);
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x000063C0 File Offset: 0x000045C0
	[Token(Token = "0x6001255")]
	[Address(RVA = "0x2B926C0", Offset = "0x2B916C0", VA = "0x182B926C0")]
	private float ScoreForSource(WaterOnTerrainSFX.IntVector position, WaterOnTerrainSFX.Source source)
	{
		return default(float);
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001256")]
	[Address(RVA = "0x2B923B0", Offset = "0x2B913B0", VA = "0x182B923B0")]
	private void MoveSampleGridEntries(WaterOnTerrainSFX.IntVector offset)
	{
	}

	// Token: 0x06001257 RID: 4695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001257")]
	[Address(RVA = "0x2B90650", Offset = "0x2B8F650", VA = "0x182B90650")]
	private void CacheGradients(WaterOnTerrainSFX.IntVector basePosition, WaterOnTerrainSFX.IntVector start, WaterOnTerrainSFX.IntVector end)
	{
	}

	// Token: 0x06001258 RID: 4696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001258")]
	[Address(RVA = "0x2B909B0", Offset = "0x2B8F9B0", VA = "0x182B909B0")]
	private void CalculateSampleGridScores()
	{
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001259")]
	[Address(RVA = "0x2B92D20", Offset = "0x2B91D20", VA = "0x182B92D20")]
	private void UpdateSampleGrid()
	{
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125A")]
	[Address(RVA = "0x2B92B70", Offset = "0x2B91B70", VA = "0x182B92B70")]
	private void StopSources(WaterOnTerrainSFX.IntVector offset)
	{
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125B")]
	[Address(RVA = "0x2B90CC0", Offset = "0x2B8FCC0", VA = "0x182B90CC0")]
	private static void CreateDebugTextures()
	{
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125C")]
	[Address(RVA = "0x2B91250", Offset = "0x2B90250", VA = "0x182B91250")]
	public void DrawDebug()
	{
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125D")]
	[Address(RVA = "0x2B91BB0", Offset = "0x2B90BB0", VA = "0x182B91BB0")]
	private void DrawSource(WaterOnTerrainSFX.Source source, Matrix4x4 worldToScreenMatrix)
	{
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125E")]
	[Address(RVA = "0x2B91D40", Offset = "0x2B90D40", VA = "0x182B91D40")]
	private void DrawTexture(Vector2 position, Texture2D texture)
	{
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x000063D8 File Offset: 0x000045D8
	[Token(Token = "0x600125F")]
	[Address(RVA = "0x2B92030", Offset = "0x2B91030", VA = "0x182B92030")]
	private static Vector2 GuiPosition(Vector3 worldPosition)
	{
		return default(Vector2);
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001260")]
	[Address(RVA = "0x2B93950", Offset = "0x2B92950", VA = "0x182B93950", Slot = "4")]
	public void UpdateWetness(float wetnessCurrent)
	{
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001261")]
	[Address(RVA = "0x2B93D50", Offset = "0x2B92D50", VA = "0x182B93D50")]
	public WaterOnTerrainSFX()
	{
	}

	// Token: 0x04001247 RID: 4679
	[Token(Token = "0x4001247")]
	[FieldOffset(Offset = "0x0")]
	private static float _wetness;

	// Token: 0x04001248 RID: 4680
	[Token(Token = "0x4001248")]
	[FieldOffset(Offset = "0x20")]
	public int targetSourceCount;

	// Token: 0x04001249 RID: 4681
	[Token(Token = "0x4001249")]
	[FieldOffset(Offset = "0x24")]
	public float sourceSpeed;

	// Token: 0x0400124A RID: 4682
	[Token(Token = "0x400124A")]
	private const int MAXIMUM_GRID_DISTANCE = 10;

	// Token: 0x0400124B RID: 4683
	[Token(Token = "0x400124B")]
	private const int SAMPLE_GRID_SIZE = 21;

	// Token: 0x0400124C RID: 4684
	[Token(Token = "0x400124C")]
	private const int MAXIMUM_GRID_DISTANCE_SQUARED = 100;

	// Token: 0x0400124D RID: 4685
	[Token(Token = "0x400124D")]
	private const string EVENT_PATH = "event:/ambient/water/water_runoff";

	// Token: 0x0400124E RID: 4686
	[Token(Token = "0x400124E")]
	private const float MAXIMUM_GRADIENT = 60f;

	// Token: 0x0400124F RID: 4687
	[Token(Token = "0x400124F")]
	[FieldOffset(Offset = "0x4")]
	private static readonly WaterOnTerrainSFX.IntVector SAMPLE_GRID_CENTRE;

	// Token: 0x04001250 RID: 4688
	[Token(Token = "0x4001250")]
	[FieldOffset(Offset = "0x28")]
	private WaterOnTerrainSFX.IntVector gridPosition;

	// Token: 0x04001251 RID: 4689
	[Token(Token = "0x4001251")]
	[FieldOffset(Offset = "0x30")]
	private WaterOnTerrainSFX.GridCell[,] sampleGrid;

	// Token: 0x04001252 RID: 4690
	[Token(Token = "0x4001252")]
	[FieldOffset(Offset = "0x38")]
	private WaterOnTerrainSFX.Source centreSource;

	// Token: 0x04001253 RID: 4691
	[Token(Token = "0x4001253")]
	[FieldOffset(Offset = "0x40")]
	private List<WaterOnTerrainSFX.Source> sources;

	// Token: 0x04001254 RID: 4692
	[Token(Token = "0x4001254")]
	[FieldOffset(Offset = "0x48")]
	private Stack<WaterOnTerrainSFX.Source> sourcePool;

	// Token: 0x04001255 RID: 4693
	[Token(Token = "0x4001255")]
	[FieldOffset(Offset = "0x50")]
	private EventDescription eventDescription;

	// Token: 0x04001256 RID: 4694
	[Token(Token = "0x4001256")]
	[FieldOffset(Offset = "0x58")]
	private int gradientParameterIndex;

	// Token: 0x04001257 RID: 4695
	[Token(Token = "0x4001257")]
	[FieldOffset(Offset = "0x5C")]
	private int wetnessParameterIndex;

	// Token: 0x04001258 RID: 4696
	[Token(Token = "0x4001258")]
	[FieldOffset(Offset = "0x60")]
	private float gridCellSize;

	// Token: 0x04001259 RID: 4697
	[Token(Token = "0x4001259")]
	private const float MAXIMUM_SCORE_RATIO = 5f;

	// Token: 0x0400125A RID: 4698
	[Token(Token = "0x400125A")]
	[FieldOffset(Offset = "0x64")]
	private float maximumScore;

	// Token: 0x0400125B RID: 4699
	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0x10")]
	private static readonly WaterOnTerrainSFX.IntVector[] NEIGHBOURS;

	// Token: 0x0400125C RID: 4700
	[Token(Token = "0x400125C")]
	private const int SOURCE_EFFECT_RADIUS = 5;

	// Token: 0x0400125D RID: 4701
	[Token(Token = "0x400125D")]
	private const float SOURCE_EFFECT_AMOUNT = 0.1f;

	// Token: 0x0400125E RID: 4702
	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0x18")]
	private static Texture2D cellTexture;

	// Token: 0x0400125F RID: 4703
	[Token(Token = "0x400125F")]
	[FieldOffset(Offset = "0x20")]
	private static Texture2D sourceTexture;

	// Token: 0x04001260 RID: 4704
	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0x28")]
	private static Texture2D eventTexture;

	// Token: 0x04001261 RID: 4705
	[Token(Token = "0x4001261")]
	[FieldOffset(Offset = "0x68")]
	private bool _initialized;

	// Token: 0x04001262 RID: 4706
	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0x69")]
	private bool _weatherSystemRegistered;

	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	private struct IntVector
	{
		// Token: 0x06001263 RID: 4707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001263")]
		[Address(RVA = "0x584850", Offset = "0x583850", VA = "0x180584850")]
		public IntVector(int x, int y)
		{
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x6001264")]
		[Address(RVA = "0x5E4800", Offset = "0x5E3800", VA = "0x1805E4800")]
		public static bool operator ==(WaterOnTerrainSFX.IntVector a, WaterOnTerrainSFX.IntVector b)
		{
			return default(bool);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x6001265")]
		[Address(RVA = "0x5E4820", Offset = "0x5E3820", VA = "0x1805E4820")]
		public static bool operator !=(WaterOnTerrainSFX.IntVector a, WaterOnTerrainSFX.IntVector b)
		{
			return default(bool);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00006420 File Offset: 0x00004620
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x5E4840", Offset = "0x5E3840", VA = "0x1805E4840")]
		public static WaterOnTerrainSFX.IntVector operator -(WaterOnTerrainSFX.IntVector a, WaterOnTerrainSFX.IntVector b)
		{
			return default(WaterOnTerrainSFX.IntVector);
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x1B3A210", Offset = "0x1B39210", VA = "0x181B3A210")]
		public static WaterOnTerrainSFX.IntVector operator -(WaterOnTerrainSFX.IntVector v)
		{
			return default(WaterOnTerrainSFX.IntVector);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00006450 File Offset: 0x00004650
		[Token(Token = "0x6001268")]
		[Address(RVA = "0x5E47E0", Offset = "0x5E37E0", VA = "0x1805E47E0")]
		public static WaterOnTerrainSFX.IntVector operator +(WaterOnTerrainSFX.IntVector a, WaterOnTerrainSFX.IntVector b)
		{
			return default(WaterOnTerrainSFX.IntVector);
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00006468 File Offset: 0x00004668
		[Token(Token = "0x1700020F")]
		public int squareMagnitude
		{
			[Token(Token = "0x6001269")]
			[Address(RVA = "0x1B3A010", Offset = "0x1B39010", VA = "0x181B3A010")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00006480 File Offset: 0x00004680
		[Token(Token = "0x17000210")]
		public float magnitude
		{
			[Token(Token = "0x600126A")]
			[Address(RVA = "0x2B84CE0", Offset = "0x2B83CE0", VA = "0x182B84CE0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x04001263 RID: 4707
		[Token(Token = "0x4001263")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x04001264 RID: 4708
		[Token(Token = "0x4001264")]
		[FieldOffset(Offset = "0x4")]
		public int y;
	}

	// Token: 0x020002CF RID: 719
	[Token(Token = "0x20002CF")]
	private struct GridCell
	{
		// Token: 0x04001265 RID: 4709
		[Token(Token = "0x4001265")]
		[FieldOffset(Offset = "0x0")]
		public float gradient;

		// Token: 0x04001266 RID: 4710
		[Token(Token = "0x4001266")]
		[FieldOffset(Offset = "0x4")]
		public float score;
	}

	// Token: 0x020002D0 RID: 720
	[Token(Token = "0x20002D0")]
	private class Source
	{
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00006498 File Offset: 0x00004698
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000211")]
		public Vector3 eventPosition
		{
			[Token(Token = "0x600126B")]
			[Address(RVA = "0x909E10", Offset = "0x908E10", VA = "0x180909E10")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600126C")]
			[Address(RVA = "0x143A810", Offset = "0x1439810", VA = "0x18143A810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x2B86AE0", Offset = "0x2B85AE0", VA = "0x182B86AE0")]
		public void Start(EventDescription eventDescription, int gradientParameterIndex, int wetnessParameterIndex, WaterOnTerrainSFX.IntVector localPosition, Vector3 eventPosition, float gradient)
		{
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000064B0 File Offset: 0x000046B0
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x2B86A90", Offset = "0x2B85A90", VA = "0x182B86A90")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x2B86AA0", Offset = "0x2B85AA0", VA = "0x182B86AA0")]
		public void SetGradient(float gradient)
		{
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x2B86C50", Offset = "0x2B85C50", VA = "0x182B86C50")]
		public void UpdateEvent(Vector3 targetPosition, float distance, float wetness)
		{
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x2B86C00", Offset = "0x2B85C00", VA = "0x182B86C00")]
		public void Stop()
		{
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001272")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public Source()
		{
		}

		// Token: 0x04001267 RID: 4711
		[Token(Token = "0x4001267")]
		[FieldOffset(Offset = "0x10")]
		public WaterOnTerrainSFX.IntVector localPosition;

		// Token: 0x04001269 RID: 4713
		[Token(Token = "0x4001269")]
		[FieldOffset(Offset = "0x28")]
		private EventInstance eventInstance;

		// Token: 0x0400126A RID: 4714
		[Token(Token = "0x400126A")]
		[FieldOffset(Offset = "0x30")]
		private int gradientParameterIndex;

		// Token: 0x0400126B RID: 4715
		[Token(Token = "0x400126B")]
		[FieldOffset(Offset = "0x34")]
		private int wetnessParameterIndex;
	}
}
