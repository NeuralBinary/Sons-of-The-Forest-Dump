using System;
using System.Collections.Generic;
using Endnight.Utilities;
using Il2CppDummyDll;
using PathologicalGames;
using Sons.Ai.Vail;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Characters
{
	// Token: 0x020007FC RID: 2044
	[Token(Token = "0x20007FC")]
	[AddComponentMenu("Sons/Characters/Simple Animal Zone")]
	[RequireComponent(typeof(BoundsShape))]
	public class SimpleAnimalZone : MonoBehaviour, ISimpleSpawner, ISpawner
	{
		// Token: 0x0600361D RID: 13853 RVA: 0x0000FA80 File Offset: 0x0000DC80
		[Token(Token = "0x600361D")]
		[Address(RVA = "0x5F2450", Offset = "0x5F1450", VA = "0x1805F2450")]
		private bool ShowActivate()
		{
			return default(bool);
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x0000FA98 File Offset: 0x0000DC98
		[Token(Token = "0x600361E")]
		[Address(RVA = "0x8A27A0", Offset = "0x8A17A0", VA = "0x1808A27A0")]
		public bool ShowPathOptions()
		{
			return default(bool);
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		[Token(Token = "0x600361F")]
		[Address(RVA = "0x20452A0", Offset = "0x20442A0", VA = "0x1820452A0", Slot = "6")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003620")]
		[Address(RVA = "0x2E99880", Offset = "0x2E98880", VA = "0x182E99880")]
		private void OnValidate()
		{
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003621")]
		[Address(RVA = "0x2E9A100", Offset = "0x2E99100", VA = "0x182E9A100")]
		private void Start()
		{
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003622")]
		[Address(RVA = "0x2E99B80", Offset = "0x2E98B80", VA = "0x182E99B80")]
		public void ResetCount()
		{
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003623")]
		[Address(RVA = "0x2E99340", Offset = "0x2E98340", VA = "0x182E99340")]
		public void Init(float width, float depth, int count)
		{
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003624")]
		[Address(RVA = "0x2E997B0", Offset = "0x2E987B0", VA = "0x182E997B0", Slot = "10")]
		public void OnLoad(VailWorldSimulation.VailSpawnerData saveData)
		{
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003625")]
		[Address(RVA = "0x2E992D0", Offset = "0x2E982D0", VA = "0x182E992D0", Slot = "11")]
		public VailWorldSimulation.VailSpawnerData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[Token(Token = "0x6003626")]
		[Address(RVA = "0x2E99E60", Offset = "0x2E98E60", VA = "0x182E99E60")]
		private bool SpawnAnimal(bool checkIsVisible)
		{
			return default(bool);
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003627")]
		[Address(RVA = "0x2E999E0", Offset = "0x2E989E0", VA = "0x182E999E0")]
		private void RemoveNullOrDisabled(ref List<SimpleAnimal> targetList)
		{
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		[Token(Token = "0x6003628")]
		[Address(RVA = "0x2E993E0", Offset = "0x2E983E0", VA = "0x182E993E0")]
		private bool IsWinter()
		{
			return default(bool);
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003629")]
		[Address(RVA = "0x2E99480", Offset = "0x2E98480", VA = "0x182E99480")]
		private void OnActivate()
		{
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362A")]
		[Address(RVA = "0x2E99630", Offset = "0x2E98630", VA = "0x182E99630")]
		private void OnDeactivate()
		{
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362B")]
		[Address(RVA = "0x2E990B0", Offset = "0x2E980B0", VA = "0x182E990B0")]
		private void DeactivateAnimal(SimpleAnimal animal)
		{
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362C")]
		[Address(RVA = "0x2E9A820", Offset = "0x2E99820", VA = "0x182E9A820", Slot = "14")]
		public void UpdateRelevant(List<PlayerLocation.ViewerInfo> viewerList)
		{
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362D")]
		[Address(RVA = "0x2E99100", Offset = "0x2E98100", VA = "0x182E99100", Slot = "15")]
		public void ForceDeactivate()
		{
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362E")]
		[Address(RVA = "0x2E99D40", Offset = "0x2E98D40", VA = "0x182E99D40")]
		public void SetActive(bool newActive)
		{
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x2E999B0", Offset = "0x2E989B0", VA = "0x182E999B0")]
		public void ReActivate()
		{
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x2E9A2E0", Offset = "0x2E992E0", VA = "0x182E9A2E0", Slot = "12")]
		public void Tick(float deltaTime)
		{
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003631")]
		[Address(RVA = "0x2E99B90", Offset = "0x2E98B90", VA = "0x182E99B90")]
		private void ScareAnimals(Vector3 scarePoint, float scareRadius)
		{
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x2E9A740", Offset = "0x2E99740", VA = "0x182E9A740")]
		private void UpdatePopulation()
		{
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x2E99620", Offset = "0x2E98620", VA = "0x182E99620")]
		public void OnAnimalDied()
		{
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003634")]
		[Address(RVA = "0x2E997F0", Offset = "0x2E987F0", VA = "0x182E997F0")]
		public void OnPathComplete(SimpleAnimal animal)
		{
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003635")]
		[Address(RVA = "0x2E99D70", Offset = "0x2E98D70", VA = "0x182E99D70")]
		public void SetupZone(BoundsShape bounds, SimpleAnimal animalPrefab, int animalCount)
		{
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[Token(Token = "0x6003636")]
		[Address(RVA = "0x2E99190", Offset = "0x2E98190", VA = "0x182E99190", Slot = "4")]
		public VailActorTypeId GetActorType()
		{
			return default(VailActorTypeId);
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x0000FB10 File Offset: 0x0000DD10
		[Token(Token = "0x6003637")]
		[Address(RVA = "0x7B2E90", Offset = "0x7B1E90", VA = "0x1807B2E90", Slot = "5")]
		public int GetCount()
		{
			return default(int);
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x0000FB28 File Offset: 0x0000DD28
		[Token(Token = "0x6003638")]
		[Address(RVA = "0x2E99150", Offset = "0x2E98150", VA = "0x182E99150")]
		public int GetActiveCount()
		{
			return default(int);
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x0000FB40 File Offset: 0x0000DD40
		[Token(Token = "0x6003639")]
		[Address(RVA = "0x589ED0", Offset = "0x588ED0", VA = "0x180589ED0")]
		public int GetStartPopulation()
		{
			return default(int);
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x0000FB58 File Offset: 0x0000DD58
		[Token(Token = "0x600363A")]
		[Address(RVA = "0x986250", Offset = "0x985250", VA = "0x180986250", Slot = "7")]
		public int GetUniqueId()
		{
			return default(int);
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363B")]
		[Address(RVA = "0x2E99120", Offset = "0x2E98120", VA = "0x182E99120", Slot = "8")]
		[ContextMenu("Generate Unique Id")]
		public void GenerateUniqueId()
		{
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x0000FB70 File Offset: 0x0000DD70
		[Token(Token = "0x600363C")]
		[Address(RVA = "0x2E993D0", Offset = "0x2E983D0", VA = "0x182E993D0", Slot = "13")]
		public bool IsAlwaysRelevant()
		{
			return default(bool);
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x0000FB88 File Offset: 0x0000DD88
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x2871DD0", Offset = "0x2870DD0", VA = "0x182871DD0", Slot = "9")]
		public bool IsSaved()
		{
			return default(bool);
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363E")]
		[Address(RVA = "0x2E99210", Offset = "0x2E98210", VA = "0x182E99210", Slot = "16")]
		public string GetLabel()
		{
			return null;
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		[Token(Token = "0x600363F")]
		[Address(RVA = "0x2294B70", Offset = "0x2293B70", VA = "0x182294B70", Slot = "17")]
		public Vector3 GetLabelPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003640")]
		[Address(RVA = "0x2E99DC0", Offset = "0x2E98DC0", VA = "0x182E99DC0")]
		private void SnapSpawnerToTerrain()
		{
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003641")]
		[Address(RVA = "0x2E9AA60", Offset = "0x2E99A60", VA = "0x182E9AA60")]
		public SimpleAnimalZone()
		{
		}

		// Token: 0x04002E6F RID: 11887
		[Token(Token = "0x4002E6F")]
		private const float MaxViewDistance = 14f;

		// Token: 0x04002E70 RID: 11888
		[Token(Token = "0x4002E70")]
		private const float UpdatePopulationTick = 5f;

		// Token: 0x04002E71 RID: 11889
		[Token(Token = "0x4002E71")]
		private const float DefaultScareDistance = 4f;

		// Token: 0x04002E72 RID: 11890
		[Token(Token = "0x4002E72")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleAnimal _animalPrefab;

		// Token: 0x04002E73 RID: 11891
		[Token(Token = "0x4002E73")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_numSpawns")]
		private int _startPopulation;

		// Token: 0x04002E74 RID: 11892
		[Token(Token = "0x4002E74")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _maxPopulation;

		// Token: 0x04002E75 RID: 11893
		[Token(Token = "0x4002E75")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _spawnRatePerDay;

		// Token: 0x04002E76 RID: 11894
		[Token(Token = "0x4002E76")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[FormerlySerializedAs("_swimBounds")]
		private BoundsShape _pathBounds;

		// Token: 0x04002E77 RID: 11895
		[Token(Token = "0x4002E77")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _activateByDistance;

		// Token: 0x04002E78 RID: 11896
		[Token(Token = "0x4002E78")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _activeDistance;

		// Token: 0x04002E79 RID: 11897
		[Token(Token = "0x4002E79")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _allowScare;

		// Token: 0x04002E7A RID: 11898
		[Token(Token = "0x4002E7A")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _followPath;

		// Token: 0x04002E7B RID: 11899
		[Token(Token = "0x4002E7B")]
		[FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool _registerWithWorldSim;

		// Token: 0x04002E7C RID: 11900
		[Token(Token = "0x4002E7C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PathBoundsList _pathBoundsList;

		// Token: 0x04002E7D RID: 11901
		[Token(Token = "0x4002E7D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleAnimalZone.PathCompleteOption _onPathComplete;

		// Token: 0x04002E7E RID: 11902
		[Token(Token = "0x4002E7E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BoundsShape _pathCompleteBounds;

		// Token: 0x04002E7F RID: 11903
		[Token(Token = "0x4002E7F")]
		[FieldOffset(Offset = "0x68")]
		private List<SimpleAnimal> _spawnedAnimals;

		// Token: 0x04002E80 RID: 11904
		[Token(Token = "0x4002E80")]
		[FieldOffset(Offset = "0x70")]
		private int _animalCount;

		// Token: 0x04002E81 RID: 11905
		[Token(Token = "0x4002E81")]
		[FieldOffset(Offset = "0x74")]
		private int _deadCount;

		// Token: 0x04002E82 RID: 11906
		[Token(Token = "0x4002E82")]
		[FieldOffset(Offset = "0x78")]
		private float _lastSpawnTimeHours;

		// Token: 0x04002E83 RID: 11907
		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0x7C")]
		private float _tickPopulationTime;

		// Token: 0x04002E84 RID: 11908
		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0x80")]
		private bool _isActive;

		// Token: 0x04002E85 RID: 11909
		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private int _uniqueId;

		// Token: 0x04002E86 RID: 11910
		[Token(Token = "0x4002E86")]
		private const string PoolName = "creatures";

		// Token: 0x04002E87 RID: 11911
		[Token(Token = "0x4002E87")]
		[FieldOffset(Offset = "0x88")]
		private SpawnPool _spawnPool;

		// Token: 0x04002E88 RID: 11912
		[Token(Token = "0x4002E88")]
		[FieldOffset(Offset = "0x90")]
		private BoundsShape.SphereBounds _sphereBounds;

		// Token: 0x04002E89 RID: 11913
		[Token(Token = "0x4002E89")]
		[FieldOffset(Offset = "0xA8")]
		private bool _invalidZone;

		// Token: 0x020007FD RID: 2045
		[Token(Token = "0x20007FD")]
		private enum PathCompleteOption
		{
			// Token: 0x04002E8B RID: 11915
			[Token(Token = "0x4002E8B")]
			Deactivate,
			// Token: 0x04002E8C RID: 11916
			[Token(Token = "0x4002E8C")]
			WanderBounds
		}
	}
}
