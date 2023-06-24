using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gui
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[DefaultExecutionOrder(51)]
	public class UiManager : MonoBehaviour
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x17000018")]
		public static bool IsUiActive
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x301C1D0", Offset = "0x301A7D0", VA = "0x18301C1D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x17000019")]
		public static bool IsHudActive
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x301C2D0", Offset = "0x301A8D0", VA = "0x18301C2D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000201 RID: 513 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x1700001A")]
		public static bool IsInWorldUiActive
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x301C3D0", Offset = "0x301A9D0", VA = "0x18301C3D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x1700001B")]
		public static bool IsProjectileRecticleUiActive
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x301C4D0", Offset = "0x301AAD0", VA = "0x18301C4D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000203 RID: 515 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x1700001C")]
		public static bool IsPlayerNameTagsUiActive
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x301C520", Offset = "0x301AB20", VA = "0x18301C520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000B")]
		public static event Action<UiManager> OnInstanceCreated
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x301C570", Offset = "0x301AB70", VA = "0x18301C570")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x301C700", Offset = "0x301AD00", VA = "0x18301C700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x301C890", Offset = "0x301AE90", VA = "0x18301C890")]
		public void SortElements()
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x301C9F0", Offset = "0x301AFF0", VA = "0x18301C9F0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x301CB20", Offset = "0x301B120", VA = "0x18301CB20")]
		private void PushUiElementsToMonos()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x301CE40", Offset = "0x301B440", VA = "0x18301CE40")]
		private void CleanupInstance()
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x301CFD0", Offset = "0x301B5D0", VA = "0x18301CFD0")]
		private bool SetupInstance()
		{
			return default(bool);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x301D350", Offset = "0x301B950", VA = "0x18301D350")]
		private void CheckLoadingFromTitle()
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x301D430", Offset = "0x301BA30", VA = "0x18301D430")]
		private void SetShowInternal(bool enable)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x301D680", Offset = "0x301BC80", VA = "0x18301D680")]
		private void Awake()
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x301D690", Offset = "0x301BC90", VA = "0x18301D690")]
		private void Update()
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x301D910", Offset = "0x301BF10", VA = "0x18301D910")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x301DAC0", Offset = "0x301C0C0", VA = "0x18301DAC0")]
		private void UpdateAuto(UiElement element)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x301DD10", Offset = "0x301C310", VA = "0x18301DD10")]
		private void UpdateWorldSpace(UiElement element, [Optional] Transform elementTransform)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x301E0B0", Offset = "0x301C6B0", VA = "0x18301E0B0")]
		private static void UpdateScreenSpace(UiElement element, [Optional] RectTransform elementRt)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x301E6B0", Offset = "0x301CCB0", VA = "0x18301E6B0")]
		private static void GetTransforms(UiElement element, out RectTransform elementRectTransform, out Transform elementTransform)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x301CE40", Offset = "0x301B440", VA = "0x18301CE40")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x301E810", Offset = "0x301CE10", VA = "0x18301E810")]
		private UiElement FindElement(string id, GameObject uiGameObject)
		{
			return null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x301E870", Offset = "0x301CE70", VA = "0x18301E870")]
		private UiElement FindElement(int hash, GameObject uiGameObject)
		{
			return null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x301EA80", Offset = "0x301D080", VA = "0x18301EA80")]
		private GameObject SetActiveInternal(string id, bool value)
		{
			return null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x301EB10", Offset = "0x301D110", VA = "0x18301EB10")]
		private GameObject SetActiveInternal(int idHash, bool value, Vector3 worldPos, Quaternion worldRotation, bool alwaysFaceCamera, GameObject uiGameObject)
		{
			return null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x301EC50", Offset = "0x301D250", VA = "0x18301EC50")]
		public static GameObject SetActive(string id, bool value)
		{
			return null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x301EDC0", Offset = "0x301D3C0", VA = "0x18301EDC0")]
		public static GameObject SetActive(int idHash, bool value, Vector3 worldPos, Quaternion worldRotation, GameObject uiGameObject)
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x301EF30", Offset = "0x301D530", VA = "0x18301EF30")]
		public static GameObject SetActive(string id, bool value, Vector3 worldPos, bool alwaysFaceCamera)
		{
			return null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x301F100", Offset = "0x301D700", VA = "0x18301F100")]
		public static void SetShowAllOffUserOverride(bool value)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x301F150", Offset = "0x301D750", VA = "0x18301F150")]
		public static void SetShowHudOffUserOverride(bool value)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x301F1A0", Offset = "0x301D7A0", VA = "0x18301F1A0")]
		public static void SetShowMiniMapOffHudUserOverride(bool value)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x301F1F0", Offset = "0x301D7F0", VA = "0x18301F1F0")]
		public static void ShowInWorldUiOffUserOverride(bool value)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x301F240", Offset = "0x301D840", VA = "0x18301F240")]
		public static void SetShowBuildingUiOffUserOverride(bool value)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x301F290", Offset = "0x301D890", VA = "0x18301F290")]
		public static void SetShowTutorialsUiOffUserOverride(bool value)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x301F2E0", Offset = "0x301D8E0", VA = "0x18301F2E0")]
		public static void SetShowProjectileReticleUiOffUserOverride(bool value)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x301F330", Offset = "0x301D930", VA = "0x18301F330")]
		public static void SetShowPlayerNameTagsUiOffUserOverride(bool value)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x301F380", Offset = "0x301D980", VA = "0x18301F380")]
		private static void Refresh()
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x301F630", Offset = "0x301DC30", VA = "0x18301F630")]
		public static void SetShowAll(bool value)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x301F730", Offset = "0x301DD30", VA = "0x18301F730")]
		public static void SetShowHudAndWorldUi(bool enable)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x301F750", Offset = "0x301DD50", VA = "0x18301F750")]
		public static void SetShowHud(bool enable)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x301F8D0", Offset = "0x301DED0", VA = "0x18301F8D0")]
		private void RefreshShowHud()
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x301F930", Offset = "0x301DF30", VA = "0x18301F930")]
		private void RefreshShowMiniMap()
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x301F9B0", Offset = "0x301DFB0", VA = "0x18301F9B0")]
		private void RefreshShowWorldUi()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x301FA10", Offset = "0x301E010", VA = "0x18301FA10")]
		private void RefreshShowBuildingUi()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x301FA70", Offset = "0x301E070", VA = "0x18301FA70")]
		private void RefreshShowTutorialsUi()
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x301FAD0", Offset = "0x301E0D0", VA = "0x18301FAD0")]
		private void RefreshElements(List<Transform> elements, bool baseIsActive, bool userOffOverride)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x301FD20", Offset = "0x301E320", VA = "0x18301FD20")]
		public static void SetShowMiniMapHud(bool enable)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x301FE40", Offset = "0x301E440", VA = "0x18301FE40")]
		public static void SetShowBuildingUi(bool enable)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x301FFA0", Offset = "0x301E5A0", VA = "0x18301FFA0")]
		public static void SetShowTutorialsUi(bool enable)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x3020100", Offset = "0x301E700", VA = "0x183020100")]
		public static void SetShowInWorldUi(bool enable)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x3020260", Offset = "0x301E860", VA = "0x183020260")]
		public static GameObject RequestPooled(int idHash)
		{
			return null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x3020390", Offset = "0x301E990", VA = "0x183020390")]
		private UiElement RequestPooledInternal(int idHash)
		{
			return null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x30203C0", Offset = "0x301E9C0", VA = "0x1830203C0")]
		public static void ReturnPooled(int idHash, GameObject uiGameObject)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x3020580", Offset = "0x301EB80", VA = "0x183020580")]
		private void ReturnPooledInternal(int idHash, GameObject uiGameObject)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x301BE80", Offset = "0x301A480", VA = "0x18301BE80")]
		public static void RegisterUiElement(UiElementMono uiElementMono)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x301C020", Offset = "0x301A620", VA = "0x18301C020")]
		public static void UnregisterUiElement(UiElementMono uiElementMono)
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x30205D0", Offset = "0x301EBD0", VA = "0x1830205D0")]
		public static void SetHudScale(float value)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x30206F0", Offset = "0x301ECF0", VA = "0x1830206F0")]
		private void RefreshHudScale()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x3020C90", Offset = "0x301F290", VA = "0x183020C90")]
		public UiManager()
		{
		}

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UiManager _instance;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<UiElement> _elements;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _allUiExceptMenuElements;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Transform> _hudElements;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Transform> _hudScaleElements;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_inWorldElements")]
		private List<Transform> _inWorldUiElements;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Transform> _miniMapElements;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("_buildingElements")]
		private List<Transform> _buildingUiElements;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FormerlySerializedAs("_tutorialsElements")]
		private List<Transform> _tutorialsUiElements;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _uiIsActive;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _worldPosLerpSpeed;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[FormerlySerializedAs("_loadScene")]
		private GuidReference _loadSceneReference;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<UiElement> _followWorldPosElements;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool _hudIsActive;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool _miniMapHudIsActive;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		private bool _tutorialsUiIsActive;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		private bool _inWorldUiIsActive;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool _buildingUiIsActive;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _allOffUserOverride;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool _hudOffUserOverride;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private static bool _miniMapOffUserOverride;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		private static bool _inWorldUiOffUserOverride;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static bool _buildingUiOffUserOverride;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		private static bool _tutorialsUiOffUserOverride;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		private static bool _projectileReticleUiOffUserOverride;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		private static bool _playerNameTagsUiOffUserOverride;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _hudScale;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Vector3> _hudScaleElementsBaseScales;
	}
}
