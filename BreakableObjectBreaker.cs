using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000039 RID: 57
[Token(Token = "0x2000039")]
public class BreakableObjectBreaker : MonoBehaviour
{
	// Token: 0x0600016E RID: 366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016E")]
	[Address(RVA = "0x299D800", Offset = "0x299C800", VA = "0x18299D800")]
	private void Start()
	{
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x299D7F0", Offset = "0x299C7F0", VA = "0x18299D7F0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x299D7B0", Offset = "0x299C7B0", VA = "0x18299D7B0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x299D8D0", Offset = "0x299C8D0", VA = "0x18299D8D0")]
	private void TryBreak(Collider other)
	{
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public BreakableObjectBreaker()
	{
	}

	// Token: 0x04000179 RID: 377
	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _checkForBreakableTag;
}
