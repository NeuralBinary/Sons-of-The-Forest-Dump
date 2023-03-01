using System;
using System.Collections;
using Il2CppDummyDll;
using TheForest.Utils.Physics;
using UnityEngine;

// Token: 0x02000136 RID: 310
[Token(Token = "0x2000136")]
public class logChecker : MonoBehaviour, IOnCollisionEnterProxy, IOnCollisionExitProxy
{
	// Token: 0x060008BD RID: 2237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x2F4A0B0", Offset = "0x2F490B0", VA = "0x182F4A0B0")]
	private void Start()
	{
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x2F4A140", Offset = "0x2F49140", VA = "0x182F4A140")]
	private void enableSpawnedfromTree()
	{
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x2F49FC0", Offset = "0x2F48FC0", VA = "0x182F49FC0")]
	private void OnEnable()
	{
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x2F49F20", Offset = "0x2F48F20", VA = "0x182F49F20")]
	private void OnDisable()
	{
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x2F4A1B0", Offset = "0x2F491B0", VA = "0x182F4A1B0")]
	private IEnumerator setDrag()
	{
		return null;
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x2F49C00", Offset = "0x2F48C00", VA = "0x182F49C00", Slot = "4")]
	public void OnCollisionEnterProxied(Collision col)
	{
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x2F49D90", Offset = "0x2F48D90", VA = "0x182F49D90", Slot = "5")]
	public void OnCollisionExitProxied(Collision col)
	{
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public logChecker()
	{
	}

	// Token: 0x04000719 RID: 1817
	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0x20")]
	public bool grounded;

	// Token: 0x0400071A RID: 1818
	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rb;

	// Token: 0x0400071B RID: 1819
	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x30")]
	private bool ignoringTerrainCollision;
}
