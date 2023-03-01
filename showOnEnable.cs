using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016F RID: 367
[Token(Token = "0x200016F")]
public class showOnEnable : MonoBehaviour
{
	// Token: 0x06000AF8 RID: 2808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x2F5F1F0", Offset = "0x2F5E1F0", VA = "0x182F5F1F0")]
	private void Awake()
	{
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0x2F5F310", Offset = "0x2F5E310", VA = "0x182F5F310")]
	private void OnEnable()
	{
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x2F5F280", Offset = "0x2F5E280", VA = "0x182F5F280")]
	private void OnDisable()
	{
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public showOnEnable()
	{
	}

	// Token: 0x0400098E RID: 2446
	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x20")]
	public showOnEnable.Actions allowedAction;

	// Token: 0x0400098F RID: 2447
	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x24")]
	public bool invert;

	// Token: 0x04000990 RID: 2448
	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0x28")]
	public GameObject go;

	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	public enum Actions
	{
		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		All,
		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		EnabledOnly,
		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		DisabledOnly
	}
}
