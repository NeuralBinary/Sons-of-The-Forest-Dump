using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crest
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[Serializable]
	public class FloaterForcePoints
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x9D7D40", Offset = "0x9D6340", VA = "0x1809D7D40")]
		public FloaterForcePoints()
		{
		}

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("_factor")]
		public float _weight;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 _offsetPosition;
	}
}
