using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AA RID: 682
[Token(Token = "0x20002AA")]
[Obsolete("Use VRGameObjectSwitcher")]
public class VRGameobjectSwitcherOLD : MonoBehaviour
{
	// Token: 0x0600121C RID: 4636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121C")]
	[Address(RVA = "0x31D5120", Offset = "0x31D3720", VA = "0x1831D5120")]
	private void Start()
	{
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121D")]
	[Address(RVA = "0x31D5130", Offset = "0x31D3730", VA = "0x1831D5130")]
	private void OnEnable()
	{
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121E")]
	[Address(RVA = "0x31D5140", Offset = "0x31D3740", VA = "0x1831D5140")]
	private void OnDisable()
	{
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121F")]
	[Address(RVA = "0x31D52C0", Offset = "0x31D38C0", VA = "0x1831D52C0")]
	private void switchTargets()
	{
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001220")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRGameobjectSwitcherOLD()
	{
	}

	// Token: 0x040011ED RID: 4589
	[Token(Token = "0x40011ED")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	// Token: 0x040011EE RID: 4590
	[Token(Token = "0x40011EE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject VRtarget;

	// Token: 0x040011EF RID: 4591
	[Token(Token = "0x40011EF")]
	[FieldOffset(Offset = "0x30")]
	public bool DoDisable;

	// Token: 0x040011F0 RID: 4592
	[Token(Token = "0x40011F0")]
	[FieldOffset(Offset = "0x31")]
	public bool RunOnStart;
}
