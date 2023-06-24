using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Player.CustomActions;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200069A RID: 1690
	[Token(Token = "0x200069A")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerFinalDeath")]
	public class PlayerFinalDeath : MonoBehaviour
	{
		// Token: 0x06002CA4 RID: 11428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA4")]
		[Address(RVA = "0x3426810", Offset = "0x3424E10", VA = "0x183426810")]
		private void OnValidate()
		{
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA5")]
		[Address(RVA = "0x3426C30", Offset = "0x3425230", VA = "0x183426C30")]
		private void Update()
		{
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA6")]
		[Address(RVA = "0x3426DB0", Offset = "0x34253B0", VA = "0x183426DB0")]
		public void DumpInventory()
		{
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA7")]
		[Address(RVA = "0x3426ED0", Offset = "0x34254D0", VA = "0x183426ED0")]
		public void Show()
		{
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA8")]
		[Address(RVA = "0x3427270", Offset = "0x3425870", VA = "0x183427270")]
		public void Hide()
		{
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA9")]
		[Address(RVA = "0x34272F0", Offset = "0x34258F0", VA = "0x1834272F0")]
		private void UndoCollisionSetup()
		{
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CAA")]
		[Address(RVA = "0x3427600", Offset = "0x3425C00", VA = "0x183427600")]
		private void DoCollisionSetup()
		{
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CAB")]
		[Address(RVA = "0x3427740", Offset = "0x3425D40", VA = "0x183427740")]
		private IEnumerator DumpInventoryOnPlayerWorker()
		{
			return null;
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CAC")]
		[Address(RVA = "0x34277D0", Offset = "0x3425DD0", VA = "0x1834277D0")]
		private IEnumerator DumpItemBurst(DumpItemBurstDef def, IReadOnlyList<ItemData> itemDatas, List<GameObject> instancesRef)
		{
			return null;
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x0000D230 File Offset: 0x0000B430
		[Token(Token = "0x6002CAD")]
		[Address(RVA = "0x3427990", Offset = "0x3425F90", VA = "0x183427990")]
		private static int ConvertToIndex(float percent, int count)
		{
			return 0;
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x0000D248 File Offset: 0x0000B448
		[Token(Token = "0x6002CAE")]
		[Address(RVA = "0x34279D0", Offset = "0x3425FD0", VA = "0x1834279D0")]
		private static bool ShouldDrop(ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CAF")]
		[Address(RVA = "0x3427B80", Offset = "0x3426180", VA = "0x183427B80")]
		private void DeathDumpItem(ItemData itemData, ref List<GameObject> instances)
		{
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB0")]
		[Address(RVA = "0x34286B0", Offset = "0x3426CB0", VA = "0x1834286B0")]
		private void UpdateSpawnItemPivRotation()
		{
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB1")]
		private static void DestroyComponentInChildren<T>(Transform instance) where T : Component
		{
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB2")]
		[Address(RVA = "0x3428A50", Offset = "0x3427050", VA = "0x183428A50")]
		public PlayerFinalDeath()
		{
		}

		// Token: 0x04002740 RID: 10048
		[Token(Token = "0x4002740")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] WhitelistDroppableItems;

		// Token: 0x04002741 RID: 10049
		[Token(Token = "0x4002741")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] BlacklistDroppableItems;

		// Token: 0x04002742 RID: 10050
		[Token(Token = "0x4002742")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _shown;

		// Token: 0x04002743 RID: 10051
		[Token(Token = "0x4002743")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _deadRigGroup;

		// Token: 0x04002744 RID: 10052
		[Token(Token = "0x4002744")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<ReparentObjectPair> _colliderPairs;

		// Token: 0x04002745 RID: 10053
		[Token(Token = "0x4002745")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _deathSpawnItemsLocatorPiv;

		// Token: 0x04002746 RID: 10054
		[Token(Token = "0x4002746")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _deathSpawnItemsLocator;

		// Token: 0x04002747 RID: 10055
		[Token(Token = "0x4002747")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 _randomArea;

		// Token: 0x04002748 RID: 10056
		[Token(Token = "0x4002748")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<DumpItemBurstDef> _dumpBurstDefs;

		// Token: 0x04002749 RID: 10057
		[Token(Token = "0x4002749")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine _dumpCoroutine;

		// Token: 0x0400274A RID: 10058
		[Token(Token = "0x400274A")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> _dumpIteminstances;

		// Token: 0x0400274B RID: 10059
		[Token(Token = "0x400274B")]
		[FieldOffset(Offset = "0x70")]
		private List<int> _itemsThatWereDropped;
	}
}
