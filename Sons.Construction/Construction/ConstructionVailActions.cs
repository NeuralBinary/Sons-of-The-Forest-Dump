using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200027A RID: 634
	[Token(Token = "0x200027A")]
	public class ConstructionVailActions : MonoBehaviour, IConstructionVailActions
	{
		// Token: 0x0600136D RID: 4973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x2F56560", Offset = "0x2F54B60", VA = "0x182F56560")]
		private void Awake()
		{
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x2F56640", Offset = "0x2F54C40", VA = "0x182F56640", Slot = "4")]
		private GameObject BuildFire(Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600136F")]
		[Address(RVA = "0x2F567F0", Offset = "0x2F54DF0", VA = "0x182F567F0", Slot = "5")]
		private GameObject StartDefensiveWall(Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0000BC84 File Offset: 0x00009E84
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x2F569D0", Offset = "0x2F54FD0", VA = "0x182F569D0", Slot = "6")]
		private bool TryAddPillarToWall(GameObject targetWall, Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x2F56C30", Offset = "0x2F55230", VA = "0x182F56C30", Slot = "7")]
		private GameObject BuildTarp(Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0000BC9C File Offset: 0x00009E9C
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x2F56CF0", Offset = "0x2F552F0", VA = "0x182F56CF0", Slot = "10")]
		private bool TryRemoveTarp(GameObject targetTarp, Vector3 nearPosition)
		{
			return default(bool);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x2F56DF0", Offset = "0x2F553F0", VA = "0x182F56DF0", Slot = "8")]
		private bool TryGetClosestTarpStakePosition(GameObject targetTarp, Vector3 nearPosition, out Vector3 snapPos)
		{
			return default(bool);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0000BCCC File Offset: 0x00009ECC
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x2F56E40", Offset = "0x2F55440", VA = "0x182F56E40")]
		private bool GetTarpStakeReferences(GameObject targetTarp, Vector3 nearPosition, out TarpStructure tarpStructure, out TarpDirections closestDir, out Vector3 snapPos)
		{
			return default(bool);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x2F56FF0", Offset = "0x2F555F0", VA = "0x182F56FF0")]
		private IEnumerator RaiseTarp(GameObject targetTarp, TarpStructure tarpStructure, TarpDirections closestDir, Vector3 snapPos)
		{
			return null;
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001376")]
		[Address(RVA = "0x2F57170", Offset = "0x2F55770", VA = "0x182F57170")]
		private static void GetStakeDirectionForTarp(StakeStructure targetStake, TarpStructure targetTarp, out Directions dirA)
		{
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0000BCE4 File Offset: 0x00009EE4
		[Token(Token = "0x6001377")]
		[Address(RVA = "0x2F57370", Offset = "0x2F55970", VA = "0x182F57370", Slot = "9")]
		private bool TryBuildTarpStake(GameObject targetTarp, Vector3 nearPosition)
		{
			return default(bool);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0000BCFC File Offset: 0x00009EFC
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x2F57F30", Offset = "0x2F56530", VA = "0x182F57F30")]
		private static bool TryFindClosestAvailableStakeDir(TarpStructure tarpStructure, Vector3 nearPosition, out TarpDirections closestDir, out Vector3 closestSnapPos)
		{
			return default(bool);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x2F58170", Offset = "0x2F56770", VA = "0x182F58170")]
		private ConstructionManager GetOrFetchConstructionManager()
		{
			return null;
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ConstructionVailActions()
		{
		}

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StructureElement _tarpPrefab;

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StructureElement _tarpStakePrefab;

		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StructureElement _sleepTriggerPrefab;

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StructureElement _firePrefab;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StructureElement _pillarPrefab;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StructureElement _secondStickPrefab;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x50")]
		private ConstructionManager _manager;

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TarpDirections[] TarpStakeDirs;
	}
}
