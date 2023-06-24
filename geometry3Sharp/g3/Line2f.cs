using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	public struct Line2f
	{
		// Token: 0x06000EE3 RID: 3811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0xF9DB00", Offset = "0xF9C100", VA = "0x180F9DB00")]
		public Line2f(Vector2f origin, Vector2f direction)
		{
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0000AF94 File Offset: 0x00009194
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x1E304E0", Offset = "0x1E2EAE0", VA = "0x181E304E0")]
		public Vector2f PointAt(float d)
		{
			return default(Vector2f);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0000AFAC File Offset: 0x000091AC
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x1E30580", Offset = "0x1E2EB80", VA = "0x181E30580")]
		public float Project(Vector2f p)
		{
			return 0f;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0000AFC4 File Offset: 0x000091C4
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x1E30600", Offset = "0x1E2EC00", VA = "0x181E30600")]
		public float DistanceSquared(Vector2f p)
		{
			return 0f;
		}

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0x0")]
		public Vector2f Origin;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0x8")]
		public Vector2f Direction;
	}
}
