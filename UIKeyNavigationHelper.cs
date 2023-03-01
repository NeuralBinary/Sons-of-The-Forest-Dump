using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using Sons.Input;
using UnityEngine;

// Token: 0x020002A4 RID: 676
[Token(Token = "0x20002A4")]
public class UIKeyNavigationHelper : MonoBehaviour
{
	// Token: 0x06001182 RID: 4482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001182")]
	[Address(RVA = "0x2B871C0", Offset = "0x2B861C0", VA = "0x182B871C0")]
	private void Update()
	{
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001183")]
	[Address(RVA = "0x2B87420", Offset = "0x2B86420", VA = "0x182B87420")]
	public UIKeyNavigationHelper()
	{
	}

	// Token: 0x04001154 RID: 4436
	[Token(Token = "0x4001154")]
	[FieldOffset(Offset = "0x20")]
	public InputSystem.ActionId CatchAction;

	// Token: 0x04001155 RID: 4437
	[Token(Token = "0x4001155")]
	[FieldOffset(Offset = "0x28")]
	public UIKeyNavigation TargetNavigation;

	// Token: 0x04001156 RID: 4438
	[Token(Token = "0x4001156")]
	[FieldOffset(Offset = "0x30")]
	public float DeadZone;

	// Token: 0x04001157 RID: 4439
	[Token(Token = "0x4001157")]
	[FieldOffset(Offset = "0x0")]
	private static bool _hasNavigated;
}
