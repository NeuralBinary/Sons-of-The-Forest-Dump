using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000130 RID: 304
[Token(Token = "0x2000130")]
public class ImpactSfx : MonoBehaviour
{
	// Token: 0x060008EE RID: 2286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x368DFD0", Offset = "0x368C5D0", VA = "0x18368DFD0")]
	private void Awake()
	{
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x368E0C0", Offset = "0x368C6C0", VA = "0x18368E0C0")]
	private void Start()
	{
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x368E1D0", Offset = "0x368C7D0", VA = "0x18368E1D0")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x368E220", Offset = "0x368C820", VA = "0x18368E220")]
	private void HandleCollision(Collider collider)
	{
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x368E4E0", Offset = "0x368CAE0", VA = "0x18368E4E0")]
	private void OnDisable()
	{
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x368E570", Offset = "0x368CB70", VA = "0x18368E570")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x368E670", Offset = "0x368CC70", VA = "0x18368E670")]
	public void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x22BEAF0", Offset = "0x22BD0F0", VA = "0x1822BEAF0")]
	private void EndTimeout()
	{
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x000045C0 File Offset: 0x000027C0
	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x368E730", Offset = "0x368CD30", VA = "0x18368E730")]
	private bool SoundsEnabled()
	{
		return default(bool);
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x368E800", Offset = "0x368CE00", VA = "0x18368E800")]
	private void TryPlaySound(string path)
	{
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ImpactSfx()
	{
	}

	// Token: 0x04000720 RID: 1824
	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x20")]
	[Header("Impact Events")]
	public string tree;

	// Token: 0x04000721 RID: 1825
	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x28")]
	public string water;

	// Token: 0x04000722 RID: 1826
	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x30")]
	public bool impactOnTriggerEnter;

	// Token: 0x04000723 RID: 1827
	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x31")]
	public bool ignoreSpeedThreshold;

	// Token: 0x04000724 RID: 1828
	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x34")]
	private int waterLayer;

	// Token: 0x04000725 RID: 1829
	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x38")]
	private bool timeoutActive;

	// Token: 0x04000726 RID: 1830
	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody rigidBody;

	// Token: 0x04000727 RID: 1831
	[Token(Token = "0x4000727")]
	private const float SPEED_THRESHOLD = 2.5f;

	// Token: 0x04000728 RID: 1832
	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x48")]
	private int inWaterCount;
}
