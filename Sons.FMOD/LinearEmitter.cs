using System;
using System.Collections.Generic;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using PathCreation;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
public class LinearEmitter : MonoBehaviour, FMOD_Listener.ILinearEmitter, IFMODEmitter
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000078 RID: 120 RVA: 0x0000236C File Offset: 0x0000056C
	[Token(Token = "0x17000002")]
	private bool HasSource
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2FD94F0", Offset = "0x2FD7AF0", VA = "0x182FD94F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000079 RID: 121 RVA: 0x00002384 File Offset: 0x00000584
	[Token(Token = "0x17000003")]
	private bool HasSpline
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2FD95B0", Offset = "0x2FD7BB0", VA = "0x182FD95B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0000239C File Offset: 0x0000059C
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2FD9670", Offset = "0x2FD7C70", VA = "0x182FD9670", Slot = "4")]
	public float GetMaximumDistance()
	{
		return 0f;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2FD9A00", Offset = "0x2FD8000", VA = "0x182FD9A00", Slot = "5")]
	public void DrawDebug(Vector2 centre, float radius, float maximumDistance)
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2FDA240", Offset = "0x2FD8840", VA = "0x182FDA240")]
	public void RegeneratePointsFromSource()
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2FDA460", Offset = "0x2FD8A60", VA = "0x182FDA460")]
	public void RegeneratePointsFromSpline()
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2FDA7C0", Offset = "0x2FD8DC0", VA = "0x182FDA7C0")]
	public void SetPoints(List<Vector3> newPoints)
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
	public void SetPathCreator(PathCreator creator)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnValidate()
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2FDA820", Offset = "0x2FD8E20", VA = "0x182FDA820")]
	private void Awake()
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2FDA830", Offset = "0x2FD8E30", VA = "0x182FDA830")]
	private void Start()
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2FDAEA0", Offset = "0x2FD94A0", VA = "0x182FDAEA0")]
	public void Activate()
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2FDB3A0", Offset = "0x2FD99A0", VA = "0x182FDB3A0")]
	private void CreateGrid(float eventMaximumDistance)
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2FDB7D0", Offset = "0x2FD9DD0", VA = "0x182FDB7D0")]
	private void AddSegmentToGrid(int segmentIndex)
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000023B4 File Offset: 0x000005B4
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2FDBBE0", Offset = "0x2FDA1E0", VA = "0x182FDBBE0")]
	private LinearEmitter.GridPosition CalculateGridPosition(Vector3 point)
	{
		return default(LinearEmitter.GridPosition);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2FDBDC0", Offset = "0x2FDA3C0", VA = "0x182FDBDC0")]
	private void Update()
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2FDC130", Offset = "0x2FDA730", VA = "0x182FDC130")]
	private void ForEachSegment(Action<Vector3, Vector3> action)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000023CC File Offset: 0x000005CC
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2FDC300", Offset = "0x2FDA900", VA = "0x182FDC300")]
	private int WrapSegmentIndex(int index)
	{
		return 0;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2FDC360", Offset = "0x2FDA960", VA = "0x182FDC360")]
	private void UpdateSegment(int index)
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2FDC790", Offset = "0x2FDAD90", VA = "0x182FDC790")]
	private void UpdateSegments()
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2FDC8B0", Offset = "0x2FDAEB0", VA = "0x182FDC8B0")]
	private void UpdateSegmentsWithGrid()
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2FDCCF0", Offset = "0x2FDB2F0", VA = "0x182FDCCF0")]
	private void UpdateSource(LinearEmitter.Source source)
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2FDCF80", Offset = "0x2FDB580", VA = "0x182FDCF80")]
	private void UpdateSources()
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2FDD710", Offset = "0x2FDBD10", VA = "0x182FDD710")]
	private void SetSourceParameterValues(LinearEmitter.Source source)
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000023E4 File Offset: 0x000005E4
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2FDDA20", Offset = "0x2FDC020", VA = "0x182FDDA20")]
	private int FindClosestAudibleSegment()
	{
		return 0;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x000023FC File Offset: 0x000005FC
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2FCF930", Offset = "0x2FCDF30", VA = "0x182FCF930")]
	private static float WrapDegrees(float angle)
	{
		return 0f;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2FDDBC0", Offset = "0x2FDC1C0", VA = "0x182FDDBC0")]
	private void OccludeSegments(LinearEmitter.Source occluder)
	{
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002414 File Offset: 0x00000614
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2FDE0E0", Offset = "0x2FDC6E0", VA = "0x182FDE0E0")]
	private int DescendToClosestSegment(int segmentIndex)
	{
		return 0;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000242C File Offset: 0x0000062C
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2FDE460", Offset = "0x2FDCA60", VA = "0x182FDE460")]
	private int AscendToAudibleSegment(int segmentIndex)
	{
		return 0;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2FDE750", Offset = "0x2FDCD50", VA = "0x182FDE750")]
	private void OnEnable()
	{
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2FDE7E0", Offset = "0x2FDCDE0", VA = "0x182FDE7E0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2FDE870", Offset = "0x2FDCE70", VA = "0x182FDE870")]
	private void StopAllSources()
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002444 File Offset: 0x00000644
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2FDEAF0", Offset = "0x2FDD0F0", VA = "0x182FDEAF0")]
	private bool IsSegmentOccluded(int index)
	{
		return default(bool);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x0000245C File Offset: 0x0000065C
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2FDEB70", Offset = "0x2FDD170", VA = "0x182FDEB70")]
	private bool IsSegmentActive(int index)
	{
		return default(bool);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2FDEBF0", Offset = "0x2FDD1F0", VA = "0x182FDEBF0")]
	private void SetSegmentFlag(int index, LinearEmitter.SegmentFlags flagToSet, bool value)
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2FDECE0", Offset = "0x2FDD2E0", VA = "0x182FDECE0")]
	private void SetSegmentOccluded(int index, bool value)
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2FDED00", Offset = "0x2FDD300", VA = "0x182FDED00")]
	private void SetSegmentActive(int index, bool value)
	{
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2FD0120", Offset = "0x2FCE720", VA = "0x182FD0120")]
	private static void DrawCross(Texture2D texture, Color color)
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2FDED20", Offset = "0x2FDD320", VA = "0x182FDED20")]
	private void CreateDebugTextures()
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2FDF950", Offset = "0x2FDDF50", VA = "0x182FDF950")]
	private void DrawLine(Vector2 start, Vector2 end, Texture2D texture)
	{
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2FDFA60", Offset = "0x2FDE060", VA = "0x182FDFA60")]
	private void DrawLine(Vector2 start, float angle, float length, Texture2D texture)
	{
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2FDFC00", Offset = "0x2FDE200", VA = "0x182FDFC00")]
	private void DrawTexture(Vector2 position, Texture2D texture)
	{
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x26AB660", Offset = "0x26A9C60", VA = "0x1826AB660", Slot = "6")]
	public void EnableEmitter(bool value)
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2FDFD10", Offset = "0x2FDE310", VA = "0x182FDFD10", Slot = "7")]
	public void DestroyEmitter()
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770", Slot = "8")]
	public void Stop()
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2E3A120", Offset = "0x2E38720", VA = "0x182E3A120", Slot = "9")]
	public void Play()
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90", Slot = "10")]
	public void SetEventPath(string emitterPath)
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
	public List<Vector3> GetPoints()
	{
		return null;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2FDFD60", Offset = "0x2FDE360", VA = "0x182FDFD60")]
	public void SetParameter(string parameterName, List<float> values)
	{
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2FE0150", Offset = "0x2FDE750", VA = "0x182FE0150")]
	public LinearEmitter()
	{
	}

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextAsset _generateSource;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("_patchCreator")]
	[SerializeField]
	private PathCreator _pathCreator;

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x30")]
	[EventRef]
	[SerializeField]
	private string _eventPath;

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int _maximumActiveSources;

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _sourceSpeed;

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool _loopPoints;

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	private const float SOURCE_WIDTH = 90f;

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x0")]
	public static List<LinearEmitter> sAwaitingBankLoad;

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x8")]
	private static Texture2D lineTexture;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x10")]
	private static Texture2D occludedLineTexture;

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x18")]
	private static Texture2D occluderBorderTexture;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x20")]
	private static Texture2D occluderCentreTexture;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x28")]
	private static Texture2D sourceTexture;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x30")]
	private static Texture2D pointTexture;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x38")]
	private static Texture2D occludedPointTexture;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<LinearEmitter.Source> sources;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x50")]
	private List<int> audibleSegments;

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x58")]
	private Bounds bounds;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x70")]
	private Comparison<LinearEmitter.Source> compareSources;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x78")]
	private EventDescription eventDescription;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x80")]
	private List<int>[,,] grid;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 gridCellSizes;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x94")]
	private bool isActive;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x98")]
	public List<LinearEmitter.ParameterInfo> parameters;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[FormerlySerializedAs("points")]
	private List<Vector3> _points;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0xA8")]
	private int rainParameterIndex;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0xAC")]
	private int onOceanParameterIndex;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0xB0")]
	private List<LinearEmitter.SegmentFlags> segmentFlags;

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0xB8")]
	private List<LinearEmitter.Segment> segments;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0xC0")]
	private float sqrEventMaximumDistance;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0xC4")]
	private bool _localPlayerInitialized;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0xC8")]
	private Transform _activeWorldLocation;

	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[Flags]
	public enum SegmentFlags : byte
	{
		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		None = 0,
		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		Occluded = 1,
		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		Active = 2
	}

	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	private class SoundPositionData
	{
		// Token: 0x060000AE RID: 174 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SoundPositionData()
		{
		}

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x10")]
		public List<Vector3> positions;
	}

	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[Serializable]
	public struct ParameterInfo
	{
		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x8")]
		public List<float> values;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public int index;
	}

	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	private struct Segment
	{
		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 start;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 delta;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 closestPoint;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x24")]
		public float closestT;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x28")]
		public float length;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x2C")]
		public float sqrDistance;
	}

	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	private struct Source
	{
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x0")]
		public int segment;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x8")]
		public EventInstance eventInstance;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;
	}

	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	private struct GridPosition
	{
		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x4")]
		public int y;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x8")]
		public int z;
	}
}
