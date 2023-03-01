using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	public struct LocalizedHitData
	{
		// Token: 0x060017C4 RID: 6084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x2CB4670", Offset = "0x2CB3670", VA = "0x182CB4670")]
		public LocalizedHitData(Vector3 position, float damage)
		{
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x2CB4690", Offset = "0x2CB3690", VA = "0x182CB4690")]
		public LocalizedHitData(Vector3 position, float damage, float distortRatio)
		{
		}

		// Token: 0x040016CF RID: 5839
		[Token(Token = "0x40016CF")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 _position;

		// Token: 0x040016D0 RID: 5840
		[Token(Token = "0x40016D0")]
		[FieldOffset(Offset = "0xC")]
		public float _damage;

		// Token: 0x040016D1 RID: 5841
		[Token(Token = "0x40016D1")]
		[FieldOffset(Offset = "0x10")]
		public float _distortRatio;
	}
}
