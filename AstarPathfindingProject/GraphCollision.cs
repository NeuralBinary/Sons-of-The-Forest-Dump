using System;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	[Serializable]
	public class GraphCollision
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x67BE50", Offset = "0x67A450", VA = "0x18067BE50")]
		public void Initialize(GraphTransform transform, float scale)
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x67C0E0", Offset = "0x67A6E0", VA = "0x18067C0E0")]
		public bool Check(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x67C8C0", Offset = "0x67AEC0", VA = "0x18067C8C0")]
		public Vector3 CheckHeight(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x67C940", Offset = "0x67AF40", VA = "0x18067C940")]
		public Vector3 CheckHeight(Vector3 position, out RaycastHit hit, out bool walkable)
		{
			return default(Vector3);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x67CE50", Offset = "0x67B450", VA = "0x18067CE50")]
		public RaycastHit[] CheckHeightAll(Vector3 position, out int numHits)
		{
			return null;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x67D110", Offset = "0x67B710", VA = "0x18067D110")]
		public void DeserializeSettingsCompatibility(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x67D320", Offset = "0x67B920", VA = "0x18067D320")]
		public GraphCollision()
		{
		}

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x10")]
		public ColliderType type;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x14")]
		public float diameter;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x18")]
		public float height;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x1C")]
		public float collisionOffset;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x20")]
		public RayDirection rayDirection;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x24")]
		public LayerMask mask;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask heightMask;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x2C")]
		public float fromHeight;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x30")]
		public bool thickRaycast;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x34")]
		public float thickRaycastDiameter;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x38")]
		public bool unwalkableWhenNoGround;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x39")]
		public bool use2D;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x3A")]
		public bool collisionCheck;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x3B")]
		public bool heightCheck;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 up;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 upheight;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x54")]
		private ContactFilter2D contactFilter;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x0")]
		private static Collider2D[] dummyArray;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x70")]
		private float finalRadius;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x74")]
		private float finalRaycastRadius;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		public const float RaycastErrorMargin = 0.005f;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x78")]
		private RaycastHit[] hitBuffer;
	}
}
