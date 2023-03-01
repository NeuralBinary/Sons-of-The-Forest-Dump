using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Multiplayer;
using Sons.Save;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Token: 0x0200002E RID: 46
[Token(Token = "0x200002E")]
public class Resin3dPrinter : BoltEntityBehaviourWrapper<IResin3dPrinterState>, ISaveGameSerializer<Resin3dPrinter.Resin3dPrinterSaveData>
{
	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000109 RID: 265 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x17000022")]
	public float MaxResinVolume
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x674370", Offset = "0x673370", VA = "0x180674370")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600010A RID: 266 RVA: 0x00002478 File Offset: 0x00000678
	[Token(Token = "0x17000023")]
	public float CurrentResinVolume
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x6743D0", Offset = "0x6733D0", VA = "0x1806743D0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600010B RID: 267 RVA: 0x00002490 File Offset: 0x00000690
	[Token(Token = "0x17000024")]
	public float ResinPercentRemaining
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x29B1140", Offset = "0x29B0140", VA = "0x1829B1140")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600010C RID: 268 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x17000025")]
	public bool IsOutOfResin
	{
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x29B0F80", Offset = "0x29AFF80", VA = "0x1829B0F80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600010D RID: 269 RVA: 0x000024C0 File Offset: 0x000006C0
	[Token(Token = "0x17000026")]
	public float PrintJobPercentComplete
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x29B1070", Offset = "0x29B0070", VA = "0x1829B1070")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600010E RID: 270 RVA: 0x000024D8 File Offset: 0x000006D8
	[Token(Token = "0x17000027")]
	public bool IsPrintJobDone
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x29B0FA0", Offset = "0x29AFFA0", VA = "0x1829B0FA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600010F RID: 271 RVA: 0x000024F0 File Offset: 0x000006F0
	[Token(Token = "0x17000028")]
	public bool IsPrinting
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x267BA70", Offset = "0x267AA70", VA = "0x18267BA70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000110 RID: 272 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x17000029")]
	public bool IsPaused
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x267BA60", Offset = "0x267AA60", VA = "0x18267BA60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000111 RID: 273 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x1700002A")]
	public Color LoadedColor
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x29B0FE0", Offset = "0x29AFFE0", VA = "0x1829B0FE0")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000112 RID: 274 RVA: 0x00002538 File Offset: 0x00000738
	[Token(Token = "0x1700002B")]
	public bool HasCompletedPrintsOnTheBed
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x29B0F30", Offset = "0x29AFF30", VA = "0x1829B0F30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000113")]
	[Address(RVA = "0x29AF4D0", Offset = "0x29AE4D0", VA = "0x1829AF4D0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x29B0870", Offset = "0x29AF870", VA = "0x1829B0870")]
	private void Start()
	{
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x29AE4B0", Offset = "0x29AD4B0", VA = "0x1829AE4B0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x29B0110", Offset = "0x29AF110", VA = "0x1829B0110")]
	private void SetupPrinterFromNetwork()
	{
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x29AF430", Offset = "0x29AE430", VA = "0x1829AF430")]
	private void OnUpdateResinAmount()
	{
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x29AF150", Offset = "0x29AE150", VA = "0x1829AF150")]
	private void OnIsPaused()
	{
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x29AF3A0", Offset = "0x29AE3A0", VA = "0x1829AF3A0")]
	private void OnUpdateCurrentTimeInPrint()
	{
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x29AE930", Offset = "0x29AD930", VA = "0x1829AE930")]
	private void Awake()
	{
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x29B0CD0", Offset = "0x29AFCD0", VA = "0x1829B0CD0")]
	private void Update()
	{
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011C")]
	[Address(RVA = "0x29B0960", Offset = "0x29AF960", VA = "0x1829B0960")]
	private void UpdateUI()
	{
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x29AFC50", Offset = "0x29AEC50", VA = "0x1829AFC50")]
	public void RefillResin(int refillAmount, bool updateNetwork = true)
	{
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x29B00E0", Offset = "0x29AF0E0", VA = "0x1829B00E0")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x6B7320", Offset = "0x6B6320", VA = "0x1806B7320")]
	public void LoadBlueprint(PrintedItemBlueprint blueprint)
	{
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x29B0750", Offset = "0x29AF750", VA = "0x1829B0750")]
	public void StartPrint(float timeInCurrentPrintJob = 0f)
	{
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x29AF7E0", Offset = "0x29AE7E0", VA = "0x1829AF7E0")]
	private IEnumerator PreparePrinter(float timeInCurrentPrintJob)
	{
		return null;
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x29AF5B0", Offset = "0x29AE5B0", VA = "0x1829AF5B0")]
	public void OutOfResinLoopActive(bool active)
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x29AF700", Offset = "0x29AE700", VA = "0x1829AF700")]
	public void PausePrint()
	{
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x29AFFC0", Offset = "0x29AEFC0", VA = "0x1829AFFC0")]
	public void ResumePrint()
	{
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x29AEA70", Offset = "0x29ADA70", VA = "0x1829AEA70")]
	public void CancelPrint()
	{
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x29AF860", Offset = "0x29AE860", VA = "0x1829AF860")]
	private void PrintingComplete()
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x29AEEA0", Offset = "0x29ADEA0", VA = "0x1829AEEA0")]
	private void ItemRemovedFromPlate(PickUp pickup)
	{
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x29AFEA0", Offset = "0x29AEEA0", VA = "0x1829AFEA0")]
	public void RemoveItem(int index)
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x29AFBE0", Offset = "0x29AEBE0", VA = "0x1829AFBE0")]
	private IEnumerator Printing()
	{
		return null;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012A")]
	[Address(RVA = "0x29AF500", Offset = "0x29AE500", VA = "0x1829AF500")]
	private void OpenLid()
	{
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x29AECE0", Offset = "0x29ADCE0", VA = "0x1829AECE0")]
	private void CloseLid()
	{
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x29AEDA0", Offset = "0x29ADDA0", VA = "0x1829AEDA0")]
	private void GrabEnter()
	{
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012D")]
	[Address(RVA = "0x29AEE80", Offset = "0x29ADE80", VA = "0x1829AEE80")]
	private void GrabExit()
	{
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x29B02A0", Offset = "0x29AF2A0", VA = "0x1829B02A0")]
	private void ShowRefillInteractIcons(bool show)
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x29AF1D0", Offset = "0x29AE1D0", VA = "0x1829AF1D0")]
	private void OnRefillResin(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x29AF040", Offset = "0x29AE040", VA = "0x1829AF040")]
	public void ItemRemovedFromPrinter(int index)
	{
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000132 RID: 306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700002C")]
	public string SerializedName
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2572F60", Offset = "0x2571F60", VA = "0x182572F60", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x29AED90", Offset = "0x29ADD90", VA = "0x1829AED90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000133 RID: 307 RVA: 0x00002550 File Offset: 0x00000750
	[Token(Token = "0x1700002D")]
	private bool UniqueFile
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000134 RID: 308 RVA: 0x00002568 File Offset: 0x00000768
	[Token(Token = "0x1700002E")]
	private bool ShouldSerialize
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000135 RID: 309 RVA: 0x00002580 File Offset: 0x00000780
	[Token(Token = "0x1700002F")]
	private bool IncludeInPlayerSave
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000136")]
	[Address(RVA = "0x29AF0F0", Offset = "0x29AE0F0", VA = "0x1829AF0F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000137")]
	[Address(RVA = "0x29B05D0", Offset = "0x29AF5D0", VA = "0x1829B05D0", Slot = "25")]
	private Resin3dPrinter.Resin3dPrinterSaveData OnSerialize()
	{
		return null;
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000138")]
	[Address(RVA = "0x29B0480", Offset = "0x29AF480", VA = "0x1829B0480", Slot = "26")]
	private void OnDeserialize(Resin3dPrinter.Resin3dPrinterSaveData data)
	{
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000139")]
	[Address(RVA = "0x29AED90", Offset = "0x29ADD90", VA = "0x1829AED90")]
	public void ConfigureSerialization(string serializedName)
	{
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x29B0E00", Offset = "0x29AFE00", VA = "0x1829B0E00")]
	public Resin3dPrinter()
	{
	}

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string _printerName;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Resin3dPrinterLaptop _connectedLaptop;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Animation _animation;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform _printedItemTransform;

	// Token: 0x04000119 RID: 281
	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform _basePlateTransform;

	// Token: 0x0400011A RID: 282
	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Light _light;

	// Token: 0x0400011B RID: 283
	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private MeshRenderer _resinVat;

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x68")]
	[FormerlySerializedAs("_openLidEvent")]
	[EventRef]
	[SerializeField]
	private string _openLidEventPath;

	// Token: 0x0400011D RID: 285
	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("_closeLidEvent")]
	[SerializeField]
	[EventRef]
	private string _closeLidEventPath;

	// Token: 0x0400011E RID: 286
	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x78")]
	[FormerlySerializedAs("_printDoneEvent")]
	[SerializeField]
	[EventRef]
	private string _printDoneEventPath;

	// Token: 0x0400011F RID: 287
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[EventRef]
	[FormerlySerializedAs("_printingActiveEvent")]
	private string _printingActiveEventPath;

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x88")]
	[EventRef]
	[SerializeField]
	private string _printBedHeightAdjustment;

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x90")]
	[EventRef]
	[SerializeField]
	private string _printingOutOfResinEventPath;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private float _currentResinVolume;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private float _maxResinVolume;

	// Token: 0x04000124 RID: 292
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private PrinterResinProperties _currentResin;

	// Token: 0x04000125 RID: 293
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Transform _uiRoot;

	// Token: 0x04000126 RID: 294
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private TextMeshProUGUI _resinVolumeRemainingUI;

	// Token: 0x04000127 RID: 295
	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private TextMeshProUGUI _printingProgressUI;

	// Token: 0x04000128 RID: 296
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Image _resinIconUI;

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private float _printSpeed;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private PrintedItemBlueprint _printedItemBlueprint;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private float _basePlateStartHeight;

	// Token: 0x0400012C RID: 300
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private float _basePlateEndHeight;

	// Token: 0x0400012D RID: 301
	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public float _basePlateMovementSpeed;

	// Token: 0x0400012E RID: 302
	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0xE4")]
	[HideInInspector]
	[SerializeField]
	private bool _isPrinting;

	// Token: 0x0400012F RID: 303
	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0xE5")]
	[SerializeField]
	[HideInInspector]
	private bool _isPaused;

	// Token: 0x04000130 RID: 304
	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0xE8")]
	[HideInInspector]
	[SerializeField]
	private float _timeInCurrentPrintJob;

	// Token: 0x04000131 RID: 305
	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0xF0")]
	public UnityEvent PrintJobPausedEvent;

	// Token: 0x04000132 RID: 306
	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0xF8")]
	public UnityEvent PrintJobCompleteEvent;

	// Token: 0x04000133 RID: 307
	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private GameObject _refillInteractionObject;

	// Token: 0x04000134 RID: 308
	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x108")]
	private bool _lidIsOpen;

	// Token: 0x04000135 RID: 309
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x109")]
	private bool _isFocused;

	// Token: 0x04000136 RID: 310
	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x10A")]
	private bool _networkPrinterLaptopSet;

	// Token: 0x04000137 RID: 311
	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x10C")]
	private int _lastResinPercentRemaining;

	// Token: 0x04000138 RID: 312
	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x110")]
	private int _lastPrintJobPercentComplete;

	// Token: 0x04000139 RID: 313
	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x118")]
	private EventInstance _printerActiveEvent;

	// Token: 0x0400013A RID: 314
	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x120")]
	private EventInstance _printBedAdjustmentEvent;

	// Token: 0x0400013B RID: 315
	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x128")]
	private EventInstance _printerOutOfResinEvent;

	// Token: 0x0400013C RID: 316
	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x130")]
	private List<GameObject> _printedItemGameObjects;

	// Token: 0x0400013D RID: 317
	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x138")]
	private float _basePlateEndHeightForCurrentPrint;

	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[Serializable]
	internal class Resin3dPrinterSaveData
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x29AE460", Offset = "0x29AD460", VA = "0x1829AE460")]
		public Resin3dPrinterSaveData()
		{
		}

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x18")]
		public float CurrentResinVolume;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x1C")]
		public float TimeInCurrentPrintJob;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x20")]
		public bool InMidPrint;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x21")]
		public bool FinishedPrintIsOnThePlate;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x24")]
		public int CurrentBlueprintId;
	}
}
