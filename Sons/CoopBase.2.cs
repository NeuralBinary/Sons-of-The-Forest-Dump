using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A9 RID: 169
[Token(Token = "0x20000A9")]
public abstract class CoopBase<T> : EntityEventListener<T>, IPriorityCalculator
{
	// Token: 0x060005D2 RID: 1490 RVA: 0x00003CC0 File Offset: 0x00001EC0
	[Token(Token = "0x60005D2")]
	private float CalculateEventPriority(BoltConnection connection, Bolt.Event evnt)
	{
		return 0f;
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[Token(Token = "0x60005D3")]
	private float CalculateStatePriority(BoltConnection connection, int skipped)
	{
		return 0f;
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00003CF0 File Offset: 0x00001EF0
	[Token(Token = "0x170000DB")]
	private bool Always
	{
		[Token(Token = "0x60005D4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D5")]
	public override void OnEvent(SendMessageEvent evnt)
	{
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D6")]
	protected CoopBase()
	{
	}

	// Token: 0x04000522 RID: 1314
	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public float MultiplayerPriority;
}
