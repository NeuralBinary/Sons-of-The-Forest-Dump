using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
public class FMODListenerTarget : MonoBehaviour
{
	// Token: 0x06000073 RID: 115 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
	public int GetPriority()
	{
		return default(int);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x29A1D00", Offset = "0x29A0D00", VA = "0x1829A1D00")]
	private void OnEnable()
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x29A1B90", Offset = "0x29A0B90", VA = "0x1829A1B90")]
	private void OnDisable()
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x576710", Offset = "0x575710", VA = "0x180576710")]
	public void SetPriority(int priority)
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public FMODListenerTarget()
	{
	}

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _priority;
}
