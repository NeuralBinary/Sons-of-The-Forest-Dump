using System;
using System.Collections.Generic;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class AreaEmitter : MonoBehaviour, FMOD_Listener.IAreaEmitter, IFMODEmitter
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
	public string GetEventPath()
	{
		return null;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2FCD9B0", Offset = "0x2FCBFB0", VA = "0x182FCD9B0")]
	private static Vector3 GetListenerPosition()
	{
		return default(Vector3);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2FCD9E0", Offset = "0x2FCBFE0", VA = "0x182FCD9E0")]
	public Vector3 TransformPoint(Vector2 point)
	{
		return default(Vector3);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2FCDAF0", Offset = "0x2FCC0F0", VA = "0x182FCDAF0")]
	public Vector2 InverseTransformPoint(Vector3 point)
	{
		return default(Vector2);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2FCDBE0", Offset = "0x2FCC1E0", VA = "0x182FCDBE0")]
	private void Start()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2FCDBF0", Offset = "0x2FCC1F0", VA = "0x182FCDBF0")]
	private bool Initialize()
	{
		return default(bool);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2FCE220", Offset = "0x2FCC820", VA = "0x182FCE220")]
	public AreaEmitter.Polygon GetPolygon(int index)
	{
		return null;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2FCE2A0", Offset = "0x2FCC8A0", VA = "0x182FCE2A0")]
	private void Update()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2FCE580", Offset = "0x2FCCB80", VA = "0x182FCE580")]
	private void UpdateContained(Vector3 listenerPosition)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000020B4 File Offset: 0x000002B4
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2FCEA70", Offset = "0x2FCD070", VA = "0x182FCEA70")]
	private bool ContainsPlayer(out AreaEmitter.Polygon boundaryPolygon)
	{
		return default(bool);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2FCECB0", Offset = "0x2FCD2B0", VA = "0x182FCECB0")]
	private void UpdateSource(AreaEmitter.Source source)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2FCED20", Offset = "0x2FCD320", VA = "0x182FCED20")]
	private void UpdateEvent(EventInstance eventInstance, Vector3 position)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2FCEF70", Offset = "0x2FCD570", VA = "0x182FCEF70")]
	private static void StopSource(AreaEmitter.Source source)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2FCEFB0", Offset = "0x2FCD5B0", VA = "0x182FCEFB0")]
	private void UpdateSources(AreaEmitter.Polygon boundary)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2FCF690", Offset = "0x2FCDC90", VA = "0x182FCF690")]
	private void CreateSource(AreaEmitter.Polygon polygon, int segment)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000020CC File Offset: 0x000002CC
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2FCF930", Offset = "0x2FCDF30", VA = "0x182FCF930")]
	private static float WrapDegrees(float angle)
	{
		return 0f;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2FCF950", Offset = "0x2FCDF50", VA = "0x182FCF950")]
	private void OccludeSegments(AreaEmitter.Source occluder)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2FCFCC0", Offset = "0x2FCE2C0", VA = "0x182FCFCC0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2FCFD50", Offset = "0x2FCE350", VA = "0x182FCFD50")]
	private void OnDisable()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2FCFDE0", Offset = "0x2FCE3E0", VA = "0x182FCFDE0")]
	private void StopAllSources()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2FD0120", Offset = "0x2FCE720", VA = "0x182FD0120")]
	private static void DrawCross(Texture2D texture, Color color)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2FD0300", Offset = "0x2FCE900", VA = "0x182FD0300")]
	private void CreateDebugTextures()
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000020E4 File Offset: 0x000002E4
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2FD12A0", Offset = "0x2FCF8A0", VA = "0x182FD12A0")]
	private bool IsActive()
	{
		return default(bool);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000020FC File Offset: 0x000002FC
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2FD1300", Offset = "0x2FCF900", VA = "0x182FD1300", Slot = "4")]
	public float GetMaximumDistance()
	{
		return 0f;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2FD1620", Offset = "0x2FCFC20", VA = "0x182FD1620", Slot = "5")]
	public void DrawDebug(Vector2 centre, float radius, float maximumDistance)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2FD1D40", Offset = "0x2FD0340", VA = "0x182FD1D40")]
	private void DrawPolygon(AreaEmitter.Polygon polygon, Vector2 centre, float scale, float sqrMaximumDistance, Texture2D audibleTexture, Texture2D occludedTexture, bool drawPoints)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2FD2160", Offset = "0x2FD0760", VA = "0x182FD2160")]
	private void DrawLine(Vector2 start, Vector2 end, Texture2D texture)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2FD2270", Offset = "0x2FD0870", VA = "0x182FD2270")]
	private void DrawLine(Vector2 start, float angle, float length, Texture2D texture)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2FD2410", Offset = "0x2FD0A10", VA = "0x182FD2410")]
	private void DrawTexture(Vector2 position, Texture2D texture)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x26AB660", Offset = "0x26A9C60", VA = "0x1826AB660", Slot = "6")]
	public void EnableEmitter(bool value)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2FD2520", Offset = "0x2FD0B20", VA = "0x182FD2520", Slot = "7")]
	public void DestroyEmitter()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770", Slot = "8")]
	public void Stop()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2E3A120", Offset = "0x2E38720", VA = "0x182E3A120", Slot = "9")]
	public void Play()
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10", Slot = "10")]
	public void SetEventPath(string eventPath)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void UpdateWind(Vector3 direction, float intensity)
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void UpdateWindOnEvent(EventInstance eventInstance)
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2FD2570", Offset = "0x2FD0B70", VA = "0x182FD2570")]
	public AreaEmitter()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("eventPath")]
	[EventRef]
	[SerializeField]
	private string _eventPath;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x28")]
	public int maximumSourceCount;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x2C")]
	public float sourceSpeed;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	public MeshFilter contourArea;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x38")]
	public int contourResolution;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x3C")]
	[Range(1f, 20f)]
	public float simplifyMaximumError;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	public AreaEmitter.Polygon perimeter;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x48")]
	public List<AreaEmitter.Polygon> voids;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AreaEmitter.ShowGizmos _drawGizmos;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x54")]
	private bool _initialized;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x55")]
	private bool _lastActiveDistanceCheck;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x58")]
	private Bounds _bounds;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x70")]
	private float _maxBoundsCenterDistanceXZ;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x78")]
	private EventDescription eventDescription;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x80")]
	private float sqrEventMaximumDistance;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x88")]
	private List<AreaEmitter.Source> sources;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x90")]
	private Comparison<AreaEmitter.Source> compareSources;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x98")]
	private Func<Vector3, Vector2> inverseTransformDelegate;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0xA0")]
	private EventInstance eventInstanceFollowingPlayer;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	private const float SOURCE_WIDTH = 90f;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x0")]
	private static Texture2D lineTexture;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x8")]
	private static Texture2D voidLineTexture;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x10")]
	private static Texture2D occludedLineTexture;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x18")]
	private static Texture2D occludedVoidLineTexture;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x20")]
	private static Texture2D occluderBorderTexture;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x28")]
	private static Texture2D occluderCentreTexture;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x30")]
	private static Texture2D activeAreaTexture;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x38")]
	private static Texture2D sourceTexture;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x40")]
	private static Texture2D pointTexture;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x48")]
	private static Texture2D occludedPointTexture;

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	private enum ShowGizmos
	{
		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		Never,
		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		Selected,
		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		Always
	}

	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public struct Segment
	{
		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 start;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 delta;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 closestPoint;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x24")]
		public float closestT;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x28")]
		public float length;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x2C")]
		public float sqrDistance;
	}

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	private struct Source
	{
		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x0")]
		public AreaEmitter.Polygon polygon;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x8")]
		public int segment;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x10")]
		public EventInstance eventInstance;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 position;
	}

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[Serializable]
	public class Polygon
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2FCD9B0", Offset = "0x2FCBFB0", VA = "0x182FCD9B0")]
		private static Vector3 GetListenerPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2FD27D0", Offset = "0x2FD0DD0", VA = "0x182FD27D0")]
		public Polygon()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2FD2B60", Offset = "0x2FD1160", VA = "0x182FD2B60")]
		public Polygon(AreaEmitter.Polygon other)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2FD2E80", Offset = "0x2FD1480", VA = "0x182FD2E80")]
		public AreaEmitter.Segment GetSegment(int index)
		{
			return default(AreaEmitter.Segment);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2FD2F20", Offset = "0x2FD1520", VA = "0x182FD2F20")]
		public bool IsSegmentActive(int index)
		{
			return default(bool);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2FD2F90", Offset = "0x2FD1590", VA = "0x182FD2F90")]
		public bool IsSegmentOccluded(int index)
		{
			return default(bool);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2FD3000", Offset = "0x2FD1600", VA = "0x182FD3000")]
		public bool HasActiveSegments()
		{
			return default(bool);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2FD3050", Offset = "0x2FD1650", VA = "0x182FD3050")]
		public void Start(float maximumDistance, Func<Vector2, Vector3> TransformPoint)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2FD3210", Offset = "0x2FD1810", VA = "0x182FD3210")]
		private void CalculateBounds()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2FD3460", Offset = "0x2FD1A60", VA = "0x182FD3460")]
		private void CreateGrid()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2FD35F0", Offset = "0x2FD1BF0", VA = "0x182FD35F0")]
		private void CalculateSegments(Func<Vector2, Vector3> TransformPoint)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2FD3920", Offset = "0x2FD1F20", VA = "0x182FD3920")]
		private void AddSegmentToGrid(Vector2 start, Vector2 end, int segmentIndex)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2FD3C20", Offset = "0x2FD2220", VA = "0x182FD3C20")]
		private AreaEmitter.Polygon.GridPosition CalculateGridPosition(Vector2 point)
		{
			return default(AreaEmitter.Polygon.GridPosition);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2FD3D20", Offset = "0x2FD2320", VA = "0x182FD3D20")]
		public bool ContainsPoint(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2FD3D50", Offset = "0x2FD2350", VA = "0x182FD3D50")]
		public void ForEachSegment(Action<Vector2, Vector2> action)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2FD3F10", Offset = "0x2FD2510", VA = "0x182FD3F10")]
		public void ForEachSegment(Action<AreaEmitter.Segment, bool> action)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2FD4040", Offset = "0x2FD2640", VA = "0x182FD4040")]
		public int WrapSegmentIndex(int index)
		{
			return 0;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2FD4090", Offset = "0x2FD2690", VA = "0x182FD4090")]
		public void UpdateSegments(Func<Vector3, Vector2> InverseTransformPoint)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2FD41F0", Offset = "0x2FD27F0", VA = "0x182FD41F0")]
		private void UpdateSegmentsWithGrid(Func<Vector3, Vector2> InverseTransformPoint)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2FD4480", Offset = "0x2FD2A80", VA = "0x182FD4480")]
		private void UpdateSegmentsWithoutGrid()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2FD4900", Offset = "0x2FD2F00", VA = "0x182FD4900")]
		private void UpdateSegment(int index)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2FD4C80", Offset = "0x2FD3280", VA = "0x182FD4C80")]
		public int FindClosestAudibleSegment()
		{
			return 0;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2FD4E00", Offset = "0x2FD3400", VA = "0x182FD4E00")]
		public int DescendToClosestSegment(int segmentIndex)
		{
			return 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2FD5100", Offset = "0x2FD3700", VA = "0x182FD5100")]
		public int AscendToAudibleSegment(int segmentIndex)
		{
			return 0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2FD5330", Offset = "0x2FD3930", VA = "0x182FD5330")]
		public void OccludeSegments(float sqrOccluderDistance, Vector3 rightOfLeft, Vector3 leftOfRight)
		{
		}

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x10")]
		public List<Vector2> points;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x18")]
		private List<AreaEmitter.Segment> segments;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x20")]
		private List<AreaEmitter.Polygon.SegmentFlags> segmentFlags;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x28")]
		private List<int> activeSegments;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x30")]
		private Rect bounds;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x40")]
		private List<int>[,] grid;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 gridSize;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x50")]
		private float sqrMaximumDistance;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x54")]
		private int audibleSegmentCount;

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		[Flags]
		private enum SegmentFlags
		{
			// Token: 0x04000037 RID: 55
			[Token(Token = "0x4000037")]
			None = 0,
			// Token: 0x04000038 RID: 56
			[Token(Token = "0x4000038")]
			Occluded = 1,
			// Token: 0x04000039 RID: 57
			[Token(Token = "0x4000039")]
			Active = 2
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		private struct GridPosition
		{
			// Token: 0x0400003A RID: 58
			[Token(Token = "0x400003A")]
			[FieldOffset(Offset = "0x0")]
			public int row;

			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x4")]
			public int column;
		}
	}
}
