using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200010B RID: 267
[Token(Token = "0x200010B")]
public class camFollowHead : MonoBehaviour
{
	// Token: 0x17000103 RID: 259
	// (get) Token: 0x060007FA RID: 2042 RVA: 0x00004290 File Offset: 0x00002490
	[Token(Token = "0x17000103")]
	public bool IsActive
	{
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x2F46C70", Offset = "0x2F45C70", VA = "0x182F46C70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x2F467A0", Offset = "0x2F457A0", VA = "0x182F467A0")]
	public void SetFollowAnim(bool value)
	{
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x2F45290", Offset = "0x2F44290", VA = "0x182F45290")]
	private void Awake()
	{
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x2F46490", Offset = "0x2F45490", VA = "0x182F46490")]
	private void SetAnimStateProperties(string stateId, [Optional] WrapMode? wrapMode, [Optional] float? speed, [Optional] int? layer)
	{
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x2F468C0", Offset = "0x2F458C0", VA = "0x182F468C0")]
	private void Start()
	{
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x2F462D0", Offset = "0x2F452D0", VA = "0x182F462D0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x2F46B60", Offset = "0x2F45B60", VA = "0x182F46B60")]
	private void checkPlayerControl()
	{
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x2F46CF0", Offset = "0x2F45CF0", VA = "0x182F46CF0")]
	public void stopAllCameraShake()
	{
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x2F46C80", Offset = "0x2F45C80", VA = "0x182F46C80")]
	public IEnumerator startFallingShake()
	{
		return null;
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000803")]
	[Address(RVA = "0x2F46850", Offset = "0x2F45850", VA = "0x182F46850")]
	public IEnumerator StartZipLineShake()
	{
		return null;
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000804")]
	[Address(RVA = "0x2F46B50", Offset = "0x2F45B50", VA = "0x182F46B50")]
	private void Update()
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000805")]
	[Address(RVA = "0x2F46990", Offset = "0x2F45990", VA = "0x182F46990")]
	public void UpdateCamPosition()
	{
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x000042A8 File Offset: 0x000024A8
	[Token(Token = "0x6000806")]
	[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970")]
	private bool vrAllowFollow()
	{
		return default(bool);
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000807")]
	[Address(RVA = "0x2F45950", Offset = "0x2F44950", VA = "0x182F45950")]
	private void DoCamFollow()
	{
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000808")]
	[Address(RVA = "0x2F45680", Offset = "0x2F44680", VA = "0x182F45680")]
	public void BeginSmoothLock(bool shouldLookDownOnly = false, bool handleSpineLayer = true)
	{
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000809")]
	[Address(RVA = "0x2F45840", Offset = "0x2F44840", VA = "0x182F45840")]
	public void BeginSmoothUnlock(float maxSmoothDuration = 0.5f)
	{
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080A")]
	[Address(RVA = "0x2F460D0", Offset = "0x2F450D0", VA = "0x182F460D0")]
	public void InstantUnlockInPlace(bool handleSplineLayer = true)
	{
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x2F46320", Offset = "0x2F45320", VA = "0x182F46320")]
	public void RevertToUnlockedState()
	{
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080C")]
	[Address(RVA = "0x2F46C10", Offset = "0x2F45C10", VA = "0x182F46C10")]
	public void enableMouseControl(bool on)
	{
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080D")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public camFollowHead()
	{
	}

	// Token: 0x0400067C RID: 1660
	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0x20")]
	public Transform headJnt;

	// Token: 0x0400067D RID: 1661
	[Token(Token = "0x400067D")]
	[FieldOffset(Offset = "0x28")]
	private Transform thisTr;

	// Token: 0x0400067E RID: 1662
	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0x30")]
	public Transform camTr;

	// Token: 0x0400067F RID: 1663
	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0x38")]
	private playerScriptSetup setup;

	// Token: 0x04000680 RID: 1664
	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0x40")]
	private playerHitReactions reactions;

	// Token: 0x04000681 RID: 1665
	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x48")]
	public SimpleMouseRotator mouse1;

	// Token: 0x04000682 RID: 1666
	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x50")]
	public SimpleMouseRotator mouse2;

	// Token: 0x04000683 RID: 1667
	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x58")]
	public bool lookDownOnly;

	// Token: 0x04000684 RID: 1668
	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x59")]
	private bool followAnim;

	// Token: 0x04000685 RID: 1669
	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x5A")]
	public bool AllowCameraMoveFollowAnim;

	// Token: 0x04000686 RID: 1670
	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 playerCamPos;

	// Token: 0x04000687 RID: 1671
	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 startCamPos;

	// Token: 0x04000688 RID: 1672
	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private bool lockXCam;

	// Token: 0x04000689 RID: 1673
	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x75")]
	public bool lockYCam;

	// Token: 0x0400068A RID: 1674
	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x76")]
	public bool smoothLock;

	// Token: 0x0400068B RID: 1675
	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x77")]
	private bool smoothUnLock;

	// Token: 0x0400068C RID: 1676
	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x78")]
	private Animation anim;

	// Token: 0x0400068D RID: 1677
	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x80")]
	private bool reparent;

	// Token: 0x0400068E RID: 1678
	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 pos;

	// Token: 0x0400068F RID: 1679
	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x90")]
	private float _smoothLockStartTime;

	// Token: 0x04000690 RID: 1680
	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x94")]
	private float _degreePerSecond;
}
