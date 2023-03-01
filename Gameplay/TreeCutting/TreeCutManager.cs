using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using PathologicalGames;
using Sons.Ai.Vail;
using Sons.Atmosphere;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006E6 RID: 1766
	[Token(Token = "0x20006E6")]
	public class TreeCutManager : MonoBehaviour, IVailActorInteract
	{
		// Token: 0x06002D53 RID: 11603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D53")]
		[Address(RVA = "0x2E1C970", Offset = "0x2E1B970", VA = "0x182E1C970")]
		public static void SetSimulateBolt(bool simulateBolt)
		{
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A5")]
		public GameObject RootObject
		{
			[Token(Token = "0x6002D54")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D55")]
		[Address(RVA = "0x6AC8C0", Offset = "0x6AB8C0", VA = "0x1806AC8C0")]
		public Material GetBlockMaterial()
		{
			return null;
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D56")]
		[Address(RVA = "0x2E1B780", Offset = "0x2E1A780", VA = "0x182E1B780")]
		public void ForceTriggeredByThisManager()
		{
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D57")]
		[Address(RVA = "0x2E1BC50", Offset = "0x2E1AC50", VA = "0x182E1BC50")]
		public void OnEnable()
		{
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D58")]
		[Address(RVA = "0x2E1BB10", Offset = "0x2E1AB10", VA = "0x182E1BB10")]
		public void OnDisable()
		{
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x2E1C9D0", Offset = "0x2E1B9D0", VA = "0x182E1C9D0")]
		public void SetWorldObjectLocatorHolder(WorldObjectLocatorHolder newHolder)
		{
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D5A")]
		[Address(RVA = "0x2E1C130", Offset = "0x2E1B130", VA = "0x182E1C130")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state)
		{
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D5B")]
		[Address(RVA = "0x2E1C470", Offset = "0x2E1B470", VA = "0x182E1C470")]
		private void RegisterTreeRemoved()
		{
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x0000CF00 File Offset: 0x0000B100
		[Token(Token = "0x6002D5C")]
		[Address(RVA = "0x2E1B7E0", Offset = "0x2E1A7E0", VA = "0x182E1B7E0")]
		private float GetHitFrequency()
		{
			return default(float);
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x0000CF18 File Offset: 0x0000B118
		[Token(Token = "0x6002D5D")]
		[Address(RVA = "0x2E1B800", Offset = "0x2E1A800", VA = "0x182E1B800")]
		private int GetMaxSwingHits()
		{
			return default(int);
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D5E")]
		[Address(RVA = "0x2E1D820", Offset = "0x2E1C820", VA = "0x182E1D820")]
		private void Update()
		{
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D5F")]
		[Address(RVA = "0x2E1C730", Offset = "0x2E1B730", VA = "0x182E1C730")]
		private void Revert()
		{
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D60")]
		[Address(RVA = "0x2E1CC10", Offset = "0x2E1BC10", VA = "0x182E1CC10")]
		public void SetupMoss()
		{
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D61")]
		[Address(RVA = "0x2E19030", Offset = "0x2E18030", VA = "0x182E19030")]
		public void ApplyMoss(GameObject treeToCutDown, float mossFactor)
		{
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D62")]
		[Address(RVA = "0x2E1D760", Offset = "0x2E1C760", VA = "0x182E1D760")]
		private void UpdateSwing()
		{
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D63")]
		[Address(RVA = "0x2E19FB0", Offset = "0x2E18FB0", VA = "0x182E19FB0")]
		public void ChipBurst(Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D64")]
		[Address(RVA = "0x2E1CF90", Offset = "0x2E1BF90", VA = "0x182E1CF90")]
		public void SnowBurst()
		{
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x2E1B900", Offset = "0x2E1A900", VA = "0x182E1B900")]
		public void HitPrefab(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x0000CF30 File Offset: 0x0000B130
		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x2E1B790", Offset = "0x2E1A790", VA = "0x182E1B790")]
		public Vector3 GetCorePosition()
		{
			return default(Vector3);
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x0000CF48 File Offset: 0x0000B148
		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x8C5E80", Offset = "0x8C4E80", VA = "0x1808C5E80")]
		public bool HasBeenHit()
		{
			return default(bool);
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D68")]
		[Address(RVA = "0x2E1BED0", Offset = "0x2E1AED0", VA = "0x182E1BED0")]
		public void OnHit()
		{
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x0000CF60 File Offset: 0x0000B160
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A6")]
		public bool IsActivelyBeingHit
		{
			[Token(Token = "0x6002D69")]
			[Address(RVA = "0x2E1DF30", Offset = "0x2E1CF30", VA = "0x182E1DF30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002D6A")]
			[Address(RVA = "0x2E1DF40", Offset = "0x2E1CF40", VA = "0x182E1DF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x2E1BB00", Offset = "0x2E1AB00", VA = "0x182E1BB00")]
		private void NoLongerActivelyBeingHit()
		{
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x2E19EE0", Offset = "0x2E18EE0", VA = "0x182E19EE0")]
		private void CheckPercentage()
		{
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x2E199C0", Offset = "0x2E189C0", VA = "0x182E199C0")]
		private void BreakAllRemainingWoodChunks()
		{
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x2E197B0", Offset = "0x2E187B0", VA = "0x182E197B0")]
		private void BreakAllRemainingBark()
		{
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0x2E1C530", Offset = "0x2E1B530", VA = "0x182E1C530")]
		private void ReplaceBarkSnowMaterials(Collider eachCollider, Dictionary<Material, Material> replaceMaterials)
		{
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D70")]
		[Address(RVA = "0x2E1A920", Offset = "0x2E19920", VA = "0x182E1A920")]
		private void DisableSnowSetting(Renderer[] renderers, Dictionary<Material, Material> replaceMaterials)
		{
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D71")]
		[Address(RVA = "0x2E1ACB0", Offset = "0x2E19CB0", VA = "0x182E1ACB0")]
		private static void DisableSnowSetting(Renderer eachRenderer, Dictionary<Material, Material> replaceMaterials)
		{
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x2E1B850", Offset = "0x2E1A850", VA = "0x182E1B850")]
		private static bool HasDynamicSnowKeyword(Material eachMaterialCheck)
		{
			return default(bool);
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x2E1A700", Offset = "0x2E19700", VA = "0x182E1A700")]
		public void ClearTree()
		{
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D74")]
		[Address(RVA = "0x2E1BA90", Offset = "0x2E1AA90", VA = "0x182E1BA90")]
		public void InstantCutForceFall(Vector3 direction)
		{
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D75")]
		[Address(RVA = "0x2E1BAC0", Offset = "0x2E1AAC0", VA = "0x182E1BAC0")]
		public void InstantCut(bool straightToStump)
		{
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D76")]
		[Address(RVA = "0x2E1B100", Offset = "0x2E1A100", VA = "0x182E1B100")]
		private void FellTree(bool straightToStump)
		{
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D77")]
		[Address(RVA = "0x2E1A8B0", Offset = "0x2E198B0", VA = "0x182E1A8B0")]
		private IEnumerator DelayedClearStaticBrokenTree()
		{
			return null;
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D78")]
		[Address(RVA = "0x2E1AFA0", Offset = "0x2E19FA0", VA = "0x182E1AFA0")]
		private void DisableStaticTreeColliders()
		{
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D79")]
		[Address(RVA = "0x2E19C50", Offset = "0x2E18C50", VA = "0x182E19C50")]
		private void CalculateFallForces(out Vector3 forcePoint, out Vector3 finalTippingForce)
		{
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7A")]
		[Address(RVA = "0x2E1D790", Offset = "0x2E1C790", VA = "0x182E1D790")]
		private void UpdateWorldObjectState(WorldObjectState worldObjectState)
		{
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7B")]
		[Address(RVA = "0x2E1D570", Offset = "0x2E1C570", VA = "0x182E1D570")]
		private void SpawnVailNoise(Vector3 treePos)
		{
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7C")]
		[Address(RVA = "0x2E1D1B0", Offset = "0x2E1C1B0", VA = "0x182E1D1B0")]
		public static void SpawnFallingTree(GameObject trunkFractured, Vector3 position, Quaternion rotation, Vector3 scale, Transform parent, Vector3 forcePoint, Vector3 finalTippingForce, ref GameObject trunkFracturedExtras, bool forceInstance = false, [Optional] WorldLocatorId worldLocatorId)
		{
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7D")]
		[Address(RVA = "0x2E1C7D0", Offset = "0x2E1B7D0", VA = "0x182E1C7D0")]
		private static void SendSpawnFallingTreeEvent(GameObject trunkFractured, Vector3 position, Quaternion rotation, float uniformScale, Vector3 forcePoint, Vector3 finalTippingForce, [Optional] WorldLocatorId id)
		{
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7E")]
		[Address(RVA = "0x2E1A820", Offset = "0x2E19820", VA = "0x182E1A820")]
		private void DeactivatePhysicsStaticBrokenTree()
		{
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7F")]
		[Address(RVA = "0x2E1A660", Offset = "0x2E19660", VA = "0x182E1A660")]
		private void ClearStaticBrokenTree()
		{
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D80")]
		[Address(RVA = "0x2E18C20", Offset = "0x2E17C20", VA = "0x182E18C20")]
		private void ActivateBreakableStumpGroup()
		{
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D81")]
		[Address(RVA = "0x2E194E0", Offset = "0x2E184E0", VA = "0x182E194E0")]
		public static void ApplyTippingForce(GameObject treeTrunk, Vector3 finalTippingForce, Vector3 forcePoint)
		{
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D82")]
		[Address(RVA = "0x2E1C060", Offset = "0x2E1B060", VA = "0x182E1C060")]
		private void OnValidate()
		{
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D83")]
		[Address(RVA = "0x2E1DAD0", Offset = "0x2E1CAD0", VA = "0x182E1DAD0")]
		private void ValidateTrunkFracturedExtras()
		{
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D84")]
		[Address(RVA = "0x2E19700", Offset = "0x2E18700", VA = "0x182E19700")]
		private void Awake()
		{
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D85")]
		[Address(RVA = "0x5E9610", Offset = "0x5E8610", VA = "0x1805E9610")]
		public TreeCutGrid GetGrid()
		{
			return null;
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D86")]
		[Address(RVA = "0x5E9600", Offset = "0x5E8600", VA = "0x1805E9600")]
		public List<TreeCutMesh> GetMeshes()
		{
			return null;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D87")]
		[Address(RVA = "0x2E1B9D0", Offset = "0x2E1A9D0", VA = "0x182E1B9D0")]
		private void InitializeGridFromCellGroup()
		{
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D88")]
		[Address(RVA = "0x2E1D640", Offset = "0x2E1C640", VA = "0x182E1D640")]
		private void UpdateMeshes()
		{
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D89")]
		[Address(RVA = "0x2E1C5B0", Offset = "0x2E1B5B0", VA = "0x182E1C5B0")]
		private void ResetCells()
		{
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D8A")]
		[Address(RVA = "0x2E1BAE0", Offset = "0x2E1AAE0", VA = "0x182E1BAE0")]
		private void ManualUpdate()
		{
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D8B")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D8C")]
		[Address(RVA = "0x2E1B0A0", Offset = "0x2E1A0A0", VA = "0x182E1B0A0", Slot = "5")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D8D")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x0000CF90 File Offset: 0x0000B190
		[Token(Token = "0x6002D8E")]
		[Address(RVA = "0x2E1DA20", Offset = "0x2E1CA20", VA = "0x182E1DA20")]
		public static bool ValidTreeCutCollider(Collider other)
		{
			return default(bool);
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D8F")]
		[Address(RVA = "0x2E1B820", Offset = "0x2E1A820", VA = "0x182E1B820")]
		public string GetTaskName()
		{
			return null;
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D90")]
		[Address(RVA = "0x2E1BDA0", Offset = "0x2E1ADA0", VA = "0x182E1BDA0")]
		public void OnHitFrom(Collider source)
		{
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D91")]
		[Address(RVA = "0x2E1C250", Offset = "0x2E1B250", VA = "0x182E1C250")]
		public static void ProcessSpawnCutTreeEvent(SpawnCutTree spawnCutTreeEvent)
		{
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D92")]
		[Address(RVA = "0x2E1A7B0", Offset = "0x2E197B0", VA = "0x182E1A7B0")]
		private void ConfirmSpawnCutTree(WorldLocatorId worldObjectLocatorId)
		{
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D93")]
		[Address(RVA = "0x2E18DA0", Offset = "0x2E17DA0", VA = "0x182E18DA0")]
		private void ApplyLODs(LODGroup lodGroup, List<List<GameObject>> renderableObjects, List<float> lodRanges)
		{
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D94")]
		[Address(RVA = "0x2E1DC50", Offset = "0x2E1CC50", VA = "0x182E1DC50")]
		public TreeCutManager()
		{
		}

		// Token: 0x0400287E RID: 10366
		[Token(Token = "0x400287E")]
		[FieldOffset(Offset = "0x0")]
		public static bool UseOneHitFell;

		// Token: 0x0400287F RID: 10367
		[Token(Token = "0x400287F")]
		private const float RevertDistance = 32400f;

		// Token: 0x04002880 RID: 10368
		[Token(Token = "0x4002880")]
		private const string TreeCutTag = "TreeCut";

		// Token: 0x04002881 RID: 10369
		[Token(Token = "0x4002881")]
		public const WorldObjectState TreeFellWorldObjectState = WorldObjectState.Destroyed;

		// Token: 0x04002882 RID: 10370
		[Token(Token = "0x4002882")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string EnableSnowMaterialPropKeywordId;

		// Token: 0x04002883 RID: 10371
		[Token(Token = "0x4002883")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int EnableSnowMaterialPropId;

		// Token: 0x04002884 RID: 10372
		[Token(Token = "0x4002884")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rootGameObject;

		// Token: 0x04002885 RID: 10373
		[Token(Token = "0x4002885")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _hitChips;

		// Token: 0x04002886 RID: 10374
		[Token(Token = "0x4002886")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _chipVelocity;

		// Token: 0x04002887 RID: 10375
		[Token(Token = "0x4002887")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _chipScale;

		// Token: 0x04002888 RID: 10376
		[Token(Token = "0x4002888")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public Rigidbody _treeTrunkRigidbody;

		// Token: 0x04002889 RID: 10377
		[Token(Token = "0x4002889")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public GameObject _hitParticlePrefab;

		// Token: 0x0400288A RID: 10378
		[Token(Token = "0x400288A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public GameObject _barkGroup;

		// Token: 0x0400288B RID: 10379
		[Token(Token = "0x400288B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TreeCutGrid _grid;

		// Token: 0x0400288C RID: 10380
		[Token(Token = "0x400288C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<TreeCutMesh> _blockMeshes;

		// Token: 0x0400288D RID: 10381
		[Token(Token = "0x400288D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _rbdChips;

		// Token: 0x0400288E RID: 10382
		[Token(Token = "0x400288E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _coreGuide;

		// Token: 0x0400288F RID: 10383
		[Token(Token = "0x400288F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _fractureGuide;

		// Token: 0x04002890 RID: 10384
		[Token(Token = "0x4002890")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _trunkFractured;

		// Token: 0x04002891 RID: 10385
		[Token(Token = "0x4002891")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _trunkFracturedExtras;

		// Token: 0x04002892 RID: 10386
		[Token(Token = "0x4002892")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _trunkGroundHitTrigger;

		// Token: 0x04002893 RID: 10387
		[Token(Token = "0x4002893")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _breakThreshold;

		// Token: 0x04002894 RID: 10388
		[Token(Token = "0x4002894")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _broken;

		// Token: 0x04002895 RID: 10389
		[Token(Token = "0x4002895")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _tippingForce;

		// Token: 0x04002896 RID: 10390
		[Token(Token = "0x4002896")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _hitFrequency;

		// Token: 0x04002897 RID: 10391
		[Token(Token = "0x4002897")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int _maxSwingHits;

		// Token: 0x04002898 RID: 10392
		[Token(Token = "0x4002898")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Material _blockMaterial;

		// Token: 0x04002899 RID: 10393
		[Token(Token = "0x4002899")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _breakableStumpGroup;

		// Token: 0x0400289A RID: 10394
		[Token(Token = "0x400289A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _activeHitDuration;

		// Token: 0x0400289B RID: 10395
		[Token(Token = "0x400289B")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _SnowChance;

		// Token: 0x0400289C RID: 10396
		[Token(Token = "0x400289C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject[] _SnowPrefabs;

		// Token: 0x0400289D RID: 10397
		[Token(Token = "0x400289D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private List<TreeCutManager.MossMaterialSetup> _mossMaterialSetups;

		// Token: 0x0400289E RID: 10398
		[Token(Token = "0x400289E")]
		[FieldOffset(Offset = "0xD0")]
		private bool _isHit;

		// Token: 0x0400289F RID: 10399
		[Token(Token = "0x400289F")]
		[FieldOffset(Offset = "0xD1")]
		private bool _isHitStart;

		// Token: 0x040028A0 RID: 10400
		[Token(Token = "0x40028A0")]
		[FieldOffset(Offset = "0xD4")]
		private int _swingHits;

		// Token: 0x040028A1 RID: 10401
		[Token(Token = "0x40028A1")]
		[FieldOffset(Offset = "0xD8")]
		private float _swingInterval;

		// Token: 0x040028A2 RID: 10402
		[Token(Token = "0x40028A2")]
		[FieldOffset(Offset = "0xDC")]
		private bool _hasSpawnedParticle;

		// Token: 0x040028A3 RID: 10403
		[Token(Token = "0x40028A3")]
		[FieldOffset(Offset = "0xE0")]
		private SpawnPool _spawnPool;

		// Token: 0x040028A4 RID: 10404
		[Token(Token = "0x40028A4")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 _lastHitSourceForward;

		// Token: 0x040028A5 RID: 10405
		[Token(Token = "0x40028A5")]
		[FieldOffset(Offset = "0xF4")]
		private float _lastHitSourceFrequency;

		// Token: 0x040028A6 RID: 10406
		[Token(Token = "0x40028A6")]
		[FieldOffset(Offset = "0xF8")]
		private int _lastHitSourceMaxSwingHits;

		// Token: 0x040028A7 RID: 10407
		[Token(Token = "0x40028A7")]
		[FieldOffset(Offset = "0x100")]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;

		// Token: 0x040028A8 RID: 10408
		[Token(Token = "0x40028A8")]
		[FieldOffset(Offset = "0x108")]
		private SeasonsManager _seasonsManager;

		// Token: 0x040028A9 RID: 10409
		[Token(Token = "0x40028A9")]
		[FieldOffset(Offset = "0x110")]
		private bool _isWinter;

		// Token: 0x040028AA RID: 10410
		[Token(Token = "0x40028AA")]
		[FieldOffset(Offset = "0x111")]
		private bool _thisManagerTriggeredTheFell;

		// Token: 0x040028AB RID: 10411
		[Token(Token = "0x40028AB")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<WorldLocatorId, TreeCutManager> _boltSpawnCutTreeEventConfirmations;

		// Token: 0x040028AC RID: 10412
		[Token(Token = "0x40028AC")]
		[FieldOffset(Offset = "0x20")]
		private static bool _simulateBolt;

		// Token: 0x040028AE RID: 10414
		[Token(Token = "0x40028AE")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private List<GameObject> _barkSources;

		// Token: 0x040028AF RID: 10415
		[Token(Token = "0x40028AF")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[HideInInspector]
		private GameObject _barkSource;

		// Token: 0x040028B0 RID: 10416
		[Token(Token = "0x40028B0")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject _BarkLOD1;

		// Token: 0x040028B1 RID: 10417
		[Token(Token = "0x40028B1")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<float> _BarkLODRangeValues;

		// Token: 0x040028B2 RID: 10418
		[Token(Token = "0x40028B2")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private List<float> _CutGridLODRangeValues;

		// Token: 0x040028B3 RID: 10419
		[Token(Token = "0x40028B3")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private GameObject _barkInstance;

		// Token: 0x040028B4 RID: 10420
		[Token(Token = "0x40028B4")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject _gridSource;

		// Token: 0x040028B5 RID: 10421
		[Token(Token = "0x40028B5")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private GameObject _gridInstance;

		// Token: 0x040028B6 RID: 10422
		[Token(Token = "0x40028B6")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Transform _probeAnchorOverride;

		// Token: 0x040028B7 RID: 10423
		[Token(Token = "0x40028B7")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private Vector3 _meshSphereColliderCenter;

		// Token: 0x040028B8 RID: 10424
		[Token(Token = "0x40028B8")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private float _meshSphereColliderScale;

		// Token: 0x040028B9 RID: 10425
		[Token(Token = "0x40028B9")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private float _mergeSphereCollidersMinThreshold;

		// Token: 0x040028BA RID: 10426
		[Token(Token = "0x40028BA")]
		[FieldOffset(Offset = "0x174")]
		[SerializeField]
		private float _barkHeightDivider;

		// Token: 0x020006E7 RID: 1767
		[Token(Token = "0x20006E7")]
		[Serializable]
		private class MossMaterialSetup
		{
			// Token: 0x06002D96 RID: 11670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002D96")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public MossMaterialSetup()
			{
			}

			// Token: 0x040028BB RID: 10427
			[Token(Token = "0x40028BB")]
			[FieldOffset(Offset = "0x10")]
			public Material _mossMat;

			// Token: 0x040028BC RID: 10428
			[Token(Token = "0x40028BC")]
			[FieldOffset(Offset = "0x18")]
			public Material _mossMatInstance;

			// Token: 0x040028BD RID: 10429
			[Token(Token = "0x40028BD")]
			[FieldOffset(Offset = "0x20")]
			public List<Renderer> _mossRenderers;
		}
	}
}
