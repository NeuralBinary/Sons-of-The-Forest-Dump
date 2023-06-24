using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	[AddComponentMenu("Sons/Ai/Vail World Paths")]
	public class VailWorldPaths : MonoBehaviour
	{
		// Token: 0x0600087C RID: 2172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x2B6BE60", Offset = "0x2B6A460", VA = "0x182B6BE60")]
		private void AddPathNode(Vector3 pointPos, bool isEndPoint)
		{
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2B6BF40", Offset = "0x2B6A540", VA = "0x182B6BF40")]
		private void FinalizeBuildPath()
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void UpdateFromJson()
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void UpdateAndApplyPathModifiers()
		{
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x2B6C380", Offset = "0x2B6A980", VA = "0x182B6C380")]
		private void AddPointsToGrid()
		{
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x2B6C6B0", Offset = "0x2B6ACB0", VA = "0x182B6C6B0")]
		private void CheckConnection(VailWorldPaths.PathPoint checkNode)
		{
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x2B6CAD0", Offset = "0x2B6B0D0", VA = "0x182B6CAD0")]
		private void Start()
		{
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x2B6CAE0", Offset = "0x2B6B0E0", VA = "0x182B6CAE0")]
		public VailWorldPaths.PathPoint GetClosestPathPoint(Vector3 pos, float maxDistance = 30f)
		{
			return null;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x2B6CB60", Offset = "0x2B6B160", VA = "0x182B6CB60")]
		public void GetClosestPath(Vector3 pos, ref List<Vector3> path, int count)
		{
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x2B6CD60", Offset = "0x2B6B360", VA = "0x182B6CD60")]
		public void AddPathPoints(ref List<Vector3> actorPath, VailWorldPaths.WorldPathMove pathMove)
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x2B6CF70", Offset = "0x2B6B570", VA = "0x182B6CF70")]
		public bool GetUsePath(Vector3 start, Vector3 end, ref VailWorldPaths.WorldPathMove ret)
		{
			return default(bool);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x2B6D630", Offset = "0x2B6BC30", VA = "0x182B6D630")]
		private bool TestDrawPath(Vector3 start, Vector3 end)
		{
			return default(bool);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x2B6D9F0", Offset = "0x2B6BFF0", VA = "0x182B6D9F0")]
		private void DrawPathGizmos()
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x2B6E880", Offset = "0x2B6CE80", VA = "0x182B6E880")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x2B6E890", Offset = "0x2B6CE90", VA = "0x182B6E890")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x2B6E8A0", Offset = "0x2B6CEA0", VA = "0x182B6E8A0")]
		public VailWorldPaths()
		{
		}

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x20")]
		private VailLevelGrid _worldPathGrid;

		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _jsonPath;

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<VailWorldPaths.PathPoint> _pathNodes;

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<VailWorldPaths.PathSection> _pathSections;

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _connectMaxDistance;

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _maxMoveToPathDist;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _minDirectDistance;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _minDistOnPath;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _alwaysDrawGizmos;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _drawPointRadius;

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _testPosition;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _testDestination;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _snapTestToTerrain;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x70")]
		private VailWorldPaths.WorldPathMove _worldPathMove;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x78")]
		private List<VailWorldPaths.PathPoint> _nearPoints;

		// Token: 0x020000DF RID: 223
		[Token(Token = "0x20000DF")]
		[Serializable]
		public class PathPoint : IVailGridObject
		{
			// Token: 0x0600088C RID: 2188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x2B6EB10", Offset = "0x2B6D110", VA = "0x182B6EB10")]
			public PathPoint(Vector3 pos, bool isEnd, int idx, int sectionIdx)
			{
			}

			// Token: 0x0600088D RID: 2189 RVA: 0x00005E08 File Offset: 0x00004008
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x1766460", Offset = "0x1764A60", VA = "0x181766460", Slot = "4")]
			public Vector3 Position()
			{
				return default(Vector3);
			}

			// Token: 0x0600088E RID: 2190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x2B6EB30", Offset = "0x2B6D130", VA = "0x182B6EB30")]
			public void SetIndices(int point, int section)
			{
			}

			// Token: 0x04000706 RID: 1798
			[Token(Token = "0x4000706")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 _position;

			// Token: 0x04000707 RID: 1799
			[Token(Token = "0x4000707")]
			[FieldOffset(Offset = "0x1C")]
			public bool _isEnd;

			// Token: 0x04000708 RID: 1800
			[Token(Token = "0x4000708")]
			[FieldOffset(Offset = "0x20")]
			public int _idx;

			// Token: 0x04000709 RID: 1801
			[Token(Token = "0x4000709")]
			[FieldOffset(Offset = "0x24")]
			public int _section;
		}

		// Token: 0x020000E0 RID: 224
		[Token(Token = "0x20000E0")]
		[Serializable]
		public class PathSection
		{
			// Token: 0x0600088F RID: 2191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x2B6EB40", Offset = "0x2B6D140", VA = "0x182B6EB40")]
			public PathSection(int start, int end)
			{
			}

			// Token: 0x0400070A RID: 1802
			[Token(Token = "0x400070A")]
			[FieldOffset(Offset = "0x10")]
			public int _startIdx;

			// Token: 0x0400070B RID: 1803
			[Token(Token = "0x400070B")]
			[FieldOffset(Offset = "0x14")]
			public int _endIdx;

			// Token: 0x0400070C RID: 1804
			[Token(Token = "0x400070C")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public List<VailWorldPaths.PathConnection> _connections;
		}

		// Token: 0x020000E1 RID: 225
		[Token(Token = "0x20000E1")]
		[Serializable]
		public class PathConnection
		{
			// Token: 0x06000890 RID: 2192 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PathConnection()
			{
			}

			// Token: 0x0400070D RID: 1805
			[Token(Token = "0x400070D")]
			[FieldOffset(Offset = "0x10")]
			public int _pointIdx;

			// Token: 0x0400070E RID: 1806
			[Token(Token = "0x400070E")]
			[FieldOffset(Offset = "0x14")]
			public int _toSectionIdx;

			// Token: 0x0400070F RID: 1807
			[Token(Token = "0x400070F")]
			[FieldOffset(Offset = "0x18")]
			public int _toPointIdx;
		}

		// Token: 0x020000E2 RID: 226
		[Token(Token = "0x20000E2")]
		[Serializable]
		private struct StreamInfo
		{
			// Token: 0x04000710 RID: 1808
			[Token(Token = "0x4000710")]
			[FieldOffset(Offset = "0x0")]
			public int end;
		}

		// Token: 0x020000E3 RID: 227
		[Token(Token = "0x20000E3")]
		private class HoudiniWorldPathData
		{
			// Token: 0x06000891 RID: 2193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public HoudiniWorldPathData()
			{
			}

			// Token: 0x04000711 RID: 1809
			[Token(Token = "0x4000711")]
			[FieldOffset(Offset = "0x10")]
			public List<Vector3> positions;

			// Token: 0x04000712 RID: 1810
			[Token(Token = "0x4000712")]
			[FieldOffset(Offset = "0x18")]
			public List<VailWorldPaths.StreamInfo> streamInfo;
		}

		// Token: 0x020000E4 RID: 228
		[Token(Token = "0x20000E4")]
		public class WorldPathMoveSegment
		{
			// Token: 0x06000892 RID: 2194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x2B6EC10", Offset = "0x2B6D210", VA = "0x182B6EC10")]
			public WorldPathMoveSegment(int startIdx, int endIdx)
			{
			}

			// Token: 0x04000713 RID: 1811
			[Token(Token = "0x4000713")]
			[FieldOffset(Offset = "0x10")]
			public int StartIdx;

			// Token: 0x04000714 RID: 1812
			[Token(Token = "0x4000714")]
			[FieldOffset(Offset = "0x14")]
			public int EndIdx;

			// Token: 0x04000715 RID: 1813
			[Token(Token = "0x4000715")]
			[FieldOffset(Offset = "0x18")]
			public int Dir;
		}

		// Token: 0x020000E5 RID: 229
		[Token(Token = "0x20000E5")]
		public class WorldPathMove
		{
			// Token: 0x06000893 RID: 2195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x2B6EC30", Offset = "0x2B6D230", VA = "0x182B6EC30")]
			public void Clear()
			{
			}

			// Token: 0x06000894 RID: 2196 RVA: 0x00005E20 File Offset: 0x00004020
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x2B6EC90", Offset = "0x2B6D290", VA = "0x182B6EC90")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x06000895 RID: 2197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x2B6ECE0", Offset = "0x2B6D2E0", VA = "0x182B6ECE0")]
			public WorldPathMove()
			{
			}

			// Token: 0x04000716 RID: 1814
			[Token(Token = "0x4000716")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 StartPos;

			// Token: 0x04000717 RID: 1815
			[Token(Token = "0x4000717")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 EndPos;

			// Token: 0x04000718 RID: 1816
			[Token(Token = "0x4000718")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 PathStartPos;

			// Token: 0x04000719 RID: 1817
			[Token(Token = "0x4000719")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 PathEndPos;

			// Token: 0x0400071A RID: 1818
			[Token(Token = "0x400071A")]
			[FieldOffset(Offset = "0x40")]
			public List<VailWorldPaths.WorldPathMoveSegment> MoveSegments;
		}
	}
}
