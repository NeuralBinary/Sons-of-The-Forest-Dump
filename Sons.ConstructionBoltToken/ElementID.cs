using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.ConstructionBoltToken
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public struct ElementID
	{
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x0")]
		public ushort ProfileID;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x4")]
		public Vector3 LocalPosition;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 LocalEulerAngles;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x1C")]
		public float LengthScale;
	}
}
