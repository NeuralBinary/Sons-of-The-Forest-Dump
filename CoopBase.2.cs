using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AA RID: 170
[Token(Token = "0x20000AA")]
public abstract class CoopBase<T> : EntityEventListener<T>, IPriorityCalculator
{
	// Token: 0x06000598 RID: 1432 RVA: 0x00003AF8 File Offset: 0x00001CF8
	[Token(Token = "0x6000598")]
	private float CalculateEventPriority(BoltConnection connection, Event evnt)
	{
		return default(float);
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00003B10 File Offset: 0x00001D10
	[Token(Token = "0x6000599")]
	private float CalculateStatePriority(BoltConnection connection, int skipped)
	{
		return default(float);
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x0600059A RID: 1434 RVA: 0x00003B28 File Offset: 0x00001D28
	[Token(Token = "0x170000D4")]
	private bool Always
	{
		[Token(Token = "0x600059A")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059B")]
	public override void OnEvent(SendMessageEvent evnt)
	{
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059C")]
	protected CoopBase()
	{
	}

	// Token: 0x04000501 RID: 1281
	[Token(Token = "0x4000501")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public float MultiplayerPriority;
}
