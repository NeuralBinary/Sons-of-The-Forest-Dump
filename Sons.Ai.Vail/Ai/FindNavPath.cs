using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[AddComponentMenu("Sons/Utilities/FindNavPath")]
	public class FindNavPath : MonoBehaviour
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2AEFB10", Offset = "0x2AEE110", VA = "0x182AEFB10")]
		private void OnValidate()
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x1700000B")]
		public bool IsWaitingForPath
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2AEFC40", Offset = "0x2AEE240", VA = "0x182AEFC40")]
		public bool StartFindPath(Vector3 start, Vector3 end, int graphMask, Action<Path> onPathFound)
		{
			return default(bool);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2AEFE70", Offset = "0x2AEE470", VA = "0x182AEFE70")]
		private void OnNavMeshPathFound(Path result)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2AEFE90", Offset = "0x2AEE490", VA = "0x182AEFE90")]
		private void TestFindPath()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2AF0140", Offset = "0x2AEE740", VA = "0x182AF0140")]
		private void OnTestPathFound(Path result)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2AF0370", Offset = "0x2AEE970", VA = "0x182AF0370")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2AF0B50", Offset = "0x2AEF150", VA = "0x182AF0B50")]
		public FindNavPath()
		{
		}

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x20")]
		private bool _success;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 _navMeshPosition;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x30")]
		private bool _waitingForPath;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x34")]
		private float _findPathStartTime;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x38")]
		private Path _activeNavMeshPath;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Seeker _seeker;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _testStart;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _testTarget;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x58")]
		private List<Vector3> _pathNodes;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x60")]
		private Action<Path> _onPathFound;
	}
}
