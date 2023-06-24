using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A9 RID: 681
[Token(Token = "0x20002A9")]
public class VRGameObjectSwitcher : MonoBehaviour
{
	// Token: 0x06001214 RID: 4628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001214")]
	[Address(RVA = "0x31D4BA0", Offset = "0x31D31A0", VA = "0x1831D4BA0")]
	private void OnValidate()
	{
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001215")]
	[Address(RVA = "0x31D4E00", Offset = "0x31D3400", VA = "0x1831D4E00")]
	private void Start()
	{
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001216")]
	[Address(RVA = "0x31D4E10", Offset = "0x31D3410", VA = "0x1831D4E10")]
	private void OnEnable()
	{
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001217")]
	[Address(RVA = "0x31D4E20", Offset = "0x31D3420", VA = "0x1831D4E20")]
	private void OnDisable()
	{
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001218")]
	[Address(RVA = "0x31D4E90", Offset = "0x31D3490", VA = "0x1831D4E90")]
	private void SwitchTargets()
	{
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001219")]
	[Address(RVA = "0x31D4F00", Offset = "0x31D3500", VA = "0x1831D4F00")]
	public void AddDefault(GameObject target)
	{
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121A")]
	[Address(RVA = "0x31D5010", Offset = "0x31D3610", VA = "0x1831D5010")]
	public void AddVR(GameObject target)
	{
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121B")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRGameObjectSwitcher()
	{
	}

	// Token: 0x040011E9 RID: 4585
	[Token(Token = "0x40011E9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> DefaultTargets;

	// Token: 0x040011EA RID: 4586
	[Token(Token = "0x40011EA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<GameObject> VRTargets;

	// Token: 0x040011EB RID: 4587
	[Token(Token = "0x40011EB")]
	[FieldOffset(Offset = "0x30")]
	public bool DoDisable;

	// Token: 0x040011EC RID: 4588
	[Token(Token = "0x40011EC")]
	[FieldOffset(Offset = "0x31")]
	public bool RunOnStart;
}
