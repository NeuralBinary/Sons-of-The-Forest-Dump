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
	// Token: 0x0200070A RID: 1802
	[Token(Token = "0x200070A")]
	[AddComponentMenu("Sons/Characters/Simple Animal Zone")]
	[RequireComponent(typeof(BoundsShape))]
	public class SimpleAnimalZone : MonoBehaviour, ISimpleSpawner, ISpawner
	{
		// Token: 0x06002FC5 RID: 12229 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x6002FC5")]
		[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
		private bool ShowActivate()
		{
			return default(bool);
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x0000E550 File Offset: 0x0000C750
		[Token(Token = "0x6002FC6")]
		[Address(RVA = "0x9D9870", Offset = "0x9D7E70", VA = "0x1809D9870")]
		public bool ShowPathOptions()
		{
			return default(bool);
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x0000E568 File Offset: 0x0000C768
		[Token(Token = "0x6002FC7")]
		[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0", Slot = "6")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC8")]
		[Address(RVA = "0x34674F0", Offset = "0x3465AF0", VA = "0x1834674F0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC9")]
		[Address(RVA = "0x3467780", Offset = "0x3465D80", VA = "0x183467780")]
		private void Start()
		{
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCA")]
		[Address(RVA = "0x3467A60", Offset = "0x3466060", VA = "0x183467A60")]
		public void ResetCount()
		{
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCB")]
		[Address(RVA = "0x3467A70", Offset = "0x3466070", VA = "0x183467A70")]
		public void Init(float width, float depth, int count)
		{
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCC")]
		[Address(RVA = "0x3467AF0", Offset = "0x34660F0", VA = "0x183467AF0", Slot = "10")]
		public void OnLoad(VailWorldSimulation.VailSpawnerData saveData)
		{
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCD")]
		[Address(RVA = "0x3467B40", Offset = "0x3466140", VA = "0x183467B40", Slot = "11")]
		public VailWorldSimulation.VailSpawnerData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0x3467BA0", Offset = "0x34661A0", VA = "0x183467BA0")]
		private SimpleAnimal SpawnAnimal(bool checkIsVisible)
		{
			return null;
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCF")]
		[Address(RVA = "0x3467EB0", Offset = "0x34664B0", VA = "0x183467EB0")]
		private void RemoveNullOrDisabled(ref List<SimpleAnimal> targetList)
		{
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x0000E580 File Offset: 0x0000C780
		[Token(Token = "0x6002FD0")]
		[Address(RVA = "0x3468110", Offset = "0x3466710", VA = "0x183468110")]
		private bool IsWinter()
		{
			return default(bool);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD1")]
		[Address(RVA = "0x34681B0", Offset = "0x34667B0", VA = "0x1834681B0")]
		private void OnActivate()
		{
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0x3468400", Offset = "0x3466A00", VA = "0x183468400")]
		private void OnDeactivate()
		{
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x34685F0", Offset = "0x3466BF0", VA = "0x1834685F0")]
		private void DeactivateAnimal(SimpleAnimal animal)
		{
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD4")]
		[Address(RVA = "0x3468680", Offset = "0x3466C80", VA = "0x183468680", Slot = "14")]
		public void UpdateRelevant(List<PlayerLocation.ViewerInfo> viewerList)
		{
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0x3468990", Offset = "0x3466F90", VA = "0x183468990", Slot = "15")]
		public void ForceDeactivate()
		{
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x34689B0", Offset = "0x3466FB0", VA = "0x1834689B0")]
		public void SetActive(bool newActive)
		{
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0x34689E0", Offset = "0x3466FE0", VA = "0x1834689E0")]
		public void ReActivate()
		{
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD8")]
		[Address(RVA = "0x3468A10", Offset = "0x3467010", VA = "0x183468A10", Slot = "12")]
		public void Tick(float deltaTime)
		{
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD9")]
		[Address(RVA = "0x3468FB0", Offset = "0x34675B0", VA = "0x183468FB0")]
		private void ScareAnimals(Vector3 scarePoint, float scareRadius)
		{
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FDA")]
		[Address(RVA = "0x3469190", Offset = "0x3467790", VA = "0x183469190")]
		private void UpdatePopulation()
		{
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x3469250", Offset = "0x3467850", VA = "0x183469250")]
		public void OnAnimalDied()
		{
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FDC")]
		[Address(RVA = "0x3469260", Offset = "0x3467860", VA = "0x183469260")]
		public void OnPathComplete(SimpleAnimal animal)
		{
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FDD")]
		[Address(RVA = "0x3469360", Offset = "0x3467960", VA = "0x183469360")]
		public void SetupZone(BoundsShape bounds, SimpleAnimal animalPrefab, int animalCount)
		{
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x0000E598 File Offset: 0x0000C798
		[Token(Token = "0x6002FDE")]
		[Address(RVA = "0x3469430", Offset = "0x3467A30", VA = "0x183469430", Slot = "4")]
		public VailActorTypeId GetActorType()
		{
			return VailActorTypeId.None;
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		[Token(Token = "0x6002FDF")]
		[Address(RVA = "0x8DCFC0", Offset = "0x8DB5C0", VA = "0x1808DCFC0", Slot = "5")]
		public int GetCount()
		{
			return 0;
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[Token(Token = "0x6002FE0")]
		[Address(RVA = "0x3469510", Offset = "0x3467B10", VA = "0x183469510")]
		public int GetActiveCount()
		{
			return 0;
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		[Token(Token = "0x6002FE1")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
		public int GetStartPopulation()
		{
			return 0;
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[Token(Token = "0x6002FE2")]
		[Address(RVA = "0xAFF2B0", Offset = "0xAFD8B0", VA = "0x180AFF2B0", Slot = "7")]
		public int GetUniqueId()
		{
			return 0;
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE3")]
		[Address(RVA = "0x3469550", Offset = "0x3467B50", VA = "0x183469550", Slot = "8")]
		[ContextMenu("Generate Unique Id")]
		public void GenerateUniqueId()
		{
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x0000E610 File Offset: 0x0000C810
		[Token(Token = "0x6002FE4")]
		[Address(RVA = "0x3469580", Offset = "0x3467B80", VA = "0x183469580", Slot = "13")]
		public bool IsAlwaysRelevant()
		{
			return default(bool);
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x0000E628 File Offset: 0x0000C828
		[Token(Token = "0x6002FE5")]
		[Address(RVA = "0x3143AD0", Offset = "0x31420D0", VA = "0x183143AD0", Slot = "9")]
		public bool IsSaved()
		{
			return default(bool);
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE6")]
		[Address(RVA = "0x3469590", Offset = "0x3467B90", VA = "0x183469590", Slot = "16")]
		public string GetLabel()
		{
			return null;
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x0000E640 File Offset: 0x0000C840
		[Token(Token = "0x6002FE7")]
		[Address(RVA = "0x26E86D0", Offset = "0x26E6CD0", VA = "0x1826E86D0", Slot = "17")]
		public Vector3 GetLabelPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0x34696B0", Offset = "0x3467CB0", VA = "0x1834696B0")]
		private void SnapSpawnerToTerrain()
		{
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x3469740", Offset = "0x3467D40", VA = "0x183469740")]
		public void PositionToCameraTrace()
		{
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0x34697D0", Offset = "0x3467DD0", VA = "0x1834697D0")]
		public SimpleAnimalZone()
		{
		}

		// Token: 0x04002961 RID: 10593
		[Token(Token = "0x4002961")]
		private const float MaxViewDistance = 14f;

		// Token: 0x04002962 RID: 10594
		[Token(Token = "0x4002962")]
		private const float UpdatePopulationTick = 5f;

		// Token: 0x04002963 RID: 10595
		[Token(Token = "0x4002963")]
		private const float DefaultScareDistance = 4f;

		// Token: 0x04002964 RID: 10596
		[Token(Token = "0x4002964")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleAnimal _animalPrefab;

		// Token: 0x04002965 RID: 10597
		[Token(Token = "0x4002965")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_numSpawns")]
		private int _startPopulation;

		// Token: 0x04002966 RID: 10598
		[Token(Token = "0x4002966")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _maxPopulation;

		// Token: 0x04002967 RID: 10599
		[Token(Token = "0x4002967")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _spawnRatePerDay;

		// Token: 0x04002968 RID: 10600
		[Token(Token = "0x4002968")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("_swimBounds")]
		[SerializeField]
		private BoundsShape _pathBounds;

		// Token: 0x04002969 RID: 10601
		[Token(Token = "0x4002969")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _activateByDistance;

		// Token: 0x0400296A RID: 10602
		[Token(Token = "0x400296A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _activeDistance;

		// Token: 0x0400296B RID: 10603
		[Token(Token = "0x400296B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _allowScare;

		// Token: 0x0400296C RID: 10604
		[Token(Token = "0x400296C")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _followPath;

		// Token: 0x0400296D RID: 10605
		[Token(Token = "0x400296D")]
		[FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool _registerWithWorldSim;

		// Token: 0x0400296E RID: 10606
		[Token(Token = "0x400296E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PathBoundsList _pathBoundsList;

		// Token: 0x0400296F RID: 10607
		[Token(Token = "0x400296F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleAnimalZone.PathCompleteOption _onPathComplete;

		// Token: 0x04002970 RID: 10608
		[Token(Token = "0x4002970")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BoundsShape _pathCompleteBounds;

		// Token: 0x04002971 RID: 10609
		[Token(Token = "0x4002971")]
		[FieldOffset(Offset = "0x68")]
		private List<SimpleAnimal> _spawnedAnimals;

		// Token: 0x04002972 RID: 10610
		[Token(Token = "0x4002972")]
		[FieldOffset(Offset = "0x70")]
		private int _currentPopulation;

		// Token: 0x04002973 RID: 10611
		[Token(Token = "0x4002973")]
		[FieldOffset(Offset = "0x74")]
		private int _deadCount;

		// Token: 0x04002974 RID: 10612
		[Token(Token = "0x4002974")]
		[FieldOffset(Offset = "0x78")]
		private float _lastSpawnTimeHours;

		// Token: 0x04002975 RID: 10613
		[Token(Token = "0x4002975")]
		[FieldOffset(Offset = "0x7C")]
		private float _tickPopulationTime;

		// Token: 0x04002976 RID: 10614
		[Token(Token = "0x4002976")]
		[FieldOffset(Offset = "0x80")]
		private bool _isActive;

		// Token: 0x04002977 RID: 10615
		[Token(Token = "0x4002977")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private int _uniqueId;

		// Token: 0x04002978 RID: 10616
		[Token(Token = "0x4002978")]
		private const string PoolName = "creatures";

		// Token: 0x04002979 RID: 10617
		[Token(Token = "0x4002979")]
		[FieldOffset(Offset = "0x88")]
		private SpawnPool _spawnPool;

		// Token: 0x0400297A RID: 10618
		[Token(Token = "0x400297A")]
		[FieldOffset(Offset = "0x90")]
		private BoundsShape.SphereBounds _sphereBounds;

		// Token: 0x0400297B RID: 10619
		[Token(Token = "0x400297B")]
		[FieldOffset(Offset = "0xA8")]
		private bool _invalidZone;

		// Token: 0x0200070B RID: 1803
		[Token(Token = "0x200070B")]
		private enum PathCompleteOption
		{
			// Token: 0x0400297D RID: 10621
			[Token(Token = "0x400297D")]
			Deactivate,
			// Token: 0x0400297E RID: 10622
			[Token(Token = "0x400297E")]
			WanderBounds
		}
	}
}
