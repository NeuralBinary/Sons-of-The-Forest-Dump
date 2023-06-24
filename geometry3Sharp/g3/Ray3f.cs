using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x020001F7 RID: 503
	[Token(Token = "0x20001F7")]
	public struct Ray3f
	{
		// Token: 0x06001079 RID: 4217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001079")]
		[Address(RVA = "0x1E45040", Offset = "0x1E43640", VA = "0x181E45040")]
		public Ray3f(Vector3f origin, Vector3f direction, bool bIsNormalized = false)
		{
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0000C704 File Offset: 0x0000A904
		[Token(Token = "0x600107A")]
		[Address(RVA = "0x1E450A0", Offset = "0x1E436A0", VA = "0x181E450A0")]
		public Vector3f PointAt(float d)
		{
			return default(Vector3f);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0000C71C File Offset: 0x0000A91C
		[Token(Token = "0x600107B")]
		[Address(RVA = "0x1E45180", Offset = "0x1E43780", VA = "0x181E45180")]
		public float Project(Vector3f p)
		{
			return 0f;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0000C734 File Offset: 0x0000A934
		[Token(Token = "0x600107C")]
		[Address(RVA = "0x1E45230", Offset = "0x1E43830", VA = "0x181E45230")]
		public float DistanceSquared(Vector3f p)
		{
			return 0f;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0000C74C File Offset: 0x0000A94C
		[Token(Token = "0x600107D")]
		[Address(RVA = "0x1E45370", Offset = "0x1E43970", VA = "0x181E45370")]
		public static implicit operator Ray3f(Ray r)
		{
			return default(Ray3f);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0000C764 File Offset: 0x0000A964
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x1E45440", Offset = "0x1E43A40", VA = "0x181E45440")]
		public static implicit operator Ray(Ray3f r)
		{
			return default(Ray);
		}

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x0")]
		public Vector3f Origin;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0xC")]
		public Vector3f Direction;
	}
}
