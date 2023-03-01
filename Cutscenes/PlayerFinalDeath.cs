using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Player.CustomActions;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200078F RID: 1935
	[Token(Token = "0x200078F")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerFinalDeath")]
	public class PlayerFinalDeath : MonoBehaviour
	{
		// Token: 0x0600332C RID: 13100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332C")]
		[Address(RVA = "0x2E63CD0", Offset = "0x2E62CD0", VA = "0x182E63CD0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332D")]
		[Address(RVA = "0x2E64840", Offset = "0x2E63840", VA = "0x182E64840")]
		private void Update()
		{
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332E")]
		[Address(RVA = "0x2E63B30", Offset = "0x2E62B30", VA = "0x182E63B30")]
		public void DumpInventory()
		{
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332F")]
		[Address(RVA = "0x2E642C0", Offset = "0x2E632C0", VA = "0x182E642C0")]
		public void Show()
		{
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003330")]
		[Address(RVA = "0x2E63C90", Offset = "0x2E62C90", VA = "0x182E63C90")]
		public void Hide()
		{
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003331")]
		[Address(RVA = "0x2E644D0", Offset = "0x2E634D0", VA = "0x182E644D0")]
		private void UndoCollisionSetup()
		{
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003332")]
		[Address(RVA = "0x2E639C0", Offset = "0x2E629C0", VA = "0x182E639C0")]
		private void DoCollisionSetup()
		{
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003333")]
		[Address(RVA = "0x2E63AC0", Offset = "0x2E62AC0", VA = "0x182E63AC0")]
		private IEnumerator DumpInventoryOnPlayerWorker()
		{
			return null;
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003334")]
		[Address(RVA = "0x2E63BD0", Offset = "0x2E62BD0", VA = "0x182E63BD0")]
		private IEnumerator DumpItemBurst(DumpItemBurstDef def, IReadOnlyList<ItemData> itemDatas, List<GameObject> instancesRef)
		{
			return null;
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x0000E958 File Offset: 0x0000CB58
		[Token(Token = "0x6003335")]
		[Address(RVA = "0x2E63220", Offset = "0x2E62220", VA = "0x182E63220")]
		private static int ConvertToIndex(float percent, int count)
		{
			return default(int);
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x0000E970 File Offset: 0x0000CB70
		[Token(Token = "0x6003336")]
		[Address(RVA = "0x2E64160", Offset = "0x2E63160", VA = "0x182E64160")]
		private static bool ShouldDrop(ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003337")]
		[Address(RVA = "0x2E632C0", Offset = "0x2E622C0", VA = "0x182E632C0")]
		private void DeathDumpItem(ItemData itemData, ref List<GameObject> instances)
		{
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003338")]
		[Address(RVA = "0x2E64690", Offset = "0x2E63690", VA = "0x182E64690")]
		private void UpdateSpawnItemPivRotation()
		{
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003339")]
		private static void DestroyComponentInChildren<T>(Transform instance) where T : Component
		{
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333A")]
		[Address(RVA = "0x2E649F0", Offset = "0x2E639F0", VA = "0x182E649F0")]
		public PlayerFinalDeath()
		{
		}

		// Token: 0x04002C6D RID: 11373
		[Token(Token = "0x4002C6D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] WhitelistDroppableItems;

		// Token: 0x04002C6E RID: 11374
		[Token(Token = "0x4002C6E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] BlacklistDroppableItems;

		// Token: 0x04002C6F RID: 11375
		[Token(Token = "0x4002C6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _shown;

		// Token: 0x04002C70 RID: 11376
		[Token(Token = "0x4002C70")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _deadRigGroup;

		// Token: 0x04002C71 RID: 11377
		[Token(Token = "0x4002C71")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<ReparentObjectPair> _colliderPairs;

		// Token: 0x04002C72 RID: 11378
		[Token(Token = "0x4002C72")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _deathSpawnItemsLocatorPiv;

		// Token: 0x04002C73 RID: 11379
		[Token(Token = "0x4002C73")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _deathSpawnItemsLocator;

		// Token: 0x04002C74 RID: 11380
		[Token(Token = "0x4002C74")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 _randomArea;

		// Token: 0x04002C75 RID: 11381
		[Token(Token = "0x4002C75")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<DumpItemBurstDef> _dumpBurstDefs;

		// Token: 0x04002C76 RID: 11382
		[Token(Token = "0x4002C76")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine _dumpCoroutine;

		// Token: 0x04002C77 RID: 11383
		[Token(Token = "0x4002C77")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> _dumpIteminstances;

		// Token: 0x04002C78 RID: 11384
		[Token(Token = "0x4002C78")]
		[FieldOffset(Offset = "0x70")]
		private List<int> _itemsThatWereDropped;
	}
}
