using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000281 RID: 641
[Token(Token = "0x2000281")]
[Serializable]
public class ToggleWireframe : MonoBehaviour
{
	// Token: 0x0600109E RID: 4254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109E")]
	[Address(RVA = "0x2FBB630", Offset = "0x2FBA630", VA = "0x182FBB630", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109F")]
	[Address(RVA = "0x2FBB730", Offset = "0x2FBA730", VA = "0x182FBB730", Slot = "5")]
	public virtual void Update()
	{
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A0")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public ToggleWireframe()
	{
	}

	// Token: 0x04001022 RID: 4130
	[Token(Token = "0x4001022")]
	[FieldOffset(Offset = "0x20")]
	public GameObject wireframeCamera;

	// Token: 0x04001023 RID: 4131
	[Token(Token = "0x4001023")]
	[FieldOffset(Offset = "0x28")]
	public bool isOn;
}
