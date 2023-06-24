using System;
using Il2CppDummyDll;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
internal class BoltHitboxWorldSnapshot : BoltObject, IDisposable
{
	// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x783D10", Offset = "0x782310", VA = "0x180783D10")]
	internal void Snapshot(BoltHitboxBody body)
	{
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x783E40", Offset = "0x782440", VA = "0x180783E40", Slot = "10")]
	public void Dispose()
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void Draw()
	{
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x7841A0", Offset = "0x7827A0", VA = "0x1807841A0")]
	public BoltHitboxWorldSnapshot()
	{
	}

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BoltObjectPool<BoltHitboxWorldSnapshot> _pool;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x28")]
	internal int _frame;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x30")]
	internal BoltSingleList<BoltHitboxBodySnapshot> _bodySnapshots;
}
