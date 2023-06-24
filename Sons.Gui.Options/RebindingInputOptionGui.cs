using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.SmartFormat.PersistentVariables;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class RebindingInputOptionGui : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x3038850", Offset = "0x3036E50", VA = "0x183038850")]
	public void SetBindingMode(bool value)
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x30389C0", Offset = "0x3036FC0", VA = "0x1830389C0")]
	public void Awake()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3038AE0", Offset = "0x30370E0", VA = "0x183038AE0")]
	public void Update()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x3038B90", Offset = "0x3037190", VA = "0x183038B90")]
	public RebindingInputOptionGui()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Text _text;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _inputIcon;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	private float _delay;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x38")]
	private FloatVariable _delayVariable;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x40")]
	private LocalizeStringEvent _smartString;
}
