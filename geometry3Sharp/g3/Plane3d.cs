using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	public struct Plane3d
	{
		// Token: 0x06000FD2 RID: 4050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x1E3C3D0", Offset = "0x1E3A9D0", VA = "0x181E3C3D0")]
		public Plane3d(Vector3d normal, double constant)
		{
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x1E3C3F0", Offset = "0x1E3A9F0", VA = "0x181E3C3F0")]
		public Plane3d(Vector3d normal, Vector3d point)
		{
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x1E3C440", Offset = "0x1E3AA40", VA = "0x181E3C440")]
		public Plane3d(Vector3d p0, Vector3d p1, Vector3d p2)
		{
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0000BC3C File Offset: 0x00009E3C
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x1E3C590", Offset = "0x1E3AB90", VA = "0x181E3C590")]
		public double DistanceTo(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0000BC54 File Offset: 0x00009E54
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x1E3C5D0", Offset = "0x1E3ABD0", VA = "0x181E3C5D0")]
		public int WhichSide(Vector3d p)
		{
			return 0;
		}

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d Normal;

		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0x18")]
		public double Constant;
	}
}
