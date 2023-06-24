using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[Serializable]
	public struct Aabb
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x23A9D20", Offset = "0x23A8320", VA = "0x1823A9D20")]
		public static Aabb Union(Aabb a, Aabb b)
		{
			return default(Aabb);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x23A9DA0", Offset = "0x23A83A0", VA = "0x1823A9DA0")]
		public static bool Intersects(Aabb a, Aabb b)
		{
			return default(bool);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x1700000C")]
		public static Aabb Empty
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x23A9E00", Offset = "0x23A8400", VA = "0x1823A9E00")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x1700000D")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x23A9E70", Offset = "0x23A8470", VA = "0x1823A9E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x1700000E")]
		public float HalfArea
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x23A9EA0", Offset = "0x23A84A0", VA = "0x1823A9EA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x1700000F")]
		public Vector3 Center
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x23A9F00", Offset = "0x23A8500", VA = "0x1823A9F00")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000010")]
		public Vector3 Size
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x23A9F70", Offset = "0x23A8570", VA = "0x1823A9F70")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x17000011")]
		public Vector3 Extent
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x23A9FD0", Offset = "0x23A85D0", VA = "0x1823A9FD0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0xFA1160", Offset = "0xF9F760", VA = "0x180FA1160")]
		public Aabb(Vector3 min, Vector3 max)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x23AA040", Offset = "0x23A8640", VA = "0x1823AA040")]
		public void Include(Vector3 p)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x23AA0A0", Offset = "0x23A86A0", VA = "0x1823AA0A0")]
		public void Include(Aabb aabb)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x202DF70", Offset = "0x202C570", VA = "0x18202DF70")]
		public void Expand(float r)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x23AA100", Offset = "0x23A8700", VA = "0x1823AA100")]
		public void Expand(Vector3 r)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x23AA160", Offset = "0x23A8760", VA = "0x1823AA160")]
		public void Rotate(Quaternion q)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x23AA540", Offset = "0x23A8B40", VA = "0x1823AA540")]
		public void Transform(Transform transform)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x202EB60", Offset = "0x202D160", VA = "0x18202EB60")]
		public bool Contains(Vector3 p)
		{
			return default(bool);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x23AAAB0", Offset = "0x23A90B0", VA = "0x1823AAAB0")]
		public bool Contains(Aabb rhs)
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x23AAB10", Offset = "0x23A9110", VA = "0x1823AAB10")]
		public float RayCast(Vector3 from, Vector3 to, float maxFraction = 1f)
		{
			return 0f;
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 Min;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 Max;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Aabb s_empty;
	}
}
