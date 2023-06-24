using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007F9 RID: 2041
	[Token(Token = "0x20007F9")]
	[Serializable]
	public class SpawnItemTarget
	{
		// Token: 0x0600372F RID: 14127 RVA: 0x00010770 File Offset: 0x0000E970
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x353A140", Offset = "0x3538740", VA = "0x18353A140")]
		private bool ShouldShowItemData()
		{
			return default(bool);
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00010788 File Offset: 0x0000E988
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x74DB00", Offset = "0x74C100", VA = "0x18074DB00")]
		private bool ShouldShowPrefab()
		{
			return default(bool);
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x353A210", Offset = "0x3538810", VA = "0x18353A210")]
		public void Spawn(int dismemberMask)
		{
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003732")]
		[Address(RVA = "0x353A2A0", Offset = "0x35388A0", VA = "0x18353A2A0")]
		private void SpawnTargetPair(SpawnItemTarget.TargetPair targetPair)
		{
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003733")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SpawnItemTarget()
		{
		}

		// Token: 0x04002FA3 RID: 12195
		[Token(Token = "0x4002FA3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SpawnItemTarget.Axis _axis;

		// Token: 0x04002FA4 RID: 12196
		[Token(Token = "0x4002FA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpawnItemTarget.TargetPair[] _targetPairs;

		// Token: 0x04002FA5 RID: 12197
		[Token(Token = "0x4002FA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _itemId;

		// Token: 0x04002FA6 RID: 12198
		[Token(Token = "0x4002FA6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x020007FA RID: 2042
		[Token(Token = "0x20007FA")]
		public enum Axis
		{
			// Token: 0x04002FA8 RID: 12200
			[Token(Token = "0x4002FA8")]
			FromToAxis,
			// Token: 0x04002FA9 RID: 12201
			[Token(Token = "0x4002FA9")]
			Copy
		}

		// Token: 0x020007FB RID: 2043
		[Token(Token = "0x20007FB")]
		[Serializable]
		public class TargetPair
		{
			// Token: 0x06003734 RID: 14132 RVA: 0x000107A0 File Offset: 0x0000E9A0
			[Token(Token = "0x6003734")]
			[Address(RVA = "0x353A770", Offset = "0x3538D70", VA = "0x18353A770")]
			public bool IsDismembered(int dismemberMask)
			{
				return default(bool);
			}

			// Token: 0x06003735 RID: 14133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003735")]
			[Address(RVA = "0x353A7A0", Offset = "0x3538DA0", VA = "0x18353A7A0")]
			internal void GetTransformValues(SpawnItemTarget.Axis axis, out Quaternion rotation, out Vector3 position)
			{
			}

			// Token: 0x06003736 RID: 14134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003736")]
			[Address(RVA = "0x353AEE0", Offset = "0x35394E0", VA = "0x18353AEE0")]
			public TargetPair()
			{
			}

			// Token: 0x04002FAA RID: 12202
			[Token(Token = "0x4002FAA")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform _from;

			// Token: 0x04002FAB RID: 12203
			[Token(Token = "0x4002FAB")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform _to;

			// Token: 0x04002FAC RID: 12204
			[Token(Token = "0x4002FAC")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Quaternion _rotationOffset;

			// Token: 0x04002FAD RID: 12205
			[Token(Token = "0x4002FAD")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private DismembermentController.DismemberPartId _dismemberPartId;
		}
	}
}
