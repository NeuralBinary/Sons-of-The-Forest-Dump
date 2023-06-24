using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000036")]
[AddComponentMenu("Sons/Gameplay/BatteryIndicator")]
public class BatteryIndicator : MonoBehaviour
{
	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000168 RID: 360 RVA: 0x00002640 File Offset: 0x00000840
	[Token(Token = "0x17000034")]
	public bool IsLowPower
	{
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2F7D480", Offset = "0x2F7BA80", VA = "0x182F7D480")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x2F7D490", Offset = "0x2F7BA90", VA = "0x182F7D490")]
	private void Start()
	{
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x2F7D4A0", Offset = "0x2F7BAA0", VA = "0x182F7D4A0")]
	private void InitMaterial()
	{
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x2F7D810", Offset = "0x2F7BE10", VA = "0x182F7D810")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x2F7D8F0", Offset = "0x2F7BEF0", VA = "0x182F7D8F0")]
	private void Update()
	{
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x2F7DA60", Offset = "0x2F7C060", VA = "0x182F7DA60")]
	public void SetPowerLevel(float powerLevel)
	{
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016E")]
	[Address(RVA = "0x2F7DE20", Offset = "0x2F7C420", VA = "0x182F7DE20")]
	public BatteryIndicator()
	{
	}

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _percentRemaining;

	// Token: 0x0400016E RID: 366
	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Color _segmentColor;

	// Token: 0x0400016F RID: 367
	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Color _lowPowerColor;

	// Token: 0x04000170 RID: 368
	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _lowPowerPercent;

	// Token: 0x04000171 RID: 369
	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _lowPowerFlashSpeed;

	// Token: 0x04000172 RID: 370
	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _segmentsRoot;

	// Token: 0x04000173 RID: 371
	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool _useUi;

	// Token: 0x04000174 RID: 372
	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<Renderer> _segments;

	// Token: 0x04000175 RID: 373
	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<RawImage> _uiSegments;

	// Token: 0x04000176 RID: 374
	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x70")]
	private Material _material;

	// Token: 0x04000177 RID: 375
	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x78")]
	private float _lastFlashTriggered;
}
