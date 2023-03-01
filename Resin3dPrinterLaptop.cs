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
	// Token: 0x0600014A RID: 330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x29AD9D0", Offset = "0x29AC9D0", VA = "0x1829AD9D0")]
	private void Start()
	{
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014B")]
	[Address(RVA = "0x29ABEC0", Offset = "0x29AAEC0", VA = "0x1829ABEC0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014C")]
	[Address(RVA = "0x29AD4F0", Offset = "0x29AC4F0", VA = "0x1829AD4F0")]
	private void SetupPrinterFromNetwork()
	{
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014D")]
	[Address(RVA = "0x29AD240", Offset = "0x29AC240", VA = "0x1829AD240")]
	private void SetBlueprintId()
	{
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x29ADBC0", Offset = "0x29ACBC0", VA = "0x1829ADBC0")]
	private void Update()
	{
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014F")]
	[Address(RVA = "0x29AC480", Offset = "0x29AB480", VA = "0x1829AC480")]
	private void DisplayBlueprintDetails()
	{
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x29AC9A0", Offset = "0x29AB9A0", VA = "0x1829AC9A0")]
	private void GrabEnter()
	{
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000151")]
	[Address(RVA = "0x29ACC40", Offset = "0x29ABC40", VA = "0x1829ACC40")]
	private void GrabExit()
	{
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x29AD0E0", Offset = "0x29AC0E0", VA = "0x1829AD0E0")]
	private void OnStart3dPrintJob(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x29AD860", Offset = "0x29AC860", VA = "0x1829AD860")]
	public void StartPrint(bool updateNetwork = true)
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x29ACEE0", Offset = "0x29ABEE0", VA = "0x1829ACEE0")]
	private void OnCycle3dPrints(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x29AD300", Offset = "0x29AC300", VA = "0x1829AD300")]
	public void SetCurrentBlueprintIdRemotely(int id)
	{
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000156")]
	[Address(RVA = "0x29AC8D0", Offset = "0x29AB8D0", VA = "0x1829AC8D0")]
	public PrintedItemBlueprint GetBlueprintFromId(int id)
	{
		return null;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x29AD2F0", Offset = "0x29AC2F0", VA = "0x1829AD2F0")]
	public void SetBusyRemotely(bool isBusy)
	{
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x29AE420", Offset = "0x29AD420", VA = "0x1829AE420")]
	public Resin3dPrinterLaptop()
	{
	}

	// Token: 0x04000151 RID: 337
	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Resin3dPrinter _connectedPrinter;

	// Token: 0x04000152 RID: 338
	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<PrintedItemBlueprint> _availableBlueprints;

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform _printSelectionGroup;

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform _printInProgressGroup;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform _noPrinterConnectedGroup;

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform _printCompletedGroup;

	// Token: 0x04000157 RID: 343
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform _outOfResinGroup;

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform _cycleButton;

	// Token: 0x04000159 RID: 345
	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform _startPrintJobButton;

	// Token: 0x0400015A RID: 346
	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private RawImage _currentBlueprintIcon;

	// Token: 0x0400015B RID: 347
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private RawImage _previousBlueprintIcon;

	// Token: 0x0400015C RID: 348
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private RawImage _nextBlueprintIcon;

	// Token: 0x0400015D RID: 349
	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private TextMeshProUGUI _blueprintName;

	// Token: 0x0400015E RID: 350
	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private TextMeshProUGUI _totalPrintTime;

	// Token: 0x0400015F RID: 351
	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private TextMeshProUGUI _requiredResinVolume;

	// Token: 0x04000160 RID: 352
	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private TextMeshProUGUI _loadedResinVolume;

	// Token: 0x04000161 RID: 353
	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Image _loadedResinColor;

	// Token: 0x04000162 RID: 354
	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private TextMeshProUGUI _printInProgress;

	// Token: 0x04000163 RID: 355
	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Transform _progressBar;

	// Token: 0x04000164 RID: 356
	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0xC8")]
	private int _currentBlueprintIndex;

	// Token: 0x04000165 RID: 357
	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0xCC")]
	private bool _isFocused;

	// Token: 0x04000166 RID: 358
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0xCD")]
	private bool _isBusy;

	// Token: 0x04000167 RID: 359
	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0xCE")]
	private bool _networkPrinterSet;

	// Token: 0x04000168 RID: 360
	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0xCF")]
	private bool _hasPrinted;
}
