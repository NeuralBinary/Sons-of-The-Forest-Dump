using System;
using Il2CppDummyDll;
using Sons.Gui;
using UnityEngine;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
[AddComponentMenu("Sons/Cutscene/SkipCutsceneUi")]
public class SkipCutsceneUi : MonoBehaviour
{
	// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2F692E0", Offset = "0x2F678E0", VA = "0x182F692E0")]
	private void Update()
	{
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2F69600", Offset = "0x2F67C00", VA = "0x182F69600")]
	private bool CheckOtherInputs()
	{
		return default(bool);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2F69920", Offset = "0x2F67F20", VA = "0x182F69920")]
	private void OnValidate()
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2F69A50", Offset = "0x2F68050", VA = "0x182F69A50")]
	private void OnDisable()
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2F69AE0", Offset = "0x2F680E0", VA = "0x182F69AE0")]
	private void SlideIn()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2F69B50", Offset = "0x2F68150", VA = "0x182F69B50")]
	private void SlideOut()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2F69BB0", Offset = "0x2F681B0", VA = "0x182F69BB0")]
	public SkipCutsceneUi()
	{
	}

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	private const string ButtonEastString = "/buttonEast";

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	private const string ButtonWestString = "/buttonWest";

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	private const string LeftTriggerString = "/leftTrigger";

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	private const string RightTriggerString = "/rightTrigger";

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006F")]
	private const string LeftShoulderString = "/leftShoulder";

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	private const string RightShoulderString = "/rightShoulder";

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	private const string SpaceKeyString = "/space";

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	private const string EnterKeyString = "/enter";

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x4000073")]
	private const string EscapeKeyString = "/escape";

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _visibleDuration;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimateSidebarElement _sidebarElement;

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x30")]
	private bool _shownFirstTime;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x34")]
	private float _initialDelay;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x38")]
	private float _firstUpdateTime;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x3C")]
	private float _startTime;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x40")]
	private bool _textVisible;
}
