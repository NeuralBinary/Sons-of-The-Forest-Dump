using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x020006C1 RID: 1729
	[Token(Token = "0x20006C1")]
	[Serializable]
	public class SpawnItemTarget
	{
		// Token: 0x06002C60 RID: 11360 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[Token(Token = "0x6002C60")]
		[Address(RVA = "0x2DF8510", Offset = "0x2DF7510", VA = "0x182DF8510")]
		private bool ShouldShowItemData()
		{
			return default(bool);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[Token(Token = "0x6002C61")]
		[Address(RVA = "0x2DF85A0", Offset = "0x2DF75A0", VA = "0x182DF85A0")]
		private bool ShouldShowPrefab()
		{
			return default(bool);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C62")]
		[Address(RVA = "0x2DF8910", Offset = "0x2DF7910", VA = "0x182DF8910")]
		public void Spawn(int dismemberMask)
		{
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C63")]
		[Address(RVA = "0x2DF85F0", Offset = "0x2DF75F0", VA = "0x182DF85F0")]
		private void SpawnTargetPair(SpawnItemTarget.TargetPair targetPair)
		{
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C64")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public SpawnItemTarget()
		{
		}

		// Token: 0x040027B9 RID: 10169
		[Token(Token = "0x40027B9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SpawnItemTarget.Axis _axis;

		// Token: 0x040027BA RID: 10170
		[Token(Token = "0x40027BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpawnItemTarget.TargetPair[] _targetPairs;

		// Token: 0x040027BB RID: 10171
		[Token(Token = "0x40027BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_item")]
		private ItemData _itemData;

		// Token: 0x040027BC RID: 10172
		[Token(Token = "0x40027BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x020006C2 RID: 1730
		[Token(Token = "0x20006C2")]
		public enum Axis
		{
			// Token: 0x040027BE RID: 10174
			[Token(Token = "0x40027BE")]
			FromToAxis,
			// Token: 0x040027BF RID: 10175
			[Token(Token = "0x40027BF")]
			Copy
		}

		// Token: 0x020006C3 RID: 1731
		[Token(Token = "0x20006C3")]
		[Serializable]
		public class TargetPair
		{
			// Token: 0x06002C65 RID: 11365 RVA: 0x0000CC18 File Offset: 0x0000AE18
			[Token(Token = "0x6002C65")]
			[Address(RVA = "0x2DFADB0", Offset = "0x2DF9DB0", VA = "0x182DFADB0")]
			public bool IsDismembered(int dismemberMask)
			{
				return default(bool);
			}

			// Token: 0x06002C66 RID: 11366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C66")]
			[Address(RVA = "0x2DFA920", Offset = "0x2DF9920", VA = "0x182DFA920")]
			internal void GetTransformValues(SpawnItemTarget.Axis axis, out Quaternion rotation, out Vector3 position)
			{
			}

			// Token: 0x06002C67 RID: 11367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C67")]
			[Address(RVA = "0x2DFADC0", Offset = "0x2DF9DC0", VA = "0x182DFADC0")]
			public TargetPair()
			{
			}

			// Token: 0x040027C0 RID: 10176
			[Token(Token = "0x40027C0")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform _from;

			// Token: 0x040027C1 RID: 10177
			[Token(Token = "0x40027C1")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform _to;

			// Token: 0x040027C2 RID: 10178
			[Token(Token = "0x40027C2")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Quaternion _rotationOffset;

			// Token: 0x040027C3 RID: 10179
			[Token(Token = "0x40027C3")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private DismembermentController.DismemberPartId _dismemberPartId;
		}
	}
}
