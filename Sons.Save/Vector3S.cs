using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Save
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[Serializable]
	public struct Vector3S
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x5B2550", Offset = "0x5B0B50", VA = "0x1805B2550")]
		public Vector3S(float x, float y, float z)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000063")]
		[Address(RVA = "0xA60D20", Offset = "0xA5F320", VA = "0x180A60D20")]
		public static implicit operator Vector3(Vector3S v)
		{
			return default(Vector3);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000064")]
		[Address(RVA = "0xA60D20", Offset = "0xA5F320", VA = "0x180A60D20")]
		public static implicit operator Vector3S(Vector3 v)
		{
			return default(Vector3S);
		}

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x8")]
		public float z;
	}
}
