using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001EB RID: 491
	[Token(Token = "0x20001EB")]
	public struct Plane3f
	{
		// Token: 0x06000FD7 RID: 4055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0xFA17B0", Offset = "0xF9FDB0", VA = "0x180FA17B0")]
		public Plane3f(Vector3f normal, float constant)
		{
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x1E3C620", Offset = "0x1E3AC20", VA = "0x181E3C620")]
		public Plane3f(Vector3f normal, Vector3f point)
		{
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x1E3C670", Offset = "0x1E3AC70", VA = "0x181E3C670")]
		public Plane3f(Vector3f p0, Vector3f p1, Vector3f p2)
		{
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0000BC6C File Offset: 0x00009E6C
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x1E3C8C0", Offset = "0x1E3AEC0", VA = "0x181E3C8C0")]
		public float DistanceTo(Vector3f p)
		{
			return 0f;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0000BC84 File Offset: 0x00009E84
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x1E3C900", Offset = "0x1E3AF00", VA = "0x181E3C900")]
		public int WhichSide(Vector3f p)
		{
			return 0;
		}

		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x0")]
		public Vector3f Normal;

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0xC")]
		public float Constant;
	}
}
