using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000C3 RID: 195
[Token(Token = "0x20000C3")]
public class CoopMetaObject : EntityBehaviour, IPriorityCalculator
{
	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00003C48 File Offset: 0x00001E48
	[Token(Token = "0x170000DF")]
	private bool Always
	{
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00003C60 File Offset: 0x00001E60
	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x2E78570", Offset = "0x2E77570", VA = "0x182E78570", Slot = "25")]
	private float CalculateEventPriority(BoltConnection connection, Event evnt)
	{
		return default(float);
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00003C78 File Offset: 0x00001E78
	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x2E78570", Offset = "0x2E77570", VA = "0x182E78570", Slot = "24")]
	private float CalculateStatePriority(BoltConnection connection, int skipped)
	{
		return default(float);
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x59FF50", Offset = "0x59EF50", VA = "0x18059FF50")]
	public CoopMetaObject()
	{
	}
}
