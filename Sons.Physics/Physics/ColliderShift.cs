using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class ColliderShift : MonoBehaviour
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x3101CB0", Offset = "0x31002B0", VA = "0x183101CB0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x3102270", Offset = "0x3100870", VA = "0x183102270")]
		private void InitializePositions()
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ColliderShift()
		{
		}

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Collider> _targets;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _amount;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector3> _basePositions;
	}
}
