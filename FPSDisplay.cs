using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012D RID: 301
[Token(Token = "0x200012D")]
public class FPSDisplay : MonoBehaviour
{
	// Token: 0x0600089D RID: 2205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089D")]
	[Address(RVA = "0x2F299A0", Offset = "0x2F289A0", VA = "0x182F299A0")]
	private void Start()
	{
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089E")]
	[Address(RVA = "0x1D3A9D0", Offset = "0x1D399D0", VA = "0x181D3A9D0")]
	private void Update()
	{
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089F")]
	[Address(RVA = "0x2F29760", Offset = "0x2F28760", VA = "0x182F29760")]
	private void OnGUI()
	{
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public FPSDisplay()
	{
	}

	// Token: 0x040006F9 RID: 1785
	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0x20")]
	private float deltaTime;

	// Token: 0x040006FA RID: 1786
	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x24")]
	private float updateDelay;

	// Token: 0x040006FB RID: 1787
	[Token(Token = "0x40006FB")]
	[FieldOffset(Offset = "0x28")]
	private float msec;

	// Token: 0x040006FC RID: 1788
	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0x2C")]
	private float fps;

	// Token: 0x040006FD RID: 1789
	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x30")]
	private string text;
}
