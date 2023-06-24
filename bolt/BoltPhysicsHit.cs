using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001E")]
[Documentation]
public struct BoltPhysicsHit
{
	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x0")]
	public float distance;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x8")]
	public BoltHitbox hitbox;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x10")]
	public BoltHitboxBody body;
}
