using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000019 RID: 25
[Token(Token = "0x2000019")]
internal class BoltHitboxBodySnapshot : BoltObject, IDisposable
{
	// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x782680", Offset = "0x780C80", VA = "0x180782680")]
	public void Snapshot(BoltHitboxBody body)
	{
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x782C50", Offset = "0x781250", VA = "0x180782C50", Slot = "10")]
	public void Dispose()
	{
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x782E10", Offset = "0x781410", VA = "0x180782E10")]
	public void OverlapSphere(Vector3 center, float radius, BoltPhysicsHits hits)
	{
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x783440", Offset = "0x781A40", VA = "0x180783440")]
	public void Raycast(Vector3 origin, Vector3 direction, BoltPhysicsHits hits)
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void Draw()
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x7837A0", Offset = "0x781DA0", VA = "0x1807837A0")]
	public static BoltHitboxBodySnapshot Create(BoltHitboxBody body)
	{
		return null;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x783870", Offset = "0x781E70", VA = "0x180783870")]
	public BoltHitboxBodySnapshot()
	{
	}

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x0")]
	private static readonly BoltObjectPool<BoltHitboxBodySnapshot> _pool;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x28")]
	private int _count;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x30")]
	private BoltHitboxBody _body;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x38")]
	private Matrix4x4 _wtl;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x78")]
	private Matrix4x4 _ltw;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0xB8")]
	private Matrix4x4[] _hbwtl;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0xC0")]
	private Matrix4x4[] _hbltw;
}
