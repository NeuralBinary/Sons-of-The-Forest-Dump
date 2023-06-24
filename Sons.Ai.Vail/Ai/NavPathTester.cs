using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[AddComponentMenu("Sons/Utilities/Nav Path Tester")]
	public class NavPathTester : MonoBehaviour
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2AF0C30", Offset = "0x2AEF230", VA = "0x182AF0C30")]
		private void ResetPathQuery()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2AF0CF0", Offset = "0x2AEF2F0", VA = "0x182AF0CF0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2AF0E40", Offset = "0x2AEF440", VA = "0x182AF0E40")]
		private void Update()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2AF1520", Offset = "0x2AEFB20", VA = "0x182AF1520")]
		private void FindPath(Vector3 start, Vector3 end)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2AF16F0", Offset = "0x2AEFCF0", VA = "0x182AF16F0")]
		private void OnNavMeshPathFound(Path result)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2AF1930", Offset = "0x2AEFF30", VA = "0x182AF1930")]
		private void TestLocalAvoidance()
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2AF22B0", Offset = "0x2AF08B0", VA = "0x182AF22B0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2AF2980", Offset = "0x2AF0F80", VA = "0x182AF2980")]
		public NavPathTester()
		{
		}

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x20")]
		private bool _success;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 _navMeshPosition;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x30")]
		private bool _waitingForPath;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x34")]
		private float _findPathStartTime;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x38")]
		private float _nextPathUpdateTime;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x40")]
		private Path _activeNavMeshPath;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Seeker _seeker;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _pathStart;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _pathTarget;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _snapToTerrain;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x68")]
		private List<Vector3> _pathNodes;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x70")]
		private List<Vector3> _tempPath;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _testLocalAvoidance;
	}
}
