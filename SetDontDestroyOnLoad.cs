using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AA RID: 682
[Token(Token = "0x20002AA")]
public class SetDontDestroyOnLoad : MonoBehaviour
{
	// Token: 0x060011AE RID: 4526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x2B86A70", Offset = "0x2B85A70", VA = "0x182B86A70")]
	private void Start()
	{
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x2B86A50", Offset = "0x2B85A50", VA = "0x182B86A50")]
	private void Awake()
	{
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x2B86A60", Offset = "0x2B85A60", VA = "0x182B86A60")]
	private void OnEnable()
	{
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x2B86960", Offset = "0x2B85960", VA = "0x182B86960")]
	private void ApplyDontDestoryOnLoad()
	{
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x2B86A80", Offset = "0x2B85A80", VA = "0x182B86A80")]
	public SetDontDestroyOnLoad()
	{
	}

	// Token: 0x04001182 RID: 4482
	[Token(Token = "0x4001182")]
	[FieldOffset(Offset = "0x20")]
	public bool UseAwake;

	// Token: 0x04001183 RID: 4483
	[Token(Token = "0x4001183")]
	[FieldOffset(Offset = "0x21")]
	public bool UseStart;

	// Token: 0x04001184 RID: 4484
	[Token(Token = "0x4001184")]
	[FieldOffset(Offset = "0x22")]
	public bool UseEnable;
}
