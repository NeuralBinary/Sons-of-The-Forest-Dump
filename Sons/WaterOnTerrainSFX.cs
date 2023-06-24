using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;

// Token: 0x020002C1 RID: 705
[Token(Token = "0x20002C1")]
public class WaterOnTerrainSFX : MonoBehaviour, IEnvironmentWetnessReceiver
{
	// Token: 0x0600127B RID: 4731 RVA: 0x000065B8 File Offset: 0x000047B8
	[Token(Token = "0x600127B")]
	[Address(RVA = "0x31DD380", Offset = "0x31DB980", VA = "0x1831DD380")]
	private float GradientForLocalPosition(WaterOnTerrainSFX.IntVector v)
	{
		return 0f;
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x000065D0 File Offset: 0x000047D0
	[Token(Token = "0x600127C")]
	[Address(RVA = "0x31DD3D0", Offset = "0x31DB9D0", VA = "0x1831DD3D0")]
	private Vector3 EventPositionForLocalPosition(WaterOnTerrainSFX.IntVector v)
	{
		return default(Vector3);
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x000065E8 File Offset: 0x000047E8
	[Token(Token = "0x600127D")]
	[Address(RVA = "0x31DD550", Offset = "0x31DBB50", VA = "0x1831DD550")]
	private WaterOnTerrainSFX.IntVector SampleGridToWorldGrid(WaterOnTerrainSFX.IntVector v)
	{
		return default(WaterOnTerrainSFX.IntVector);
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x00006600 File Offset: 0x00004800
	[Token(Token = "0x600127E")]
	[Address(RVA = "0x31DD5F0", Offset = "0x31DBBF0", VA = "0x1831DD5F0")]
	private Vector3 GridCellCentre(WaterOnTerrainSFX.IntVector v)
	{
		return default(Vector3);
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x00006618 File Offset: 0x00004818
	[Token(Token = "0x600127F")]
	[Address(RVA = "0x31DD640", Offset = "0x31DBC40", VA = "0x1831DD640")]
	private Rect GridCellRect(WaterOnTerrainSFX.IntVector v)
	{
		return default(Rect);
	}

	// Token: 0x06001280 RID: 4736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001280")]
	[Address(RVA = "0x31DD680", Offset = "0x31DBC80", VA = "0x1831DD680")]
	private void Update()
	{
	}

	// Token: 0x06001281 RID: 4737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001281")]
	[Address(RVA = "0x31DD840", Offset = "0x31DBE40", VA = "0x1831DD840")]
	private void OnDisable()
	{
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001282")]
	[Address(RVA = "0x31DD970", Offset = "0x31DBF70", VA = "0x1831DD970")]
	private void CheckWeatherSystemRegister()
	{
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001283")]
	[Address(RVA = "0x31DDAB0", Offset = "0x31DC0B0", VA = "0x1831DDAB0")]
	private void Initialize()
	{
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001284")]
	[Address(RVA = "0x31DDEE0", Offset = "0x31DC4E0", VA = "0x1831DDEE0")]
	private void UpdateSources()
	{
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001285")]
	[Address(RVA = "0x31DE5C0", Offset = "0x31DCBC0", VA = "0x1831DE5C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001286")]
	[Address(RVA = "0x31DE620", Offset = "0x31DCC20", VA = "0x1831DE620")]
	private void ClearPool()
	{
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x31DE670", Offset = "0x31DCC70", VA = "0x1831DE670")]
	private void StopAllSources()
	{
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001288")]
	[Address(RVA = "0x31DE7E0", Offset = "0x31DCDE0", VA = "0x1831DE7E0")]
	private void StopSource(int index)
	{
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x00006630 File Offset: 0x00004830
	[Token(Token = "0x6001289")]
	[Address(RVA = "0x31DE910", Offset = "0x31DCF10", VA = "0x1831DE910")]
	private static bool IsWithinSampleGrid(WaterOnTerrainSFX.IntVector v)
	{
		return default(bool);
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x00006648 File Offset: 0x00004848
	[Token(Token = "0x600128A")]
	[Address(RVA = "0x31DE930", Offset = "0x31DCF30", VA = "0x1831DE930")]
	private float ScoreForSource(WaterOnTerrainSFX.IntVector position, WaterOnTerrainSFX.Source source)
	{
		return 0f;
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128B")]
	[Address(RVA = "0x31DEB80", Offset = "0x31DD180", VA = "0x1831DEB80")]
	private void MoveSampleGridEntries(WaterOnTerrainSFX.IntVector offset)
	{
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128C")]
	[Address(RVA = "0x31DECC0", Offset = "0x31DD2C0", VA = "0x1831DECC0")]
	private void CacheGradients(WaterOnTerrainSFX.IntVector basePosition, WaterOnTerrainSFX.IntVector start, WaterOnTerrainSFX.IntVector end)
	{
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128D")]
	[Address(RVA = "0x31DF110", Offset = "0x31DD710", VA = "0x1831DF110")]
	private void CalculateSampleGridScores()
	{
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128E")]
	[Address(RVA = "0x31DF2F0", Offset = "0x31DD8F0", VA = "0x1831DF2F0")]
	private void UpdateSampleGrid()
	{
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128F")]
	[Address(RVA = "0x31DF760", Offset = "0x31DDD60", VA = "0x1831DF760")]
	private void StopSources(WaterOnTerrainSFX.IntVector offset)
	{
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001290")]
	[Address(RVA = "0x31DF910", Offset = "0x31DDF10", VA = "0x1831DF910")]
	private static void CreateDebugTextures()
	{
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001291")]
	[Address(RVA = "0x31E0140", Offset = "0x31DE740", VA = "0x1831E0140")]
	public void DrawDebug()
	{
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001292")]
	[Address(RVA = "0x31E0EE0", Offset = "0x31DF4E0", VA = "0x1831E0EE0")]
	private void DrawSource(WaterOnTerrainSFX.Source source, Matrix4x4 worldToScreenMatrix)
	{
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001293")]
	[Address(RVA = "0x31E10D0", Offset = "0x31DF6D0", VA = "0x1831E10D0")]
	private void DrawTexture(Vector2 position, Texture2D texture)
	{
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x00006660 File Offset: 0x00004860
	[Token(Token = "0x6001294")]
	[Address(RVA = "0x31E11E0", Offset = "0x31DF7E0", VA = "0x1831E11E0")]
	private static Vector2 GuiPosition(Vector3 worldPosition)
	{
		return default(Vector2);
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001295")]
	[Address(RVA = "0x31E1200", Offset = "0x31DF800", VA = "0x1831E1200", Slot = "4")]
	public void UpdateWetness(float wetnessCurrent)
	{
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001296")]
	[Address(RVA = "0x31E1260", Offset = "0x31DF860", VA = "0x1831E1260")]
	public WaterOnTerrainSFX()
	{
	}

	// Token: 0x0400126E RID: 4718
	[Token(Token = "0x400126E")]
	[FieldOffset(Offset = "0x0")]
	private static float _wetness;

	// Token: 0x0400126F RID: 4719
	[Token(Token = "0x400126F")]
	[FieldOffset(Offset = "0x20")]
	public int targetSourceCount;

	// Token: 0x04001270 RID: 4720
	[Token(Token = "0x4001270")]
	[FieldOffset(Offset = "0x24")]
	public float sourceSpeed;

	// Token: 0x04001271 RID: 4721
	[Token(Token = "0x4001271")]
	private const int MAXIMUM_GRID_DISTANCE = 10;

	// Token: 0x04001272 RID: 4722
	[Token(Token = "0x4001272")]
	private const int SAMPLE_GRID_SIZE = 21;

	// Token: 0x04001273 RID: 4723
	[Token(Token = "0x4001273")]
	private const int MAXIMUM_GRID_DISTANCE_SQUARED = 100;

	// Token: 0x04001274 RID: 4724
	[Token(Token = "0x4001274")]
	private const string EVENT_PATH = "event:/ambient/water/water_runoff";

	// Token: 0x04001275 RID: 4725
	[Token(Token = "0x4001275")]
	private const float MAXIMUM_GRADIENT = 60f;

	// Token: 0x04001276 RID: 4726
	[Token(Token = "0x4001276")]
	[FieldOffset(Offset = "0x4")]
	private static readonly WaterOnTerrainSFX.IntVector SAMPLE_GRID_CENTRE;

	// Token: 0x04001277 RID: 4727
	[Token(Token = "0x4001277")]
	[FieldOffset(Offset = "0x28")]
	private WaterOnTerrainSFX.IntVector gridPosition;

	// Token: 0x04001278 RID: 4728
	[Token(Token = "0x4001278")]
	[FieldOffset(Offset = "0x30")]
	private WaterOnTerrainSFX.GridCell[,] sampleGrid;

	// Token: 0x04001279 RID: 4729
	[Token(Token = "0x4001279")]
	[FieldOffset(Offset = "0x38")]
	private WaterOnTerrainSFX.Source centreSource;

	// Token: 0x0400127A RID: 4730
	[Token(Token = "0x400127A")]
	[FieldOffset(Offset = "0x40")]
	private List<WaterOnTerrainSFX.Source> sources;

	// Token: 0x0400127B RID: 4731
	[Token(Token = "0x400127B")]
	[FieldOffset(Offset = "0x48")]
	private Stack<WaterOnTerrainSFX.Source> sourcePool;

	// Token: 0x0400127C RID: 4732
	[Token(Token = "0x400127C")]
	[FieldOffset(Offset = "0x50")]
	private EventDescription eventDescription;

	// Token: 0x0400127D RID: 4733
	[Token(Token = "0x400127D")]
	[FieldOffset(Offset = "0x58")]
	private int gradientParameterIndex;

	// Token: 0x0400127E RID: 4734
	[Token(Token = "0x400127E")]
	[FieldOffset(Offset = "0x5C")]
	private int wetnessParameterIndex;

	// Token: 0x0400127F RID: 4735
	[Token(Token = "0x400127F")]
	[FieldOffset(Offset = "0x60")]
	private float gridCellSize;

	// Token: 0x04001280 RID: 4736
	[Token(Token = "0x4001280")]
	private const float MAXIMUM_SCORE_RATIO = 5f;

	// Token: 0x04001281 RID: 4737
	[Token(Token = "0x4001281")]
	[FieldOffset(Offset = "0x64")]
	private float maximumScore;

	// Token: 0x04001282 RID: 4738
	[Token(Token = "0x4001282")]
	[FieldOffset(Offset = "0x10")]
	private static readonly WaterOnTerrainSFX.IntVector[] NEIGHBOURS;

	// Token: 0x04001283 RID: 4739
	[Token(Token = "0x4001283")]
	private const int SOURCE_EFFECT_RADIUS = 5;

	// Token: 0x04001284 RID: 4740
	[Token(Token = "0x4001284")]
	private const float SOURCE_EFFECT_AMOUNT = 0.1f;

	// Token: 0x04001285 RID: 4741
	[Token(Token = "0x4001285")]
	[FieldOffset(Offset = "0x18")]
	private static Texture2D cellTexture;

	// Token: 0x04001286 RID: 4742
	[Token(Token = "0x4001286")]
	[FieldOffset(Offset = "0x20")]
	private static Texture2D sourceTexture;

	// Token: 0x04001287 RID: 4743
	[Token(Token = "0x4001287")]
	[FieldOffset(Offset = "0x28")]
	private static Texture2D eventTexture;

	// Token: 0x04001288 RID: 4744
	[Token(Token = "0x4001288")]
	[FieldOffset(Offset = "0x68")]
	private bool _initialized;

	// Token: 0x04001289 RID: 4745
	[Token(Token = "0x4001289")]
	[FieldOffset(Offset = "0x69")]
	private bool _weatherSystemRegistered;

	// Token: 0x020002C2 RID: 706
	[Token(Token = "0x20002C2")]
	private struct IntVector
	{
		// Token: 0x06001298 RID: 4760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
		public IntVector(int x, int y)
		{
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00006678 File Offset: 0x00004878
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x65FF70", Offset = "0x65E570", VA = "0x18065FF70")]
		public static bool operator ==(WaterOnTerrainSFX.IntVector a, WaterOnTerrainSFX.IntVector b)
		{
			return default(bool);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00006690 File Offset: 0x00004890
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x65FF90", Offset = "0x65E590", VA = "0x18065FF90")]
		public static bool operator !=(WaterOnTerrainSFX.IntVector a, WaterOnTerrainSFX.IntVector b)
		{
			return default(bool);
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x65FF50", Offset = "0x65E550", VA = "0x18065FF50")]
		public static WaterOnTerrainSFX.IntVector operator -(WaterOnTerrainSFX.IntVector a, WaterOnTerrainSFX.IntVector b)
		{
			return default(WaterOnTerrainSFX.IntVector);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x600129C")]
		[Address(RVA = "0x1E2ACB0", Offset = "0x1E292B0", VA = "0x181E2ACB0")]
		public static WaterOnTerrainSFX.IntVector operator -(WaterOnTerrainSFX.IntVector v)
		{
			return default(WaterOnTerrainSFX.IntVector);
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000066D8 File Offset: 0x000048D8
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x65FF30", Offset = "0x65E530", VA = "0x18065FF30")]
		public static WaterOnTerrainSFX.IntVector operator +(WaterOnTerrainSFX.IntVector a, WaterOnTerrainSFX.IntVector b)
		{
			return default(WaterOnTerrainSFX.IntVector);
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x000066F0 File Offset: 0x000048F0
		[Token(Token = "0x17000218")]
		public int squareMagnitude
		{
			[Token(Token = "0x600129E")]
			[Address(RVA = "0x1E2AC10", Offset = "0x1E29210", VA = "0x181E2AC10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x17000219")]
		public float magnitude
		{
			[Token(Token = "0x600129F")]
			[Address(RVA = "0x31E1750", Offset = "0x31DFD50", VA = "0x1831E1750")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0400128A RID: 4746
		[Token(Token = "0x400128A")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x0400128B RID: 4747
		[Token(Token = "0x400128B")]
		[FieldOffset(Offset = "0x4")]
		public int y;
	}

	// Token: 0x020002C3 RID: 707
	[Token(Token = "0x20002C3")]
	private struct GridCell
	{
		// Token: 0x0400128C RID: 4748
		[Token(Token = "0x400128C")]
		[FieldOffset(Offset = "0x0")]
		public float gradient;

		// Token: 0x0400128D RID: 4749
		[Token(Token = "0x400128D")]
		[FieldOffset(Offset = "0x4")]
		public float score;
	}

	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20002C4")]
	private class Source
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00006720 File Offset: 0x00004920
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700021A")]
		public Vector3 eventPosition
		{
			[Token(Token = "0x60012A0")]
			[Address(RVA = "0xA6DCA0", Offset = "0xA6C2A0", VA = "0x180A6DCA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60012A1")]
			[Address(RVA = "0x1676010", Offset = "0x1674610", VA = "0x181676010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x31E1780", Offset = "0x31DFD80", VA = "0x1831E1780")]
		public void Start(EventDescription eventDescription, int gradientParameterIndex, int wetnessParameterIndex, WaterOnTerrainSFX.IntVector localPosition, Vector3 eventPosition, float gradient)
		{
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x60012A3")]
		[Address(RVA = "0x31E1900", Offset = "0x31DFF00", VA = "0x1831E1900")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x31E1910", Offset = "0x31DFF10", VA = "0x1831E1910")]
		public void SetGradient(float gradient)
		{
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x31E1950", Offset = "0x31DFF50", VA = "0x1831E1950")]
		public void UpdateEvent(Vector3 targetPosition, float distance, float wetness)
		{
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x31E1BF0", Offset = "0x31E01F0", VA = "0x1831E1BF0")]
		public void Stop()
		{
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Source()
		{
		}

		// Token: 0x0400128E RID: 4750
		[Token(Token = "0x400128E")]
		[FieldOffset(Offset = "0x10")]
		public WaterOnTerrainSFX.IntVector localPosition;

		// Token: 0x04001290 RID: 4752
		[Token(Token = "0x4001290")]
		[FieldOffset(Offset = "0x28")]
		private EventInstance eventInstance;

		// Token: 0x04001291 RID: 4753
		[Token(Token = "0x4001291")]
		[FieldOffset(Offset = "0x30")]
		private int gradientParameterIndex;

		// Token: 0x04001292 RID: 4754
		[Token(Token = "0x4001292")]
		[FieldOffset(Offset = "0x34")]
		private int wetnessParameterIndex;
	}
}
