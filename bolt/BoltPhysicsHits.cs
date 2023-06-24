using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
[Documentation]
public class BoltPhysicsHits : BoltObject, IDisposable
{
	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060000EA RID: 234 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x17000029")]
	public int count
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x784300", Offset = "0x782900", VA = "0x180784300")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700002A RID: 42
	[Token(Token = "0x1700002A")]
	public BoltPhysicsHit this[int index]
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x784340", Offset = "0x782940", VA = "0x180784340")]
		get
		{
			return default(BoltPhysicsHit);
		}
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x7843D0", Offset = "0x7829D0", VA = "0x1807843D0")]
	public BoltPhysicsHit GetHit(int index)
	{
		return default(BoltPhysicsHit);
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x784460", Offset = "0x782A60", VA = "0x180784460", Slot = "10")]
	public void Dispose()
	{
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x784530", Offset = "0x782B30", VA = "0x180784530")]
	internal void AddHit(BoltHitboxBody body, BoltHitbox hitbox, float distance)
	{
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x784680", Offset = "0x782C80", VA = "0x180784680")]
	public BoltPhysicsHits()
	{
	}

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BoltObjectPool<BoltPhysicsHits> _pool;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x28")]
	internal List<BoltPhysicsHit> _hits;
}
