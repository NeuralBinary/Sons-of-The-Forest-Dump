using System;
using Il2CppDummyDll;
using Sons.Gui;
using UnityEngine;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
[AddComponentMenu("Sons/Cutscene/SkipCutsceneUi")]
public class SkipCutsceneUi : MonoBehaviour
{
	// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x29B19E0", Offset = "0x29B09E0", VA = "0x1829B19E0")]
	private void Update()
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x29B1580", Offset = "0x29B0580", VA = "0x1829B1580")]
	private bool CheckOtherInputs()
	{
		return default(bool);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x29B18D0", Offset = "0x29B08D0", VA = "0x1829B18D0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x29B18A0", Offset = "0x29B08A0", VA = "0x1829B18A0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x29B1970", Offset = "0x29B0970", VA = "0x1829B1970")]
	private void SlideIn()
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x29B19B0", Offset = "0x29B09B0", VA = "0x1829B19B0")]
	private void SlideOut()
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x29B1B40", Offset = "0x29B0B40", VA = "0x1829B1B40")]
	public SkipCutsceneUi()
	{
	}

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	private const string ButtonEastString = "/buttonEast";

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	private const string ButtonWestString = "/buttonWest";

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	private const string LeftTriggerString = "/leftTrigger";

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	private const string RightTriggerString = "/rightTrigger";

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	private const string LeftShoulderString = "/leftShoulder";

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	private const string RightShoulderString = "/rightShoulder";

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006F")]
	private const string SpaceKeyString = "/space";

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	private const string EnterKeyString = "/enter";

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	private const string EscapeKeyString = "/escape";

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _visibleDuration;

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimateSidebarElement _sidebarElement;

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x30")]
	private bool _shownFirstTime;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x34")]
	private float _initialDelay;

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x38")]
	private float _firstUpdateTime;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x3C")]
	private float _startTime;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x40")]
	private bool _textVisible;
}
