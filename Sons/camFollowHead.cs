using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Player;
using UnityEngine;

// Token: 0x02000108 RID: 264
[Token(Token = "0x2000108")]
public class camFollowHead : MonoBehaviour
{
	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000842 RID: 2114 RVA: 0x000044A0 File Offset: 0x000026A0
	[Token(Token = "0x1700010B")]
	public bool IsActive
	{
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x3685060", Offset = "0x3683660", VA = "0x183685060")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000843")]
	[Address(RVA = "0x3685070", Offset = "0x3683670", VA = "0x183685070")]
	public void SetFollowAnim(bool value)
	{
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000844")]
	[Address(RVA = "0x3685120", Offset = "0x3683720", VA = "0x183685120")]
	private void Awake()
	{
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000845")]
	[Address(RVA = "0x36855A0", Offset = "0x3683BA0", VA = "0x1836855A0")]
	private void Start()
	{
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000846")]
	[Address(RVA = "0x3685720", Offset = "0x3683D20", VA = "0x183685720")]
	private void OnEnable()
	{
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000847")]
	[Address(RVA = "0x3685770", Offset = "0x3683D70", VA = "0x183685770")]
	private void checkPlayerControl()
	{
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000848")]
	[Address(RVA = "0x36858D0", Offset = "0x3683ED0", VA = "0x1836858D0")]
	public void stopAllCameraShake()
	{
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000849")]
	[Address(RVA = "0x3685920", Offset = "0x3683F20", VA = "0x183685920")]
	public IEnumerator startFallingShake()
	{
		return null;
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600084A")]
	[Address(RVA = "0x36859B0", Offset = "0x3683FB0", VA = "0x1836859B0")]
	public IEnumerator StartZipLineShake()
	{
		return null;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084B")]
	[Address(RVA = "0x3685A40", Offset = "0x3684040", VA = "0x183685A40")]
	private void Update()
	{
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084C")]
	[Address(RVA = "0x3685A50", Offset = "0x3684050", VA = "0x183685A50")]
	public void UpdateCamPosition()
	{
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x000044B8 File Offset: 0x000026B8
	[Token(Token = "0x600084D")]
	[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
	private bool vrAllowFollow()
	{
		return default(bool);
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084E")]
	[Address(RVA = "0x3685D20", Offset = "0x3684320", VA = "0x183685D20")]
	private void DoCamFollow()
	{
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084F")]
	[Address(RVA = "0x36866C0", Offset = "0x3684CC0", VA = "0x1836866C0")]
	public void BeginSmoothLock(bool shouldLookDownOnly = false, bool handleSpineLayer = true)
	{
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000850")]
	[Address(RVA = "0x3686970", Offset = "0x3684F70", VA = "0x183686970")]
	public void BeginSmoothUnlock(float maxSmoothDuration = 0.5f)
	{
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000851")]
	[Address(RVA = "0x3686AC0", Offset = "0x36850C0", VA = "0x183686AC0")]
	public void InstantUnlockInPlace(bool handleSplineLayer = true)
	{
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000852")]
	[Address(RVA = "0x3686E50", Offset = "0x3685450", VA = "0x183686E50")]
	public void RevertToUnlockedState()
	{
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000853")]
	[Address(RVA = "0x3687080", Offset = "0x3685680", VA = "0x183687080")]
	public void enableMouseControl(bool on)
	{
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000854")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public camFollowHead()
	{
	}

	// Token: 0x04000698 RID: 1688
	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x20")]
	public Transform headJnt;

	// Token: 0x04000699 RID: 1689
	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x28")]
	private Transform thisTr;

	// Token: 0x0400069A RID: 1690
	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x30")]
	public Transform camTr;

	// Token: 0x0400069B RID: 1691
	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x38")]
	private playerScriptSetup setup;

	// Token: 0x0400069C RID: 1692
	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x40")]
	private playerHitReactions reactions;

	// Token: 0x0400069D RID: 1693
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x48")]
	public SimpleMouseRotator mouse1;

	// Token: 0x0400069E RID: 1694
	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x50")]
	public SimpleMouseRotator mouse2;

	// Token: 0x0400069F RID: 1695
	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x58")]
	public bool lookDownOnly;

	// Token: 0x040006A0 RID: 1696
	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x59")]
	private bool followAnim;

	// Token: 0x040006A1 RID: 1697
	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x5A")]
	public bool AllowCameraMoveFollowAnim;

	// Token: 0x040006A2 RID: 1698
	[Token(Token = "0x40006A2")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 playerCamPos;

	// Token: 0x040006A3 RID: 1699
	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 startCamPos;

	// Token: 0x040006A4 RID: 1700
	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private bool lockXCam;

	// Token: 0x040006A5 RID: 1701
	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x75")]
	public bool lockYCam;

	// Token: 0x040006A6 RID: 1702
	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x76")]
	public bool smoothLock;

	// Token: 0x040006A7 RID: 1703
	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0x77")]
	private bool smoothUnLock;

	// Token: 0x040006A8 RID: 1704
	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x78")]
	private CameraShakeController _cameraShakeController;

	// Token: 0x040006A9 RID: 1705
	[Token(Token = "0x40006A9")]
	[FieldOffset(Offset = "0x80")]
	private bool reparent;

	// Token: 0x040006AA RID: 1706
	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 pos;

	// Token: 0x040006AB RID: 1707
	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0x90")]
	private float _smoothLockStartTime;

	// Token: 0x040006AC RID: 1708
	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0x94")]
	private float _degreePerSecond;
}
