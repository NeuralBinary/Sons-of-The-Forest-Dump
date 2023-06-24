using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Save
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Serializable]
	public struct Vector4S
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1E1F030", Offset = "0x1E1D630", VA = "0x181E1F030")]
		public Vector4S(float x, float y, float z, float w)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000066")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Quaternion(Vector4S v)
		{
			return default(Quaternion);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000067")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Vector4S(Quaternion q)
		{
			return default(Vector4S);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000068")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Vector4S(Vector4 v)
		{
			return default(Vector4S);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000069")]
		[Address(RVA = "0xAB4B70", Offset = "0xAB3170", VA = "0x180AB4B70")]
		public static implicit operator Vector4S(Color c)
		{
			return default(Vector4S);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x600006A")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public Vector4 ToVector4()
		{
			return default(Vector4);
		}

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xC")]
		public float w;
	}
}
