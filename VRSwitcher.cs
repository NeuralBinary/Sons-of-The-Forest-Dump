using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020002C2 RID: 706
[Token(Token = "0x20002C2")]
public class VRSwitcher : MonoBehaviour
{
	// Token: 0x06001219 RID: 4633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001219")]
	[Address(RVA = "0x2B8BA90", Offset = "0x2B8AA90", VA = "0x182B8BA90")]
	private void Awake()
	{
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121A")]
	[Address(RVA = "0x2B8B9E0", Offset = "0x2B8A9E0", VA = "0x182B8B9E0")]
	public void ActivateVRDevice(VRSystemTarget target)
	{
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121B")]
	[Address(RVA = "0x2B8BC10", Offset = "0x2B8AC10", VA = "0x182B8BC10")]
	private void SwitchVRRig(bool enable)
	{
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600121C")]
	[Address(RVA = "0x2B8BB70", Offset = "0x2B8AB70", VA = "0x182B8BB70")]
	private IEnumerator LoadAndEnable(string deviceName, bool enable)
	{
		return null;
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121D")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void OnGUI()
	{
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121E")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRSwitcher()
	{
	}

	// Token: 0x0400120F RID: 4623
	[Token(Token = "0x400120F")]
	[FieldOffset(Offset = "0x20")]
	[Header("Input")]
	public bool RunOnAwake;

	// Token: 0x04001210 RID: 4624
	[Token(Token = "0x4001210")]
	[FieldOffset(Offset = "0x28")]
	[Header("Output")]
	public UnityEvent OnEnabled;

	// Token: 0x04001211 RID: 4625
	[Token(Token = "0x4001211")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent OnDisabled;

	// Token: 0x04001212 RID: 4626
	[Token(Token = "0x4001212")]
	[FieldOffset(Offset = "0x38")]
	public bool ShowGUI;
}
