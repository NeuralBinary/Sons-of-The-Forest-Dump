using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	public struct Line3f
	{
		// Token: 0x06000EEE RID: 3822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0xFA1160", Offset = "0xF9F760", VA = "0x180FA1160")]
		public Line3f(Vector3f origin, Vector3f direction)
		{
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0000B06C File Offset: 0x0000926C
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x1E30C20", Offset = "0x1E2F220", VA = "0x181E30C20")]
		public Vector3f PointAt(float d)
		{
			return default(Vector3f);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0000B084 File Offset: 0x00009284
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x1E30D00", Offset = "0x1E2F300", VA = "0x181E30D00")]
		public float Project(Vector3f p)
		{
			return 0f;
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0000B09C File Offset: 0x0000929C
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x1E30DB0", Offset = "0x1E2F3B0", VA = "0x181E30DB0")]
		public float DistanceSquared(Vector3f p)
		{
			return 0f;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0000B0B4 File Offset: 0x000092B4
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x1E30EF0", Offset = "0x1E2F4F0", VA = "0x181E30EF0")]
		public Vector3f ClosestPoint(Vector3f p)
		{
			return default(Vector3f);
		}

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x0")]
		public Vector3f Origin;

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0xC")]
		public Vector3f Direction;
	}
}
