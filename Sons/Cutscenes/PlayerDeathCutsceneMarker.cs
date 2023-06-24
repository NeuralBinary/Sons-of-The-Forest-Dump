using System;
using System.Collections.Generic;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x02000699 RID: 1689
	[Token(Token = "0x2000699")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerDeathCutsceneMarker")]
	public class PlayerDeathCutsceneMarker : MonoBehaviour
	{
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[Token(Token = "0x170005E7")]
		public bool IsOccupied
		{
			[Token(Token = "0x6002C86")]
			[Address(RVA = "0x3423A30", Offset = "0x3422030", VA = "0x183423A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[Token(Token = "0x6002C87")]
		[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
		public DeathCutsceneType GetDeathCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E8")]
		public Transform GetDroppedInventoryBagLocation
		{
			[Token(Token = "0x6002C88")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C89")]
		[Address(RVA = "0x3423A40", Offset = "0x3422040", VA = "0x183423A40")]
		private void OnDisable()
		{
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8A")]
		[Address(RVA = "0x3423A70", Offset = "0x3422070", VA = "0x183423A70")]
		private void Update()
		{
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8B")]
		[Address(RVA = "0x3423A70", Offset = "0x3422070", VA = "0x183423A70")]
		private void CheckCleanupTimer()
		{
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8C")]
		[Address(RVA = "0x3423B30", Offset = "0x3422130", VA = "0x183423B30")]
		private void OnValidate()
		{
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x3423BA0", Offset = "0x34221A0", VA = "0x183423BA0")]
		private void ValidateMarkerId()
		{
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8E")]
		[Address(RVA = "0x3423C20", Offset = "0x3422220", VA = "0x183423C20")]
		private void SnapToGround()
		{
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0x3423C40", Offset = "0x3422240", VA = "0x183423C40")]
		private void FixBagRenderableTransform()
		{
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C90")]
		[Address(RVA = "0x3424180", Offset = "0x3422780", VA = "0x183424180")]
		private void SnapBagTransform()
		{
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C91")]
		[Address(RVA = "0x3424710", Offset = "0x3422D10", VA = "0x183424710")]
		private void SnapBaseTransform()
		{
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C92")]
		[Address(RVA = "0x3424C70", Offset = "0x3423270", VA = "0x183424C70")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C93")]
		[Address(RVA = "0x3424C80", Offset = "0x3423280", VA = "0x183424C80")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C94")]
		[Address(RVA = "0x3424C90", Offset = "0x3423290", VA = "0x183424C90")]
		private void DrawGizmos(float baseAlpha)
		{
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C95")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void ValidateMarkerId(ref string markerId, ref int markerIdIntegers, ref int instanceId, ref Dictionary<string, int> registeredMarkerIds, string namePrefix, Component targetObject)
		{
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C96")]
		[Address(RVA = "0x3425300", Offset = "0x3423900", VA = "0x183425300")]
		private static string ConvertToPrefix(string sceneName)
		{
			return null;
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C97")]
		[Address(RVA = "0x3425B80", Offset = "0x3424180", VA = "0x183425B80")]
		private static string GetRandomIdString()
		{
			return null;
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C98")]
		[Address(RVA = "0x3425ED0", Offset = "0x34244D0", VA = "0x183425ED0")]
		public void LogSelected()
		{
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[Token(Token = "0x6002C99")]
		[Address(RVA = "0x3425F50", Offset = "0x3424550", VA = "0x183425F50")]
		public int GetIdInteger()
		{
			return 0;
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		[Token(Token = "0x6002C9A")]
		[Address(RVA = "0x34260F0", Offset = "0x34246F0", VA = "0x1834260F0")]
		private static int GetIdInteger(string markerId)
		{
			return 0;
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x0000D200 File Offset: 0x0000B400
		[Token(Token = "0x6002C9B")]
		[Address(RVA = "0x3426250", Offset = "0x3424850", VA = "0x183426250")]
		public bool MarkerIdMatches(int markerId)
		{
			return default(bool);
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9C")]
		[Address(RVA = "0x3426260", Offset = "0x3424860", VA = "0x183426260")]
		public void SetOccupied(bool value)
		{
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9D")]
		[Address(RVA = "0x34263F0", Offset = "0x34249F0", VA = "0x1834263F0")]
		public void SetStagePrefabInstance(GameObject cutsceneStagePrefab)
		{
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9E")]
		[Address(RVA = "0x3426460", Offset = "0x3424A60", VA = "0x183426460")]
		private void CleanupStagePrefabInstance()
		{
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C9F")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		public string GetMarkerId()
		{
			return null;
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x0000D218 File Offset: 0x0000B418
		[Token(Token = "0x6002CA0")]
		[Address(RVA = "0x75C1D0", Offset = "0x75A7D0", VA = "0x18075C1D0")]
		public int GetMarkerHash()
		{
			return 0;
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA1")]
		[Address(RVA = "0x34266C0", Offset = "0x3424CC0", VA = "0x1834266C0")]
		public void SetMarkerId(string markerId)
		{
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerDeathCutsceneMarker()
		{
		}

		// Token: 0x04002734 RID: 10036
		[Token(Token = "0x4002734")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _snapOffset;

		// Token: 0x04002735 RID: 10037
		[Token(Token = "0x4002735")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private DeathCutsceneType _deathCutsceneType;

		// Token: 0x04002736 RID: 10038
		[Token(Token = "0x4002736")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _droppedInventoryBag;

		// Token: 0x04002737 RID: 10039
		[Token(Token = "0x4002737")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _markerIdIntegers;

		// Token: 0x04002738 RID: 10040
		[Token(Token = "0x4002738")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _markerId;

		// Token: 0x04002739 RID: 10041
		[Token(Token = "0x4002739")]
		[FieldOffset(Offset = "0x48")]
		private int _instanceId;

		// Token: 0x0400273A RID: 10042
		[Token(Token = "0x400273A")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static Dictionary<string, int> _registeredMarkerIds;

		// Token: 0x0400273B RID: 10043
		[Token(Token = "0x400273B")]
		[FieldOffset(Offset = "0x4C")]
		[NonSerialized]
		private bool _validatedMarkerId;

		// Token: 0x0400273C RID: 10044
		[Token(Token = "0x400273C")]
		[FieldOffset(Offset = "0x4D")]
		private bool _isOccupied;

		// Token: 0x0400273D RID: 10045
		[Token(Token = "0x400273D")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _cutsceneStagePrefabInstance;

		// Token: 0x0400273E RID: 10046
		[Token(Token = "0x400273E")]
		[FieldOffset(Offset = "0x58")]
		private AutoTimer _prefabInstanceCleanupTimer;

		// Token: 0x0400273F RID: 10047
		[Token(Token = "0x400273F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _markerIdHash;
	}
}
