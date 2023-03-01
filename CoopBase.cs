using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A9 RID: 169
[Token(Token = "0x20000A9")]
public abstract class CoopBase : EntityEventListener, IPriorityCalculator
{
	// Token: 0x06000593 RID: 1427 RVA: 0x00003AB0 File Offset: 0x00001CB0
	[Token(Token = "0x6000593")]
	[Address(RVA = "0x2E71350", Offset = "0x2E70350", VA = "0x182E71350", Slot = "297")]
	private float CalculateEventPriority(BoltConnection connection, Event evnt)
	{
		return default(float);
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00003AC8 File Offset: 0x00001CC8
	[Token(Token = "0x6000594")]
	[Address(RVA = "0x2E713A0", Offset = "0x2E703A0", VA = "0x182E713A0", Slot = "296")]
	private float CalculateStatePriority(BoltConnection connection, int skipped)
	{
		return default(float);
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06000595 RID: 1429 RVA: 0x00003AE0 File Offset: 0x00001CE0
	[Token(Token = "0x170000D3")]
	private bool Always
	{
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "298")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000596")]
	[Address(RVA = "0x2E713F0", Offset = "0x2E703F0", VA = "0x182E713F0", Slot = "174")]
	public override void OnEvent(SendMessageEvent evnt)
	{
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000597")]
	[Address(RVA = "0x2E71440", Offset = "0x2E70440", VA = "0x182E71440")]
	protected CoopBase()
	{
	}

	// Token: 0x04000500 RID: 1280
	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float MultiplayerPriority;
}
