using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027C RID: 636
[Token(Token = "0x200027C")]
[Serializable]
public class ToggleWireframe : MonoBehaviour
{
	// Token: 0x060010EC RID: 4332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EC")]
	[Address(RVA = "0x3740470", Offset = "0x373EA70", VA = "0x183740470", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x3740640", Offset = "0x373EC40", VA = "0x183740640", Slot = "5")]
	public virtual void Update()
	{
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ToggleWireframe()
	{
	}

	// Token: 0x04001048 RID: 4168
	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x20")]
	public GameObject wireframeCamera;

	// Token: 0x04001049 RID: 4169
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x28")]
	public bool isOn;
}
