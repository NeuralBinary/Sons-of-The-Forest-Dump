using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace MTAssets.UltimateLODSystem
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[AddComponentMenu("MT Assets/Ultimate LOD System/Ultimate Level Of Detail")]
	[ExecuteInEditMode]
	public class UltimateLevelOfDetail : MonoBehaviour
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		public Transform customPivotToSimulateLods
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x5EE3A0", Offset = "0x5EC9A0", VA = "0x1805EE3A0")]
			set
			{
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x5EE670", Offset = "0x5ECC70", VA = "0x1805EE670")]
		private void ValidateAllParameters(bool isGoingToScan)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void CreateHierarchyOfFoldersIfNotExists()
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x5EE8F0", Offset = "0x5ECEF0", VA = "0x1805EE8F0")]
		private string SaveGeneratedLodInAssets(string lodNumber, long ticks, Mesh generatedLodMesh)
		{
			return null;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x5EE920", Offset = "0x5ECF20", VA = "0x1805EE920")]
		private Mesh GetGeneratedLodForThisMesh(Mesh originalMesh, float percentOfVertices, bool isSkinnedMesh)
		{
			return null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x5EEB40", Offset = "0x5ED140", VA = "0x1805EEB40")]
		private Material[] GetCopyOfExistentArrayOfMaterials(Material[] sourceArray)
		{
			return null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x5EED00", Offset = "0x5ED300", VA = "0x1805EED00")]
		private void ScanForMeshesAndGenerateAllLodGroups_StartProcessing(bool showProgressBar)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x5EEDA0", Offset = "0x5ED3A0", VA = "0x1805EEDA0")]
		private IEnumerator ScanForMeshesAndGenerateAllLodGroups_AsyncProcessing(bool showProgressBar)
		{
			return null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x5EEE30", Offset = "0x5ED430", VA = "0x1805EEE30")]
		private void UndoAllMeshesScannedAndAllLodGroups(bool showProgressBar, bool deleteAllGeneratedMeshes, bool runMonoIl2CppGc, bool runUnityGc)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
		private bool isLodsSimulationEnabledInThisSceneForEditorSceneViewMode()
		{
			return default(bool);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
		private Camera GetLastActiveSceneViewCamera()
		{
			return null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x5EF5B0", Offset = "0x5EDBB0", VA = "0x1805EF5B0")]
		private void CullThisLodMeshOfRenderer(UltimateLevelOfDetail.ScannedMeshItem meshItem)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x5EFA50", Offset = "0x5EE050", VA = "0x1805EFA50")]
		private void UncullThisLodMeshOfRenderer(UltimateLevelOfDetail.ScannedMeshItem meshItem)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x5EFE90", Offset = "0x5EE490", VA = "0x1805EFE90")]
		private void ChangeLodMeshAndMaterialsOfRenderer(UltimateLevelOfDetail.ScannedMeshItem meshItem, int lodLevel)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x5F0280", Offset = "0x5EE880", VA = "0x1805F0280")]
		private void CalculateCorrectLodForDistanceBeforeChange(float distance)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x5F0700", Offset = "0x5EED00", VA = "0x1805F0700")]
		public void OnRenderObject()
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x5F14A0", Offset = "0x5EFAA0", VA = "0x1805F14A0")]
		public void Awake()
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x5F1A20", Offset = "0x5F0020", VA = "0x1805F1A20")]
		private IEnumerator OnRenderObject_HookEmulationForHDRP()
		{
			return null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x5F1AB0", Offset = "0x5F00B0", VA = "0x1805F1AB0")]
		public void OnEnable()
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x5F1CB0", Offset = "0x5F02B0", VA = "0x1805F1CB0")]
		public int GetCurrentLodLevel()
		{
			return 0;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x5F1D00", Offset = "0x5F0300", VA = "0x1805F1D00")]
		public float GetCurrentCameraDistance()
		{
			return 0f;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
		public float GetCurrentRealCameraDistance()
		{
			return 0f;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x5F1D20", Offset = "0x5F0320", VA = "0x1805F1D20")]
		public int GetNumberOfLodsGenerated()
		{
			return 0;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x5F1D70", Offset = "0x5F0370", VA = "0x1805F1D70")]
		public bool isScannedMeshesCurrentCulled()
		{
			return default(bool);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x5F1D80", Offset = "0x5F0380", VA = "0x1805F1D80")]
		public UltimateLevelOfDetailMeshes[] GetListOfAllMeshesScanned()
		{
			return null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x5F1F90", Offset = "0x5F0590", VA = "0x1805F1F90")]
		public void ForceShowLod(bool force, int level)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x5F2100", Offset = "0x5F0700", VA = "0x1805F2100")]
		public bool isThisComponentForcedToShowLod()
		{
			return default(bool);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
		public void ForceDisableLodChangesInThisComponent(bool force)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
		public bool isThisComponentForcedToDisableLodChanges()
		{
			return default(bool);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x5F2130", Offset = "0x5F0730", VA = "0x1805F2130")]
		public void ForceThisComponentToUpdateLodsRender()
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x5F21C0", Offset = "0x5F07C0", VA = "0x1805F21C0")]
		public bool isMeshesCurrentScannedAndLodsWorkingInThisComponent()
		{
			return default(bool);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x5F2210", Offset = "0x5F0810", VA = "0x1805F2210")]
		public void ScanAllMeshesAndGenerateLodsGroups()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x5F23F0", Offset = "0x5F09F0", VA = "0x1805F23F0")]
		public void UndoCurrentScanWorkingAndDeleteGeneratedMeshes(bool runMonoIl2CppGc, bool runUnityGc)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x5F2570", Offset = "0x5F0B70", VA = "0x1805F2570")]
		public UltimateLevelOfDetail[] GetListOfAllUlodsInThisScene()
		{
			return null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x5F2670", Offset = "0x5F0C70", VA = "0x1805F2670")]
		public UltimateLevelOfDetailOptimizer[] GetListOfAllUlodsOptimizerInThisScene()
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x5F2780", Offset = "0x5F0D80", VA = "0x1805F2780")]
		public void SetNewCustomCameraForThisAndAllUlodsInThisScene(Camera newCustomCamera)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x5F2A30", Offset = "0x5F1030", VA = "0x1805F2A30")]
		public void ConvertThisToDefaultUnityLods()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x5F3CD0", Offset = "0x5F22D0", VA = "0x1805F3CD0")]
		public UltimateLevelOfDetail()
		{
		}

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x20")]
		private WaitForEndOfFrame WAIT_FOR_END_OF_FRAME;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x28")]
		private Camera cacheOfMainCamera;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x30")]
		private GameObject cacheOfUlodData;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x38")]
		private RuntimeInstancesDetector cacheOfUlodDataRuntimeInstancesDetector;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x40")]
		private float lastDistanceFromMainCamera;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x44")]
		private int currentLodAccordingToDistance;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x48")]
		private float currentDistanceFromMainCamera;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x4C")]
		private float currentRealDistanceFromMainCamera;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x50")]
		private bool forcedToDisableLodsOfThisComponent;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x54")]
		private int forcedToShowOnlyALodIndependentOfDistance;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public List<UltimateLevelOfDetail.ScannedMeshItem> currentScannedMeshesList;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public UltimateLevelOfDetail.ScanMeshesMode modeOfMeshesScanning;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x64")]
		[HideInInspector]
		public bool scanInactiveGameObjects;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public List<GameObject> gameObjectsToIgnore;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public int levelsOfDetailToGenerate;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public float[] percentOfVerticesForEachLod;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public bool saveGeneratedLodsInAssets;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x81")]
		[HideInInspector]
		public bool skinnedAnimsCompatibilityMode;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x82")]
		[HideInInspector]
		public bool preventArtifacts;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x83")]
		[HideInInspector]
		public bool optimizeResultingMeshes;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x84")]
		[HideInInspector]
		public bool enableLightmapsSupport;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x85")]
		[HideInInspector]
		public bool enableMaterialsChanges;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public UltimateLevelOfDetail.ForceOfSimplification forceOfSimplification;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x8C")]
		[HideInInspector]
		public UltimateLevelOfDetail.CullingMode cullingMode;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private Transform _customPivotToSimulateLods;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public UltimateLevelOfDetail.CameraDetectionMode cameraDetectionMode;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x9C")]
		[HideInInspector]
		public bool useCacheForMainCameraInDetection;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Camera customCameraForSimulationOfLods;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public float[] minDistanceOfViewForEachLod;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public float minDistanceOfViewForCull;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onDoneScan;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0xC0")]
		public UnityEvent onUndoScan;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		public bool forceChangeLodsOfSkinnedInEditor;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0xC9")]
		[HideInInspector]
		public bool drawGizmoOnThisPivot;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0xCC")]
		[HideInInspector]
		public Color colorOfGizmo;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0xDC")]
		[HideInInspector]
		public float sizeOfGizmo;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0xE0")]
		[HideInInspector]
		public bool forceShowHiddenSettings;

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		public enum ScanMeshesMode
		{
			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			ScanInChildrenGameObjectsOnly,
			// Token: 0x04000289 RID: 649
			[Token(Token = "0x4000289")]
			ScanInThisGameObjectOnly
		}

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		public enum ForceOfSimplification
		{
			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400028B")]
			Normal,
			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			Strong,
			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			VeryStrong,
			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			ExtremelyStrong,
			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			Destroyer
		}

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		public enum CullingMode
		{
			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			Disabled,
			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			CullingMeshes,
			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			CullingRenderer
		}

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		public enum CameraDetectionMode
		{
			// Token: 0x04000295 RID: 661
			[Token(Token = "0x4000295")]
			CurrentCamera,
			// Token: 0x04000296 RID: 662
			[Token(Token = "0x4000296")]
			MainCamera,
			// Token: 0x04000297 RID: 663
			[Token(Token = "0x4000297")]
			CustomCamera
		}

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		[Serializable]
		public class ScannedMeshItem
		{
			// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x5F4020", Offset = "0x5F2620", VA = "0x1805F4020")]
			public void InitializeAllMeshLodsMaterialsArray()
			{
			}

			// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x5F4260", Offset = "0x5F2860", VA = "0x1805F4260")]
			public ScannedMeshItem()
			{
			}

			// Token: 0x04000298 RID: 664
			[Token(Token = "0x4000298")]
			[FieldOffset(Offset = "0x10")]
			public GameObject originalGameObject;

			// Token: 0x04000299 RID: 665
			[Token(Token = "0x4000299")]
			[FieldOffset(Offset = "0x18")]
			public SkinnedMeshRenderer originalSkinnedMeshRenderer;

			// Token: 0x0400029A RID: 666
			[Token(Token = "0x400029A")]
			[FieldOffset(Offset = "0x20")]
			public MeshFilter originalMeshFilter;

			// Token: 0x0400029B RID: 667
			[Token(Token = "0x400029B")]
			[FieldOffset(Offset = "0x28")]
			public MeshRenderer originalMeshRenderer;

			// Token: 0x0400029C RID: 668
			[Token(Token = "0x400029C")]
			[FieldOffset(Offset = "0x30")]
			public Mesh[] allMeshLods;

			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			[FieldOffset(Offset = "0x38")]
			public string[] allMeshLodsPaths;

			// Token: 0x0400029E RID: 670
			[Token(Token = "0x400029E")]
			[FieldOffset(Offset = "0x40")]
			public bool canChangeMaterialsOnThisMeshLods;

			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			[FieldOffset(Offset = "0x48")]
			public UltimateLevelOfDetail.ScannedMeshItem.MeshMaterials[] allMeshLodsMaterials;

			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			[FieldOffset(Offset = "0x50")]
			public UltimateLevelOfDetailMeshes originalMeshLodsManager;

			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			[FieldOffset(Offset = "0x58")]
			public Mesh beforeCullingData_lastMeshOfThis;

			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			[FieldOffset(Offset = "0x60")]
			public bool beforeCullingData_isForcedToRenderizationOff;

			// Token: 0x0200005C RID: 92
			[Token(Token = "0x200005C")]
			[Serializable]
			public class MeshMaterials
			{
				// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000156")]
				[Address(RVA = "0x5F43E0", Offset = "0x5F29E0", VA = "0x1805F43E0")]
				public MeshMaterials()
				{
				}

				// Token: 0x040002A3 RID: 675
				[Token(Token = "0x40002A3")]
				[FieldOffset(Offset = "0x10")]
				public Material[] materialArray;
			}
		}
	}
}
