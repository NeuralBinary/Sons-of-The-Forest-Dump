using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000132 RID: 306
[Token(Token = "0x2000132")]
public class ImpactSfx : MonoBehaviour
{
	// Token: 0x060008A6 RID: 2214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x2F299D0", Offset = "0x2F289D0", VA = "0x182F299D0")]
	private void Awake()
	{
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x2F29DB0", Offset = "0x2F28DB0", VA = "0x182F29DB0")]
	private void Start()
	{
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x2F29BF0", Offset = "0x2F28BF0", VA = "0x182F29BF0")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x2F29A40", Offset = "0x2F28A40", VA = "0x182F29A40")]
	private void HandleCollision(Collider collider)
	{
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x2F29C30", Offset = "0x2F28C30", VA = "0x182F29C30")]
	private void OnDisable()
	{
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x2F29C80", Offset = "0x2F28C80", VA = "0x182F29C80")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x2F29D00", Offset = "0x2F28D00", VA = "0x182F29D00")]
	public void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x22CA110", Offset = "0x22C9110", VA = "0x1822CA110")]
	private void EndTimeout()
	{
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x000043B0 File Offset: 0x000025B0
	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x2F29D40", Offset = "0x2F28D40", VA = "0x182F29D40")]
	private bool SoundsEnabled()
	{
		return default(bool);
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x2F29E60", Offset = "0x2F28E60", VA = "0x182F29E60")]
	private void TryPlaySound(string path)
	{
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public ImpactSfx()
	{
	}

	// Token: 0x04000704 RID: 1796
	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0x20")]
	[Header("Impact Events")]
	public string tree;

	// Token: 0x04000705 RID: 1797
	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x28")]
	public string water;

	// Token: 0x04000706 RID: 1798
	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x30")]
	public bool impactOnTriggerEnter;

	// Token: 0x04000707 RID: 1799
	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x31")]
	public bool ignoreSpeedThreshold;

	// Token: 0x04000708 RID: 1800
	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x34")]
	private int waterLayer;

	// Token: 0x04000709 RID: 1801
	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x38")]
	private bool timeoutActive;

	// Token: 0x0400070A RID: 1802
	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody rigidBody;

	// Token: 0x0400070B RID: 1803
	[Token(Token = "0x400070B")]
	private const float SPEED_THRESHOLD = 2.5f;

	// Token: 0x0400070C RID: 1804
	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x48")]
	private int inWaterCount;
}
