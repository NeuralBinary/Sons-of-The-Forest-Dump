using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020002B6 RID: 694
[Token(Token = "0x20002B6")]
public class VRSwitcher : MonoBehaviour
{
	// Token: 0x0600124E RID: 4686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124E")]
	[Address(RVA = "0x31D7FA0", Offset = "0x31D65A0", VA = "0x1831D7FA0")]
	private void Awake()
	{
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124F")]
	[Address(RVA = "0x31D80E0", Offset = "0x31D66E0", VA = "0x1831D80E0")]
	public void ActivateVRDevice(VRSystemTarget target)
	{
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001250")]
	[Address(RVA = "0x31D8190", Offset = "0x31D6790", VA = "0x1831D8190")]
	private void SwitchVRRig(bool enable)
	{
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001251")]
	[Address(RVA = "0x31D8230", Offset = "0x31D6830", VA = "0x1831D8230")]
	private IEnumerator LoadAndEnable(string deviceName, bool enable)
	{
		return null;
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001252")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnGUI()
	{
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001253")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRSwitcher()
	{
	}

	// Token: 0x04001236 RID: 4662
	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x20")]
	[Header("Input")]
	public bool RunOnAwake;

	// Token: 0x04001237 RID: 4663
	[Token(Token = "0x4001237")]
	[FieldOffset(Offset = "0x28")]
	[Header("Output")]
	public UnityEvent OnEnabled;

	// Token: 0x04001238 RID: 4664
	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent OnDisabled;

	// Token: 0x04001239 RID: 4665
	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0x38")]
	public bool ShowGUI;
}
