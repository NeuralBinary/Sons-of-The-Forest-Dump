using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Characters
{
	// Token: 0x02000724 RID: 1828
	[Token(Token = "0x2000724")]
	[Serializable]
	public class VariationSet
	{
		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		[Token(Token = "0x17000672")]
		public bool IsExclusive
		{
			[Token(Token = "0x60030A4")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		[Token(Token = "0x17000673")]
		public int RepeatRollCount
		{
			[Token(Token = "0x60030A5")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A6")]
		[Address(RVA = "0x347A210", Offset = "0x3478810", VA = "0x18347A210")]
		public void SetRepeatRollCount(int count)
		{
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x347A220", Offset = "0x3478820", VA = "0x18347A220")]
		public void UpdateVariationSetData()
		{
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x347A230", Offset = "0x3478830", VA = "0x18347A230")]
		private void UpdateObjectsChanceSum(VariationSet.Subset subSet)
		{
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x0000EC10 File Offset: 0x0000CE10
		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x347A3A0", Offset = "0x34789A0", VA = "0x18347A3A0")]
		public VariationSet.Subset Apply(System.Random random, VariationSet.Subset subSet)
		{
			return VariationSet.Subset.Any;
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x347A430", Offset = "0x3478A30", VA = "0x18347A430")]
		private void ApplyTargets(System.Random random, VariationSet.Subset subSet)
		{
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x347A4B0", Offset = "0x3478AB0", VA = "0x18347A4B0")]
		private void ApplyObjectTargets(System.Random random, VariationSet.Subset subset)
		{
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AC")]
		[Address(RVA = "0x347AA40", Offset = "0x3479040", VA = "0x18347AA40")]
		private void ApplyObjectTarget(VariationSet.ObjectTarget eachTarget, bool shouldEnable, System.Random random)
		{
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x347AD90", Offset = "0x3479390", VA = "0x18347AD90")]
		private VariationSet.Subset ApplyExclusive(System.Random random, VariationSet.Subset subSet)
		{
			return VariationSet.Subset.Any;
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x347B380", Offset = "0x3479980", VA = "0x18347B380")]
		private void ApplyExclusiveObjectTarget(VariationSet.ObjectTarget target, bool shouldEnable, System.Random random)
		{
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x347B730", Offset = "0x3479D30", VA = "0x18347B730")]
		public void ShowAll(bool value)
		{
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0000EC40 File Offset: 0x0000CE40
		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x347BC10", Offset = "0x347A210", VA = "0x18347BC10")]
		private float GetObjectsChance(int chance, VariationSet.Subset subSet)
		{
			return 0f;
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B1")]
		[Address(RVA = "0x347BC70", Offset = "0x347A270", VA = "0x18347BC70")]
		public VariationSet()
		{
		}

		// Token: 0x04002A1D RID: 10781
		[Token(Token = "0x4002A1D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[FormerlySerializedAs("_targets")]
		private List<VariationSet.ObjectTarget> _objectTargets;

		// Token: 0x04002A1E RID: 10782
		[Token(Token = "0x4002A1E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _exclusive;

		// Token: 0x04002A1F RID: 10783
		[Token(Token = "0x4002A1F")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _additiveChance;

		// Token: 0x04002A20 RID: 10784
		[Token(Token = "0x4002A20")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _repeatRollCount;

		// Token: 0x04002A21 RID: 10785
		[Token(Token = "0x4002A21")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _shouldInstantiateTargets;

		// Token: 0x04002A22 RID: 10786
		[Token(Token = "0x4002A22")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _spawnTargetRoot;

		// Token: 0x04002A23 RID: 10787
		[Token(Token = "0x4002A23")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("_chanceSum")]
		private int _objectsChanceSum;

		// Token: 0x02000725 RID: 1829
		[Token(Token = "0x2000725")]
		public enum Subset
		{
			// Token: 0x04002A25 RID: 10789
			[Token(Token = "0x4002A25")]
			Any,
			// Token: 0x04002A26 RID: 10790
			[Token(Token = "0x4002A26")]
			Primitive,
			// Token: 0x04002A27 RID: 10791
			[Token(Token = "0x4002A27")]
			Clothed,
			// Token: 0x04002A28 RID: 10792
			[Token(Token = "0x4002A28")]
			Creepy
		}

		// Token: 0x02000726 RID: 1830
		[Token(Token = "0x2000726")]
		[Serializable]
		public class MaterialTarget
		{
			// Token: 0x060030B2 RID: 12466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030B2")]
			[Address(RVA = "0x347BD20", Offset = "0x347A320", VA = "0x18347BD20")]
			public void Apply()
			{
			}

			// Token: 0x060030B3 RID: 12467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030B3")]
			[Address(RVA = "0x30EF1F0", Offset = "0x30ED7F0", VA = "0x1830EF1F0")]
			public MaterialTarget()
			{
			}

			// Token: 0x04002A29 RID: 10793
			[Token(Token = "0x4002A29")]
			[FieldOffset(Offset = "0x10")]
			public Renderer _targetRenderer;

			// Token: 0x04002A2A RID: 10794
			[Token(Token = "0x4002A2A")]
			[FieldOffset(Offset = "0x18")]
			public Material[] _materials;

			// Token: 0x04002A2B RID: 10795
			[Token(Token = "0x4002A2B")]
			[FieldOffset(Offset = "0x20")]
			[Min(1f)]
			public int _chance;
		}

		// Token: 0x02000727 RID: 1831
		[Token(Token = "0x2000727")]
		[Serializable]
		public class ObjectTarget
		{
			// Token: 0x060030B4 RID: 12468 RVA: 0x0000EC58 File Offset: 0x0000CE58
			[Token(Token = "0x60030B4")]
			[Address(RVA = "0x347BD90", Offset = "0x347A390", VA = "0x18347BD90")]
			public bool IsValid(VariationSet.Subset subSet)
			{
				return default(bool);
			}

			// Token: 0x060030B5 RID: 12469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030B5")]
			[Address(RVA = "0x347BDB0", Offset = "0x347A3B0", VA = "0x18347BDB0")]
			public void UpdateMaterialsChanceSum()
			{
			}

			// Token: 0x060030B6 RID: 12470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030B6")]
			[Address(RVA = "0x347BF60", Offset = "0x347A560", VA = "0x18347BF60")]
			public void ApplyMaterialTargets(System.Random random)
			{
			}

			// Token: 0x060030B7 RID: 12471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030B7")]
			[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
			public ObjectTarget()
			{
			}

			// Token: 0x04002A2C RID: 10796
			[Token(Token = "0x4002A2C")]
			[FieldOffset(Offset = "0x10")]
			public GameObject _target;

			// Token: 0x04002A2D RID: 10797
			[Token(Token = "0x4002A2D")]
			[FieldOffset(Offset = "0x18")]
			[Min(1f)]
			public int _chance;

			// Token: 0x04002A2E RID: 10798
			[Token(Token = "0x4002A2E")]
			[FieldOffset(Offset = "0x1C")]
			public VariationSet.Subset _subSet;

			// Token: 0x04002A2F RID: 10799
			[Token(Token = "0x4002A2F")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[HideInInspector]
			private int _materialsChanceSum;

			// Token: 0x04002A30 RID: 10800
			[Token(Token = "0x4002A30")]
			[FieldOffset(Offset = "0x28")]
			public VariationSet.MaterialTarget[] _materialTargets;

			// Token: 0x04002A31 RID: 10801
			[Token(Token = "0x4002A31")]
			[FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public GameObject _runtimeInstance;
		}
	}
}
