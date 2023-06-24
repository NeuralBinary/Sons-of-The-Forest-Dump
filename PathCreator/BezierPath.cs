using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[Serializable]
	public class BezierPath
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		public event Action OnModified
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x28260A0", Offset = "0x28246A0", VA = "0x1828260A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2826190", Offset = "0x2824790", VA = "0x182826190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2826280", Offset = "0x2824880", VA = "0x182826280")]
		public BezierPath(bool isClosed = false, PathSpace space = PathSpace.xyz)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2826960", Offset = "0x2824F60", VA = "0x182826960")]
		public BezierPath(IEnumerable<Vector3> points, bool isClosed = false, PathSpace space = PathSpace.xyz)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2826F40", Offset = "0x2825540", VA = "0x182826F40")]
		public BezierPath(IEnumerable<Vector2> transforms, bool isClosed = false, PathSpace space = PathSpace.xy)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x28270D0", Offset = "0x28256D0", VA = "0x1828270D0")]
		public BezierPath(IEnumerable<Transform> transforms, bool isClosed = false, PathSpace space = PathSpace.xy)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2827260", Offset = "0x2825860", VA = "0x182827260")]
		public BezierPath(IEnumerable<Vector2> points, PathSpace space = PathSpace.xyz, bool isClosed = false)
		{
		}

		// Token: 0x17000001 RID: 1
		[Token(Token = "0x17000001")]
		public Vector3 this[int i]
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x28273F0", Offset = "0x28259F0", VA = "0x1828273F0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x28273F0", Offset = "0x28259F0", VA = "0x1828273F0")]
		public Vector3 GetPoint(int i)
		{
			return default(Vector3);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2827480", Offset = "0x2825A80", VA = "0x182827480")]
		public void SetPoint(int i, Vector3 localPosition, bool suppressPathModifiedEvent = false)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x17000002")]
		public int NumPoints
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2827540", Offset = "0x2825B40", VA = "0x182827540")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x17000003")]
		public int NumAnchorPoints
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2827580", Offset = "0x2825B80", VA = "0x182827580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x17000004")]
		public int NumSegments
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x28275F0", Offset = "0x2825BF0", VA = "0x1828275F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020E0 File Offset: 0x000002E0
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000005")]
		public PathSpace Space
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			get
			{
				return PathSpace.xyz;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2827640", Offset = "0x2825C40", VA = "0x182827640")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020F8 File Offset: 0x000002F8
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000006")]
		public bool IsClosed
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2827660", Offset = "0x2825C60", VA = "0x182827660")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002110 File Offset: 0x00000310
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000007")]
		public BezierPath.ControlMode ControlPointMode
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return BezierPath.ControlMode.Aligned;
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2827670", Offset = "0x2825C70", VA = "0x182827670")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002128 File Offset: 0x00000328
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000008")]
		public float AutoControlLength
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x28276B0", Offset = "0x2825CB0", VA = "0x1828276B0")]
			set
			{
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2827700", Offset = "0x2825D00", VA = "0x182827700")]
		public void SnapAnchorPointsToTerrain(Vector3 parentPosition)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2827AB0", Offset = "0x28260B0", VA = "0x182827AB0")]
		public void SnapAnchorPointsXAxis(Vector3 parentPosition)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2827BD0", Offset = "0x28261D0", VA = "0x182827BD0")]
		public void AddSegmentToEnd(Vector3 anchorPos)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x28282A0", Offset = "0x28268A0", VA = "0x1828282A0")]
		public void AddSegmentToStart(Vector3 anchorPos)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2828740", Offset = "0x2826D40", VA = "0x182828740")]
		public void SplitSegment(Vector3 anchorPos, int segmentIndex, float splitTime)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2828E60", Offset = "0x2827460", VA = "0x182828E60")]
		public void DeleteSegment(int anchorIndex)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2829190", Offset = "0x2827790", VA = "0x182829190")]
		public Vector3[] GetPointsInSegment(int segmentIndex)
		{
			return null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2829450", Offset = "0x2827A50", VA = "0x182829450")]
		public void MovePoint(int i, Vector3 pointPos, bool suppressPathModifiedEvent = false)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2829B80", Offset = "0x2828180", VA = "0x182829B80")]
		public Bounds CalculateBoundsWithTransform(Transform transform)
		{
			return default(Bounds);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000215C File Offset: 0x0000035C
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000009")]
		public bool FlipNormals
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x998F00", Offset = "0x997500", VA = "0x180998F00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x282A330", Offset = "0x2828930", VA = "0x18282A330")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002174 File Offset: 0x00000374
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000A")]
		public float GlobalNormalsAngle
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x282A360", Offset = "0x2828960", VA = "0x18282A360")]
			set
			{
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x282A390", Offset = "0x2828990", VA = "0x18282A390")]
		public float GetAnchorNormalAngle(int anchorIndex)
		{
			return 0f;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x282A410", Offset = "0x2828A10", VA = "0x18282A410")]
		public void SetAnchorNormalAngle(int anchorIndex, float angle)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x282A4F0", Offset = "0x2828AF0", VA = "0x18282A4F0")]
		public void ResetNormalAngles()
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x1700000B")]
		public Bounds PathBounds
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x282A5B0", Offset = "0x2828BB0", VA = "0x18282A5B0")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x282A5F0", Offset = "0x2828BF0", VA = "0x18282A5F0")]
		private void UpdateBounds()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x282ACC0", Offset = "0x28292C0", VA = "0x18282ACC0")]
		private void AutoSetAllAffectedControlPoints(int updatedAnchorIndex)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x282AD80", Offset = "0x2829380", VA = "0x18282AD80")]
		private void AutoSetAllControlPoints()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x282AE10", Offset = "0x2829410", VA = "0x18282AE10")]
		private void AutoSetAnchorControlPoints(int anchorIndex)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x282B410", Offset = "0x2829A10", VA = "0x18282B410")]
		private void AutoSetStartAndEndControls()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x282BE90", Offset = "0x282A490", VA = "0x18282BE90")]
		private void UpdateToNewPathSpace(PathSpace previousSpace)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x282C460", Offset = "0x282AA60", VA = "0x18282C460")]
		private void UpdateClosedState()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x282CC00", Offset = "0x282B200", VA = "0x18282CC00")]
		private int LoopIndex(int i)
		{
			return 0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x282CC50", Offset = "0x282B250", VA = "0x18282CC50")]
		public void NotifyPathModified()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private List<Vector3> points;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private bool isClosed;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private PathSpace space;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private BezierPath.ControlMode controlMode;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[HideInInspector]
		private float autoControlLength;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private bool boundsUpToDate;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x34")]
		[HideInInspector]
		[SerializeField]
		private Bounds bounds;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		private List<float> perAnchorNormalsAngle;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private float globalNormalsAngle;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[HideInInspector]
		private bool flipNormals;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		public enum ControlMode
		{
			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			Aligned,
			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			Mirrored,
			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			Free,
			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			Automatic
		}
	}
}
