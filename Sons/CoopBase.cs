using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A8 RID: 168
[Token(Token = "0x20000A8")]
public abstract class CoopBase : EntityEventListener, IPriorityCalculator
{
	// Token: 0x060005CD RID: 1485 RVA: 0x00003C78 File Offset: 0x00001E78
	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x350F490", Offset = "0x350DA90", VA = "0x18350F490", Slot = "323")]
	private float CalculateEventPriority(BoltConnection connection, Bolt.Event evnt)
	{
		return 0f;
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00003C90 File Offset: 0x00001E90
	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x350F4E0", Offset = "0x350DAE0", VA = "0x18350F4E0", Slot = "322")]
	private float CalculateStatePriority(BoltConnection connection, int skipped)
	{
		return 0f;
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060005CF RID: 1487 RVA: 0x00003CA8 File Offset: 0x00001EA8
	[Token(Token = "0x170000DA")]
	private bool Always
	{
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "324")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x350F530", Offset = "0x350DB30", VA = "0x18350F530", Slot = "187")]
	public override void OnEvent(SendMessageEvent evnt)
	{
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x1896380", Offset = "0x1894980", VA = "0x181896380")]
	protected CoopBase()
	{
	}

	// Token: 0x04000521 RID: 1313
	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float MultiplayerPriority;
}
