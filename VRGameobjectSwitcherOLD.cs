using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B6 RID: 694
[Token(Token = "0x20002B6")]
[Obsolete("Use VRGameObjectSwitcher")]
public class VRGameobjectSwitcherOLD : MonoBehaviour
{
	// Token: 0x060011E7 RID: 4583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E7")]
	[Address(RVA = "0x2B8A150", Offset = "0x2B89150", VA = "0x182B8A150")]
	private void Start()
	{
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E8")]
	[Address(RVA = "0x2B8A140", Offset = "0x2B89140", VA = "0x182B8A140")]
	private void OnEnable()
	{
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E9")]
	[Address(RVA = "0x2B8A080", Offset = "0x2B89080", VA = "0x182B8A080")]
	private void OnDisable()
	{
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EA")]
	[Address(RVA = "0x2B8A160", Offset = "0x2B89160", VA = "0x182B8A160")]
	private void switchTargets()
	{
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EB")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRGameobjectSwitcherOLD()
	{
	}

	// Token: 0x040011C6 RID: 4550
	[Token(Token = "0x40011C6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	// Token: 0x040011C7 RID: 4551
	[Token(Token = "0x40011C7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject VRtarget;

	// Token: 0x040011C8 RID: 4552
	[Token(Token = "0x40011C8")]
	[FieldOffset(Offset = "0x30")]
	public bool DoDisable;

	// Token: 0x040011C9 RID: 4553
	[Token(Token = "0x40011C9")]
	[FieldOffset(Offset = "0x31")]
	public bool RunOnStart;
}
