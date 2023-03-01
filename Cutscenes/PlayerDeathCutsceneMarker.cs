using System;
using System.Collections.Generic;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200078E RID: 1934
	[Token(Token = "0x200078E")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerDeathCutsceneMarker")]
	public class PlayerDeathCutsceneMarker : MonoBehaviour
	{
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600330E RID: 13070 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x1700067A")]
		public bool IsOccupied
		{
			[Token(Token = "0x600330E")]
			[Address(RVA = "0x2E63210", Offset = "0x2E62210", VA = "0x182E63210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x600330F")]
		[Address(RVA = "0x5ED0E0", Offset = "0x5EC0E0", VA = "0x1805ED0E0")]
		public DeathCutsceneType GetDeathCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06003310 RID: 13072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067B")]
		public Transform GetDroppedInventoryBagLocation
		{
			[Token(Token = "0x6003310")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003311")]
		[Address(RVA = "0x2E62710", Offset = "0x2E61710", VA = "0x182E62710")]
		private void OnDisable()
		{
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003312")]
		[Address(RVA = "0x2E61710", Offset = "0x2E60710", VA = "0x182E61710")]
		private void Update()
		{
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003313")]
		[Address(RVA = "0x2E61710", Offset = "0x2E60710", VA = "0x182E61710")]
		private void CheckCleanupTimer()
		{
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003314")]
		[Address(RVA = "0x2E62760", Offset = "0x2E61760", VA = "0x182E62760")]
		private void OnValidate()
		{
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003315")]
		[Address(RVA = "0x2E63100", Offset = "0x2E62100", VA = "0x182E63100")]
		private void ValidateMarkerId()
		{
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003316")]
		[Address(RVA = "0x2E630E0", Offset = "0x2E620E0", VA = "0x182E630E0")]
		private void SnapToGround()
		{
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x2E620B0", Offset = "0x2E610B0", VA = "0x182E620B0")]
		private void FixBagRenderableTransform()
		{
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003318")]
		[Address(RVA = "0x2E62930", Offset = "0x2E61930", VA = "0x182E62930")]
		private void SnapBagTransform()
		{
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003319")]
		[Address(RVA = "0x2E62D40", Offset = "0x2E61D40", VA = "0x182E62D40")]
		private void SnapBaseTransform()
		{
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331A")]
		[Address(RVA = "0x2E62740", Offset = "0x2E61740", VA = "0x182E62740")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331B")]
		[Address(RVA = "0x2E62750", Offset = "0x2E61750", VA = "0x182E62750")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331C")]
		[Address(RVA = "0x2E61C50", Offset = "0x2E60C50", VA = "0x182E61C50")]
		private void DrawGizmos(float baseAlpha)
		{
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331D")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public static void ValidateMarkerId(ref string markerId, ref int markerIdIntegers, ref int instanceId, ref Dictionary<string, int> registeredMarkerIds, string namePrefix, Component targetObject)
		{
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331E")]
		[Address(RVA = "0x2E618E0", Offset = "0x2E608E0", VA = "0x182E618E0")]
		private static string ConvertToPrefix(string sceneName)
		{
			return null;
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600331F")]
		[Address(RVA = "0x2E625C0", Offset = "0x2E615C0", VA = "0x182E625C0")]
		private static string GetRandomIdString()
		{
			return null;
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003320")]
		[Address(RVA = "0x2E62680", Offset = "0x2E61680", VA = "0x182E62680")]
		public void LogSelected()
		{
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		[Token(Token = "0x6003321")]
		[Address(RVA = "0x2E624C0", Offset = "0x2E614C0", VA = "0x182E624C0")]
		public int GetIdInteger()
		{
			return default(int);
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x0000E910 File Offset: 0x0000CB10
		[Token(Token = "0x6003322")]
		[Address(RVA = "0x2E62400", Offset = "0x2E61400", VA = "0x182E62400")]
		private static int GetIdInteger(string markerId)
		{
			return default(int);
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x0000E928 File Offset: 0x0000CB28
		[Token(Token = "0x6003323")]
		[Address(RVA = "0x2E62700", Offset = "0x2E61700", VA = "0x182E62700")]
		public bool MarkerIdMatches(int markerId)
		{
			return default(bool);
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003324")]
		[Address(RVA = "0x2E627E0", Offset = "0x2E617E0", VA = "0x182E627E0")]
		public void SetOccupied(bool value)
		{
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003325")]
		[Address(RVA = "0x2E62900", Offset = "0x2E61900", VA = "0x182E62900")]
		public void SetStagePrefabInstance(GameObject cutsceneStagePrefab)
		{
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003326")]
		[Address(RVA = "0x2E61760", Offset = "0x2E60760", VA = "0x182E61760")]
		private void CleanupStagePrefabInstance()
		{
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003327")]
		[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
		public string GetMarkerId()
		{
			return null;
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x0000E940 File Offset: 0x0000CB40
		[Token(Token = "0x6003328")]
		[Address(RVA = "0x6A3820", Offset = "0x6A2820", VA = "0x1806A3820")]
		public int GetMarkerHash()
		{
			return default(int);
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003329")]
		[Address(RVA = "0x2E62790", Offset = "0x2E61790", VA = "0x182E62790")]
		public void SetMarkerId(string markerId)
		{
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332A")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PlayerDeathCutsceneMarker()
		{
		}

		// Token: 0x04002C61 RID: 11361
		[Token(Token = "0x4002C61")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _snapOffset;

		// Token: 0x04002C62 RID: 11362
		[Token(Token = "0x4002C62")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private DeathCutsceneType _deathCutsceneType;

		// Token: 0x04002C63 RID: 11363
		[Token(Token = "0x4002C63")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _droppedInventoryBag;

		// Token: 0x04002C64 RID: 11364
		[Token(Token = "0x4002C64")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _markerIdIntegers;

		// Token: 0x04002C65 RID: 11365
		[Token(Token = "0x4002C65")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _markerId;

		// Token: 0x04002C66 RID: 11366
		[Token(Token = "0x4002C66")]
		[FieldOffset(Offset = "0x48")]
		private int _instanceId;

		// Token: 0x04002C67 RID: 11367
		[Token(Token = "0x4002C67")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static Dictionary<string, int> _registeredMarkerIds;

		// Token: 0x04002C68 RID: 11368
		[Token(Token = "0x4002C68")]
		[FieldOffset(Offset = "0x4C")]
		[NonSerialized]
		private bool _validatedMarkerId;

		// Token: 0x04002C69 RID: 11369
		[Token(Token = "0x4002C69")]
		[FieldOffset(Offset = "0x4D")]
		private bool _isOccupied;

		// Token: 0x04002C6A RID: 11370
		[Token(Token = "0x4002C6A")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _cutsceneStagePrefabInstance;

		// Token: 0x04002C6B RID: 11371
		[Token(Token = "0x4002C6B")]
		[FieldOffset(Offset = "0x58")]
		private AutoTimer _prefabInstanceCleanupTimer;

		// Token: 0x04002C6C RID: 11372
		[Token(Token = "0x4002C6C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _markerIdHash;
	}
}
