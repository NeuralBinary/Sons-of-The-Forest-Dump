using System;
using System.Collections;
using Il2CppDummyDll;
using TheForest.Utils.Physics;
using UnityEngine;

// Token: 0x02000134 RID: 308
[Token(Token = "0x2000134")]
public class logChecker : MonoBehaviour, IOnCollisionEnterProxy, IOnCollisionExitProxy
{
	// Token: 0x06000905 RID: 2309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000905")]
	[Address(RVA = "0x368F9B0", Offset = "0x368DFB0", VA = "0x18368F9B0")]
	private void Start()
	{
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000906")]
	[Address(RVA = "0x368FAF0", Offset = "0x368E0F0", VA = "0x18368FAF0")]
	private void enableSpawnedfromTree()
	{
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000907")]
	[Address(RVA = "0x368FB90", Offset = "0x368E190", VA = "0x18368FB90")]
	private void OnEnable()
	{
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000908")]
	[Address(RVA = "0x368FD20", Offset = "0x368E320", VA = "0x18368FD20")]
	private void OnDisable()
	{
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000909")]
	[Address(RVA = "0x368FED0", Offset = "0x368E4D0", VA = "0x18368FED0")]
	private IEnumerator setDrag()
	{
		return null;
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090A")]
	[Address(RVA = "0x368FF60", Offset = "0x368E560", VA = "0x18368FF60", Slot = "4")]
	public void OnCollisionEnterProxied(Collision col)
	{
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090B")]
	[Address(RVA = "0x36901B0", Offset = "0x368E7B0", VA = "0x1836901B0", Slot = "5")]
	public void OnCollisionExitProxied(Collision col)
	{
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090C")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public logChecker()
	{
	}

	// Token: 0x04000735 RID: 1845
	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x20")]
	public bool grounded;

	// Token: 0x04000736 RID: 1846
	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rb;

	// Token: 0x04000737 RID: 1847
	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x30")]
	private bool ignoringTerrainCollision;
}
