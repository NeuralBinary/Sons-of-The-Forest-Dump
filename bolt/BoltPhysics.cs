using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
internal static class BoltPhysics
{
	// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x77F480", Offset = "0x77DA80", VA = "0x18077F480")]
	internal static void RegisterBody(BoltHitboxBody body)
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x77F500", Offset = "0x77DB00", VA = "0x18077F500")]
	internal static void UnregisterBody(BoltHitboxBody body)
	{
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x77F580", Offset = "0x77DB80", VA = "0x18077F580")]
	internal static void SnapshotWorld()
	{
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	internal static void DrawSnapshot()
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x77FA50", Offset = "0x77E050", VA = "0x18077FA50")]
	internal static BoltPhysicsHits Raycast(Ray ray)
	{
		return null;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x77FBC0", Offset = "0x77E1C0", VA = "0x18077FBC0")]
	internal static BoltPhysicsHits Raycast(Ray ray, int frame)
	{
		return null;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x77FE60", Offset = "0x77E460", VA = "0x18077FE60")]
	internal static BoltPhysicsHits OverlapSphere(Vector3 origin, float radius)
	{
		return null;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x77FFF0", Offset = "0x77E5F0", VA = "0x18077FFF0")]
	internal static BoltPhysicsHits OverlapSphere(Vector3 origin, float radius, int frame)
	{
		return null;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x780230", Offset = "0x77E830", VA = "0x180780230")]
	private static BoltPhysicsHits Raycast(Ray ray, BoltHitboxWorldSnapshot sn)
	{
		return null;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x780450", Offset = "0x77EA50", VA = "0x180780450")]
	private static BoltPhysicsHits OverlapSphere(Vector3 origin, float radius, BoltHitboxWorldSnapshot sn)
	{
		return null;
	}

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x0")]
	private static int maxWorldSnapshots;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x8")]
	private static readonly BoltDoubleList<BoltHitboxBody> _hitboxBodies;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly BoltDoubleList<BoltHitboxWorldSnapshot> _worldSnapshots;
}
