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
	// Token: 0x02000832 RID: 2098
	[Token(Token = "0x2000832")]
	public class TreeCutManager : MonoBehaviour, IVailActorInteract
	{
		// Token: 0x06003B35 RID: 15157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B35")]
		[Address(RVA = "0x3587C10", Offset = "0x3586210", VA = "0x183587C10")]
		public static void SetSimulateBolt(bool simulateBolt)
		{
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A8")]
		public GameObject RootObject
		{
			[Token(Token = "0x6003B36")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B37")]
		[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
		public Material GetBlockMaterial()
		{
			return null;
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B38")]
		[Address(RVA = "0x3587C70", Offset = "0x3586270", VA = "0x183587C70")]
		public void ForceTriggeredByThisManager()
		{
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B39")]
		[Address(RVA = "0x3587C80", Offset = "0x3586280", VA = "0x183587C80")]
		public void OnEnable()
		{
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x3587E50", Offset = "0x3586450", VA = "0x183587E50")]
		public void OnDisable()
		{
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x3588040", Offset = "0x3586640", VA = "0x183588040")]
		public void SetWorldObjectLocatorHolder(WorldObjectLocatorHolder newHolder)
		{
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0x3588410", Offset = "0x3586A10", VA = "0x183588410")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state, bool fromSave)
		{
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0x35884B0", Offset = "0x3586AB0", VA = "0x1835884B0")]
		private void RegisterTreeRemoved()
		{
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x00012150 File Offset: 0x00010350
		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x35885C0", Offset = "0x3586BC0", VA = "0x1835885C0")]
		private float GetHitFrequency()
		{
			return 0f;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00012168 File Offset: 0x00010368
		[Token(Token = "0x6003B3F")]
		[Address(RVA = "0x35885E0", Offset = "0x3586BE0", VA = "0x1835885E0")]
		private int GetMaxSwingHits()
		{
			return 0;
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B40")]
		[Address(RVA = "0x3588600", Offset = "0x3586C00", VA = "0x183588600")]
		private void Update()
		{
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B41")]
		[Address(RVA = "0x3588940", Offset = "0x3586F40", VA = "0x183588940")]
		private void Revert()
		{
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B42")]
		[Address(RVA = "0x3588A60", Offset = "0x3587060", VA = "0x183588A60")]
		public void SetupMoss()
		{
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B43")]
		[Address(RVA = "0x3588F90", Offset = "0x3587590", VA = "0x183588F90")]
		public void ApplyMoss(GameObject treeToCutDown, float mossFactor)
		{
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B44")]
		[Address(RVA = "0x3589680", Offset = "0x3587C80", VA = "0x183589680")]
		private void UpdateSwing()
		{
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B45")]
		[Address(RVA = "0x35896B0", Offset = "0x3587CB0", VA = "0x1835896B0")]
		public void ChipBurst(Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B46")]
		[Address(RVA = "0x358A070", Offset = "0x3588670", VA = "0x18358A070")]
		public void SnowBurst()
		{
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B47")]
		[Address(RVA = "0x358A460", Offset = "0x3588A60", VA = "0x18358A460")]
		public void HitPrefab(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x00012180 File Offset: 0x00010380
		[Token(Token = "0x6003B48")]
		[Address(RVA = "0x358A560", Offset = "0x3588B60", VA = "0x18358A560")]
		public Vector3 GetCorePosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x00012198 File Offset: 0x00010398
		[Token(Token = "0x6003B49")]
		[Address(RVA = "0xA03DC0", Offset = "0xA023C0", VA = "0x180A03DC0")]
		public bool HasBeenHit()
		{
			return default(bool);
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4A")]
		[Address(RVA = "0x358A640", Offset = "0x3588C40", VA = "0x18358A640")]
		public void OnHit()
		{
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06003B4B RID: 15179 RVA: 0x000121B0 File Offset: 0x000103B0
		// (set) Token: 0x06003B4C RID: 15180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A9")]
		public bool IsActivelyBeingHit
		{
			[Token(Token = "0x6003B4B")]
			[Address(RVA = "0x358A840", Offset = "0x3588E40", VA = "0x18358A840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003B4C")]
			[Address(RVA = "0x358A850", Offset = "0x3588E50", VA = "0x18358A850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4D")]
		[Address(RVA = "0x358A860", Offset = "0x3588E60", VA = "0x18358A860")]
		private void NoLongerActivelyBeingHit()
		{
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4E")]
		[Address(RVA = "0x358A870", Offset = "0x3588E70", VA = "0x18358A870")]
		private void CheckPercentage()
		{
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4F")]
		[Address(RVA = "0x358A940", Offset = "0x3588F40", VA = "0x18358A940")]
		private void BreakAllRemainingWoodChunks()
		{
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B50")]
		[Address(RVA = "0x358AC90", Offset = "0x3589290", VA = "0x18358AC90")]
		private void BreakAllRemainingBark()
		{
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B51")]
		[Address(RVA = "0x358AF80", Offset = "0x3589580", VA = "0x18358AF80")]
		private void ReplaceBarkSnowMaterials(Collider eachCollider, Dictionary<Material, Material> replaceMaterials)
		{
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B52")]
		[Address(RVA = "0x358B0B0", Offset = "0x35896B0", VA = "0x18358B0B0")]
		private void DisableSnowSetting(Renderer[] renderers, Dictionary<Material, Material> replaceMaterials)
		{
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B53")]
		[Address(RVA = "0x358B150", Offset = "0x3589750", VA = "0x18358B150")]
		private static void DisableSnowSetting(Renderer eachRenderer, Dictionary<Material, Material> replaceMaterials)
		{
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x000121C8 File Offset: 0x000103C8
		[Token(Token = "0x6003B54")]
		[Address(RVA = "0x358B630", Offset = "0x3589C30", VA = "0x18358B630")]
		private static bool HasDynamicSnowKeyword(Material eachMaterialCheck)
		{
			return default(bool);
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B55")]
		[Address(RVA = "0x358B770", Offset = "0x3589D70", VA = "0x18358B770")]
		public void ClearTree()
		{
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B56")]
		[Address(RVA = "0x358B8A0", Offset = "0x3589EA0", VA = "0x18358B8A0")]
		public void InstantCutForceFall(Vector3 direction)
		{
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B57")]
		[Address(RVA = "0x358B8D0", Offset = "0x3589ED0", VA = "0x18358B8D0")]
		public void InstantCut(bool straightToStump)
		{
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B58")]
		[Address(RVA = "0x358B8F0", Offset = "0x3589EF0", VA = "0x18358B8F0")]
		private void FellTree(bool straightToStump)
		{
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B59")]
		[Address(RVA = "0x358C2A0", Offset = "0x358A8A0", VA = "0x18358C2A0")]
		private IEnumerator DelayedClearStaticBrokenTree()
		{
			return null;
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5A")]
		[Address(RVA = "0x358C330", Offset = "0x358A930", VA = "0x18358C330")]
		private void DisableStaticTreeColliders()
		{
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5B")]
		[Address(RVA = "0x358C570", Offset = "0x358AB70", VA = "0x18358C570")]
		private void CalculateFallForces(out Vector3 forcePoint, out Vector3 finalTippingForce)
		{
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5C")]
		[Address(RVA = "0x358C7E0", Offset = "0x358ADE0", VA = "0x18358C7E0")]
		private void UpdateWorldObjectState(WorldObjectState worldObjectState)
		{
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5D")]
		[Address(RVA = "0x358C8D0", Offset = "0x358AED0", VA = "0x18358C8D0")]
		private void SpawnVailNoise(Vector3 treePos)
		{
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5E")]
		[Address(RVA = "0x358C990", Offset = "0x358AF90", VA = "0x18358C990")]
		public static void SpawnFallingTree(GameObject trunkFractured, Vector3 position, Quaternion rotation, Vector3 scale, Transform parent, Vector3 forcePoint, Vector3 finalTippingForce, ref GameObject trunkFracturedExtras, bool forceInstance = false, [Optional] WorldLocatorId worldLocatorId)
		{
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5F")]
		[Address(RVA = "0x358CD80", Offset = "0x358B380", VA = "0x18358CD80")]
		private static void SendSpawnFallingTreeEvent(GameObject trunkFractured, Vector3 position, Quaternion rotation, float uniformScale, Vector3 forcePoint, Vector3 finalTippingForce, [Optional] WorldLocatorId id)
		{
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B60")]
		[Address(RVA = "0x358D3E0", Offset = "0x358B9E0", VA = "0x18358D3E0")]
		private void DeactivatePhysicsStaticBrokenTree()
		{
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B61")]
		[Address(RVA = "0x358D4C0", Offset = "0x358BAC0", VA = "0x18358D4C0")]
		private void ClearStaticBrokenTree()
		{
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B62")]
		[Address(RVA = "0x358D650", Offset = "0x358BC50", VA = "0x18358D650")]
		private void ActivateBreakableStumpGroup()
		{
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B63")]
		[Address(RVA = "0x358D920", Offset = "0x358BF20", VA = "0x18358D920")]
		public static void ApplyTippingForce(GameObject treeTrunk, Vector3 finalTippingForce, Vector3 forcePoint)
		{
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B64")]
		[Address(RVA = "0x358DD00", Offset = "0x358C300", VA = "0x18358DD00")]
		private void OnValidate()
		{
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B65")]
		[Address(RVA = "0x358DF20", Offset = "0x358C520", VA = "0x18358DF20")]
		private void ValidateTrunkFracturedExtras()
		{
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B66")]
		[Address(RVA = "0x358E0F0", Offset = "0x358C6F0", VA = "0x18358E0F0")]
		private void Awake()
		{
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B67")]
		[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
		public TreeCutGrid GetGrid()
		{
			return null;
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B68")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
		public List<TreeCutMesh> GetMeshes()
		{
			return null;
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B69")]
		[Address(RVA = "0x358E1E0", Offset = "0x358C7E0", VA = "0x18358E1E0")]
		private void InitializeGridFromCellGroup()
		{
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6A")]
		[Address(RVA = "0x358E2C0", Offset = "0x358C8C0", VA = "0x18358E2C0")]
		private void UpdateMeshes()
		{
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6B")]
		[Address(RVA = "0x358E420", Offset = "0x358CA20", VA = "0x18358E420")]
		private void ResetCells()
		{
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6C")]
		[Address(RVA = "0x358E5D0", Offset = "0x358CBD0", VA = "0x18358E5D0")]
		private void ManualUpdate()
		{
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6E")]
		[Address(RVA = "0x358E5F0", Offset = "0x358CBF0", VA = "0x18358E5F0", Slot = "5")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x000121E0 File Offset: 0x000103E0
		[Token(Token = "0x6003B70")]
		[Address(RVA = "0x358E650", Offset = "0x358CC50", VA = "0x18358E650")]
		public static bool ValidTreeCutCollider(Collider other)
		{
			return default(bool);
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B71")]
		[Address(RVA = "0x358E740", Offset = "0x358CD40", VA = "0x18358E740")]
		public string GetTaskName()
		{
			return null;
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x358E770", Offset = "0x358CD70", VA = "0x18358E770")]
		public void OnHitFrom(Collider source)
		{
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B73")]
		[Address(RVA = "0x358EA00", Offset = "0x358D000", VA = "0x18358EA00")]
		public static void ProcessSpawnCutTreeEvent(SpawnCutTree spawnCutTreeEvent)
		{
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x358ECB0", Offset = "0x358D2B0", VA = "0x18358ECB0")]
		private void ConfirmSpawnCutTree(WorldLocatorId worldObjectLocatorId)
		{
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x358ED20", Offset = "0x358D320", VA = "0x18358ED20")]
		private void ApplyLODs(LODGroup lodGroup, List<List<GameObject>> renderableObjects, List<float> lodRanges)
		{
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x358F0D0", Offset = "0x358D6D0", VA = "0x18358F0D0")]
		public TreeCutManager()
		{
		}

		// Token: 0x0400325A RID: 12890
		[Token(Token = "0x400325A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool UseOneHitFell;

		// Token: 0x0400325B RID: 12891
		[Token(Token = "0x400325B")]
		private const float RevertDistance = 32400f;

		// Token: 0x0400325C RID: 12892
		[Token(Token = "0x400325C")]
		private const string TreeCutTag = "TreeCut";

		// Token: 0x0400325D RID: 12893
		[Token(Token = "0x400325D")]
		public const WorldObjectState TreeFellWorldObjectState = WorldObjectState.Destroyed;

		// Token: 0x0400325E RID: 12894
		[Token(Token = "0x400325E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string EnableSnowMaterialPropKeywordId;

		// Token: 0x0400325F RID: 12895
		[Token(Token = "0x400325F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int EnableSnowMaterialPropId;

		// Token: 0x04003260 RID: 12896
		[Token(Token = "0x4003260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rootGameObject;

		// Token: 0x04003261 RID: 12897
		[Token(Token = "0x4003261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _hitChips;

		// Token: 0x04003262 RID: 12898
		[Token(Token = "0x4003262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _chipVelocity;

		// Token: 0x04003263 RID: 12899
		[Token(Token = "0x4003263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _chipScale;

		// Token: 0x04003264 RID: 12900
		[Token(Token = "0x4003264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public Rigidbody _treeTrunkRigidbody;

		// Token: 0x04003265 RID: 12901
		[Token(Token = "0x4003265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public GameObject _hitParticlePrefab;

		// Token: 0x04003266 RID: 12902
		[Token(Token = "0x4003266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public GameObject _barkGroup;

		// Token: 0x04003267 RID: 12903
		[Token(Token = "0x4003267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TreeCutGrid _grid;

		// Token: 0x04003268 RID: 12904
		[Token(Token = "0x4003268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<TreeCutMesh> _blockMeshes;

		// Token: 0x04003269 RID: 12905
		[Token(Token = "0x4003269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _rbdChips;

		// Token: 0x0400326A RID: 12906
		[Token(Token = "0x400326A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _coreGuide;

		// Token: 0x0400326B RID: 12907
		[Token(Token = "0x400326B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _fractureGuide;

		// Token: 0x0400326C RID: 12908
		[Token(Token = "0x400326C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _trunkFractured;

		// Token: 0x0400326D RID: 12909
		[Token(Token = "0x400326D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _trunkFracturedExtras;

		// Token: 0x0400326E RID: 12910
		[Token(Token = "0x400326E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _trunkGroundHitTrigger;

		// Token: 0x0400326F RID: 12911
		[Token(Token = "0x400326F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _breakThreshold;

		// Token: 0x04003270 RID: 12912
		[Token(Token = "0x4003270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _broken;

		// Token: 0x04003271 RID: 12913
		[Token(Token = "0x4003271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _tippingForce;

		// Token: 0x04003272 RID: 12914
		[Token(Token = "0x4003272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _hitFrequency;

		// Token: 0x04003273 RID: 12915
		[Token(Token = "0x4003273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int _maxSwingHits;

		// Token: 0x04003274 RID: 12916
		[Token(Token = "0x4003274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Material _blockMaterial;

		// Token: 0x04003275 RID: 12917
		[Token(Token = "0x4003275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _breakableStumpGroup;

		// Token: 0x04003276 RID: 12918
		[Token(Token = "0x4003276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _activeHitDuration;

		// Token: 0x04003277 RID: 12919
		[Token(Token = "0x4003277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _SnowChance;

		// Token: 0x04003278 RID: 12920
		[Token(Token = "0x4003278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject[] _SnowPrefabs;

		// Token: 0x04003279 RID: 12921
		[Token(Token = "0x4003279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private List<TreeCutManager.MossMaterialSetup> _mossMaterialSetups;

		// Token: 0x0400327A RID: 12922
		[Token(Token = "0x400327A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool _isHit;

		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		private bool _isHitStart;

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _swingHits;

		// Token: 0x0400327D RID: 12925
		[Token(Token = "0x400327D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _swingInterval;

		// Token: 0x0400327E RID: 12926
		[Token(Token = "0x400327E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private bool _hasSpawnedParticle;

		// Token: 0x0400327F RID: 12927
		[Token(Token = "0x400327F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private SpawnPool _spawnPool;

		// Token: 0x04003280 RID: 12928
		[Token(Token = "0x4003280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 _lastHitSourceForward;

		// Token: 0x04003281 RID: 12929
		[Token(Token = "0x4003281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _lastHitSourceFrequency;

		// Token: 0x04003282 RID: 12930
		[Token(Token = "0x4003282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _lastHitSourceMaxSwingHits;

		// Token: 0x04003283 RID: 12931
		[Token(Token = "0x4003283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;

		// Token: 0x04003284 RID: 12932
		[Token(Token = "0x4003284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private SeasonsManager _seasonsManager;

		// Token: 0x04003285 RID: 12933
		[Token(Token = "0x4003285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool _isWinter;

		// Token: 0x04003286 RID: 12934
		[Token(Token = "0x4003286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		private bool _thisManagerTriggeredTheFell;

		// Token: 0x04003287 RID: 12935
		[Token(Token = "0x4003287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<WorldLocatorId, TreeCutManager> _boltSpawnCutTreeEventConfirmations;

		// Token: 0x04003288 RID: 12936
		[Token(Token = "0x4003288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _simulateBolt;

		// Token: 0x0400328A RID: 12938
		[Token(Token = "0x400328A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private List<GameObject> _barkSources;

		// Token: 0x0400328B RID: 12939
		[Token(Token = "0x400328B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[HideInInspector]
		[SerializeField]
		private GameObject _barkSource;

		// Token: 0x0400328C RID: 12940
		[Token(Token = "0x400328C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject _BarkLOD1;

		// Token: 0x0400328D RID: 12941
		[Token(Token = "0x400328D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<float> _BarkLODRangeValues;

		// Token: 0x0400328E RID: 12942
		[Token(Token = "0x400328E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private List<float> _CutGridLODRangeValues;

		// Token: 0x0400328F RID: 12943
		[Token(Token = "0x400328F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private GameObject _barkInstance;

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject _gridSource;

		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private GameObject _gridInstance;

		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Transform _probeAnchorOverride;

		// Token: 0x04003293 RID: 12947
		[Token(Token = "0x4003293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private Vector3 _meshSphereColliderCenter;

		// Token: 0x04003294 RID: 12948
		[Token(Token = "0x4003294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private float _meshSphereColliderScale;

		// Token: 0x04003295 RID: 12949
		[Token(Token = "0x4003295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private float _mergeSphereCollidersMinThreshold;

		// Token: 0x04003296 RID: 12950
		[Token(Token = "0x4003296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[SerializeField]
		private float _barkHeightDivider;

		// Token: 0x02000833 RID: 2099
		[Token(Token = "0x2000833")]
		[Serializable]
		private class MossMaterialSetup
		{
			// Token: 0x06003B78 RID: 15224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B78")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public MossMaterialSetup()
			{
			}

			// Token: 0x04003297 RID: 12951
			[Token(Token = "0x4003297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material _mossMat;

			// Token: 0x04003298 RID: 12952
			[Token(Token = "0x4003298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Material _mossMatInstance;

			// Token: 0x04003299 RID: 12953
			[Token(Token = "0x4003299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<Renderer> _mossRenderers;
		}
	}
}
