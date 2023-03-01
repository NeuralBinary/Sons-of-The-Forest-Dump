using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B5 RID: 693
[Token(Token = "0x20002B5")]
public class VRGameObjectSwitcher : MonoBehaviour
{
	// Token: 0x060011DF RID: 4575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x2B89F50", Offset = "0x2B88F50", VA = "0x182B89F50")]
	private void OnValidate()
	{
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x2B8A010", Offset = "0x2B89010", VA = "0x182B8A010")]
	private void Start()
	{
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x2B89F10", Offset = "0x2B88F10", VA = "0x182B89F10")]
	private void OnEnable()
	{
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x2B89ED0", Offset = "0x2B88ED0", VA = "0x182B89ED0")]
	private void OnDisable()
	{
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x2B8A050", Offset = "0x2B89050", VA = "0x182B8A050")]
	private void SwitchTargets()
	{
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x2B89C70", Offset = "0x2B88C70", VA = "0x182B89C70")]
	public void AddDefault(GameObject target)
	{
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x2B89DA0", Offset = "0x2B88DA0", VA = "0x182B89DA0")]
	public void AddVR(GameObject target)
	{
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRGameObjectSwitcher()
	{
	}

	// Token: 0x040011C2 RID: 4546
	[Token(Token = "0x40011C2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> DefaultTargets;

	// Token: 0x040011C3 RID: 4547
	[Token(Token = "0x40011C3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<GameObject> VRTargets;

	// Token: 0x040011C4 RID: 4548
	[Token(Token = "0x40011C4")]
	[FieldOffset(Offset = "0x30")]
	public bool DoDisable;

	// Token: 0x040011C5 RID: 4549
	[Token(Token = "0x40011C5")]
	[FieldOffset(Offset = "0x31")]
	public bool RunOnStart;
}
