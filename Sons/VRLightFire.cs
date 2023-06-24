using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AE RID: 686
[Token(Token = "0x20002AE")]
public class VRLightFire : MonoBehaviour
{
	// Token: 0x06001228 RID: 4648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001228")]
	[Address(RVA = "0xA71C70", Offset = "0xA70270", VA = "0x180A71C70")]
	private void Start()
	{
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001229")]
	[Address(RVA = "0x66EAE0", Offset = "0x66D0E0", VA = "0x18066EAE0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122A")]
	[Address(RVA = "0x31D5930", Offset = "0x31D3F30", VA = "0x1831D5930")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600122B RID: 4651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122B")]
	[Address(RVA = "0x31D5A20", Offset = "0x31D4020", VA = "0x1831D5A20")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122C")]
	[Address(RVA = "0x31D5B10", Offset = "0x31D4110", VA = "0x1831D5B10")]
	private void Update()
	{
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122D")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRLightFire()
	{
	}

	// Token: 0x040011FA RID: 4602
	[Token(Token = "0x40011FA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject targetFire;

	// Token: 0x040011FB RID: 4603
	[Token(Token = "0x40011FB")]
	[FieldOffset(Offset = "0x28")]
	private bool InFireTrigger;

	// Token: 0x040011FC RID: 4604
	[Token(Token = "0x40011FC")]
	[FieldOffset(Offset = "0x2C")]
	private float nextFireCheck;

	// Token: 0x040011FD RID: 4605
	[Token(Token = "0x40011FD")]
	[FieldOffset(Offset = "0x30")]
	public bool ArrowFire;
}
