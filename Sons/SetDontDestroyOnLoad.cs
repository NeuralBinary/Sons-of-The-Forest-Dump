using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200029E RID: 670
[Token(Token = "0x200029E")]
public class SetDontDestroyOnLoad : MonoBehaviour
{
	// Token: 0x060011E3 RID: 4579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x31D0420", Offset = "0x31CEA20", VA = "0x1831D0420")]
	private void Start()
	{
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x31D0430", Offset = "0x31CEA30", VA = "0x1831D0430")]
	private void Awake()
	{
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x31D0440", Offset = "0x31CEA40", VA = "0x1831D0440")]
	private void OnEnable()
	{
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x31D0450", Offset = "0x31CEA50", VA = "0x1831D0450")]
	private void ApplyDontDestoryOnLoad()
	{
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E7")]
	[Address(RVA = "0x31D0750", Offset = "0x31CED50", VA = "0x1831D0750")]
	public SetDontDestroyOnLoad()
	{
	}

	// Token: 0x040011A9 RID: 4521
	[Token(Token = "0x40011A9")]
	[FieldOffset(Offset = "0x20")]
	public bool UseAwake;

	// Token: 0x040011AA RID: 4522
	[Token(Token = "0x40011AA")]
	[FieldOffset(Offset = "0x21")]
	public bool UseStart;

	// Token: 0x040011AB RID: 4523
	[Token(Token = "0x40011AB")]
	[FieldOffset(Offset = "0x22")]
	public bool UseEnable;
}
