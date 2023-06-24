using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;
using UnityEngine.InputSystem;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class PortableLight : MonoBehaviour
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2FF7350", Offset = "0x2FF5950", VA = "0x182FF7350")]
	private void SetLightStateInInspector()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2FF7420", Offset = "0x2FF5A20", VA = "0x182FF7420")]
	private void Start()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2FF7660", Offset = "0x2FF5C60", VA = "0x182FF7660")]
	private void OnEnable()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2FF7670", Offset = "0x2FF5C70", VA = "0x182FF7670")]
	public void OnBroken()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2FF76A0", Offset = "0x2FF5CA0", VA = "0x182FF76A0")]
	public void ToggleLight(bool enable)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2FF78B0", Offset = "0x2FF5EB0", VA = "0x182FF78B0")]
	private void SetupLinkUi()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2FF7B00", Offset = "0x2FF6100", VA = "0x182FF7B00")]
	public void ToggleIcon(bool enable)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2FF7E40", Offset = "0x2FF6440", VA = "0x182FF7E40")]
	private void OnUseInput(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2FF7E50", Offset = "0x2FF6450", VA = "0x182FF7E50")]
	public void OnGrabEnter()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2FF7E80", Offset = "0x2FF6480", VA = "0x182FF7E80")]
	public void OnGrabExit()
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2FF7EA0", Offset = "0x2FF64A0", VA = "0x182FF7EA0")]
	public PortableLight()
	{
	}

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Light _light;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _isOn;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GrabNode _grabNode;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[EventRef]
	private string _switchOnOffEvent;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[HideInInspector]
	protected LinkUiElement _linkUiElement;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x48")]
	public GameObject _interactionElement;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x50")]
	private bool _grabEnabled;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x51")]
	private bool _isBroken;
}
