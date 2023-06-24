using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation.Examples
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class PathSpawner : MonoBehaviour
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2837350", Offset = "0x2835950", VA = "0x182837350")]
		private void Start()
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PathSpawner()
		{
		}

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x20")]
		public PathCreator pathPrefab;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x28")]
		public PathFollower followerPrefab;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x30")]
		public Transform[] spawnPoints;
	}
}
