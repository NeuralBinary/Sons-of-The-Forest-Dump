using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	public class VailPistol : VailProp
	{
		// Token: 0x0600082B RID: 2091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2655880", Offset = "0x2653E80", VA = "0x182655880")]
		public VailPistol()
		{
		}

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _shootTransform;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _delay;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x40")]
		private List<Vector3> _positions;
	}
}
