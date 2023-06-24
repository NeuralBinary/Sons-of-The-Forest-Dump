using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Multiplayer;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Token: 0x02000033 RID: 51
[Token(Token = "0x2000033")]
public class Resin3dPrinterLaptop : BoltEntityBehaviourWrapper<IResin3dPrinterLaptopState>
{
	// Token: 0x06000153 RID: 339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x2F7A040", Offset = "0x2F78640", VA = "0x182F7A040")]
	private void Start()
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x2F7A170", Offset = "0x2F78770", VA = "0x182F7A170", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x2F7A8E0", Offset = "0x2F78EE0", VA = "0x182F7A8E0")]
	private void SetupPrinterFromNetwork()
	{
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000156")]
	[Address(RVA = "0x2F7AE10", Offset = "0x2F79410", VA = "0x182F7AE10")]
	private void SetBlueprintId()
	{
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x2F7AEC0", Offset = "0x2F794C0", VA = "0x182F7AEC0")]
	private void Update()
	{
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x2F7BDD0", Offset = "0x2F7A3D0", VA = "0x182F7BDD0")]
	private void DisplayBlueprintDetails()
	{
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x2F7C3F0", Offset = "0x2F7A9F0", VA = "0x182F7C3F0")]
	private void GrabEnter()
	{
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x2F7C740", Offset = "0x2F7AD40", VA = "0x182F7C740")]
	private void GrabExit()
	{
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x2F7CA90", Offset = "0x2F7B090", VA = "0x182F7CA90")]
	private void OnStart3dPrintJob(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x2F7CAA0", Offset = "0x2F7B0A0", VA = "0x182F7CAA0")]
	public void StartPrint(bool updateNetwork = true)
	{
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x2F7CC70", Offset = "0x2F7B270", VA = "0x182F7CC70")]
	private void OnCycle3dPrints(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x2F7CF80", Offset = "0x2F7B580", VA = "0x182F7CF80")]
	public void SetCurrentBlueprintIdRemotely(int id)
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2F7D1D0", Offset = "0x2F7B7D0", VA = "0x182F7D1D0")]
	public PrintedItemBlueprint GetBlueprintFromId(int id)
	{
		return null;
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x2F7D290", Offset = "0x2F7B890", VA = "0x182F7D290")]
	public void SetBusyRemotely(bool isBusy)
	{
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x2F7D2A0", Offset = "0x2F7B8A0", VA = "0x182F7D2A0")]
	public Resin3dPrinterLaptop()
	{
	}

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Resin3dPrinter _connectedPrinter;

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<PrintedItemBlueprint> _availableBlueprints;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform _printSelectionGroup;

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform _printInProgressGroup;

	// Token: 0x04000157 RID: 343
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform _noPrinterConnectedGroup;

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform _printCompletedGroup;

	// Token: 0x04000159 RID: 345
	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform _outOfResinGroup;

	// Token: 0x0400015A RID: 346
	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform _cycleButton;

	// Token: 0x0400015B RID: 347
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform _startPrintJobButton;

	// Token: 0x0400015C RID: 348
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private RawImage _currentBlueprintIcon;

	// Token: 0x0400015D RID: 349
	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private RawImage _previousBlueprintIcon;

	// Token: 0x0400015E RID: 350
	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private RawImage _nextBlueprintIcon;

	// Token: 0x0400015F RID: 351
	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private TextMeshProUGUI _blueprintName;

	// Token: 0x04000160 RID: 352
	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private TextMeshProUGUI _totalPrintTime;

	// Token: 0x04000161 RID: 353
	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private TextMeshProUGUI _requiredResinVolume;

	// Token: 0x04000162 RID: 354
	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private TextMeshProUGUI _loadedResinVolume;

	// Token: 0x04000163 RID: 355
	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Image _loadedResinColor;

	// Token: 0x04000164 RID: 356
	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private TextMeshProUGUI _printInProgress;

	// Token: 0x04000165 RID: 357
	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Transform _progressBar;

	// Token: 0x04000166 RID: 358
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0xC8")]
	private int _currentBlueprintIndex;

	// Token: 0x04000167 RID: 359
	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0xCC")]
	private bool _isFocused;

	// Token: 0x04000168 RID: 360
	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0xCD")]
	private bool _isBusy;

	// Token: 0x04000169 RID: 361
	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0xCE")]
	private bool _networkPrinterSet;

	// Token: 0x0400016A RID: 362
	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0xCF")]
	private bool _hasPrinted;
}
