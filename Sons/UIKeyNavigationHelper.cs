using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using Sons.Input;
using UnityEngine;

// Token: 0x02000299 RID: 665
[Token(Token = "0x2000299")]
public class UIKeyNavigationHelper : MonoBehaviour
{
	// Token: 0x060011C1 RID: 4545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x31CC0C0", Offset = "0x31CA6C0", VA = "0x1831CC0C0")]
	private void Update()
	{
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x31CC4A0", Offset = "0x31CAAA0", VA = "0x1831CC4A0")]
	public UIKeyNavigationHelper()
	{
	}

	// Token: 0x0400117B RID: 4475
	[Token(Token = "0x400117B")]
	[FieldOffset(Offset = "0x20")]
	public InputSystem.ActionId CatchAction;

	// Token: 0x0400117C RID: 4476
	[Token(Token = "0x400117C")]
	[FieldOffset(Offset = "0x28")]
	public UIKeyNavigation TargetNavigation;

	// Token: 0x0400117D RID: 4477
	[Token(Token = "0x400117D")]
	[FieldOffset(Offset = "0x30")]
	public float DeadZone;

	// Token: 0x0400117E RID: 4478
	[Token(Token = "0x400117E")]
	[FieldOffset(Offset = "0x0")]
	private static bool _hasNavigated;
}
