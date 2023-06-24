using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012A RID: 298
[Token(Token = "0x200012A")]
public class FPSDisplay : MonoBehaviour
{
	// Token: 0x060008E4 RID: 2276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x368D9C0", Offset = "0x368BFC0", VA = "0x18368D9C0")]
	private void Start()
	{
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x207A1B0", Offset = "0x20787B0", VA = "0x18207A1B0")]
	private void Update()
	{
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x368DA20", Offset = "0x368C020", VA = "0x18368DA20")]
	private void OnGUI()
	{
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public FPSDisplay()
	{
	}

	// Token: 0x04000715 RID: 1813
	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0x20")]
	private float deltaTime;

	// Token: 0x04000716 RID: 1814
	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0x24")]
	private float updateDelay;

	// Token: 0x04000717 RID: 1815
	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x28")]
	private float msec;

	// Token: 0x04000718 RID: 1816
	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x2C")]
	private float fps;

	// Token: 0x04000719 RID: 1817
	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0x30")]
	private string text;
}
