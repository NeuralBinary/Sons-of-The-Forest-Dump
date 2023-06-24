using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.EasyMeshCombiner
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public class EnviromentMovement : MonoBehaviour
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x60E390", Offset = "0x60C990", VA = "0x18060E390")]
		private void Start()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x60E480", Offset = "0x60CA80", VA = "0x18060E480")]
		private void Update()
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x60E860", Offset = "0x60CE60", VA = "0x18060E860")]
		public EnviromentMovement()
		{
		}

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 nextPosition;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x30")]
		private Transform thisTransform;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 pos1;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 pos2;
	}
}
