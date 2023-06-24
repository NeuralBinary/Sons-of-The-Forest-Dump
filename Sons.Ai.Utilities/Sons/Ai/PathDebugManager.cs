using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[AddComponentMenu("Sons/Ai/Path Debug Manager")]
	public class PathDebugManager : SingletonBehaviour<PathDebugManager>
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000254C File Offset: 0x0000074C
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public static bool DebugStructures
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x2A97A50", Offset = "0x2A96050", VA = "0x182A97A50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x2A97A90", Offset = "0x2A96090", VA = "0x182A97A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2A97AD0", Offset = "0x2A960D0", VA = "0x182A97AD0")]
		public static void SetDebugStructures(bool value)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2A97B10", Offset = "0x2A96110", VA = "0x182A97B10")]
		public static void ResetPaths()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2A97D00", Offset = "0x2A96300", VA = "0x182A97D00")]
		public static void StartPath(int actorUniqueId)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2A97DA0", Offset = "0x2A963A0", VA = "0x182A97DA0")]
		public static void EndPath()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2A97F40", Offset = "0x2A96540", VA = "0x182A97F40")]
		public static void AddPathPoint(Vector3 position, bool localAvoid, bool worldPath)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2A97FF0", Offset = "0x2A965F0", VA = "0x182A97FF0")]
		private void ResetInternal()
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2A98190", Offset = "0x2A96790", VA = "0x182A98190")]
		private void StartPathInternal(int actorUniqueId)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000246E File Offset: 0x0000066E
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2A981F0", Offset = "0x2A967F0", VA = "0x182A981F0")]
		private GameObject GetPoolObject(int count, ref List<GameObject> pool, GameObject prefab)
		{
			return null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2A98330", Offset = "0x2A96930", VA = "0x182A98330")]
		private void EndPathInternal()
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000246E File Offset: 0x0000066E
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2A98480", Offset = "0x2A96A80", VA = "0x182A98480")]
		private Material GetPointMaterial(PathDebugManager.WaypointType type)
		{
			return null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2A984A0", Offset = "0x2A96AA0", VA = "0x182A984A0")]
		private void AddPathPointInternal(Vector3 position, PathDebugManager.WaypointType pointType)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2A987E0", Offset = "0x2A96DE0", VA = "0x182A987E0")]
		private void Update()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2A98AC0", Offset = "0x2A970C0", VA = "0x182A98AC0")]
		public void ShowNavMesh(bool show)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x6124C0", Offset = "0x610AC0", VA = "0x1806124C0")]
		public float GetNavMeshOffsetY()
		{
			return 0f;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x6124D0", Offset = "0x610AD0", VA = "0x1806124D0")]
		public void SetNavMeshOffsetY(float newOffset)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2A98B90", Offset = "0x2A97190", VA = "0x182A98B90")]
		public static void OnNavMeshChanged()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000246E File Offset: 0x0000066E
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2A98C40", Offset = "0x2A97240", VA = "0x182A98C40")]
		private NavmeshBase GetNearestGraph()
		{
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2A98DE0", Offset = "0x2A973E0", VA = "0x182A98DE0")]
		private void ConvertNavMeshToMesh()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2A98FD0", Offset = "0x2A975D0", VA = "0x182A98FD0")]
		private static void AddVertices(Vector3[] vertices, ref int index, Int3 v0, Int3 v1, Int3 v2, Vector3 offset)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000246E File Offset: 0x0000066E
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2A991F0", Offset = "0x2A977F0", VA = "0x182A991F0")]
		private static Mesh CreateMesh(Vector3[] vertices, int vertCount)
		{
			return null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2A99440", Offset = "0x2A97A40", VA = "0x182A99440")]
		private void ConvertGraphToMesh(NavmeshBase navMesh)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2A99A20", Offset = "0x2A98020", VA = "0x182A99A20")]
		public PathDebugManager()
		{
		}

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _waypointPrefab;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material _defaultMaterial;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Material _localAvoidMaterial;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Material _worldPathMaterial;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _lineRendererPrefab;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _yOffset;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _pointScale;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x58")]
		private List<GameObject> _wayPointPool;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x60")]
		private List<GameObject> _linePool;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MeshRenderer[] _graphRenderers;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MeshFilter _graphMeshFilter;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MeshFilter _graphTagMeshFilter;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _graphOffsetY;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x84")]
		private bool _debugLog;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x88")]
		private NavmeshBase _nearestGraph;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x90")]
		private int _waypointCount;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x94")]
		private int _lineCount;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x98")]
		private int _currentActorUniqueId;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xA0")]
		private readonly List<Vector3> _pathPositions;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xA8")]
		private bool _showNavGraph;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xAC")]
		private Int2 _navGraphCoords;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xB4")]
		private int _updateNavGraphFrame;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		public enum WaypointType
		{
			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			Normal,
			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			LocalAvoid,
			// Token: 0x04000051 RID: 81
			[Token(Token = "0x4000051")]
			WorldPath
		}
	}
}
