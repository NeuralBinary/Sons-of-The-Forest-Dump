using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016E RID: 366
[Token(Token = "0x200016E")]
public class showOnEnable : MonoBehaviour
{
	// Token: 0x06000B51 RID: 2897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x36CB630", Offset = "0x36C9C30", VA = "0x1836CB630")]
	private void Awake()
	{
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x36CB760", Offset = "0x36C9D60", VA = "0x1836CB760")]
	private void OnEnable()
	{
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x36CB8A0", Offset = "0x36C9EA0", VA = "0x1836CB8A0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public showOnEnable()
	{
	}

	// Token: 0x040009B7 RID: 2487
	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x20")]
	public showOnEnable.Actions allowedAction;

	// Token: 0x040009B8 RID: 2488
	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x24")]
	public bool invert;

	// Token: 0x040009B9 RID: 2489
	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject go;

	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	public enum Actions
	{
		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		All,
		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		EnabledOnly,
		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x40009BD")]
		DisabledOnly
	}
}
