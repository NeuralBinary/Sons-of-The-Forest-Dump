using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Save
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[Serializable]
	public struct Vector3IntS
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x65F570", Offset = "0x65DB70", VA = "0x18065F570")]
		public Vector3IntS(int x, int y, int z)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x600006C")]
		[Address(RVA = "0xA60D20", Offset = "0xA5F320", VA = "0x180A60D20")]
		public static implicit operator Vector3Int(Vector3IntS v)
		{
			return default(Vector3Int);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x312E6E0", Offset = "0x312CCE0", VA = "0x18312E6E0")]
		public static implicit operator Vector3IntS(Vector3Int v)
		{
			return default(Vector3IntS);
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x4")]
		public int y;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x8")]
		public int z;
	}
}
