using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000036")]
[AddComponentMenu("Sons/Gameplay/BatteryIndicator")]
public class BatteryIndicator : MonoBehaviour
{
	// Token: 0x17000034 RID: 52
	// (get) Token: 0x0600015F RID: 351 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x17000034")]
	public bool IsLowPower
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x299CED0", Offset = "0x299BED0", VA = "0x18299CED0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x299CD80", Offset = "0x299BD80", VA = "0x18299CD80")]
	private void Start()
	{
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x299C9B0", Offset = "0x299B9B0", VA = "0x18299C9B0")]
	private void InitMaterial()
	{
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x299CB90", Offset = "0x299BB90", VA = "0x18299CB90")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000163")]
	[Address(RVA = "0x299CD90", Offset = "0x299BD90", VA = "0x18299CD90")]
	private void Update()
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x299CBE0", Offset = "0x299BBE0", VA = "0x18299CBE0")]
	public void SetPowerLevel(float powerLevel)
	{
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x299CE20", Offset = "0x299BE20", VA = "0x18299CE20")]
	public BatteryIndicator()
	{
	}

	// Token: 0x0400016B RID: 363
	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _percentRemaining;

	// Token: 0x0400016C RID: 364
	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Color _segmentColor;

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Color _lowPowerColor;

	// Token: 0x0400016E RID: 366
	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _lowPowerPercent;

	// Token: 0x0400016F RID: 367
	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _lowPowerFlashSpeed;

	// Token: 0x04000170 RID: 368
	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _segmentsRoot;

	// Token: 0x04000171 RID: 369
	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<Renderer> _segments;

	// Token: 0x04000172 RID: 370
	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x60")]
	private Material _material;

	// Token: 0x04000173 RID: 371
	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x68")]
	private float _lastFlashTriggered;
}
